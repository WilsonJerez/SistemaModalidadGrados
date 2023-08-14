namespace VISTAS.GRUPO
{
    partial class ModificarGrupo
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
            this.btnmodificar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CkbTurno = new System.Windows.Forms.CheckBox();
            this.CkbAula = new System.Windows.Forms.CheckBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.gvgrupo = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.txtgrupo = new System.Windows.Forms.TextBox();
            this.cmbturno = new System.Windows.Forms.ComboBox();
            this.cmbaula = new System.Windows.Forms.ComboBox();
            this.BtnModOtroDAtos = new System.Windows.Forms.Button();
            this.N_grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaternoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaternoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvgrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(343, 335);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(147, 34);
            this.btnmodificar.TabIndex = 15;
            this.btnmodificar.Text = "MODIFICAR DOCENTE";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.CkbTurno);
            this.groupBox3.Controls.Add(this.CkbAula);
            this.groupBox3.Controls.Add(this.btnbuscar);
            this.groupBox3.Controls.Add(this.gvgrupo);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtgrupo);
            this.groupBox3.Controls.Add(this.cmbturno);
            this.groupBox3.Controls.Add(this.cmbaula);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(17, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1036, 293);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BUSCAR GRUPOS POR:";
            // 
            // CkbTurno
            // 
            this.CkbTurno.AutoSize = true;
            this.CkbTurno.Location = new System.Drawing.Point(329, 25);
            this.CkbTurno.Name = "CkbTurno";
            this.CkbTurno.Size = new System.Drawing.Size(69, 19);
            this.CkbTurno.TabIndex = 15;
            this.CkbTurno.Text = "TURNO";
            this.CkbTurno.UseVisualStyleBackColor = true;
            this.CkbTurno.CheckedChanged += new System.EventHandler(this.CkbTurno_CheckedChanged);
            // 
            // CkbAula
            // 
            this.CkbAula.AutoSize = true;
            this.CkbAula.Location = new System.Drawing.Point(169, 25);
            this.CkbAula.Name = "CkbAula";
            this.CkbAula.Size = new System.Drawing.Size(56, 19);
            this.CkbAula.TabIndex = 14;
            this.CkbAula.Text = "AULA";
            this.CkbAula.UseVisualStyleBackColor = true;
            this.CkbAula.CheckedChanged += new System.EventHandler(this.CkbAula_CheckedChanged);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(490, 44);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(100, 23);
            this.btnbuscar.TabIndex = 13;
            this.btnbuscar.Text = "FILTRAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // gvgrupo
            // 
            this.gvgrupo.AllowUserToAddRows = false;
            this.gvgrupo.AllowUserToDeleteRows = false;
            this.gvgrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvgrupo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N_grupo,
            this.Cip,
            this.PaternoP,
            this.MaternoP,
            this.Docente,
            this.N_aula,
            this.Capacidad,
            this.Turno,
            this.Fecha_inicio,
            this.Fecha_final,
            this.Estado,
            this.id_contrato,
            this.id_grupo,
            this.id_aula,
            this.id_turno});
            this.gvgrupo.Location = new System.Drawing.Point(19, 74);
            this.gvgrupo.Name = "gvgrupo";
            this.gvgrupo.ReadOnly = true;
            this.gvgrupo.RowHeadersVisible = false;
            this.gvgrupo.Size = new System.Drawing.Size(998, 205);
            this.gvgrupo.TabIndex = 9;
            this.gvgrupo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvgrupo_CellMouseDoubleClick);
            this.gvgrupo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvgrupo_CellContentClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 15);
            this.label13.TabIndex = 8;
            this.label13.Text = "GRUPO";
            // 
            // txtgrupo
            // 
            this.txtgrupo.Location = new System.Drawing.Point(17, 45);
            this.txtgrupo.Name = "txtgrupo";
            this.txtgrupo.Size = new System.Drawing.Size(120, 21);
            this.txtgrupo.TabIndex = 7;
            // 
            // cmbturno
            // 
            this.cmbturno.Enabled = false;
            this.cmbturno.FormattingEnabled = true;
            this.cmbturno.Location = new System.Drawing.Point(329, 45);
            this.cmbturno.Name = "cmbturno";
            this.cmbturno.Size = new System.Drawing.Size(145, 23);
            this.cmbturno.TabIndex = 5;
            this.cmbturno.SelectedIndexChanged += new System.EventHandler(this.cmbturno_SelectedIndexChanged);
            // 
            // cmbaula
            // 
            this.cmbaula.Enabled = false;
            this.cmbaula.FormattingEnabled = true;
            this.cmbaula.Location = new System.Drawing.Point(169, 45);
            this.cmbaula.Name = "cmbaula";
            this.cmbaula.Size = new System.Drawing.Size(120, 23);
            this.cmbaula.TabIndex = 0;
            this.cmbaula.SelectedIndexChanged += new System.EventHandler(this.cmbaula_SelectedIndexChanged);
            // 
            // BtnModOtroDAtos
            // 
            this.BtnModOtroDAtos.Location = new System.Drawing.Point(580, 335);
            this.BtnModOtroDAtos.Name = "BtnModOtroDAtos";
            this.BtnModOtroDAtos.Size = new System.Drawing.Size(147, 34);
            this.BtnModOtroDAtos.TabIndex = 17;
            this.BtnModOtroDAtos.Text = "MODIFICAR OTROS DATOS";
            this.BtnModOtroDAtos.UseVisualStyleBackColor = true;
            this.BtnModOtroDAtos.Click += new System.EventHandler(this.BtnModOtroDAtos_Click);
            // 
            // N_grupo
            // 
            this.N_grupo.HeaderText = "Nº Grupo";
            this.N_grupo.Name = "N_grupo";
            this.N_grupo.ReadOnly = true;
            this.N_grupo.Width = 50;
            // 
            // Cip
            // 
            this.Cip.HeaderText = "Ci";
            this.Cip.Name = "Cip";
            this.Cip.ReadOnly = true;
            // 
            // PaternoP
            // 
            this.PaternoP.HeaderText = "Ap. Paterno";
            this.PaternoP.Name = "PaternoP";
            this.PaternoP.ReadOnly = true;
            // 
            // MaternoP
            // 
            this.MaternoP.HeaderText = "Ap. Materno";
            this.MaternoP.Name = "MaternoP";
            this.MaternoP.ReadOnly = true;
            // 
            // Docente
            // 
            this.Docente.HeaderText = "Nombre Docente";
            this.Docente.Name = "Docente";
            this.Docente.ReadOnly = true;
            // 
            // N_aula
            // 
            this.N_aula.HeaderText = "Nº Aula";
            this.N_aula.Name = "N_aula";
            this.N_aula.ReadOnly = true;
            // 
            // Capacidad
            // 
            this.Capacidad.HeaderText = "Capacidad";
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.ReadOnly = true;
            // 
            // Turno
            // 
            this.Turno.HeaderText = "Turno";
            this.Turno.Name = "Turno";
            this.Turno.ReadOnly = true;
            // 
            // Fecha_inicio
            // 
            this.Fecha_inicio.HeaderText = "Fecha Inicio";
            this.Fecha_inicio.Name = "Fecha_inicio";
            this.Fecha_inicio.ReadOnly = true;
            // 
            // Fecha_final
            // 
            this.Fecha_final.HeaderText = "Fecha Final";
            this.Fecha_final.Name = "Fecha_final";
            this.Fecha_final.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 80;
            // 
            // id_contrato
            // 
            this.id_contrato.HeaderText = "id_contrato";
            this.id_contrato.Name = "id_contrato";
            this.id_contrato.ReadOnly = true;
            this.id_contrato.Visible = false;
            // 
            // id_grupo
            // 
            this.id_grupo.HeaderText = "id_grupo";
            this.id_grupo.Name = "id_grupo";
            this.id_grupo.ReadOnly = true;
            this.id_grupo.Visible = false;
            // 
            // id_aula
            // 
            this.id_aula.HeaderText = "id_aula";
            this.id_aula.Name = "id_aula";
            this.id_aula.ReadOnly = true;
            this.id_aula.Visible = false;
            // 
            // id_turno
            // 
            this.id_turno.HeaderText = "id_turno";
            this.id_turno.Name = "id_turno";
            this.id_turno.ReadOnly = true;
            this.id_turno.Visible = false;
            // 
            // ModificarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 399);
            this.Controls.Add(this.BtnModOtroDAtos);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.groupBox3);
            this.Name = "ModificarGrupo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODIFICAR GRUPO";
            this.Load += new System.EventHandler(this.ModificarGrupo_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvgrupo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridView gvgrupo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtgrupo;
        private System.Windows.Forms.ComboBox cmbturno;
        private System.Windows.Forms.ComboBox cmbaula;
        private System.Windows.Forms.CheckBox CkbAula;
        private System.Windows.Forms.CheckBox CkbTurno;
        private System.Windows.Forms.Button BtnModOtroDAtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cip;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaternoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaternoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Docente;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_aula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_final;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_aula;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_turno;
    }
}