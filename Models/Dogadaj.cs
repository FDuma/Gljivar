using System;
using System.Collections.Generic;

namespace Gljivar.Models
{
    public partial class Dogadaj
    {
        public int IdDogadaj { get; set; }
        public int IdGljivarDrustvo { get; set; }
        public int IdMjesto { get; set; }
        public string Opis { get; set; }
        public DateTime? Datum { get; set; }
        public string Naziv { get; set; }

        public virtual GljivarDrustvo IdGljivarDrustvoNavigation { get; set; }
        public virtual Mjesto IdMjestoNavigation { get; set; }
    }
}
