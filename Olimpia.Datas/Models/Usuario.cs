using System;
using System.Collections.Generic;

#nullable disable

namespace Olimpia.Datas.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            ControlAccesos = new HashSet<ControlAcceso>();
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Documento { get; set; }
        public string TipoDocumento { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }
        public bool? Estado { get; set; }

        public virtual ICollection<ControlAcceso> ControlAccesos { get; set; }
    }
}
