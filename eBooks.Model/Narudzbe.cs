using System;
using System.Collections.Generic;
using System.Text;

namespace eBooks.Model
{
    public class Narudzbe
    {
        public int NarudzbaId { get; set; }
        public string BrojNarudzbe { get; set; }
        public DateTime Datum { get; set; }
        public bool Status { get; set; }
        public bool? Otkazano { get; set; }
        public int KupacId { get; set; }
        public List<NarudzbaStavke> NarudzbaStavke { get; set; }
    }
}
