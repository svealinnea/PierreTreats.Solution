using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PierreTreat.Models
{
    public class Treat
    {
        public Treat()
        {
            this.JoinEntries = new HashSet<TreatFlavor>();  
        }
        public int TreatId { get; set; }

        [DisplayName("Treat Name")]
        public string TreatName { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<TreatFlavor> JoinEntries { get; set; } //IColletion is basically a list. The ICollection<T> interface is the base interface for classes in the System.Collections.Generic namespace.
    }
}

