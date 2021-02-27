using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBooks.Model.Requests
{
    public class OcjeneUpsertRequest
    {
        [DataType(DataType.Date)]
        public DateTime Datum { get; set; }

        [Range(1,5)]
        public int Ocjena { get; set; }

        public int KnjigaId { get; set; }
        public int KupacId { get; set; }
    }
}
