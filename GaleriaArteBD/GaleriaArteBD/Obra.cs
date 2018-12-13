using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaleriaArteBD
{
	class Obra
	{
		private int codigo;
		private string nombre;
		private int year;
		private string genero;
		private int precio;
		private int codArtista;
		private int codExposicion;

		public Obra()
		{

		}

		public Obra(int codigo, string nombre, int year, string genero, int precio, int codArtista, int codExposicion)
		{
			this.codigo = codigo;
			this.nombre = nombre;
			this.genero = genero;
			this.year = year;
			this.precio = precio;
			this.codArtista = codArtista;
			this.codExposicion = codExposicion;
		}

		public int Codigo { get => codigo; set => codigo = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public string Genero { get => genero; set => genero = value; }
		public int Year { get => year; set => year = value; }
		public int Precio { get => precio; set => precio = value; }
		public int CodArtista { get => codArtista; set => codArtista = value; }
		public int CodExposicion { get => codExposicion; set => codExposicion = value; }
	}
}
