using System;
using System.Collections.Generic;

#nullable disable

namespace Olimpia.Datas.Models
{
    public partial class ControlAcceso
    {
        public int IdControlAcceso { get; set; }
        public string EstadoAcceso { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdEstadio { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual Estadio IdEstadioNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
