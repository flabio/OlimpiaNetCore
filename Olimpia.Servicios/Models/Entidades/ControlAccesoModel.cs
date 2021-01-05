namespace Olimpia.Servicios.Models.Entidades
{
	using Olimpia.IC.DTO.Entidades;
	using System;
	public class ControlAccesoModel : IControlAccesoDTO
	{
		#region "PROPIEDADES DTO"
		public int IdControlAcceso { get; set; }
		public string EstadoAcceso { get; set; }
		public int? IdUsuario { get; set; }
		public int? IdEstadio { get; set; }
		public DateTime? Fecha { get; set; }
		#endregion
	}
}
