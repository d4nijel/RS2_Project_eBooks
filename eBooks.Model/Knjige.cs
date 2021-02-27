using System;
using System.Collections.Generic;
using System.Text;

namespace eBooks.Model
{
    public class Knjige
    {
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

        public string Kolekcija { get; set; }
        public string KolekcijaOriginalniNaziv { get; set; }
        public List<KnjigeKategorije> KnjigeKategorije { get; set; }
        public List<AutoriKnjige> AutoriKnjige { get; set; }

        public List<int> KategorijeID = new List<int>();
        public List<string> Kategorije = new List<string>();

        public List<int> AutoriID = new List<int>();
        public List<string> Autori = new List<string>();
    }
}
