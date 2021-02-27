using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBooks.Model.Requests
{
    public class KorisniciUpsertRequest
    {
        [Required]
        [StringLength(50)]
        public string Ime { get; set; }

        [Required]
        [StringLength(50)]
        public string Prezime { get; set; }

        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Phone]
        [StringLength(20)]
        public string Telefon { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 4)]
        public string KorisnickoIme { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 4)]
        public string Password { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 4)]
        public string PasswordPotvrda { get; set; }

        public bool Status { get; set; }

        public List<int> Uloge { get; set; } = new List<int>();
    }
}
