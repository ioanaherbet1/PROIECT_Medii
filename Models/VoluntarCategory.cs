using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herbet_Ioana_ONG.Models
{
    public class VoluntarCategory
    {
        public int ID { get; set; }
        public int VoluntarID { get; set; }
        public Voluntar Voluntar { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
