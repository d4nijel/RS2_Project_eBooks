using System;
using System.Collections.Generic;
using System.Text;

namespace eBooks.Model
{
    public class Kolekcije
    {
        public int KolekcijaId { get; set; }
        public string OriginalniNaziv { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public List<Model.Knjige> Knjige { get; set; }
    }
}
