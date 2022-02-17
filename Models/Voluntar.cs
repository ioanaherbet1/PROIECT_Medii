using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Herbet_Ioana_ONG.Models
{
    public class Voluntar
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        public int Varsta { get; set; }
        [DataType(DataType.Date)]
        public DateTime MembershipDate { get; set; }
        public int DepartamentID { get; set; }
        public Departament Departament { get; set; }
        public ICollection<VoluntarCategory> VoluntarCategories { get; set; }
    }
}
