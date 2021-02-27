using System;
using System.Collections.Generic;
using System.Text;

namespace eBooks.Model
{
    public class Ocjene
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
