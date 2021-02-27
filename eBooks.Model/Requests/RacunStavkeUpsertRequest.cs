using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBooks.Model.Requests
{
    public class RacunStavkeUpsertRequest
    {
        [Range(1,100)]
        public int Kolicina { get; set; }

        [Range(typeof(Decimal), "0", "9999999")]
        public decimal Cijena { get; set; }

        public int KnjigaId { get; set; }
        public int RacunId { get; set; }
    }
}
