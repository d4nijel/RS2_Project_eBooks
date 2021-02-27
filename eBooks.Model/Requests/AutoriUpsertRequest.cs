using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBooks.Model.Requests
{
    public class AutoriUpsertRequest
    {
        [StringLength(50)]
        public string Ime { get; set; }

        [StringLength(50)]
        public string Prezime { get; set; }

        [StringLength(50)]
        public string Pseudonim { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DatumRodjenja { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DatumSmrti { get; set; }

        [Required]
        [StringLength(2000)]
        public string KratkaBiografija { get; set; }

        public bool Status { get; set; }
        public int? MjestoRodjenja { get; set; }
        public int? MjestoSmrti { get; set; }
    }
}
