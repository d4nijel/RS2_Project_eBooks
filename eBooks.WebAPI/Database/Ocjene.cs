using System;
using System.Collections.Generic;

namespace eBooks.WebAPI.Database
{
    public partial class Ocjene
    {
        public int OcjenaId { get; set; }
        public DateTime Datum { get; set; }
        public int Ocjena { get; set; }
        public int KnjigaId { get; set; }
        public int KupacId { get; set; }

        public Knjige Knjiga { get; set; }
        public Kupci Kupac { get; set; }
    }
}
