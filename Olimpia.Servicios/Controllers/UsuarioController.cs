using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Olimpia.IC.DTO.Consultas;
using Olimpia.Negocios.BL;
using Olimpia.Servicios.App_LocalResources.comunes;
using Olimpia.Servicios.App_LocalResources.Configuracion;
using Olimpia.Servicios.Models;
using Olimpia.Servicios.Models.Entidades;
using System;
using System.Collections.Generic;

namespace Olimpia.Servicios.Controllers
{
	[Produces("application/json")]
	[ApiController]
	public class UsuarioController : ControllerBase
	{
		#region DECLARACIONES
		private readonly Lazy<UsuarioBL> _usuarioBL;
		#endregion

		#region CONSTRUCTORES
		public UsuarioController()
		{
			this._usuarioBL = new Lazy<UsuarioBL>();
		}
		#endregion

		#region METODOS
		[HttpPost("api/usuario/crear")]
		//[Authorize]
		
		public ActionResult<RespuestaModel> CrearUsuario([FromBody] ControlUsuarioModel control)
		{
			try
			{
				UsuarioModel usuario = new UsuarioModel() {
					Nombre = control.Nombre,
					Apellidos = control.Apellidos,
					Documento=control.Documento,
					TipoDocumento = control.TipoDocumento,
					Direccion = control.Direccion,
					Celular = control.Celular,
					Estado=true
				};
				
				bool resultado = this._usuarioBL.Value.CrearUsuario(usuario,control.IdEstadio,control.EstadoAcceso);

				return StatusCode(StatusCodes.Status200OK, new RespuestaModel()
				{
					EsExitoso = true,
					Mensaje = true ? rscMensajesComunes.RegistroCreado : rscMensajesComunes.RegistroNoCreado,
					Resultado = true
				});
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, new RespuestaModel() { Mensaje = ex.Message });
			}
		}
		[HttpPost]
		//[Authorize]
		[Route("api/usuario/editar")]
		public ActionResult<bool> EditarEstadio(UsuarioModel usuario)
		{
			try
			{
				//bool resultado = this._usuarioBL.Value.EditarUsuario(usuario);

				return StatusCode(StatusCodes.Status200OK, new RespuestaModel()
				{
					EsExitoso = true,
					Mensaje = true ? rscMensajesComunes.RegistroEditado : rscMensajesComunes.RegistroNoEditado,
					Resultado = true
				});
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, new RespuestaModel() { Mensaje = ex.Message });
			}
		}
		
		
		[HttpGet("api/usuario/listadousuario")]

		public ActionResult<List<IUsuarioConsultaDTO>> ListadoUsuario()
		{
			try
			{
				List<IUsuarioConsultaDTO> resultado = this._usuarioBL.Value.ListadoUsuario();
				return resultado;
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, new RespuestaModel() { Mensaje = ex.Message });
			}
		}

		[HttpGet("api/usuario/dashboard")]

		public ActionResult<IUsuarioConsultaDTO> ListadoDashboard()
		{
			try
			{
				
				var resultado = this._usuarioBL.Value.Grafica();
				return StatusCode(StatusCodes.Status200OK, new RespuestaModel()
				{
					EsExitoso = true,
					Mensaje = true ? rscMensajesComunes.RegistroEditado : rscMensajesComunes.RegistroNoEditado,
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
