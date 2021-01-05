namespace Olimpia.Datas.DAL
{
	using Olimpia.Datas.Models;
	using Olimpia.IC.Acciones;
	using Olimpia.IC.DTO.Consultas;
	using Olimpia.IC.DTO.Entidades;
	using Olimpia.IC.Extensiones;
	using System;
	using System.Linq;
	using System.Collections.Generic;
	using Olimpia.Datas.Consultas;

	public class UsuarioDAL : IUsuarioAccion
	{
		public bool CrearUsuario(IUsuarioDTO usuario, int IdEstadio, string EstadoAcceso)
		{
			bool resultado = false;
			using (OlimpiaDBContext context = new OlimpiaDBContext())
			{
				using (var transacion = context.Database.BeginTransaction())
				{
					try
					{
						Usuario nuevoUsuario = new Usuario();
						nuevoUsuario = usuario.MapeadorUsuario<Usuario>();
						context.Usuarios.Add(nuevoUsuario);
						context.SaveChanges();
						ControlAcceso nuewvoControlAcceso = new ControlAcceso()
						{
							IdEstadio = IdEstadio,
							IdUsuario = nuevoUsuario.IdUsuario,
							EstadoAcceso = EstadoAcceso,
							Fecha = DateTime.Now
						};
						context.ControlAccesos.Add(nuewvoControlAcceso);
						context.SaveChanges();
						transacion.Commit();
						resultado = true;

					}
					catch (Exception ex)
					{
						transacion.Rollback();
					}
				}
			}
			return resultado;
		}

		public bool EditarUsuario(IUsuarioDTO usuario)
		{
			throw new NotImplementedException();
		}

		public bool EliminarUsuario(int id)
		{
			throw new NotImplementedException();
		}

		public List<IUsuarioConsultaDTO> ListadoUsuario()
		{
			List<IUsuarioConsultaDTO> resultado = new List<IUsuarioConsultaDTO>();
			using (OlimpiaDBContext context = new OlimpiaDBContext())
			{
				try
				{
					resultado = (from c in context.ControlAccesos
								 join u in context.Usuarios on c.IdUsuario equals u.IdUsuario
								 join e in context.Estadios on c.IdEstadio equals e.IdEstadio
								 select new ConsultaUsuario()
								 {
									 IdUsuario = u.IdUsuario,
									 Nombre = u.Nombre,
									 Apellidos = u.Apellidos,
									 Documento = u.Documento,
									 TipoDocumento = u.TipoDocumento,
									 Direccion = u.Direccion,
									 Celular = u.Celular,
									 EstadoAcceso = c.EstadoAcceso,
									 Fecha = c.Fecha,
									 FechaInicio = e.FechaInicio,
									 FechaFinal = e.FechaFinal,
									 IdEstadio = e.IdEstadio,
									 CapacidadPermitidad = e.CapacidadPermitida,
									 CapacidadMaxima = e.CapacidadMaxima

								 }
							   ).ToList<IUsuarioConsultaDTO>();
				}
				catch (Exception ex)
				{
				}
			}
			return resultado;
		}


		

	}
}
