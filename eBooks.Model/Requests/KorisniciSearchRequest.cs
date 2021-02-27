using System.ComponentModel.DataAnnotations;

namespace eBooks.Model.Requests
{
    public class KorisniciSearchRequest
    {
        [StringLength(50)]
        public string Ime { get; set; }

        [StringLength(50)]
        public string Prezime { get; set; }

        [StringLength(50)]
        public string KorisnickoIme { get; set; }
    }
}
