using System;
using System.Collections.Generic;

namespace Gljivar.Models
{
    public partial class Komentar
    {
        public int IdKomentar { get; set; }
        public int IdObjava { get; set; }
        public int? IdGljivarDrustvo { get; set; }
        public int? IdKorisnik { get; set; }
        public string Komentar1 { get; set; }
        public DateTime Datum { get; set; }

        public virtual GljivarDrustvo IdGljivarDrustvoNavigation { get; set; }
        public virtual Korisnik IdKorisnikNavigation { get; set; }
        public virtual Objava IdObjavaNavigation { get; set; }
    }
}
