using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KDControl;

namespace KICKDRIVE.Pages.CRUDS.Conductores
{
    public class CreateModel : PageModel
    {
        private readonly KDControl.AppDbContex _context;

        public CreateModel(KDControl.AppDbContex context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public KDControl.Conductor Conductor { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Conductors.Add(Conductor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
