using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBooks.Model.Requests
{
    public class KolekcijeUpsertRequest
    {
        [Required]
        [StringLength(100)]
        public string OriginalniNaziv { get; set; }
        [Required]
        [StringLength(100)]
        public string Naziv { get; set; }
        [Required]
        [StringLength(2000)]
        public string Opis { get; set; }
    }
}
