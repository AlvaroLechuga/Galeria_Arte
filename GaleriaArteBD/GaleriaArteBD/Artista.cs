using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaleriaArteBD
{
	class Artista
	{
		private int codigo;
		private string nombre;
		private string nacion;
		private int edad;

		public Artista()
		{
		}

		public Artista(int codigo, string nombre, string nacion, int edad)
		{
			this.codigo = codigo;
			this.nombre = nombre;
			this.nacion = nacion;
			this.edad = edad;
		}

		public int Codigo { get => codigo; set => codigo = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public string Nacion { get => nacion; set => nacion = value; }
		public int Edad { get => edad; set => edad = value; }
	}
}
