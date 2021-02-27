using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBooks.Model.Requests
{
    public class NarudzbeUpsertRequest
    {
        [Required]
        [StringLength(20)]
        public string BrojNarudzbe { get; set; }

        [DataType(DataType.Date)]
        public DateTime Datum { get; set; }

        public bool Status { get; set; }
        public bool? Otkazano { get; set; }
        public int KupacId { get; set; }
    }
}
