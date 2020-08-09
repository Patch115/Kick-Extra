using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KDControl
{
    public class Login : EntityBase
    {
        public string Usuario { get; set; }
        public int Contraseña { get; set; }

        [Display(Name = "Supervisor")]
        [Required(ErrorMessage = "Por favor introdusca un usuario")]
        [ForeignKey("Supervisor")]
        public int SupervisorID {get; set;}
        public SupervisorS Supervisor { get; set; }
    }
}