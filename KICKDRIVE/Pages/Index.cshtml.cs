using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KDControl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace KICKDRIVE.Pages
{
    public class IndexModel : PageModel
    {
       /* public string Msg;

        private readonly ILogger<IndexModel> _logger;
        AppDbContex AppBD;
        [BindProperty]
        public KDControl.Login Login { get; set; }
        public string Usuario { get; set; }
        public object BCrypt { get; private set; }
        public object Net { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, AppDbContex appBD)
        {
            _logger = logger;
            AppBD = appBD;
        }

        public void OnGet()
        {
            Login = new KDControl.Login();
        }

        public IActionResult OnPost()
        {
            var _loggin = login(Login.Usuario, Login.Contraseña);
            if (_loggin == null)
            {
                return RedirectToPage("Eror de inicio");
            }
            else
            {
                HttpContext.Session.SetString("Nombre", _loggin.Usuario);
                return RedirectToPage("IniciarSesion", _loggin.Contraseña);
            }
        }
        private KDControl.Login login(string usuario, string contraseña)
        {
            var login = AppBD.Logins.SingleOrDefault(a => a.Usuario.Equals(usuario));
            if (login != null)
            {
                if (BCrypt.Net.BCrypt.Verify(contraseña, login.Contraseña))
                {
                    return login;
                }
                return null;
            }
        }


        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("Nombre");
            return RedirectToPage("Index");
        }*/
        public void OnGet()
        {

        }
    }
}
