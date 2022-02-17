using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Herbet_Ioana_ONG.Data;
using Herbet_Ioana_ONG.Models;

namespace Herbet_Ioana_ONG.Pages.Voluntar
{
    public class DeleteModel : PageModel
    {
        private readonly Herbet_Ioana_ONG.Data.Herbet_Ioana_ONGContext _context;

        public DeleteModel(Herbet_Ioana_ONG.Data.Herbet_Ioana_ONGContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Herbet_Ioana_ONG.Models.Voluntar Voluntar { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Voluntar = await _context.Voluntar.FirstOrDefaultAsync(m => m.ID == id);

            if (Voluntar == null)
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

            Voluntar = await _context.Voluntar.FindAsync(id);

            if (Voluntar != null)
            {
                _context.Voluntar.Remove(Voluntar);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
