using System;

namespace Olimpia.IC.DTO.Entidades
{
	public interface IEstadioDTO
	{
		int IdEstadio { get; set; }
		string Nombre { get; set; }
		decimal? CapacidadMaxima { get; set; }
		decimal? CapacidadPermitida { get; set; }
		DateTime FechaInicio { get; set; }
		DateTime FechaFinal { get; set; }

	}
}
