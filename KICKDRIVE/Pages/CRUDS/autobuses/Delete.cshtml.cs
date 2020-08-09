using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KDControl;

namespace KICKDRIVE.Pages.CRUDS.autobuses
{
    public class DeleteModel : PageModel
    {
        private readonly KDControl.AppDbContex _context;

        public DeleteModel(KDControl.AppDbContex context)
        {
            _context = context;
        }

        [BindProperty]
        public KDControl.Autobus Autobus { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Autobus = await _context.Autobuss.FirstOrDefaultAsync(m => m.Id == id);

            if (Autobus == null)
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

            Autobus = await _context.Autobuss.FindAsync(id);

            if (Autobus != null)
            {
                _context.Autobuss.Remove(Autobus);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
