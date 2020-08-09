using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using KDControl;
using KDSevice;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace KICKDRIVE.Pages.CRUDS.Supervisor
{
    public class IndexModel : PageModel
    {
        private readonly KDControl.AppDbContex _context;

        public IndexModel(KDControl.AppDbContex context)
        {
            _context = context;
        }

        public IList<SupervisorS> SupervisorS { get;set; }

        public async Task OnGetAsync()
        {
            SupervisorS = await _context.SupervisorS.ToListAsync();
        }

        public async Task<IActionResult> OnGetReport() 
        {
            SupervisorS = await _context.SupervisorS.ToListAsync();
            FileStreamResult file = new FileStreamResult(CrearPDF.Crearpdf(SupervisorS),MediaTypeNames.Application.Pdf);
            file.FileDownloadName = "Reporte Supervisores.pdf";
            return file;
        }
    }
}
