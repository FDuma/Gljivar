using System;
using System.Collections.Generic;

namespace Gljivar.Models
{
    public partial class GljivarDrustvo
    {
        public GljivarDrustvo()
        {
            Dogadaj = new HashSet<Dogadaj>();
            Komentar = new HashSet<Komentar>();
            Korisnik = new HashSet<Korisnik>();
            Objava = new HashSet<Objava>();
        }

        public int IdGljivarDrustvo { get; set; }
        public string Naziv { get; set; }
        public int IdMjesto { get; set; }

        public virtual Mjesto IdMjestoNavigation { get; set; }
        public virtual ICollection<Dogadaj> Dogadaj { get; set; }
        public virtual ICollection<Komentar> Komentar { get; set; }
        public virtual ICollection<Korisnik> Korisnik { get; set; }
        public virtual ICollection<Objava> Objava { get; set; }
    }
}
