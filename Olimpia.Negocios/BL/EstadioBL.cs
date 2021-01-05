
namespace Olimpia.Negocios.BL
{
	using Olimpia.Datas.DAL;
	using Olimpia.IC.Acciones;
	using Olimpia.IC.DTO.Consultas;
	using Olimpia.IC.DTO.Entidades;
	using System;
	using System.Collections.Generic;
	public class EstadioBL : IEstadioAccion
	{
		private readonly Lazy<EstadioDAL> _estadioDAL;

		public EstadioBL()
		{
			_estadioDAL = new Lazy<EstadioDAL>();
		}
		public bool CrearEstadio(IEstadioDTO estadio)
		{
			return _estadioDAL.Value.CrearEstadio(estadio);
		}

		public bool EditarEstadio(IEstadioDTO estadio)
		{
			return _estadioDAL.Value.EditarEstadio(estadio);
		}

		public bool EliminarEstadio(int id)
		{
			return _estadioDAL.Value.EliminarEstadio(id);
		}

		public List<IEstadioConsultaDTO> ListadoEstadio()
		{
			return _estadioDAL.Value.ListadoEstadio();
		}
	}
}
