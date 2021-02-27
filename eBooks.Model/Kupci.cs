﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eBooks.Model
{
    public class Kupci
    {
        public int KupacId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public bool Status { get; set; }

        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
    }
}
