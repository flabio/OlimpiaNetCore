namespace Olimpia.IC.DTO.Entidades
{
	public interface IUsuarioDTO
	{
		int IdUsuario { get; set; }
		string Nombre { get; set; }
		string Apellidos { get; set; }
		string Documento { get; set; }
		string TipoDocumento { get; set; }
		string Direccion { get; set; }
		string Celular { get; set; }
		bool? Estado { get; set; }
	}
}
