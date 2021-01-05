namespace Olimpia.IC.Extensiones
{
	using Olimpia.IC.DTO.Entidades;

	public static class EstadioDTOExtension
	{
		/// <summary>
		/// Estadio
		/// </summary>
		/// <typeparam name="TR"></typeparam>
		/// <param name="origen"></param>
		/// <returns></returns>
		public static TR MapeadorEstadio<TR>(this IEstadioDTO origen)
			where TR : IEstadioDTO, new()
		{
			return origen.MapeadorEstadio(new TR());
		}
		/// <summary>
		/// Estadio
		/// </summary>
		/// <typeparam name="TR"></typeparam>
		/// <param name="origen"></param>
		/// <param name="destino"></param>
		/// <returns></returns>
		public static TR MapeadorEstadio<TR>(this IEstadioDTO origen, TR destino)
			where TR : IEstadioDTO, new()
		{
			if (destino == null)
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
				destino.CapacidadMaxima = origen.CapacidadMaxima;
				destino.CapacidadPermitida = origen.CapacidadPermitida;
				destino.FechaInicio = origen.FechaInicio;
				destino.FechaFinal = origen.FechaFinal;
			}
			return destino;
		}
		

	}
}
