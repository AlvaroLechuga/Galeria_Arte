using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaleriaArteBD
{
	class BaseDatos
	{
		private MySqlConnection cnx;

		public BaseDatos(String cadenaCnx)
		{
			cnx = new MySqlConnection(cadenaCnx);
		}

		public int Conectar()
		{
			int resultado = -1;
			try
			{
				cnx.Open();
				if (cnx.State == ConnectionState.Open)
					resultado = 1;
			}
			catch (MySqlException ex)
			{

			}
			return resultado;
		}

		public int Desconectar()
		{
			int resultado = -1;
			if (cnx.State == ConnectionState.Open)
			{
				cnx.Close();
				resultado = 1;
			}
			return resultado;
		}

		public int InsertarObra(Obra obra)
		{
			int codigo = obra.Codigo;
			string nombre = obra.Nombre;
			string genero = obra.Genero;
			int year = obra.Year;
			int precio = obra.Precio;
			int codArtista = obra.CodArtista;
			int codExposicion = obra.CodExposicion;
			MySqlCommand c = new MySqlCommand();

			try
			{
				c.Connection = cnx;
				
				c.CommandText = "INSERT INTO obra VALUES(" + codigo + ", '" + nombre + "', "+year+", '"+genero+"', "+precio+", "+codArtista+", "+codExposicion+")";

				int r = c.ExecuteNonQuery();
				if (r == 1)
					return 1;
				else
					return 0;
			}
			catch(MySqlException ex)
			{
				return 0;
			}
		}

		public List<int> ObtenerCodExpo()
		{
			List<int> id = new List<int>();
			MySqlCommand c = new MySqlCommand();
			MySqlDataReader d;
			try
			{
				c.Connection = cnx;
				c.CommandText = "SELECT `CODIGOE` FROM `exposicion`";
				d = c.ExecuteReader();
				if (d.HasRows)
				{
					while (d.Read())
						id.Add(d.GetInt32(0));
				}
				d.Close();
				

			}
			catch (MySqlException ex)
			{

			}
			return id;
		}
		
		public List<int> ObtenerCodArtista()
		{
			List<int> id = new List<int>();
			MySqlCommand c = new MySqlCommand();
			MySqlDataReader d;
			try
			{
				c.Connection = cnx;
				c.CommandText = "SELECT `CODIGOA` FROM `artista`";
				d = c.ExecuteReader();
				if (d.HasRows)
				{
					while (d.Read())
						id.Add(d.GetInt32(0));
				}
				d.Close();

			}
			catch (MySqlException ex)
			{

			}
			return id;
		}

		public List<string> ObtenerNombreArtistas()
		{
			List<string> id = new List<string>();
			MySqlCommand c = new MySqlCommand();
			MySqlDataReader d;
			try
			{
				c.Connection = cnx;
				c.CommandText = "SELECT `NOMBRE` FROM `artista`";
				d = c.ExecuteReader();
				if (d.HasRows)
				{
					while (d.Read())
						id.Add(d.GetString(0));
				}
				d.Close();

			}
			catch (MySqlException ex)
			{

			}
			return id;
		}

		public List<Artista> ObtenerArtista(String nombre)
		{
			List<Artista> id = new List<Artista>();
			MySqlCommand c = new MySqlCommand();
			MySqlDataReader d;
			try
			{
				c.Connection = cnx;
				c.CommandText = "SELECT * FROM `artista` WHERE NOMBRE = '"+nombre+"'";
				
				d = c.ExecuteReader();
				if (d.HasRows)
				{
					while (d.Read())
						id.Add(new Artista(d.GetInt32(0), d.GetString(1), d.GetString(2), d.GetInt32(3)));
				}
				d.Close();

			}
			catch (MySqlException ex)
			{

			}
			return id;
		}

		public int EliminarArtista(string nombre)
		{
			MySqlCommand c = new MySqlCommand();
			int resultado = 0;
			try
			{
				c.Connection = cnx;
				
				c.CommandText = "DELETE FROM artista WHERE Nombre = '"+nombre+"'";
				resultado = c.ExecuteNonQuery();
				return resultado;
			}
			catch (MySqlException ex)
			{
				return 0;
			}
			
		}

		public List<Exposicion> ConsultarExposiciones(String comienzo, String final)
		{
			List<Exposicion> id = new List<Exposicion>();
			MySqlCommand c = new MySqlCommand();
			MySqlDataReader d;
			try
			{
				c.Connection = cnx;
				c.CommandText = "SELECT * FROM `exposicion` WHERE FECHAI AND FECHAF BETWEEN '" + comienzo + "' AND '" + final + "'";

				Debug.Print("SELECT * FROM `exposicion` WHERE FECHAI AND FECHAF BETWEEN '" + comienzo + "' AND '" + final + "'");

				d = c.ExecuteReader();
				if (d.HasRows)
				{
					while (d.Read())
						id.Add(new Exposicion(d.GetInt32(0), d.GetString(1), d.GetString(2), d.GetDateTime(3), d.GetDateTime(4)));
				}
				d.Close();

			}
			catch (MySqlException ex)
			{

			}
			return id;
		}

		public List<string> ObtenerNacionalidadArtistas()
		{
			List<string> id = new List<string>();
			MySqlCommand c = new MySqlCommand();
			MySqlDataReader d;
			try
			{
				c.Connection = cnx;
				c.CommandText = "SELECT `NACION` FROM artista";
				d = c.ExecuteReader();
				if (d.HasRows)
				{
					while (d.Read())
						id.Add(d.GetString(0));
				}
				d.Close();

			}
			catch (MySqlException ex)
			{

			}
			return id;
		}

		public List<Obra> ConsultarObras(string nacionalidad)
		{
			List<Obra> id = new List<Obra>();
			MySqlCommand c = new MySqlCommand();
			MySqlDataReader d;
			try
			{
				c.Connection = cnx;
				c.CommandText = "SELECT T1.* FROM obra T1 INNER JOIN artista T2 ON T1.CODA = T2.CODIGOA WHERE T2.NACION = '"+nacionalidad+"'";
				d = c.ExecuteReader();
				if (d.HasRows)
				{
					while (d.Read())
						id.Add(new Obra(d.GetInt32(0), d.GetString(1), d.GetInt32(2), d.GetString(3), d.GetInt32(4), d.GetInt32(5), d.GetInt32(6)));
				}
				d.Close();

			}
			catch (MySqlException ex)
			{

			}
			return id;
		}


	}
}
