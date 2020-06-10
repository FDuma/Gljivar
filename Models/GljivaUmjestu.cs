using System;
using System.Collections.Generic;

namespace Gljivar.Models
{
    public partial class GljivaUmjestu
    {
        public int IdGljiva { get; set; }
        public int IdMjesto { get; set; }

        public virtual Mjesto IdGljiva1 { get; set; }
        public virtual Gljiva IdGljivaNavigation { get; set; }
    }
}
