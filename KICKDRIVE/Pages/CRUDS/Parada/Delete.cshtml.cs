using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KDControl;

namespace KICKDRIVE.Pages.CRUDS.Parada
{
    public class DeleteModel : PageModel
    {
        private readonly KDControl.AppDbContex _context;

        public DeleteModel(KDControl.AppDbContex context)
        {
            _context = context;
        }

        [BindProperty]
        public KDControl.Parada Parada { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Parada = await _context.Paradas.FirstOrDefaultAsync(m => m.Id == id);

            if (Parada == null)
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

            Parada = await _context.Paradas.FindAsync(id);

            if (Parada != null)
            {
                _context.Paradas.Remove(Parada);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
