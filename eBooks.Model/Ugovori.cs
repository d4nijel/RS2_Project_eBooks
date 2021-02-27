using System;
using System.Collections.Generic;
using System.Text;

namespace eBooks.Model
{
    public class Ugovori
    {
        public int UgovorId { get; set; }
        public string BrojUgovora { get; set; }
        public DateTime DatumPotpisivanja { get; set; }
        public int TrajanjeUgovora { get; set; }
        public decimal ProcenatOdProdaje { get; set; }
        public byte[] Ugovor { get; set; }
        public int IzdavacId { get; set; }
        public int KorisnikId { get; set; }
    }
}
