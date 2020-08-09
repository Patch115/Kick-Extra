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
    public class DetailsModel : PageModel
    {
        private readonly KDControl.AppDbContex _context;

        public DetailsModel(KDControl.AppDbContex context)
        {
            _context = context;
        }

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
    }
}
