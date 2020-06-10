using System;
using System.Collections.Generic;

namespace Gljivar.Models
{
    public partial class Biljeska
    {
        public int IdBiljeski { get; set; }
        public int IdKorisnika { get; set; }
        public string Biljeska1 { get; set; }
        public bool? IsPublic { get; set; }
        public DateTime? Datum { get; set; }
        public string Naziv { get; set; }

        public virtual Korisnik IdKorisnikaNavigation { get; set; }
    }
}
