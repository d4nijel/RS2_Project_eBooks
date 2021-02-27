using System;
using System.Collections.Generic;
using System.Text;

namespace eBooks.Model
{
    public class Autori
    {
        public int AutorId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Pseudonim { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public DateTime? DatumSmrti { get; set; }
        public string KratkaBiografija { get; set; }
        public bool Status { get; set; }
        public int? MjestoRodjenja { get; set; }
        public int? MjestoSmrti { get; set; }
    }
}
