using System;
using System.Collections.Generic;
using System.Text;

namespace eBooks.Model.Reports
{
    public class RacunStavkeReport
    {
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public string Naziv { get; set; }
        public decimal Iznos { get; set; }
        public decimal IznosPDV { get; set; }
        public string Isbn { get; set; }
    }
}
