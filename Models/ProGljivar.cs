using System;
using System.Collections.Generic;

namespace Gljivar.Models
{
    public partial class ProGljivar
    {
        public int IdKorisnik { get; set; }
        public int IdProfesionalniGljivar { get; set; }
        public int Rang { get; set; }

        public virtual Korisnik IdKorisnikNavigation { get; set; }
    }
}
