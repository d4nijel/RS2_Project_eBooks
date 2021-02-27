using System;
using System.Collections.Generic;

namespace eBooks.WebAPI.Database
{
    public partial class AutoriKnjige
    {
        public int AutorId { get; set; }
        public int KnjigaId { get; set; }

        public Autori Autor { get; set; }
        public Knjige Knjiga { get; set; }
    }
}
