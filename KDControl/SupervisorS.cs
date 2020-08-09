using System;
using System.Collections.Generic;
using System.Text;

namespace KDControl
{
    public class SupervisorS : EntityBase
    {
        public string Nombre { get; set; }
        public string Apellido_paterno { get; set; }
        public string Apellido_materno { get; set; }
        public string Contraseña { get; set; }
        public string Usuario { get; set; }
    }
}