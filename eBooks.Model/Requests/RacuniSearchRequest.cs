using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBooks.Model.Requests
{
    public class RacuniSearchRequest
    {
        [StringLength(50)]
        public string BrojRacuna { get; set; }
    }
}
