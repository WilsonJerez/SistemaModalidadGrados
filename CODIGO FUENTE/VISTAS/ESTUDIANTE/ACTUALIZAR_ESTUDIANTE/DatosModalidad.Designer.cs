namespace VISTAS.ESTUDIANTE.ACTUALIZAR_ESTUDIANTE
{
    partial class DatosModalidad
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtCarrera = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GvModalidades = new System.Windows.Forms.DataGridView();
            this.ID_MODALIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_GRUPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_MODALIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRUPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_CARTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_INICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_FINAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CmbTipoModalidad = new System.Windows.Forms.ComboBox();
            this.TxtTema = new System.Windows.Forms.TextBox();
            this.GpActualizar = new System.Windows.Forms.GroupBox();
            this.CkbGrupo = new System.Windows.Forms.CheckBox();
            this.CkbCarta = new System.Windows.Forms.CheckBox();
            this.TxtNCarta = new System.Windows.Forms.TextBox();
            this.CkbTipoModalidad = new System.Windows.Forms.CheckBox();
            this.CkbTema = new System.Windows.Forms.CheckBox();
            this.GridGrupos = new System.Windows.Forms.DataGridView();
            this.grupoG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_iniciog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_finalg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvModalidades)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.GpActualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TxtCarrera);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtCi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL ESTUDIANTE";
            // 
            // TxtCarrera
            // 
            this.TxtCarrera.Location = new System.Drawing.Point(510, 48);
            this.TxtCarrera.Multiline = true;
            this.TxtCarrera.Name = "TxtCarrera";
            this.TxtCarrera.ReadOnly = true;
            this.TxtCarrera.Size = new System.Drawing.Size(315, 20);
            this.TxtCarrera.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CARRERA";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(173, 48);
            this.TxtNombre.Multiline = true;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.ReadOnly = true;
            this.TxtNombre.Size = new System.Drawing.Size(315, 20);
            this.TxtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE COMPLETO";
            // 
            // TxtCi
            // 
            this.TxtCi.Location = new System.Drawing.Point(30, 48);
            this.TxtCi.Name = "TxtCi";
            this.TxtCi.ReadOnly = true;
            this.TxtCi.Size = new System.Drawing.Size(112, 20);
            this.TxtCi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CI/DNI";
            // 
            // GvModalidades
            // 
            this.GvModalidades.AllowUserToAddRows = false;
            this.GvModalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvModalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_MODALIDAD,
            this.ID_GRUPO,
            this.TEMA,
            this.TIPO_MODALIDAD,
            this.GRUPO,
            this.N_CARTA,
            this.FECHA_INICIO,
            this.FECHA_FINAL,
            this.ESTADO});
            this.GvModalidades.Location = new System.Drawing.Point(16, 33);
            this.GvModalidades.Name = "GvModalidades";
            this.GvModalidades.RowHeadersVisible = false;
            this.GvModalidades.Size = new System.Drawing.Size(861, 95);
            this.GvModalidades.TabIndex = 1;
            this.GvModalidades.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GvModalidades_CellMouseDoubleClick);
            // 
            // ID_MODALIDAD
            // 
            this.ID_MODALIDAD.HeaderText = "ID_MODALIDAD";
            this.ID_MODALIDAD.Name = "ID_MODALIDAD";
            this.ID_MODALIDAD.ReadOnly = true;
            this.ID_MODALIDAD.Visible = false;
            // 
            // ID_GRUPO
            // 
            this.ID_GRUPO.HeaderText = "ID_GRUPO";
            this.ID_GRUPO.Name = "ID_GRUPO";
            this.ID_GRUPO.Visible = false;
            // 
            // TEMA
            // 
            this.TEMA.HeaderText = "TEMA";
            this.TEMA.Name = "TEMA";
            this.TEMA.ReadOnly = true;
            this.TEMA.Width = 200;
            // 
            // TIPO_MODALIDAD
            // 
            this.TIPO_MODALIDAD.HeaderText = "TIPO_MODALIDAD";
            this.TIPO_MODALIDAD.Name = "TIPO_MODALIDAD";
            this.TIPO_MODALIDAD.ReadOnly = true;
            this.TIPO_MODALIDAD.Width = 200;
            // 
            // GRUPO
            // 
            this.GRUPO.HeaderText = "GRUPO";
            this.GRUPO.Name = "GRUPO";
            this.GRUPO.ReadOnly = true;
            this.GRUPO.Width = 80;
            // 
            // N_CARTA
            // 
            this.N_CARTA.HeaderText = "Nº CARTA";
            this.N_CARTA.Name = "N_CARTA";
            this.N_CARTA.ReadOnly = true;
            this.N_CARTA.Width = 60;
            // 
            // FECHA_INICIO
            // 
            this.FECHA_INICIO.HeaderText = "FECHA DE INICIO";
            this.FECHA_INICIO.Name = "FECHA_INICIO";
            this.FECHA_INICIO.ReadOnly = true;
            // 
            // FECHA_FINAL
            // 
            this.FECHA_FINAL.HeaderText = "FECHA DE FINALIZACION";
            this.FECHA_FINAL.Name = "FECHA_FINAL";
            this.FECHA_FINAL.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.GvModalidades);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(25, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(884, 145);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MODALIDAD(ES) CURSADAS";
            // 
            // CmbTipoModalidad
            // 
            this.CmbTipoModalidad.Enabled = false;
            this.CmbTipoModalidad.FormattingEnabled = true;
            this.CmbTipoModalidad.Location = new System.Drawing.Point(282, 50);
            this.CmbTipoModalidad.Name = "CmbTipoModalidad";
            this.CmbTipoModalidad.Size = new System.Drawing.Size(259, 21);
            this.CmbTipoModalidad.TabIndex = 3;
            this.CmbTipoModalidad.SelectedIndexChanged += new System.EventHandler(this.CmbTipoModalidad_SelectedIndexChanged);
            this.CmbTipoModalidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbTipoModalidad_KeyDown);
            // 
            // TxtTema
            // 
            this.TxtTema.Location = new System.Drawing.Point(15, 50);
            this.TxtTema.Name = "TxtTema";
            this.TxtTema.ReadOnly = true;
            this.TxtTema.Size = new System.Drawing.Size(251, 20);
            this.TxtTema.TabIndex = 6;
            // 
            // GpActualizar
            // 
            this.GpActualizar.BackColor = System.Drawing.Color.Transparent;
            this.GpActualizar.Controls.Add(this.CkbGrupo);
            this.GpActualizar.Controls.Add(this.CkbCarta);
            this.GpActualizar.Controls.Add(this.TxtNCarta);
            this.GpActualizar.Controls.Add(this.CkbTipoModalidad);
            this.GpActualizar.Controls.Add(this.CkbTema);
            this.GpActualizar.Controls.Add(this.GridGrupos);
            this.GpActualizar.Controls.Add(this.TxtTema);
            this.GpActualizar.Controls.Add(this.CmbTipoModalidad);
            this.GpActualizar.Enabled = false;
            this.GpActualizar.ForeColor = System.Drawing.Color.Black;
            this.GpActualizar.Location = new System.Drawing.Point(130, 266);
            this.GpActualizar.Name = "GpActualizar";
            this.GpActualizar.Size = new System.Drawing.Size(680, 274);
            this.GpActualizar.TabIndex = 8;
            this.GpActualizar.TabStop = false;
            this.GpActualizar.Text = "DATOS PAR MODIFCAR LA MODALIDAD";
            // 
            // CkbGrupo
            // 
            this.CkbGrupo.AutoSize = true;
            this.CkbGrupo.Location = new System.Drawing.Point(255, 104);
            this.CkbGrupo.Name = "CkbGrupo";
            this.CkbGrupo.Size = new System.Drawing.Size(203, 17);
            this.CkbGrupo.TabIndex = 35;
            this.CkbGrupo.Text = "SELECCIONAR UN NUEVO GRUPO";
            this.CkbGrupo.UseVisualStyleBackColor = true;
            this.CkbGrupo.CheckedChanged += new System.EventHandler(this.CkbGrupo_CheckedChanged);
            // 
            // CkbCarta
            // 
            this.CkbCarta.AutoSize = true;
            this.CkbCarta.Location = new System.Drawing.Point(570, 30);
            this.CkbCarta.Name = "CkbCarta";
            this.CkbCarta.Size = new System.Drawing.Size(95, 17);
            this.CkbCarta.TabIndex = 34;
            this.CkbCarta.Text = "Nº DE CARTA";
            this.CkbCarta.UseVisualStyleBackColor = true;
            this.CkbCarta.CheckedChanged += new System.EventHandler(this.CkbCarta_CheckedChanged);
            // 
            // TxtNCarta
            // 
            this.TxtNCarta.Location = new System.Drawing.Point(570, 50);
            this.TxtNCarta.Name = "TxtNCarta";
            this.TxtNCarta.ReadOnly = true;
            this.TxtNCarta.Size = new System.Drawing.Size(100, 20);
            this.TxtNCarta.TabIndex = 33;
            // 
            // CkbTipoModalidad
            // 
            this.CkbTipoModalidad.AutoSize = true;
            this.CkbTipoModalidad.Location = new System.Drawing.Point(282, 30);
            this.CkbTipoModalidad.Name = "CkbTipoModalidad";
            this.CkbTipoModalidad.Size = new System.Drawing.Size(136, 17);
            this.CkbTipoModalidad.TabIndex = 32;
            this.CkbTipoModalidad.Text = "TIPO DE MODALIDAD";
            this.CkbTipoModalidad.UseVisualStyleBackColor = true;
            this.CkbTipoModalidad.CheckedChanged += new System.EventHandler(this.CkbTipoModalidad_CheckedChanged);
            // 
            // CkbTema
            // 
            this.CkbTema.AutoSize = true;
            this.CkbTema.Location = new System.Drawing.Point(15, 30);
            this.CkbTema.Name = "CkbTema";
            this.CkbTema.Size = new System.Drawing.Size(56, 17);
            this.CkbTema.TabIndex = 31;
            this.CkbTema.Text = "TEMA";
            this.CkbTema.UseVisualStyleBackColor = true;
            this.CkbTema.CheckedChanged += new System.EventHandler(this.CkbTema_CheckedChanged);
            // 
            // GridGrupos
            // 
            this.GridGrupos.AllowUserToAddRows = false;
            this.GridGrupos.AllowUserToDeleteRows = false;
            this.GridGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grupoG,
            this.turno,
            this.fecha_iniciog,
            this.fecha_finalg,
            this.capacidad,
            this.registrados});
            this.GridGrupos.Enabled = false;
            this.GridGrupos.Location = new System.Drawing.Point(30, 127);
            this.GridGrupos.Name = "GridGrupos";
            this.GridGrupos.ReadOnly = true;
            this.GridGrupos.RowHeadersVisible = false;
            this.GridGrupos.Size = new System.Drawing.Size(613, 115);
            this.GridGrupos.TabIndex = 30;
            this.GridGrupos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridGrupos_CellContentDoubleClick);
            // 
            // grupoG
            // 
            this.grupoG.HeaderText = "GRUPO";
            this.grupoG.Name = "grupoG";
            this.grupoG.ReadOnly = true;
            this.grupoG.Width = 80;
            // 
            // turno
            // 
            this.turno.HeaderText = "TURNO";
            this.turno.Name = "turno";
            this.turno.ReadOnly = true;
            this.turno.Width = 110;
            // 
            // fecha_iniciog
            // 
            this.fecha_iniciog.HeaderText = "FECHA INICIO";
            this.fecha_iniciog.Name = "fecha_iniciog";
            this.fecha_iniciog.ReadOnly = true;
            this.fecha_iniciog.Width = 110;
            // 
            // fecha_finalg
            // 
            this.fecha_finalg.HeaderText = "FECHA FINALIZACION";
            this.fecha_finalg.Name = "fecha_finalg";
            this.fecha_finalg.ReadOnly = true;
            this.fecha_finalg.Width = 110;
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
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(439, 546);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(109, 35);
            this.BtnModificar.TabIndex = 9;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // DatosModalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(964, 593);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.GpActualizar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "DatosModalidad";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODIFICACION DE DATOS DE LA MODALIDAD";
            this.Load += new System.EventHandler(this.DatosModalidad_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvModalidades)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.GpActualizar.ResumeLayout(false);
            this.GpActualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridGrupos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtCarrera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GvModalidades;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CmbTipoModalidad;
        private System.Windows.Forms.TextBox TxtTema;
        private System.Windows.Forms.GroupBox GpActualizar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.DataGridView GridGrupos;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoG;
        private System.Windows.Forms.DataGridViewTextBoxColumn turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_iniciog;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_finalg;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrados;
        private System.Windows.Forms.CheckBox CkbTema;
        private System.Windows.Forms.CheckBox CkbTipoModalidad;
        private System.Windows.Forms.CheckBox CkbCarta;
        private System.Windows.Forms.TextBox TxtNCarta;
        private System.Windows.Forms.CheckBox CkbGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MODALIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_GRUPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_MODALIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRUPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_CARTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_INICIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_FINAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
    }
}