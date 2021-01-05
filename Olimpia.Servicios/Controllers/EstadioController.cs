using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Olimpia.IC.DTO.Consultas;
using Olimpia.IC.Extensiones;
using Olimpia.Negocios.BL;
using Olimpia.Servicios.App_LocalResources.comunes;
using Olimpia.Servicios.App_LocalResources.Configuracion;
using Olimpia.Servicios.Models;
using Olimpia.Servicios.Models.Consultas;
using Olimpia.Servicios.Models.Entidades;
using System;
using System.Collections.Generic;

namespace Olimpia.Servicios.Controllers
{
	//[Route("api/[controller]")]
	[Produces("application/json")]
	[ApiController]
	public class EstadioController : ControllerBase
	{
		#region DECLARACIONES
		private readonly Lazy<EstadioBL> _estadioBL;
		#endregion

		#region CONSTRUCTORES
		public EstadioController()
		{
			this._estadioBL = new Lazy<EstadioBL>();
		}
		#endregion

		#region METODOS
		[HttpPost]
		//[Authorize]
		[Route("api/estadio/crear")]
		public ActionResult<RespuestaModel> CrearEstadio( EstadioModel estadio)
		{
			try
			{
				bool resultado = this._estadioBL.Value.CrearEstadio(estadio);

				return StatusCode(StatusCodes.Status200OK, new RespuestaModel()
				{
					EsExitoso = true,
					Mensaje = resultado ? rscMensajesComunes.RegistroCreado : rscMensajesComunes.RegistroNoCreado,
					Resultado = resultado
				});
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, new RespuestaModel() { Mensaje = ex.Message });
			}
		}
		[HttpPost]
		//[Authorize]
		[Route("api/estadio/editar")]
		public ActionResult<RespuestaModel> EditarEstadio(EstadioModel estadio)
			{
			try
			{
				bool resultado = this._estadioBL.Value.EditarEstadio(estadio);

				return StatusCode(StatusCodes.Status200OK, new RespuestaModel()
				{
					EsExitoso = true,
					Mensaje = resultado ? rscMensajesComunes.RegistroEditado : rscMensajesComunes.RegistroNoEditado,
					Resultado = resultado
				});
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, new RespuestaModel() { Mensaje = ex.Message });
			}
		}
		[HttpGet]
		//[Authorize]
		[Route("api/estadio/listadoestadio")]
		public ActionResult<List<IEstadioConsultaDTO>> ListadoEstadio()
		{
			try
			{
				List<IEstadioConsultaDTO> resultado = this._estadioBL.Value.ListadoEstadio();

				return resultado;
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, new RespuestaModel() { Mensaje = ex.Message });
			}
		}
		[HttpDelete]
		//[Authorize]
		[Route("api/estadio/eliminar")]
		public ActionResult<RespuestaModel> EliminarEstadio(int id)
		{
			try
			{
				bool resultado = this._estadioBL.Value.EliminarEstadio(id);

				return StatusCode(StatusCodes.Status200OK, new RespuestaModel()
				{
					EsExitoso = true,
					Mensaje = resultado ? rscMensajesComunes.RegistroEliminado : rscMensajesComunes.RegistroNoEliminado,
					Resultado = resultado
				});
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, new RespuestaModel() { Mensaje = ex.Message });
			}
		}
		#endregion
	}
}
