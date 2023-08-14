namespace VISTAS.ESTUDIANTE
{
    partial class InsertarEstudianteRepitente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GridGrupos = new System.Windows.Forms.DataGridView();
            this.grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtNroCarta = new System.Windows.Forms.TextBox();
            this.TxtTema = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CmbTipoModalidad = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtMaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.TxtCi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.ID_ESTUDIANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CARRERA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridGrupos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.GridGrupos);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.TxtNroCarta);
            this.groupBox2.Controls.Add(this.TxtTema);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.CmbTipoModalidad);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(23, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(876, 284);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS DE LA MODALIDAD I";
            // 
            // GridGrupos
            // 
            this.GridGrupos.AllowUserToAddRows = false;
            this.GridGrupos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridGrupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grupo,
            this.turno,
            this.fecha_inicio,
            this.fecha_final,
            this.capacidad,
            this.registrados});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridGrupos.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridGrupos.Location = new System.Drawing.Point(147, 98);
            this.GridGrupos.Name = "GridGrupos";
            this.GridGrupos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridGrupos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridGrupos.RowHeadersVisible = false;
            this.GridGrupos.Size = new System.Drawing.Size(615, 168);
            this.GridGrupos.TabIndex = 29;
            this.GridGrupos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridGrupos_CellMouseDoubleClick);
            // 
            // grupo
            // 
            this.grupo.HeaderText = "GRUPO";
            this.grupo.Name = "grupo";
            this.grupo.ReadOnly = true;
            this.grupo.Width = 80;
            // 
            // turno
            // 
            this.turno.HeaderText = "TURNO";
            this.turno.Name = "turno";
            this.turno.ReadOnly = true;
            this.turno.Width = 110;
            // 
            // fecha_inicio
            // 
            this.fecha_inicio.HeaderText = "FECHA INICIO";
            this.fecha_inicio.Name = "fecha_inicio";
            this.fecha_inicio.ReadOnly = true;
            this.fecha_inicio.Width = 110;
            // 
            // fecha_final
            // 
            this.fecha_final.HeaderText = "FECHA FINALIZACION";
            this.fecha_final.Name = "fecha_final";
            this.fecha_final.ReadOnly = true;
            this.fecha_final.Width = 110;
            // 
            // capacidad
            // 
            this.capacidad.HeaderText = "CAPACIDAD";
            this.capacidad.Name = "capacidad";
            this.capacidad.ReadOnly = true;
            // 
            // registrados
            // 
            this.registrados.HeaderText = "REGISTRADOS";
            this.registrados.Name = "registrados";
            this.registrados.ReadOnly = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(279, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "GRUPO";
            // 
            // TxtNroCarta
            // 
            this.TxtNroCarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNroCarta.Location = new System.Drawing.Point(167, 56);
            this.TxtNroCarta.Name = "TxtNroCarta";
            this.TxtNroCarta.Size = new System.Drawing.Size(99, 20);
            this.TxtNroCarta.TabIndex = 27;
            // 
            // TxtTema
            // 
            this.TxtTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTema.Location = new System.Drawing.Point(587, 20);
            this.TxtTema.Multiline = true;
            this.TxtTema.Name = "TxtTema";
            this.TxtTema.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtTema.Size = new System.Drawing.Size(254, 40);
            this.TxtTema.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Nº DE CARTA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(438, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "NOMBRE DEL TEMA";
            // 
            // CmbTipoModalidad
            // 
            this.CmbTipoModalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipoModalidad.FormattingEnabled = true;
            this.CmbTipoModalidad.Location = new System.Drawing.Point(167, 24);
            this.CmbTipoModalidad.Name = "CmbTipoModalidad";
            this.CmbTipoModalidad.Size = new System.Drawing.Size(254, 21);
            this.CmbTipoModalidad.TabIndex = 23;
            this.CmbTipoModalidad.SelectedIndexChanged += new System.EventHandler(this.CmbTipoModalidad_SelectedIndexChanged);
            this.CmbTipoModalidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbTipoModalidad_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "TIPO DE MODALIDAD";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.TxtMaterno);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DgvEstudiantes);
            this.groupBox1.Controls.Add(this.TxtPaterno);
            this.groupBox1.Controls.Add(this.TxtCi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(24, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 213);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ESTUDIANTES INSCRITOS EN LA FACULTAD";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(666, 37);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(95, 22);
            this.BtnBuscar.TabIndex = 9;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtMaterno
            // 
            this.TxtMaterno.Location = new System.Drawing.Point(324, 39);
            this.TxtMaterno.Name = "TxtMaterno";
            this.TxtMaterno.Size = new System.Drawing.Size(160, 20);
            this.TxtMaterno.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "AP. MATERNO";
            // 
            // TxtPaterno
            // 
            this.TxtPaterno.Location = new System.Drawing.Point(153, 39);
            this.TxtPaterno.Name = "TxtPaterno";
            this.TxtPaterno.Size = new System.Drawing.Size(160, 20);
            this.TxtPaterno.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "AP. PATERNO";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(500, 39);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(160, 20);
            this.TxtNombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRE";
            // 
            // DgvEstudiantes
            // 
            this.DgvEstudiantes.AllowUserToAddRows = false;
            this.DgvEstudiantes.AllowUserToDeleteRows = false;
            this.DgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_ESTUDIANTE,
            this.CI,
            this.PATERNO,
            this.MATERNO,
            this.NOMBRE,
            this.CARRERA});
            this.DgvEstudiantes.Location = new System.Drawing.Point(36, 65);
            this.DgvEstudiantes.Name = "DgvEstudiantes";
            this.DgvEstudiantes.ReadOnly = true;
            this.DgvEstudiantes.RowHeadersVisible = false;
            this.DgvEstudiantes.Size = new System.Drawing.Size(804, 140);
            this.DgvEstudiantes.TabIndex = 2;
            this.DgvEstudiantes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvEstudiantes_CellMouseDoubleClick);
            // 
            // TxtCi
            // 
            this.TxtCi.Location = new System.Drawing.Point(36, 39);
            this.TxtCi.Name = "TxtCi";
            this.TxtCi.Size = new System.Drawing.Size(100, 20);
            this.TxtCi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CI";
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.Location = new System.Drawing.Point(405, 582);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(122, 36);
            this.btnregistrar.TabIndex = 26;
            this.btnregistrar.Text = "REGISTRAR";
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // ID_ESTUDIANTE
            // 
            this.ID_ESTUDIANTE.HeaderText = "ID_ESTUDIANTE";
            this.ID_ESTUDIANTE.Name = "ID_ESTUDIANTE";
            this.ID_ESTUDIANTE.ReadOnly = true;
            this.ID_ESTUDIANTE.Visible = false;
            // 
            // CI
            // 
            this.CI.HeaderText = "CI";
            this.CI.Name = "CI";
            this.CI.ReadOnly = true;
            // 
            // PATERNO
            // 
            this.PATERNO.HeaderText = "PATERNO";
            this.PATERNO.Name = "PATERNO";
            this.PATERNO.ReadOnly = true;
            this.PATERNO.Width = 150;
            // 
            // MATERNO
            // 
            this.MATERNO.HeaderText = "MATERNO";
            this.MATERNO.Name = "MATERNO";
            this.MATERNO.ReadOnly = true;
            this.MATERNO.Width = 150;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            this.NOMBRE.Width = 200;
            // 
            // CARRERA
            // 
            this.CARRERA.HeaderText = "CARRERA";
            this.CARRERA.Name = "CARRERA";
            this.CARRERA.ReadOnly = true;
            this.CARRERA.Width = 200;
            // 
            // InsertarEstudianteRepitente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.ClientSize = new System.Drawing.Size(922, 630);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "InsertarEstudianteRepitente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE ESTUDIANTE REPITENTE MODALIDAD I";
            this.Load += new System.EventHandler(this.InsertarEstudianteRepitente_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridGrupos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstudiantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GridGrupos;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_final;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrados;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtNroCarta;
        private System.Windows.Forms.TextBox TxtTema;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CmbTipoModalidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvEstudiantes;
        private System.Windows.Forms.TextBox TxtCi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtMaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ESTUDIANTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARRERA;
    }
}