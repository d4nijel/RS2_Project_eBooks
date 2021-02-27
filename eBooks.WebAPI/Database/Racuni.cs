using System;
using System.Collections.Generic;

namespace eBooks.WebAPI.Database
{
    public partial class Racuni
    {
        public Racuni()
        {
            RacunStavke = new HashSet<RacunStavke>();
        }

        public int RacunId { get; set; }
        public string BrojRacuna { get; set; }
        public DateTime Datum { get; set; }
        public decimal IznosBezPdv { get; set; }
        public decimal IznosSaPdv { get; set; }
        public int NarudzbaId { get; set; }

        public Narudzbe Narudzba { get; set; }
        public ICollection<RacunStavke> RacunStavke { get; set; }
    }
}
