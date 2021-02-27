using System;
using System.Collections.Generic;

namespace eBooks.WebAPI.Database
{
    public partial class Kolekcije
    {
        public Kolekcije()
        {
            Knjige = new HashSet<Knjige>();
        }

        public int KolekcijaId { get; set; }
        public string OriginalniNaziv { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public ICollection<Knjige> Knjige { get; set; }
    }
}
