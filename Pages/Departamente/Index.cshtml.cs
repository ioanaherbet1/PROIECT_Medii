using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Herbet_Ioana_ONG.Data;
using Herbet_Ioana_ONG.Models;

namespace Herbet_Ioana_ONG.Pages.Departamente
{
    public class IndexModel : PageModel
    {
        private readonly Herbet_Ioana_ONG.Data.Herbet_Ioana_ONGContext _context;

        public IndexModel(Herbet_Ioana_ONG.Data.Herbet_Ioana_ONGContext context)
        {
            _context = context;
        }

        public IList<Departament> Departament { get;set; }

        public async Task OnGetAsync()
        {
            Departament = await _context.Departament.ToListAsync();
        }
    }
}
