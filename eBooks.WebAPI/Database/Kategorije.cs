using System;
using System.Collections.Generic;

namespace eBooks.WebAPI.Database
{
    public partial class Kategorije
    {
        public Kategorije()
        {
            KnjigeKategorije = new HashSet<KnjigeKategorije>();
        }

        public int KategorijaId { get; set; }
        public string Naziv { get; set; }

        public ICollection<KnjigeKategorije> KnjigeKategorije { get; set; }
    }
}
