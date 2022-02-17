using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herbet_Ioana_ONG.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<VoluntarCategory> VoluntarCategories { get; set; }
    }
}
