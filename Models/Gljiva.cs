using System;
using System.Collections.Generic;

namespace Gljivar.Models
{
    public partial class Gljiva
    {
        public Gljiva()
        {
            GljivaUmjestu = new HashSet<GljivaUmjestu>();
        }

        public int IdGljive { get; set; }
        public string Naziv { get; set; }
        public string Kategorija { get; set; }
        public string Opis { get; set; }
        public bool? Otrovnica { get; set; }

        public virtual ICollection<GljivaUmjestu> GljivaUmjestu { get; set; }
    }
}
