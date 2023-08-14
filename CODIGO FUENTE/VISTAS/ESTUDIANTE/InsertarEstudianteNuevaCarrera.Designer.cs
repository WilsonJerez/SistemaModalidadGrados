namespace VISTAS.ESTUDIANTE
{
    partial class InsertarEstudianteNuevaCarrera
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
            this.DgvPersona = new System.Windows.Forms.DataGridView();
            this.ID_PERSONA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CELULAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CARRERA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtMaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.CmbCarrera = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersona)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridGrupos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvPersona
            // 
            this.DgvPersona.AllowUserToAddRows = false;
            this.DgvPersona.AllowUserToDeleteRows = false;
            this.DgvPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPersona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PERSONA,
            this.CI,
            this.PATERNO,
            this.MATERNO,
            this.NOMBRE,
            this.DIRECCION,
            this.TELEFONO,
            this.CELULAR,
            this.CARRERA});
            this.DgvPersona.Location = new System.Drawing.Point(12, 68);
            this.DgvPersona.Name = "DgvPersona";
            this.DgvPersona.ReadOnly = true;
            this.DgvPersona.RowHeadersVisible = false;
            this.DgvPersona.Size = new System.Drawing.Size(853, 112);
            this.DgvPersona.TabIndex = 0;
            this.DgvPersona.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvPersona_CellMouseDoubleClick);
            // 
            // ID_PERSONA
            // 
            this.ID_PERSONA.HeaderText = "ID_PERSONA";
            this.ID_PERSONA.Name = "ID_PERSONA";
            this.ID_PERSONA.ReadOnly = true;
            this.ID_PERSONA.Visible = false;
            // 
            // CI
            // 
            this.CI.HeaderText = "CI";
            this.CI.Name = "CI";
            this.CI.ReadOnly = true;
            // 
            // PATERNO
            // 
            this.PATERNO.HeaderText = "AP. PATERNO";
            this.PATERNO.Name = "PATERNO";
            this.PATERNO.ReadOnly = true;
            // 
            // MATERNO
            // 
            this.MATERNO.HeaderText = "AP. MATERNO";
            this.MATERNO.Name = "MATERNO";
            this.MATERNO.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            this.NOMBRE.Width = 150;
            // 
            // DIRECCION
            // 
            this.DIRECCION.HeaderText = "DIRECCION";
            this.DIRECCION.Name = "DIRECCION";
            this.DIRECCION.ReadOnly = true;
            // 
            // TELEFONO
            // 
            this.TELEFONO.HeaderText = "TELEFONO";
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.ReadOnly = true;
            // 
            // CELULAR
            // 
            this.CELULAR.HeaderText = "CELULAR";
            this.CELULAR.Name = "CELULAR";
            this.CELULAR.ReadOnly = true;
            // 
            // CARRERA
            // 
            this.CARRERA.HeaderText = "CARRERA";
            this.CARRERA.Name = "CARRERA";
            this.CARRERA.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.TxtMaterno);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.TxtCi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtPaterno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DgvPersona);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(33, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 186);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS PERSONALES DEL ESTUDIANTE";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(590, 41);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(97, 22);
            this.BtnBuscar.TabIndex = 9;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtMaterno
            // 
            this.TxtMaterno.Location = new System.Drawing.Point(277, 43);
            this.TxtMaterno.Name = "TxtMaterno";
            this.TxtMaterno.Size = new System.Drawing.Size(143, 20);
            this.TxtMaterno.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "AP. MATERNO";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(426, 43);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(143, 20);
            this.TxtNombre.TabIndex = 4;
            // 
            // TxtCi
            // 
            this.TxtCi.Location = new System.Drawing.Point(12, 43);
            this.TxtCi.Name = "TxtCi";
            this.TxtCi.Size = new System.Drawing.Size(100, 20);
            this.TxtCi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CI/DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRE";
            // 
            // TxtPaterno
            // 
            this.TxtPaterno.Location = new System.Drawing.Point(128, 43);
            this.TxtPaterno.Name = "TxtPaterno";
            this.TxtPaterno.Size = new System.Drawing.Size(143, 20);
            this.TxtPaterno.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "AP. PATERNO";
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
            this.groupBox2.Location = new System.Drawing.Point(33, 315);
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
            this.GridGrupos.Location = new System.Drawing.Point(131, 98);
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
            this.TxtTema.Location = new System.Drawing.Point(555, 20);
            this.TxtTema.Multiline = true;
            this.TxtTema.Name = "TxtTema";
            this.TxtTema.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtTema.Size = new System.Drawing.Size(289, 37);
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
            // CmbCarrera
            // 
            this.CmbCarrera.FormattingEnabled = true;
            this.CmbCarrera.Location = new System.Drawing.Point(119, 37);
            this.CmbCarrera.Name = "CmbCarrera";
            this.CmbCarrera.Size = new System.Drawing.Size(278, 21);
            this.CmbCarrera.TabIndex = 25;
            this.CmbCarrera.SelectedIndexChanged += new System.EventHandler(this.CmbCarrera_SelectedIndexChanged);
            this.CmbCarrera.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbCarrera_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.CmbCarrera);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(61, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(541, 78);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "NUEVA CARRERA PARA EL ESTUDIANTE";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(397, 606);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(140, 43);
            this.BtnRegistrar.TabIndex = 27;
            this.BtnRegistrar.Text = "REGISTRAR";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // InsertarEstudianteNuevaCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "InsertarEstudianteNuevaCarrera";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE ESTUDIANTE CON OTRA CARRERA";
            this.Load += new System.EventHandler(this.InsertarEstudianteNuevaCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersona)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridGrupos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPersona;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtMaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbCarrera;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PERSONA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CELULAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARRERA;
    }
}