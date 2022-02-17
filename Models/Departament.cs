using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herbet_Ioana_ONG.Models
{
    public class Departament
    {
        public int ID { get; set; }
        public string DepartamentName { get; set; }
        public ICollection<Voluntar> Voluntari { get; set; }
    }
}
