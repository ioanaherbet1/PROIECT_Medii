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
    public class DeleteModel : PageModel
    {
        private readonly Herbet_Ioana_ONG.Data.Herbet_Ioana_ONGContext _context;

        public DeleteModel(Herbet_Ioana_ONG.Data.Herbet_Ioana_ONGContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Departament Departament { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Departament = await _context.Departament.FirstOrDefaultAsync(m => m.ID == id);

            if (Departament == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Departament = await _context.Departament.FindAsync(id);

            if (Departament != null)
            {
                _context.Departament.Remove(Departament);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
