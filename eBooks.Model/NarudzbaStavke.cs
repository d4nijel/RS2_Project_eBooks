using System;
using System.Collections.Generic;
using System.Text;

namespace eBooks.Model
{
    public class NarudzbaStavke
    {
        public int NarudzbaStavkaId { get; set; }
        public int Kolicina { get; set; }
        public int NarudzbaId { get; set; }
        public int KnjigaId { get; set; }

        public Knjige Knjiga { get; set; }
    }
}
