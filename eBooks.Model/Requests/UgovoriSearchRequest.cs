using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBooks.Model.Requests
{
    public class UgovoriSearchRequest
    {
        [StringLength(15)]
        public string BrojUgovora { get; set; }
    }
}
