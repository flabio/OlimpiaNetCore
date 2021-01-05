namespace Olimpia.Datas.Consultas
{
	using Olimpia.IC.DTO.Consultas;
	using System;

	public class EstadioConsulta : IEstadioConsultaDTO
	{
		public int IdEstadio { get; set; }
		public string Nombre { get; set; }
		public decimal? CapacidadMaxima { get; set; }
		public decimal? CapacidadPermitida { get ; set; }
		public DateTime FechaInicio { get; set; }
		public DateTime FechaFinal { get; set; }
	}
}
