using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KDControl
{
    public class Conductor :EntityBase
    {
        public int Conduc { get; set; }
        public string Nombre { get; set; }
        public string Apellido_paterno { get; set; }
        public string Apellido_materno { get; set; }
        public string Tipo_licencia { get; set; }
        public char Autobus { get; set; }

        [Display(Name = "Autobus")]
        [Required(ErrorMessage = "El Autobus es Requerido")]
        [ForeignKey("Autobus")]
        public char Aatricula { get; set; }
        public Autobus Auto { get; set; }
    
    }
}
