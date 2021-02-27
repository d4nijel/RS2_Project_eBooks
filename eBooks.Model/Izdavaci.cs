using System;
using System.Collections.Generic;
using System.Text;

namespace eBooks.Model
{
    public class Izdavaci
    {
        public int IzdavacId { get; set; }
        public string Naziv { get; set; }
        public int GodinaOsnivanja { get; set; }
        public string KontaktOsoba { get; set; }
        public string KontaktTelefon { get; set; }
        public string KontaktEmail { get; set; }
        public bool Status { get; set; }
        public int GradId { get; set; }
    }
}
