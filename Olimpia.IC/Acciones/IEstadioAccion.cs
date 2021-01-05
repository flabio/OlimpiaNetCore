namespace Olimpia.IC.Acciones
{
	using Olimpia.IC.DTO.Consultas;
	using Olimpia.IC.DTO.Entidades;
	using System.Collections.Generic;
	public interface IEstadioAccion
	{
		bool CrearEstadio(IEstadioDTO estadio);
		bool EditarEstadio(IEstadioDTO estadio);
		bool EliminarEstadio(int id);

		List<IEstadioConsultaDTO> ListadoEstadio();
	}
}
