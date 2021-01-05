namespace Olimpia.IC.Extensiones
{
	using Olimpia.IC.DTO.Entidades;
	public static class UsuarioDTOExtension
	{
		public static TR MapeadorUsuario<TR>(this IUsuarioDTO origen)
		where TR : IUsuarioDTO, new()
		{
			return origen.MapeadorUsuario(new TR());
		}
		public static TR MapeadorUsuario<TR>(this IUsuarioDTO origen, TR destino)
		 where TR : IUsuarioDTO, new()
		{

			if (origen == null)
			{
				destino = default(TR);
			}
			else
			{
				if (destino == null)
				{
					destino = new TR();
				}
				destino.Nombre = origen.Nombre;
				destino.Apellidos = origen.Apellidos;
				destino.Documento = origen.Documento;
				destino.TipoDocumento = origen.TipoDocumento;
				destino.Direccion = origen.Direccion;
				destino.Celular = origen.Celular;
				destino.Estado = origen.Estado;
			}

			return destino;
		}
	}
}
