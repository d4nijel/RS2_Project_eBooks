using System;
using System.Collections.Generic;

namespace eBooks.WebAPI.Database
{
    public partial class Drzave
    {
        public Drzave()
        {
            Gradovi = new HashSet<Gradovi>();
        }

        public int DrzavaId { get; set; }
        public string Naziv { get; set; }
        public string Iso3166codeA3 { get; set; }

        public ICollection<Gradovi> Gradovi { get; set; }
    }
}
