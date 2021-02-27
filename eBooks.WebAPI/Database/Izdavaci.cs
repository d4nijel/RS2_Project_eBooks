using System;
using System.Collections.Generic;

namespace eBooks.WebAPI.Database
{
    public partial class Izdavaci
    {
        public Izdavaci()
        {
            Knjige = new HashSet<Knjige>();
            Ugovori = new HashSet<Ugovori>();
        }

        public int IzdavacId { get; set; }
        public string Naziv { get; set; }
        public int GodinaOsnivanja { get; set; }
        public string KontaktOsoba { get; set; }
        public string KontaktTelefon { get; set; }
        public string KontaktEmail { get; set; }
        public bool Status { get; set; }
        public int GradId { get; set; }

        public Gradovi Grad { get; set; }
        public ICollection<Knjige> Knjige { get; set; }
        public ICollection<Ugovori> Ugovori { get; set; }
    }
}
