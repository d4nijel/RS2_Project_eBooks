using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBooks.Model.Requests
{
    public class KolekcijeSearchRequest
    {
        [StringLength(100)]
        public string OriginalniNaziv { get; set; }

        [StringLength(100)]
        public string Naziv { get; set; }
    }
}
