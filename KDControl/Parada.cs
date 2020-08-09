using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KDControl
{
    public class Parada : EntityBase
    {
        [DisplayName("Incidentes:")]
        public int Incidentes { get; set; }
        [DisplayName("Tipo de Incidente:")]
        public string Tipo_incidente { get; set; }
        [DisplayName("Fecha de Parada:")]
        public string Fecha { get; set; }
        [DisplayName("Hora de Parada:")]
        public int Hora { get; set; }
        [DisplayName("Ruta Tomada:")]
        public string Ruta { get; set; }
    }
}
