namespace Olimpia.IC.Acciones
{
	using Olimpia.IC.DTO.Consultas;
	using Olimpia.IC.DTO.Entidades;
	using System.Collections.Generic;
	public interface IUsuarioAccion
	{
		bool CrearUsuario(IUsuarioDTO usuario,int IdEstadio,string EstadoAcceso);
		bool EditarUsuario(IUsuarioDTO usuario);
		bool EliminarUsuario(int id);

		
		List<IUsuarioConsultaDTO> ListadoUsuario();
	}
}
