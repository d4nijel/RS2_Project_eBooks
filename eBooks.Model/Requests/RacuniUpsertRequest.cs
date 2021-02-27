using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBooks.Model.Requests
{
    public class RacuniUpsertRequest
    {
        [Required]
        [StringLength(50)]
        public string BrojRacuna { get; set; }

        [DataType(DataType.Date)]
        public DateTime Datum { get; set; }

        [Range(typeof(Decimal), "0", "9999999")]
        public decimal IznosBezPdv { get; set; }

        [Range(typeof(Decimal), "0", "9999999")]
        public decimal IznosSaPdv { get; set; }
        public int NarudzbaId { get; set; }
    }
}
