using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBooks.Model.Requests
{
    public class UgovoriUpsertRequest
    {
        [Required]
        [StringLength(15)]
        public string BrojUgovora { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DatumPotpisivanja { get; set; }
        [Range(1,120)]
        public int TrajanjeUgovora { get; set; }
        [Range(0.01, 100)]
        public decimal ProcenatOdProdaje { get; set; }
        public byte[] Ugovor { get; set; }
        public int IzdavacId { get; set; }
        public int KorisnikId { get; set; }
    }
}
