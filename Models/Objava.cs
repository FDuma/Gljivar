using System;
using System.Collections.Generic;

namespace Gljivar.Models
{
    public partial class Objava
    {
        public Objava()
        {
            Komentar = new HashSet<Komentar>();
        }

        public int IdObjava { get; set; }
        public int? IdKorisnika { get; set; }
        public int? IdGljivarDrustvo { get; set; }
        public DateTime? Datum { get; set; }
        public string Objava1 { get; set; }
        public string Naziv { get; set; }

        public virtual GljivarDrustvo IdGljivarDrustvoNavigation { get; set; }
        public virtual Korisnik IdKorisnikaNavigation { get; set; }
        public virtual ICollection<Komentar> Komentar { get; set; }
    }
}
