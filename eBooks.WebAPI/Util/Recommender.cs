using AutoMapper;
using eBooks.WebAPI.Database;
using eBooks.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eBooks.WebAPI.Util
{
    public class KnjigeSlicnosti
    {
        public int KnjigaId { get; set; }
        public double Slicnost { get; set; }
    }
    public class Recommender
    {
        private readonly _140256Context _context = new _140256Context();

        private Dictionary<int, List<Ocjene>> OcjenjeKnjige = new Dictionary<int, List<Ocjene>>();
        private Dictionary<int, List<Ocjene>> NeOcjenjeneKnjige = new Dictionary<int, List<Ocjene>>();
        private Dictionary<int, List<KnjigeSlicnosti>> slicnosti = new Dictionary<int, List<KnjigeSlicnosti>>(); //Cosine similarity

        public List<Model.Knjige> GetRecommendedProducts(int kupacId)
        {
            List<Ocjene> commonRatings1 = new List<Ocjene>();
            List<Ocjene> commonRatings2 = new List<Ocjene>();

            GetNeOcjenjeneKnjige(kupacId); //ne ocjenjene knjige kupca
            GetProductsData(); //knjige koje su ocjenjene

            List<KnjigeSlicnosti> row = new List<KnjigeSlicnosti>();

            for (int i = 0; i < NeOcjenjeneKnjige.Values.Count; i++)
            {
                for (int j = 0; j < OcjenjeKnjige.Values.Count; j++)
                {
                    var p = NeOcjenjeneKnjige.Values.ElementAt(i).Select(s => s.KnjigaId).First();
                    var q = OcjenjeKnjige.Values.ElementAt(j).Select(s => s.KnjigaId).First();
                    if (p == q)
                    {
                        row.Add(new KnjigeSlicnosti() { KnjigaId = q, Slicnost = 0f });
                        continue;
                    }
                    foreach (var item in NeOcjenjeneKnjige.Values.ElementAt(i))
                    {
                        foreach (var item2 in OcjenjeKnjige.Values.ElementAt(j))
                        {
                            if (item.KupacId == item2.KupacId)
                            {
                                commonRatings1.Add(item);
                                commonRatings2.Add(item2);
                            }
                        }
                    }
                    double sim2 = CalculateSimilarity(commonRatings1, commonRatings2);
                    commonRatings1.Clear();
                    commonRatings2.Clear();
                    row.Add(new KnjigeSlicnosti() { KnjigaId = q, Slicnost = sim2 });
                }
                var NoviRed = new List<KnjigeSlicnosti>(row);
                slicnosti.Add(NeOcjenjeneKnjige.Keys.ElementAt(i), NoviRed);
                row.Clear();
            }

            double brojnik = 0;
            double nazivnik = 0;
            double suma = 0;
            List<KnjigeSlicnosti> preporuke = new List<KnjigeSlicnosti>();
            for (int i = 0; i < slicnosti.Values.Count; i++)
            {
                foreach (var item in slicnosti.Values.ElementAt(i))
                {
                    if (item.Slicnost > 0.6f)
                    {
                        var p = _context.Ocjene.Where(w => w.KupacId == 1 && w.KnjigaId == item.KnjigaId).ToList();
                        if (p.Count() > 0)
                        {
                            brojnik += item.Slicnost * p.Average(a => a.Ocjena);
                            nazivnik += item.Slicnost;
                        }
                    }
                }
                suma = brojnik / nazivnik;
                preporuke.Add(new KnjigeSlicnosti() { KnjigaId = slicnosti.Keys.ElementAt(i), Slicnost = suma });
            }

            List<Model.Knjige> preporuceneKnjige = new List<Model.Knjige>();

            foreach (var item in preporuke)
            {
                if (item.Slicnost >= 3)
                {
                    var knjiga = _context.Knjige.Where(w => w.KnjigaId == item.KnjigaId).FirstOrDefault();

                    var modelknjiga = new Model.Knjige()
                    {
                        KnjigaId = knjiga.KnjigaId,
                        Sifra = knjiga.Sifra,
                        OriginalniNaziv = knjiga.OriginalniNaziv,
                        Naziv = knjiga.Naziv,
                        Isbn = knjiga.Isbn,
                        GodinaIzdanja = knjiga.GodinaIzdanja,
                        BrojStrana = knjiga.BrojStrana,
                        Jezik = knjiga.Jezik,
                        Sadrzaj = knjiga.Sadrzaj,
                        Izdanje = knjiga.Izdanje,
                        Cijena = knjiga.Cijena,
                        Format = knjiga.Format,
                        SlikaNaslovnice = knjiga.SlikaNaslovnice,
                        SlikaNaslovniceThumb = knjiga.SlikaNaslovniceThumb,
                        Knjiga = knjiga.Knjiga,
                        UzorakKnjige = knjiga.UzorakKnjige,
                        Status = knjiga.Status,
                        KolekcijaId = knjiga.KolekcijaId,
                        IzdavacId = knjiga.IzdavacId,
                    };

                    var izdavac = _context.Izdavaci.Where(w => w.IzdavacId == modelknjiga.IzdavacId).FirstOrDefault();

                    modelknjiga.Izdavac = new Model.Izdavaci()
                    {
                        IzdavacId = izdavac.IzdavacId,
                        Naziv = izdavac.Naziv,
                        GodinaOsnivanja = izdavac.GodinaOsnivanja,
                        KontaktOsoba = izdavac.KontaktOsoba,
                        KontaktTelefon = izdavac.KontaktTelefon,
                        KontaktEmail = izdavac.KontaktEmail,
                        Status = izdavac.Status,
                        GradId = izdavac.GradId
                    };

                    preporuceneKnjige.Add(modelknjiga);
                }
            }
            return preporuceneKnjige;
        }

        private double CalculateSimilarity(List<Ocjene> commonRatings1, List<Ocjene> commonRatings2)
        {
            if (commonRatings1.Count != commonRatings2.Count)
                return 0;

            if (commonRatings1.Count == 1 && commonRatings2.Count == 1)
                return 0;

            double numerator = 0, int1 = 0, int2 = 0;

            for (int i = 0; i < commonRatings1.Count; i++)
            {
                numerator += commonRatings1[i].Ocjena * commonRatings2[i].Ocjena;
                int1 += Math.Pow(commonRatings1[i].Ocjena, 2);
                int2 += Math.Pow(commonRatings2[i].Ocjena, 2);

            }

            int1 = Math.Sqrt(int1);
            int2 = Math.Sqrt(int2);

            if (int1 * int2 != 0)
                return numerator / (int1 * int2);

            return 0;
        }

        private void GetProductsData()
        {
            List<Database.Knjige> activeProducts = _context.Knjige.Where(x => x.Status == true).OrderBy(x => x.KnjigaId).ToList();

            List<Ocjene> ratings;

            foreach (var item in activeProducts)
            {
                ratings = _context.Ocjene.Where(x => x.KnjigaId == item.KnjigaId).OrderBy(x => x.KupacId).ToList();

                if (ratings.Count > 0)
                {
                    OcjenjeKnjige.Add(item.KnjigaId, ratings);
                }
            }
        }

        private void GetNeOcjenjeneKnjige(int kupacID)
        {
            List<Database.Knjige> activeProducts = _context.Knjige.Where(x => x.Status == true).OrderBy(x => x.KnjigaId).ToList();

            List<Ocjene> ratings;

            List<int> knjigeKojeNisuOcjenjene = new List<int>();


            foreach (var item in activeProducts)
            {
                ratings = _context.Ocjene.Where(x => x.KupacId == kupacID && x.KnjigaId == item.KnjigaId).OrderBy(x => x.KnjigaId).ToList();
                if (ratings.Count == 0)
                {
                    knjigeKojeNisuOcjenjene.Add(item.KnjigaId);
                }
            }

            foreach (var item in knjigeKojeNisuOcjenjene)
            {
                ratings = _context.Ocjene.Where(x => x.KnjigaId == item).OrderBy(x => x.KnjigaId).ToList();
                if (ratings.Count > 0)
                {
                    NeOcjenjeneKnjige.Add(item, ratings);
                }
            }
        }
    }
}