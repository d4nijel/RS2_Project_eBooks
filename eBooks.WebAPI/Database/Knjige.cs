using System;
using System.Collections.Generic;

namespace eBooks.WebAPI.Database
{
    public partial class Knjige
    {
        public Knjige()
        {
            AutoriKnjige = new HashSet<AutoriKnjige>();
            KnjigeKategorije = new HashSet<KnjigeKategorije>();
            NarudzbaStavke = new HashSet<NarudzbaStavke>();
            Ocjene = new HashSet<Ocjene>();
            RacunStavke = new HashSet<RacunStavke>();
        }

        public int KnjigaId { get; set; }
        public string Sifra { get; set; }
        public string OriginalniNaziv { get; set; }
        public string Naziv { get; set; }
        public string Isbn { get; set; }
        public int GodinaIzdanja { get; set; }
        public int BrojStrana { get; set; }
        public string Jezik { get; set; }
        public string Sadrzaj { get; set; }
        public int Izdanje { get; set; }
        public decimal Cijena { get; set; }
        public string Format { get; set; }
        public byte[] SlikaNaslovnice { get; set; }
        public byte[] SlikaNaslovniceThumb { get; set; }
        public byte[] Knjiga { get; set; }
        public byte[] UzorakKnjige { get; set; }
        public bool Status { get; set; }
        public int? KolekcijaId { get; set; }
        public int IzdavacId { get; set; }

        public Izdavaci Izdavac { get; set; }
        public Kolekcije Kolekcija { get; set; }
        public ICollection<AutoriKnjige> AutoriKnjige { get; set; }
        public ICollection<KnjigeKategorije> KnjigeKategorije { get; set; }
        public ICollection<NarudzbaStavke> NarudzbaStavke { get; set; }
        public ICollection<Ocjene> Ocjene { get; set; }
        public ICollection<RacunStavke> RacunStavke { get; set; }
    }
}
