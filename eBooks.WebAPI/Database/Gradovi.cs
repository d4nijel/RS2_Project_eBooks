using System;
using System.Collections.Generic;

namespace eBooks.WebAPI.Database
{
    public partial class Gradovi
    {
        public Gradovi()
        {
            AutoriMjestoRodjenjaNavigation = new HashSet<Autori>();
            AutoriMjestoSmrtiNavigation = new HashSet<Autori>();
            Izdavaci = new HashSet<Izdavaci>();
        }

        public int GradId { get; set; }
        public string Naziv { get; set; }
        public int DrzavaId { get; set; }

        public Drzave Drzava { get; set; }
        public ICollection<Autori> AutoriMjestoRodjenjaNavigation { get; set; }
        public ICollection<Autori> AutoriMjestoSmrtiNavigation { get; set; }
        public ICollection<Izdavaci> Izdavaci { get; set; }
    }
}
