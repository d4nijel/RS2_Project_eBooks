﻿using System;
using System.Collections.Generic;

namespace eBooks.WebAPI.Database
{
    public partial class Korisnici
    {
        public Korisnici()
        {
            KorisniciUloge = new HashSet<KorisniciUloge>();
            Ugovori = new HashSet<Ugovori>();
        }

        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool Status { get; set; }

        public ICollection<KorisniciUloge> KorisniciUloge { get; set; }
        public ICollection<Ugovori> Ugovori { get; set; }
    }
}
