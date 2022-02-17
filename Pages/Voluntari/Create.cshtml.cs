using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Herbet_Ioana_ONG.Data;
using Herbet_Ioana_ONG.Models;

namespace Herbet_Ioana_ONG.Pages.Voluntar
{
    public class CreateModel : PageModel
    {
        private readonly Herbet_Ioana_ONG.Data.Herbet_Ioana_ONGContext _context;

        public CreateModel(Herbet_Ioana_ONG.Data.Herbet_Ioana_ONGContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["DepartamentID"] = new SelectList(_context.Set<Departament>(), "ID", "DepartamentName");
            return Page();
        }

        [BindProperty]
        public Herbet_Ioana_ONG.Models.Voluntar Voluntar { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Voluntar.Add(Voluntar);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
