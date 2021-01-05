namespace Olimpia.IC.DTO.Comunes
{
	public interface IRespuestaDTO
	{
		bool EsExitoso { get; set; }

		string Mensaje { get; set; }

		object Resultado { get; set; }
	}
}
