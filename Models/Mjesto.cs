using System;
using System.Collections.Generic;

namespace Gljivar.Models
{
    public partial class Mjesto
    {
        public Mjesto()
        {
            Dogadaj = new HashSet<Dogadaj>();
            GljivaUmjestu = new HashSet<GljivaUmjestu>();
            GljivarDrustvo = new HashSet<GljivarDrustvo>();
            Korisnik = new HashSet<Korisnik>();
        }

        public int IdMjesta { get; set; }
        public int IdDrzave { get; set; }
        public string Naziv { get; set; }
        public int PostanskiBroj { get; set; }

        public virtual Drzava IdDrzaveNavigation { get; set; }
        public virtual ICollection<Dogadaj> Dogadaj { get; set; }
        public virtual ICollection<GljivaUmjestu> GljivaUmjestu { get; set; }
        public virtual ICollection<GljivarDrustvo> GljivarDrustvo { get; set; }
        public virtual ICollection<Korisnik> Korisnik { get; set; }
    }
}
