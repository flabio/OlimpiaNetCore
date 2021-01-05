
namespace Olimpia.Negocios.BL
{
	using Olimpia.Datas.DAL;
	using Olimpia.IC.Acciones;
	using Olimpia.IC.DTO.Consultas;
	using Olimpia.IC.DTO.Entidades;
	using System;
	using System.Linq;
	using System.Collections.Generic;
	using Olimpia.Negocios.App_LocalResources;
	using System.Globalization;
	using Olimpia.Negocios.BO;

	public class UsuarioBL : IUsuarioAccion
	{
		private readonly Lazy<UsuarioDAL> _usuarioDAL;
		private readonly Lazy<EstadioDAL> _estadioDAL;

		public UsuarioBL()
		{
			this._usuarioDAL = new Lazy<UsuarioDAL>();
			this._estadioDAL = new Lazy<EstadioDAL>();
		}
		#region METODOS PUBLICO
		public bool CrearUsuario(IUsuarioDTO usuario, int IdEstadio, string EstadoAcceso)
		{
			ValidarIngreso(usuario, IdEstadio, EstadoAcceso);
			return this._usuarioDAL.Value.CrearUsuario(usuario, IdEstadio, EstadoAcceso);
		}

		public bool EditarUsuario(IUsuarioDTO usuario)
		{
			return this._usuarioDAL.Value.EditarUsuario(usuario);
		}

		public bool EliminarUsuario(int id)
		{
			return this._usuarioDAL.Value.EliminarUsuario(id);
		}

		public Dashboard Grafica()
		{
			List<IUsuarioConsultaDTO> res = this._usuarioDAL.Value.ListadoUsuario();
			Dashboard resultado = new Dashboard()
			{
				Hincha = res.Count(),
				CapacidadMaxima=res.Select(x=>x.CapacidadMaxima).FirstOrDefault(),
				CapacidadPermitida = res.Select(x => x.CapacidadPermitidad).FirstOrDefault(),
			};
			
			return resultado;
		}

		public List<IUsuarioConsultaDTO> ListadoUsuario()
		{
			return this._usuarioDAL.Value.ListadoUsuario();
		}
		#endregion

		#region Metodo privado
		public void ValidarIngreso(IUsuarioDTO usuario, int IdEstadio, string EstadoAcceso)
		{
			List<IUsuarioConsultaDTO> res = this._usuarioDAL.Value.ListadoUsuario();
			List<IEstadioConsultaDTO> rescapacidadPermitidad = this._estadioDAL.Value.ListadoEstadio();
			var cantidadPermitidad = rescapacidadPermitidad.Where(x => x.IdEstadio == IdEstadio).FirstOrDefault();
			int cantidad = res.Where(x => x.EstadoAcceso=="Entrada").Count();
			if (cantidad > cantidadPermitidad.CapacidadPermitida)
			{
				throw new Exception(string.Format(rscMsg.CapacidadPermitidad));
			}

			var datos = res.Where(x => x.Documento == usuario.Documento && x.IdEstadio==IdEstadio).FirstOrDefault();
			if (cantidadPermitidad != null)
			{

				int result = DateTime.Compare(cantidadPermitidad.FechaFinal, DateTime.Now);
				if (datos != null) { 
						if (datos.Documento == usuario.Documento && result > 0)
						{
							throw new Exception(string.Format(datos.EstadoAcceso == "Entrada" ? rscMsg.YaIngreso : rscMsg.YaSalio));
						}
				}
				if (result < 0)
				{
					throw new Exception(string.Format(rscMsg.NoHayFechaPromada));
				}
			}

		}


		#endregion
	}
}
