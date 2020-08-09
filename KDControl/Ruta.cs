using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KDControl
{
   public class Ruta : EntityBase
    {
        [DisplayName("Nombre de la Ruta:")]
        [Required(ErrorMessage = "Es necesario nombre de la Ruta")]
        public string Nombre { get; set; }
        [DisplayName("Distancia de la Ruta:")]
        [Required(ErrorMessage = "Es necesario la disctancia de la ruta")]
        public int Distancia { get; set; }
    }
}
