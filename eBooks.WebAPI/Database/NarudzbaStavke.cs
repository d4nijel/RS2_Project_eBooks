﻿using System;
using System.Collections.Generic;

namespace eBooks.WebAPI.Database
{
    public partial class NarudzbaStavke
    {
        public int NarudzbaStavkaId { get; set; }
        public int Kolicina { get; set; }
        public int NarudzbaId { get; set; }
        public int KnjigaId { get; set; }

        public Knjige Knjiga { get; set; }
        public Narudzbe Narudzba { get; set; }
    }
}
