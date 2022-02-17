using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Herbet_Ioana_ONG.Data;



namespace Herbet_Ioana_ONG.Pages.Voluntar
{
    public class EditModel : PageModel
    {
        private readonly Herbet_Ioana_ONG.Data.Herbet_Ioana_ONGContext _context;

        public EditModel(Herbet_Ioana_ONG.Data.Herbet_Ioana_ONGContext context)
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
            
            ViewData["DepartamentID"] = new SelectList(_context.Set<Herbet_Ioana_ONG.Models.Departament>(), "ID", "DepartamentName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Voluntar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(Voluntar.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BookExists(int id)
        {
            return _context.Voluntar.Any(e => e.ID == id);
        }
    }
}