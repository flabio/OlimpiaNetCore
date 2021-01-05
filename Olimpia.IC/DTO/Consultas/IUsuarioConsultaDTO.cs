namespace Olimpia.IC.DTO.Consultas
{
	using System;
	public interface IUsuarioConsultaDTO
	{
		int IdUsuario { get; set; }
		string Nombre { get; set; }
		string Apellidos { get; set; }
		string Documento { get; set; }
		string TipoDocumento { get; set; }
		string Direccion { get; set; }
		string Celular { get; set; }
		bool? Estado { get; set; }
		string EstadoAcceso { get; set; }
		DateTime? Fecha { get; set; }
		DateTime? FechaInicio { get; set; }
		DateTime? FechaFinal { get; set; }
		int IdEstadio { get; set; }

		int CantidadHincha { get; set; }
		decimal? CapacidadMaxima { get; set; }
		decimal? CapacidadPermitidad { get; set; }
	}
}
