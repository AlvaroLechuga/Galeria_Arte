using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaleriaArteBD
{
	public partial class Form1 : Form
	{
		BaseDatos b = new BaseDatos("SERVER=localhost;DATABASE=galeria;UID=root;PWD=''");
		List<int> listaCodArtista = new List<int>();
		List<int> listaCodExpo = new List<int>();
		List<string> listaNombres = new List<string>();
		List<string> listaNacionalidad = new List<string>();
		List<Artista> listaArtista = new List<Artista>();
		List<Exposicion> listaExposicion = new List<Exposicion>();
		List<Obra> listaObras = new List<Obra>();
		

		public Form1()
		{
			InitializeComponent();
			int r = b.Conectar();
			if (r == -1)
			{
				MessageBox.Show("No se ha podido establecer conexión con la BD");
			}
			else
			{
				dateTimePicker1.Format = DateTimePickerFormat.Custom;  
				dateTimePicker1.CustomFormat = "yyy-MM-dd";

				dateTimePicker2.Format = DateTimePickerFormat.Custom;
				dateTimePicker2.CustomFormat = "yyy-MM-dd";

				listaCodArtista = b.ObtenerCodArtista();
				listaCodExpo = b.ObtenerCodExpo();
				listaNombres = b.ObtenerNombreArtistas();
				listaNacionalidad = b.ObtenerNacionalidadArtistas();

				foreach (int clave in listaCodArtista)
				{
					cbCodigoArtista.Items.Add(clave);
				}

				foreach (int clave in listaCodExpo)
				{
					cbCodExposicion.Items.Add(clave);
				}

				foreach (string clave in listaNombres)
				{
					cbNombreArtista.Items.Add(clave);
				}

				foreach (string clave in listaNacionalidad)
				{
					cbNacionalidadArtista.Items.Add(clave);
				}

			}
				
		}

		private void btnAddObra_Click(object sender, EventArgs e)
		{
			Debug.Print(txtCodigoObra.Value.ToString());
			if(txtNombreObra.Text == "" || txtEstiloObra.Text == "" || cbCodigoArtista.SelectedIndex == -1 || cbCodExposicion.SelectedIndex == -1)
			{
				MessageBox.Show("Completa los campos");
			}
			else
			{
				Obra obra = new Obra();
				obra.CodArtista = Convert.ToInt32(cbCodExposicion.SelectedItem.ToString());
				obra.Nombre = txtNombreObra.Text;
				obra.Genero = txtEstiloObra.Text;
				obra.CodExposicion = Convert.ToInt32(cbCodExposicion.SelectedItem.ToString());
				obra.Codigo = Convert.ToInt32(txtCodigoObra.Value);
				obra.Precio = Convert.ToInt32(txtPrecioObra.Value);
				obra.Year = Convert.ToInt32(txtYearObra.Value);

				if (b.InsertarObra(obra) == 1)
				{
					MessageBox.Show("Se ha insertado la obra correctamente");
				}
				else
				{
					MessageBox.Show("Error al insertar");
				}
			}
			
		}

		private void btnEliminarArtista_Click(object sender, EventArgs e)
		{
			
			if(cbNombreArtista.SelectedIndex == -1)
			{
				MessageBox.Show("No has seleccionado ningun nombre");
			}
			else
			{

				DialogResult result = MessageBox.Show("¿Desea eliminar el artista?", "Eliminar Artista", MessageBoxButtons.OKCancel);
				if (result == DialogResult.Yes)
				{
					string nombre = cbNombreArtista.SelectedItem.ToString();
					if (b.EliminarArtista(nombre) == 1)
					{
						cbNombreArtista.Items.RemoveAt(cbNombreArtista.SelectedIndex);
						txtNacionArtista.Text = "";
						txtEdadArtista.Value = 0;
					}
				}
			}
		}

		private void btnBuscarExposiciones_Click(object sender, EventArgs e)
		{
			string comienzo = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
			string fin = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");

			listaExposicion = b.ConsultarExposiciones(comienzo, fin);

			dataGridView1.DataSource = listaExposicion.ToList();

		}

		private void cbNacionalidadArtista_SelectedIndexChanged(object sender, EventArgs e)
		{

			string nacionalidad = cbNacionalidadArtista.SelectedItem.ToString();

			listaObras = b.ConsultarObras(nacionalidad);

			dataGridView2.DataSource = listaObras.ToList();

		}

		private void cbNombreArtista_SelectedIndexChanged(object sender, EventArgs e)
		{
			string nombre = cbNombreArtista.SelectedItem.ToString();
			listaArtista = b.ObtenerArtista(nombre);

			txtNacionArtista.Text = listaArtista[0].Nacion;
			txtEdadArtista.Value = listaArtista[0].Edad;
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			listaCodArtista = b.ObtenerCodArtista();
			listaCodExpo = b.ObtenerCodExpo();
			listaNombres = b.ObtenerNombreArtistas();
			listaNacionalidad = b.ObtenerNacionalidadArtistas();

			cbCodExposicion.Items.Clear();
			cbCodigoArtista.Items.Clear();
			cbNacionalidadArtista.Items.Clear();
			cbNombreArtista.Items.Clear();

			foreach (int clave in listaCodArtista)
			{
				cbCodigoArtista.Items.Add(clave);
			}

			foreach (int clave in listaCodExpo)
			{
				cbCodExposicion.Items.Add(clave);
			}

			foreach (string clave in listaNombres)
			{
				cbNombreArtista.Items.Add(clave);
			}

			foreach (string clave in listaNacionalidad)
			{
				cbNacionalidadArtista.Items.Add(clave);
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			b.Desconectar();
		}
	}
}
