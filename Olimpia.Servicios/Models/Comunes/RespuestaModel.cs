namespace Olimpia.Servicios.Models
{
	using Olimpia.IC.DTO.Comunes;
	public class RespuestaModel : IRespuestaDTO
	{
		public bool EsExitoso { get; set; }
		public string Mensaje { get; set; }
		public object Resultado { get; set; }
	}
}
