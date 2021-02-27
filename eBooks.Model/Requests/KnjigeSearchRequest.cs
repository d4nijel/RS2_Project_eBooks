using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBooks.Model.Requests
{
    public class KnjigeSearchRequest
    {
        [StringLength(100)]
        public string OriginalniNaziv { get; set; }

        [StringLength(100)]
        public string Naziv { get; set; }

        public bool IsAutorLoadingEnabled { get; set; }
        public bool IsIzdavacLoadingEnabled { get; set; }
        public bool IsKolekcijaLoadingEnabled { get; set; }
    }
}
