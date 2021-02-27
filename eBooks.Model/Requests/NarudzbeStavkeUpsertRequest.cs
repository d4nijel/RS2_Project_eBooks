using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBooks.Model.Requests
{
    public class NarudzbeStavkeUpsertRequest
    {
        [Range(1, 100)]
        public int Kolicina { get; set; }
        public int NarudzbaId { get; set; }
        public int KnjigaId { get; set; }
    }
}
