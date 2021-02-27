using eBooks.Model.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBooks.Model.Requests
{
    public class IzdavaciUpsertRequest
    {
        [Required]
        [StringLength(100)]
        public string Naziv { get; set; }
        [RangeUntilCurrentYear(1)]
        public int GodinaOsnivanja { get; set; }
        [Required]
        [StringLength(100)]
        public string KontaktOsoba { get; set; }
        [Required]
        [StringLength(20)]
        [Phone]
        public string KontaktTelefon { get; set; }
        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string KontaktEmail { get; set; }
        public bool Status { get; set; }
        public int GradId { get; set; }
    }
}
