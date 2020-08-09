using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KDControl;

namespace KICKDRIVE.Pages.CRUDS.Rutas
{
    public class IndexModel : PageModel
    {
        private readonly KDControl.AppDbContex _context;

        public IndexModel(KDControl.AppDbContex context)
        {
            _context = context;
        }

        public IList<Ruta> Ruta { get;set; }

        public async Task OnGetAsync()
        {
            Ruta = await _context.Rutas.ToListAsync();
        }
    }
}
