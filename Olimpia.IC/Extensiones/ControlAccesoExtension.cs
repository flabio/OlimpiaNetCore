using Olimpia.IC.DTO.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Olimpia.IC.Extensiones
{
	public static class ControlAccesoExtension
	{
		public static TR MapeadorControlAcceso<TR>(this IControlAccesoDTO origen)
			where TR : IControlAccesoDTO, new()
		{
			return origen.MapeadorControlAcceso(new TR());
		}
		public static TR MapeadorControlAcceso<TR>(this IControlAccesoDTO origen,TR destino)
		where TR : IControlAccesoDTO, new()
		{
			if (destino == null)
			{
				destino = default(TR);
			}
			else {
				if (destino == null) {
					destino = new TR();
				}
				destino.EstadoAcceso = origen.EstadoAcceso;
				destino.Fecha = DateTime.Now;
				destino.IdUsuario = origen.IdUsuario;
				destino.IdEstadio = origen.IdEstadio;
			}
			return destino;
		}
	}
}
