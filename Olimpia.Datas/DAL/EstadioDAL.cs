namespace Olimpia.Datas.DAL
{
	using Olimpia.Datas.Consultas;
	using Olimpia.Datas.Models;
	using Olimpia.IC.Acciones;
	using Olimpia.IC.DTO.Consultas;
	using Olimpia.IC.DTO.Entidades;
	using Olimpia.IC.Extensiones;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	public class EstadioDAL : IEstadioAccion
	{
		public bool CrearEstadio(IEstadioDTO estadio)
		{
			bool resultado = false;
			using (OlimpiaDBContext context = new OlimpiaDBContext())
			{
				using (var transacion = context.Database.BeginTransaction())
				{
					try
					{
						Estadio nuevoEstadio = new Estadio();
						nuevoEstadio = estadio.MapeadorEstadio<Estadio>(nuevoEstadio);
						if (estadio.IdEstadio > 0)
						{
							nuevoEstadio = context.Estadios.Find(estadio.IdEstadio);
							context.Estadios.Update(nuevoEstadio);
						}
						else
						{
							context.Estadios.Add(nuevoEstadio);
						}
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

		public bool EditarEstadio(IEstadioDTO estadio)
		{
			bool resultado = false;
			using (OlimpiaDBContext context = new OlimpiaDBContext())
			{
				using (var transacion = context.Database.BeginTransaction())
				{
					try
					{
						Estadio editarEstadio = context.Estadios.Find(estadio.IdEstadio);
						editarEstadio = estadio.MapeadorEstadio<Estadio>(editarEstadio);
						context.Estadios.Update(editarEstadio);
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

		public bool EliminarEstadio(int id)
		{
			bool resultado = false;
			using (OlimpiaDBContext context = new OlimpiaDBContext())
			{
				using (var transacion = context.Database.BeginTransaction())
				{
					try
					{
						Estadio eliminarEstadio = context.Estadios.Find(id);
						context.Estadios.Remove(eliminarEstadio);
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

		public List<IEstadioConsultaDTO> ListadoEstadio()
		{
			List<IEstadioConsultaDTO> resultado = new List<IEstadioConsultaDTO>();
			using (OlimpiaDBContext context = new OlimpiaDBContext())
			{

				try
				{
					resultado = (from e in context.Estadios
								 select new EstadioConsulta()
								 {
									 IdEstadio = e.IdEstadio,
									 Nombre = e.Nombre,
									 CapacidadMaxima = e.CapacidadMaxima,
									 CapacidadPermitida = e.CapacidadPermitida,
									 FechaInicio = e.FechaInicio,
									 FechaFinal = e.FechaFinal
								 }).ToList<IEstadioConsultaDTO>();
				}
				catch (Exception ex)
				{
					throw new Exception(ex.Message);
				}

			}
			return resultado;
		}
	}
}
