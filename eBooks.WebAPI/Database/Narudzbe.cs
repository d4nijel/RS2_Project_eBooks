using System;
using System.Collections.Generic;

namespace eBooks.WebAPI.Database
{
    public partial class Narudzbe
    {
        public Narudzbe()
        {
            NarudzbaStavke = new HashSet<NarudzbaStavke>();
            Racuni = new HashSet<Racuni>();
        }

        public int NarudzbaId { get; set; }
        public string BrojNarudzbe { get; set; }
        public DateTime Datum { get; set; }
        public bool Status { get; set; }
        public bool? Otkazano { get; set; }
        public int KupacId { get; set; }

        public Kupci Kupac { get; set; }
        public ICollection<NarudzbaStavke> NarudzbaStavke { get; set; }
        public ICollection<Racuni> Racuni { get; set; }
    }
}
