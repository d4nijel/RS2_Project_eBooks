using System;
using System.Collections.Generic;
using System.Text;

namespace eBooks.Model
{
    public class Drzave
    {
        public int DrzavaId { get; set; }
        public string Naziv { get; set; }
        public List<Model.Gradovi> Gradovi { get; set; }
    }
}
