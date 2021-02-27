using System;
using System.Collections.Generic;

namespace eBooks.WebAPI.Database
{
    public partial class KnjigeKategorije
    {
        public int KategorijaId { get; set; }
        public int KnjigaId { get; set; }

        public Kategorije Kategorija { get; set; }
        public Knjige Knjiga { get; set; }
    }
}
