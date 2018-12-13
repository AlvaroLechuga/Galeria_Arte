namespace GaleriaArteBD
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.cbCodExposicion = new System.Windows.Forms.ComboBox();
			this.cbCodigoArtista = new System.Windows.Forms.ComboBox();
			this.btnAddObra = new System.Windows.Forms.Button();
			this.txtEstiloObra = new System.Windows.Forms.TextBox();
			this.txtNombreObra = new System.Windows.Forms.TextBox();
			this.txtPrecioObra = new System.Windows.Forms.NumericUpDown();
			this.txtYearObra = new System.Windows.Forms.NumericUpDown();
			this.txtCodigoObra = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnEliminarArtista = new System.Windows.Forms.Button();
			this.txtEdadArtista = new System.Windows.Forms.NumericUpDown();
			this.txtNacionArtista = new System.Windows.Forms.TextBox();
			this.cbNombreArtista = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnBuscarExposiciones = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.cbNacionalidadArtista = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtPrecioObra)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtYearObra)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCodigoObra)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtEdadArtista)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Location = new System.Drawing.Point(0, -1);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(729, 359);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.cbCodExposicion);
			this.tabPage1.Controls.Add(this.cbCodigoArtista);
			this.tabPage1.Controls.Add(this.btnAddObra);
			this.tabPage1.Controls.Add(this.txtEstiloObra);
			this.tabPage1.Controls.Add(this.txtNombreObra);
			this.tabPage1.Controls.Add(this.txtPrecioObra);
			this.tabPage1.Controls.Add(this.txtYearObra);
			this.tabPage1.Controls.Add(this.txtCodigoObra);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(721, 333);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Añadir Obra";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// cbCodExposicion
			// 
			this.cbCodExposicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCodExposicion.FormattingEnabled = true;
			this.cbCodExposicion.Location = new System.Drawing.Point(279, 265);
			this.cbCodExposicion.Name = "cbCodExposicion";
			this.cbCodExposicion.Size = new System.Drawing.Size(172, 21);
			this.cbCodExposicion.TabIndex = 13;
			// 
			// cbCodigoArtista
			// 
			this.cbCodigoArtista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCodigoArtista.FormattingEnabled = true;
			this.cbCodigoArtista.Location = new System.Drawing.Point(279, 224);
			this.cbCodigoArtista.Name = "cbCodigoArtista";
			this.cbCodigoArtista.Size = new System.Drawing.Size(172, 21);
			this.cbCodigoArtista.TabIndex = 12;
			// 
			// btnAddObra
			// 
			this.btnAddObra.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddObra.Location = new System.Drawing.Point(530, 125);
			this.btnAddObra.Name = "btnAddObra";
			this.btnAddObra.Size = new System.Drawing.Size(98, 59);
			this.btnAddObra.TabIndex = 14;
			this.btnAddObra.Text = "Añadir Obra";
			this.btnAddObra.UseVisualStyleBackColor = true;
			this.btnAddObra.Click += new System.EventHandler(this.btnAddObra_Click);
			// 
			// txtEstiloObra
			// 
			this.txtEstiloObra.Location = new System.Drawing.Point(279, 145);
			this.txtEstiloObra.Name = "txtEstiloObra";
			this.txtEstiloObra.Size = new System.Drawing.Size(172, 20);
			this.txtEstiloObra.TabIndex = 10;
			// 
			// txtNombreObra
			// 
			this.txtNombreObra.Location = new System.Drawing.Point(279, 66);
			this.txtNombreObra.Name = "txtNombreObra";
			this.txtNombreObra.Size = new System.Drawing.Size(172, 20);
			this.txtNombreObra.TabIndex = 8;
			// 
			// txtPrecioObra
			// 
			this.txtPrecioObra.Location = new System.Drawing.Point(279, 182);
			this.txtPrecioObra.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
			this.txtPrecioObra.Name = "txtPrecioObra";
			this.txtPrecioObra.Size = new System.Drawing.Size(172, 20);
			this.txtPrecioObra.TabIndex = 11;
			// 
			// txtYearObra
			// 
			this.txtYearObra.Location = new System.Drawing.Point(279, 108);
			this.txtYearObra.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
			this.txtYearObra.Name = "txtYearObra";
			this.txtYearObra.Size = new System.Drawing.Size(172, 20);
			this.txtYearObra.TabIndex = 9;
			// 
			// txtCodigoObra
			// 
			this.txtCodigoObra.Location = new System.Drawing.Point(279, 28);
			this.txtCodigoObra.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
			this.txtCodigoObra.Name = "txtCodigoObra";
			this.txtCodigoObra.Size = new System.Drawing.Size(172, 20);
			this.txtCodigoObra.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(86, 265);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(173, 17);
			this.label7.TabIndex = 6;
			this.label7.Text = "Codigo de la Exposición";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(86, 224);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(132, 17);
			this.label6.TabIndex = 5;
			this.label6.Text = "Codigo del Artista";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(86, 185);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(126, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Precio de la Obra";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(86, 145);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Estilo de la Obra";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(86, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Año de la Obra";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(86, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nombre de la Obra";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(86, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Codigo de la Obra";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btnEliminarArtista);
			this.tabPage2.Controls.Add(this.txtEdadArtista);
			this.tabPage2.Controls.Add(this.txtNacionArtista);
			this.tabPage2.Controls.Add(this.cbNombreArtista);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(721, 333);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Eliminar Artista";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnEliminarArtista
			// 
			this.btnEliminarArtista.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
			this.btnEliminarArtista.Location = new System.Drawing.Point(525, 112);
			this.btnEliminarArtista.Name = "btnEliminarArtista";
			this.btnEliminarArtista.Size = new System.Drawing.Size(86, 77);
			this.btnEliminarArtista.TabIndex = 6;
			this.btnEliminarArtista.Text = "Eliminar Artista";
			this.btnEliminarArtista.UseVisualStyleBackColor = true;
			this.btnEliminarArtista.Click += new System.EventHandler(this.btnEliminarArtista_Click);
			// 
			// txtEdadArtista
			// 
			this.txtEdadArtista.Location = new System.Drawing.Point(254, 186);
			this.txtEdadArtista.Name = "txtEdadArtista";
			this.txtEdadArtista.Size = new System.Drawing.Size(213, 20);
			this.txtEdadArtista.TabIndex = 5;
			// 
			// txtNacionArtista
			// 
			this.txtNacionArtista.Location = new System.Drawing.Point(254, 139);
			this.txtNacionArtista.Name = "txtNacionArtista";
			this.txtNacionArtista.Size = new System.Drawing.Size(213, 20);
			this.txtNacionArtista.TabIndex = 4;
			// 
			// cbNombreArtista
			// 
			this.cbNombreArtista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbNombreArtista.FormattingEnabled = true;
			this.cbNombreArtista.Location = new System.Drawing.Point(254, 90);
			this.cbNombreArtista.Name = "cbNombreArtista";
			this.cbNombreArtista.Size = new System.Drawing.Size(213, 21);
			this.cbNombreArtista.TabIndex = 3;
			this.cbNombreArtista.SelectedIndexChanged += new System.EventHandler(this.cbNombreArtista_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
			this.label10.Location = new System.Drawing.Point(75, 186);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(118, 17);
			this.label10.TabIndex = 2;
			this.label10.Text = "Edad del Artista";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
			this.label9.Location = new System.Drawing.Point(75, 139);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(131, 17);
			this.label9.TabIndex = 1;
			this.label9.Text = "Nacion del Artista";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
			this.label8.Location = new System.Drawing.Point(75, 90);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(139, 17);
			this.label8.TabIndex = 0;
			this.label8.Text = "Nombre del Artista";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.dateTimePicker2);
			this.tabPage3.Controls.Add(this.dateTimePicker1);
			this.tabPage3.Controls.Add(this.dataGridView1);
			this.tabPage3.Controls.Add(this.btnBuscarExposiciones);
			this.tabPage3.Controls.Add(this.label12);
			this.tabPage3.Controls.Add(this.label11);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(721, 333);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Consultar Exposiciones";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker2.Location = new System.Drawing.Point(426, 37);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(82, 20);
			this.dateTimePicker2.TabIndex = 7;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(270, 37);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(82, 20);
			this.dateTimePicker1.TabIndex = 6;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(45, 94);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(557, 188);
			this.dataGridView1.TabIndex = 5;
			// 
			// btnBuscarExposiciones
			// 
			this.btnBuscarExposiciones.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
			this.btnBuscarExposiciones.Location = new System.Drawing.Point(527, 34);
			this.btnBuscarExposiciones.Name = "btnBuscarExposiciones";
			this.btnBuscarExposiciones.Size = new System.Drawing.Size(75, 23);
			this.btnBuscarExposiciones.TabIndex = 4;
			this.btnBuscarExposiciones.Text = "Buscar";
			this.btnBuscarExposiciones.UseVisualStyleBackColor = true;
			this.btnBuscarExposiciones.Click += new System.EventHandler(this.btnBuscarExposiciones_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
			this.label12.Location = new System.Drawing.Point(367, 40);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(51, 17);
			this.label12.TabIndex = 2;
			this.label12.Text = "Hasta:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
			this.label11.Location = new System.Drawing.Point(42, 40);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(222, 17);
			this.label11.TabIndex = 0;
			this.label11.Text = "Consultar Exposiciones desde: ";
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.dataGridView2);
			this.tabPage4.Controls.Add(this.cbNacionalidadArtista);
			this.tabPage4.Controls.Add(this.label13);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(721, 333);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Consultar Obras de Nacionalidad";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(8, 123);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(701, 165);
			this.dataGridView2.TabIndex = 6;
			// 
			// cbNacionalidadArtista
			// 
			this.cbNacionalidadArtista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbNacionalidadArtista.FormattingEnabled = true;
			this.cbNacionalidadArtista.Location = new System.Drawing.Point(256, 61);
			this.cbNacionalidadArtista.Name = "cbNacionalidadArtista";
			this.cbNacionalidadArtista.Size = new System.Drawing.Size(170, 21);
			this.cbNacionalidadArtista.TabIndex = 5;
			this.cbNacionalidadArtista.SelectedIndexChanged += new System.EventHandler(this.cbNacionalidadArtista_SelectedIndexChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
			this.label13.Location = new System.Drawing.Point(50, 61);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(175, 17);
			this.label13.TabIndex = 0;
			this.label13.Text = "Nacionalidad del Artista";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(725, 357);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.Text = "Galeria de Arte";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtPrecioObra)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtYearObra)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCodigoObra)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtEdadArtista)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnAddObra;
		private System.Windows.Forms.TextBox txtEstiloObra;
		private System.Windows.Forms.TextBox txtNombreObra;
		private System.Windows.Forms.NumericUpDown txtPrecioObra;
		private System.Windows.Forms.NumericUpDown txtYearObra;
		private System.Windows.Forms.NumericUpDown txtCodigoObra;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cbNombreArtista;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtNacionArtista;
		private System.Windows.Forms.NumericUpDown txtEdadArtista;
		private System.Windows.Forms.Button btnEliminarArtista;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btnBuscarExposiciones;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox cbNacionalidadArtista;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.ComboBox cbCodExposicion;
		private System.Windows.Forms.ComboBox cbCodigoArtista;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
	}
}

