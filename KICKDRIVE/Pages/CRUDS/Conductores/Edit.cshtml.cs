using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KDControl;

namespace KICKDRIVE.Pages.CRUDS.Conductores
{
    public class EditModel : PageModel
    {
        private readonly KDControl.AppDbContex _context;

        public EditModel(KDControl.AppDbContex context)
        {
            _context = context;
        }

        [BindProperty]
        public KDControl.Conductor Conductor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Conductor = await _context.Conductors.FirstOrDefaultAsync(m => m.Id == id);

            if (Conductor == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Conductor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConductorExists(Conductor.Id))
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

        private bool ConductorExists(int id)
        {
            return _context.Conductors.Any(e => e.Id == id);
        }
    }
}
