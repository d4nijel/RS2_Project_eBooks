using System;
using System.Collections.Generic;

namespace eBooks.WebAPI.Database
{
    public partial class Autori
    {
        public Autori()
        {
            AutoriKnjige = new HashSet<AutoriKnjige>();
        }

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

        public Gradovi MjestoRodjenjaNavigation { get; set; }
        public Gradovi MjestoSmrtiNavigation { get; set; }
        public ICollection<AutoriKnjige> AutoriKnjige { get; set; }
    }
}
