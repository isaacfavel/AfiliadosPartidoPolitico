namespace AfiliadosPartidoPolitico
{
    partial class FrmAfiliados
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAfiliados));
            this.lblArchivo = new System.Windows.Forms.Label();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.cbxMunicipio = new System.Windows.Forms.ComboBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxFecha = new System.Windows.Forms.CheckBox();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaTermina = new System.Windows.Forms.Label();
            this.oFDAbrir = new System.Windows.Forms.OpenFileDialog();
            this.pbxCargando = new System.Windows.Forms.PictureBox();
            this.lblAfiliados = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpTermina = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCargando)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(25, 21);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(52, 16);
            this.lblArchivo.TabIndex = 0;
            this.lblArchivo.Text = "Archivo";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(12, 40);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(237, 22);
            this.txtArchivo.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(266, 34);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(92, 34);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 100);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 16);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(12, 144);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(64, 16);
            this.lblMunicipio.TabIndex = 5;
            this.lblMunicipio.Text = "Municipio";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(93, 93);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(128, 22);
            this.txtEstado.TabIndex = 6;
            // 
            // cbxMunicipio
            // 
            this.cbxMunicipio.FormattingEnabled = true;
            this.cbxMunicipio.Location = new System.Drawing.Point(93, 136);
            this.cbxMunicipio.Name = "cbxMunicipio";
            this.cbxMunicipio.Size = new System.Drawing.Size(156, 24);
            this.cbxMunicipio.TabIndex = 7;
            this.cbxMunicipio.SelectedIndexChanged += new System.EventHandler(this.cbxMunicipio_SelectedIndexChanged);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvDatos.Location = new System.Drawing.Point(15, 187);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(927, 266);
            this.dgvDatos.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ENTIDAD";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "MUNICIPIO";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "NOMBRE";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "FECHA_AFILIACION";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ESTATUS";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // checkBoxFecha
            // 
            this.checkBoxFecha.AutoSize = true;
            this.checkBoxFecha.Location = new System.Drawing.Point(513, 472);
            this.checkBoxFecha.Name = "checkBoxFecha";
            this.checkBoxFecha.Size = new System.Drawing.Size(67, 20);
            this.checkBoxFecha.TabIndex = 9;
            this.checkBoxFecha.Text = "Fecha";
            this.checkBoxFecha.UseVisualStyleBackColor = true;
            this.checkBoxFecha.CheckedChanged += new System.EventHandler(this.checkBoxFecha_CheckedChanged);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(602, 473);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(79, 16);
            this.lblFechaInicio.TabIndex = 10;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // lblFechaTermina
            // 
            this.lblFechaTermina.AutoSize = true;
            this.lblFechaTermina.Location = new System.Drawing.Point(594, 498);
            this.lblFechaTermina.Name = "lblFechaTermina";
            this.lblFechaTermina.Size = new System.Drawing.Size(98, 16);
            this.lblFechaTermina.TabIndex = 11;
            this.lblFechaTermina.Text = "Fecha Termina";
            // 
            // oFDAbrir
            // 
            this.oFDAbrir.FileName = "openFileDialog1";
            this.oFDAbrir.Filter = "Archivo de Excel|*.xlsx";
            // 
            // pbxCargando
            // 
            this.pbxCargando.Image = ((System.Drawing.Image)(resources.GetObject("pbxCargando.Image")));
            this.pbxCargando.Location = new System.Drawing.Point(373, 21);
            this.pbxCargando.Name = "pbxCargando";
            this.pbxCargando.Size = new System.Drawing.Size(53, 50);
            this.pbxCargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxCargando.TabIndex = 12;
            this.pbxCargando.TabStop = false;
            // 
            // lblAfiliados
            // 
            this.lblAfiliados.AutoSize = true;
            this.lblAfiliados.Location = new System.Drawing.Point(32, 473);
            this.lblAfiliados.Name = "lblAfiliados";
            this.lblAfiliados.Size = new System.Drawing.Size(142, 16);
            this.lblAfiliados.TabIndex = 13;
            this.lblAfiliados.Text = "Numero de Afiliados: 0";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(698, 469);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(268, 22);
            this.dtpInicio.TabIndex = 15;
            // 
            // dtpTermina
            // 
            this.dtpTermina.Location = new System.Drawing.Point(698, 497);
            this.dtpTermina.Name = "dtpTermina";
            this.dtpTermina.Size = new System.Drawing.Size(268, 22);
            this.dtpTermina.TabIndex = 16;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(605, 125);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FrmAfiliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 523);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dtpTermina);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.lblAfiliados);
            this.Controls.Add(this.pbxCargando);
            this.Controls.Add(this.lblFechaTermina);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.checkBoxFecha);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.cbxMunicipio);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblMunicipio);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.lblArchivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAfiliados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afiliados Pri";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCargando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.ComboBox cbxMunicipio;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.CheckBox checkBoxFecha;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaTermina;
        private System.Windows.Forms.OpenFileDialog oFDAbrir;
        private System.Windows.Forms.PictureBox pbxCargando;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lblAfiliados;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpTermina;
        private System.Windows.Forms.Button btnReset;
    }
}

