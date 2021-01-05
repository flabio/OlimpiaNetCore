namespace Olimpia.Datas.Consultas
{
	using Olimpia.IC.DTO.Consultas;
	using System;
	public class ConsultaUsuario : IUsuarioConsultaDTO
	{
		public int IdUsuario { get; set; }
		public string Nombre { get; set; }
		public string Apellidos { get; set; }
		public string Documento { get; set; }
		public string TipoDocumento { get; set; }
		public string Direccion { get; set; }
		public string Celular { get; set; }
		public bool? Estado { get; set; }
		public string EstadoAcceso { get; set; }
		public DateTime? Fecha { get; set; }

		public DateTime? FechaInicio { get; set; }
		public DateTime? FechaFinal { get; set; }

		public int IdEstadio { get; set; }
		public int CantidadHincha { get; set; }
		public decimal? CapacidadMaxima { get; set; }
		public decimal? CapacidadPermitidad { get; set; }
	}
}
