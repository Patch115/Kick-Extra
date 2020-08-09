using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KDControl;

namespace KICKDRIVE.Pages.CRUDS.supervisores
{
    public class DeleteModel : PageModel
    {
        private readonly KDControl.AppDbContex _context;

        public DeleteModel(KDControl.AppDbContex context)
        {
            _context = context;
        }

        [BindProperty]
        public KDControl.SupervisorS SupervisorS { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SupervisorS = await _context.SupervisorS.FirstOrDefaultAsync(m => m.Id == id);

            if (SupervisorS == null)
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

            SupervisorS = await _context.SupervisorS.FindAsync(id);

            if (SupervisorS != null)
            {
                _context.SupervisorS.Remove(SupervisorS);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
