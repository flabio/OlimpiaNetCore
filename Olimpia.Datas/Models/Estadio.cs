using System;
using System.Collections.Generic;

#nullable disable

namespace Olimpia.Datas.Models
{
    public partial class Estadio
    {
        public Estadio()
        {
            ControlAcceso = new HashSet<ControlAcceso>();
        }

        public int IdEstadio { get; set; }
        public string Nombre { get; set; }
        public decimal? CapacidadMaxima { get; set; }
        public decimal? CapacidadPermitida { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public virtual ICollection<ControlAcceso> ControlAcceso { get; set; }
    }
}
