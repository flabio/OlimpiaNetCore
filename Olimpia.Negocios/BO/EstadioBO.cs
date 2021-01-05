namespace Olimpia.Negocios.BO
{
	using Olimpia.IC.DTO.Entidades;
	using System;

	public class EstadioBO : IEstadioDTO
	{
		public int IdEstadio { get; set; }
		public string Nombre { get; set; }
		public decimal? CapacidadMaxima { get; set; }
		public decimal? CapacidadPermitida { get; set; }
		public DateTime FechaInicio { get; set; }
		public DateTime FechaFinal { get ; set; }
	}
}
