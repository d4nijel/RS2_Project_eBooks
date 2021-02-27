using System;
using System.Collections.Generic;

namespace eBooks.WebAPI.Database
{
    public partial class KreditneKartice
    {
        public int KreditnaKarticaId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojKartice { get; set; }
        public int MjesecIsteka { get; set; }
        public int GodinaIsteka { get; set; }
        public int Cvc2 { get; set; }
        public string Opis { get; set; }
        public int KupacId { get; set; }

        public Kupci Kupac { get; set; }
    }
}
