using System;
using System.Collections.Generic;

namespace Gljivar.Models
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            Biljeska = new HashSet<Biljeska>();
            Komentar = new HashSet<Komentar>();
            Objava = new HashSet<Objava>();
            ProGljivar = new HashSet<ProGljivar>();
        }

        public int IdKorisnik { get; set; }
        public string Pass { get; set; }
        public bool IsAdmin { get; set; }
        public int? KontaktBroj { get; set; }
        public string Email { get; set; }
        public int IdMjesta { get; set; }
        public int? IdGljivarskoDrustvo { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }

        public virtual GljivarDrustvo IdGljivarskoDrustvoNavigation { get; set; }
        public virtual Mjesto IdMjestaNavigation { get; set; }
        public virtual ICollection<Biljeska> Biljeska { get; set; }
        public virtual ICollection<Komentar> Komentar { get; set; }
        public virtual ICollection<Objava> Objava { get; set; }
        public virtual ICollection<ProGljivar> ProGljivar { get; set; }
    }
}
