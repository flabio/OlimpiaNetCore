namespace Olimpia.Servicios.Models.Entidades
{
	using Olimpia.IC.DTO.Entidades;
	public class UsuarioModel : IUsuarioDTO
	{
		#region "PROPIEDADES DTO"
		public int IdUsuario { get; set; }
		public string Nombre { get; set; }
		public string Apellidos { get; set; }
		public string Documento { get; set; }
		public string TipoDocumento { get; set; }
		public string Direccion { get; set; }
		public string Celular { get; set; }
		public bool? Estado { get; set; }
	
		#endregion
	}
}
