using System;
using System.Collections.Generic;

namespace Gljivar.Models
{
    public partial class Drzava
    {
        public Drzava()
        {
            Mjesto = new HashSet<Mjesto>();
        }

        public int IdDrzave { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Mjesto> Mjesto { get; set; }
    }
}
