using eBooks.Model.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBooks.Model.Requests
{
    public class KnjigeUpsertRequest
    {
        [Required]
        [StringLength(12)]
        public string Sifra { get; set; }

        [Required]
        [StringLength(100)]
        public string OriginalniNaziv { get; set; }

        [Required]
        [StringLength(100)]
        public string Naziv { get; set; }

        [Required]
        [StringLength(20)]
        [RegularExpression(@"^(?=[0-9X]{10}$|(?=(?:[0-9]+[- ]){3})[- 0-9X]{13}$|97[89][0-9]{10}$|(?=(?:[0-9]+[- ]){4})[- 0-9]{17}$)(?:97[89][- ]?)?[0-9]{1,5}[- ]?[0-9]+[- ]?[0-9]+[- ]?[0-9X]$")]
        public string Isbn { get; set; }

        [RangeUntilCurrentYear(1)]
        public int GodinaIzdanja { get; set; }

        [Range(1, 10000)]
        public int BrojStrana { get; set; }

        [Required]
        [StringLength(50)]
        public string Jezik { get; set; }

        [Required]
        [StringLength(2000)]
        public string Sadrzaj { get; set; }

        [Range(1, 100)]
        public int Izdanje { get; set; }

        [Range(0.01, 9999)]
        [RegularExpression(@"^\$?\d+(\,(\d{2}))?$")]
        public decimal Cijena { get; set; }

        [Required]
        [StringLength(10)]
        public string Format { get; set; }

        public byte[] SlikaNaslovnice { get; set; }
        public byte[] SlikaNaslovniceThumb { get; set; }
        public byte[] Knjiga { get; set; }
        public byte[] UzorakKnjige { get; set; }
        public bool Status { get; set; }
        public int? KolekcijaId { get; set; }
        public int IzdavacId { get; set; }
    }
}
