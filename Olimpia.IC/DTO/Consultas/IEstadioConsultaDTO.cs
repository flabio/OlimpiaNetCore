using System;

namespace Olimpia.IC.DTO.Consultas
{
	public interface IEstadioConsultaDTO
	{
		int IdEstadio { get; set; }
		string Nombre { get; set; }
		decimal? CapacidadMaxima { get; set; }
		decimal? CapacidadPermitida { get; set; }
		DateTime FechaInicio { get; set; }
		DateTime FechaFinal { get; set; }
	}
}
