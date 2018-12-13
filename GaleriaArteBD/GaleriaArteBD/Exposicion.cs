using System;

namespace GaleriaArteBD
{
	class Exposicion
	{
		private int codigoExposicion;
		private string nombre;
		private string descripcion;
		private DateTime fechaInicio;
		private DateTime fechaFin;

		public Exposicion()
		{
		}

		public Exposicion(int codigoExposicion, string nombre, string descripcion, DateTime fechaInicio, DateTime fechaFin)
		{
			this.codigoExposicion = codigoExposicion;
			this.nombre = nombre;
			this.descripcion = descripcion;
			this.fechaInicio = fechaInicio;
			this.fechaFin = fechaFin;
		}

		public int CodigoExposicion { get => codigoExposicion; set => codigoExposicion = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public string Descripcion { get => descripcion; set => descripcion = value; }
		public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
		public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
	}
}