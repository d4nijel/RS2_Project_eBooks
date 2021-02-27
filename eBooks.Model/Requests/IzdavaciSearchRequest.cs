using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBooks.Model.Requests
{
    public class IzdavaciSearchRequest
    {
        [StringLength(100)]
        public string Naziv { get; set; }
    }
}
