using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBooks.Model.Requests
{
    public class NarudzbeSearchRequest
    {
        [StringLength(20)]
        public string BrojNarudzbe { get; set; }
    }
}
