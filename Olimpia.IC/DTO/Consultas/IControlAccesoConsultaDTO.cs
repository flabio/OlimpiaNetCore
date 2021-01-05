namespace Olimpia.IC.DTO.Consultas
{
	using System;
	public interface IControlAccesoConsultaDTO
	{
		public int IdControlAcceso { get; set; }
		public string EstadoAcceso { get; set; }
		public int? IdUsuario { get; set; }
		public int? IdEstadio { get; set; }
		public DateTime? Fecha { get; set; }
	}
}
