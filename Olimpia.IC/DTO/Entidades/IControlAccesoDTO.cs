namespace Olimpia.IC.DTO.Entidades
{
	using System;
	public interface IControlAccesoDTO
	{
		public int IdControlAcceso { get; set; }
		public string EstadoAcceso { get; set; }
		public int? IdUsuario { get; set; }
		public int? IdEstadio { get; set; }
		public DateTime? Fecha { get; set; }
	}
}
