using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Olimpia.Servicios.Models.Entidades
{
	public class ControlUsuarioModel
	{
		#region "PROPIEDADES DTO"
		public int IdUsuario { get; set; }
		public string Nombre { get; set; }
		public string Apellidos { get; set; }
		public string Documento { get; set; }
		public string TipoDocumento { get; set; }
		public string Direccion { get; set; }
		public string Celular { get; set; }
		public bool? Estado { get; set; }
		public int IdEstadio { get; set; }

		public string EstadoAcceso{ get; set; }

	#endregion
}
}
