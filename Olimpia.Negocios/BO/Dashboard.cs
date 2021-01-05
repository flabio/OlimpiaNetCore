using Olimpia.IC.DTO.Entidades;

namespace Olimpia.Negocios.BO
{
	public class Dashboard : IDashboard
	{
		public decimal? Hincha { get; set; }
		public decimal? CapacidadMaxima { get; set; }
		public decimal? CapacidadPermitida { get; set; }
	}
}
