namespace Olimpia.IC.Acciones
{
	using Olimpia.IC.DTO.Consultas;
	using Olimpia.IC.DTO.Entidades;
	using System.Collections.Generic;
	public interface IControlAccesoAccion
	{
		bool CrearControlAcceso(IControlAccesoDTO controlAcceso);
		bool EditarControlAcceso(IControlAccesoDTO controlAcceso);
		bool EliminarControlAcceso(int id);

		List<IControlAccesoConsultaDTO> ListadoControlAcceso();
	}
}
