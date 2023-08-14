namespace VISTAS.ESTUDIANTE.ACTUALIZAR_ESTUDIANTE
{
    partial class SeleccionDeEstudiante
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
            this.gvestudiante = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.txtmaterno = new System.Windows.Forms.TextBox();
            this.txtpaterno = new System.Windows.Forms.TextBox();
            this.txtci = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.RdbDatosPersonales = new System.Windows.Forms.RadioButton();
            this.RdbDatosModalidad = new System.Windows.Forms.RadioButton();
            this.RdbDatosCarrera = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CARRERA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PERSONA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_ESTUDIANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CARRERA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvestudiante)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvestudiante
            // 
            this.gvestudiante.AllowUserToAddRows = false;
            this.gvestudiante.AllowUserToDeleteRows = false;
            this.gvestudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvestudiante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CI,
            this.ID_CARRERA,
            this.ID_PERSONA,
            this.ID_ESTUDIANTE,
            this.PATERNO,
            this.MATERNO,
            this.NOMBRE,
            this.CARRERA});
            this.gvestudiante.Location = new System.Drawing.Point(29, 68);
            this.gvestudiante.Name = "gvestudiante";
            this.gvestudiante.ReadOnly = true;
            this.gvestudiante.RowHeadersVisible = false;
            this.gvestudiante.Size = new System.Drawing.Size(803, 151);
            this.gvestudiante.TabIndex = 34;
            this.gvestudiante.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvestudiante_CellMouseDoubleClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "CI O DNI";
            // 
            // txtmaterno
            // 
            this.txtmaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaterno.Location = new System.Drawing.Point(330, 43);
            this.txtmaterno.Name = "txtmaterno";
            this.txtmaterno.Size = new System.Drawing.Size(127, 20);
            this.txtmaterno.TabIndex = 41;
            // 
            // txtpaterno
            // 
            this.txtpaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaterno.Location = new System.Drawing.Point(179, 43);
            this.txtpaterno.Name = "txtpaterno";
            this.txtpaterno.Size = new System.Drawing.Size(132, 20);
            this.txtpaterno.TabIndex = 40;
            // 
            // txtci
            // 
            this.txtci.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtci.Location = new System.Drawing.Point(29, 40);
            this.txtci.Name = "txtci";
            this.txtci.Size = new System.Drawing.Size(134, 22);
            this.txtci.TabIndex = 35;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(659, 40);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(99, 23);
            this.btnbuscar.TabIndex = 44;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(477, 43);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(137, 20);
            this.txtnombre.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "AP. MATERNO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(176, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "AP. PATERNO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(474, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "NOMBRE";
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(246, 77);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(126, 23);
            this.BtnModificar.TabIndex = 48;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // RdbDatosPersonales
            // 
            this.RdbDatosPersonales.AutoSize = true;
            this.RdbDatosPersonales.Checked = true;
            this.RdbDatosPersonales.Location = new System.Drawing.Point(69, 30);
            this.RdbDatosPersonales.Name = "RdbDatosPersonales";
            this.RdbDatosPersonales.Size = new System.Drawing.Size(137, 17);
            this.RdbDatosPersonales.TabIndex = 49;
            this.RdbDatosPersonales.TabStop = true;
            this.RdbDatosPersonales.Text = "DATOS PERSONALES";
            this.RdbDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // RdbDatosModalidad
            // 
            this.RdbDatosModalidad.AutoSize = true;
            this.RdbDatosModalidad.Location = new System.Drawing.Point(393, 30);
            this.RdbDatosModalidad.Name = "RdbDatosModalidad";
            this.RdbDatosModalidad.Size = new System.Drawing.Size(153, 17);
            this.RdbDatosModalidad.TabIndex = 51;
            this.RdbDatosModalidad.Text = "DATOS DE MODALIDAD I";
            this.RdbDatosModalidad.UseVisualStyleBackColor = true;
            // 
            // RdbDatosCarrera
            // 
            this.RdbDatosCarrera.AutoSize = true;
            this.RdbDatosCarrera.Location = new System.Drawing.Point(224, 30);
            this.RdbDatosCarrera.Name = "RdbDatosCarrera";
            this.RdbDatosCarrera.Size = new System.Drawing.Size(135, 17);
            this.RdbDatosCarrera.TabIndex = 52;
            this.RdbDatosCarrera.Text = "DATOS DE CARRERA";
            this.RdbDatosCarrera.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.RdbDatosCarrera);
            this.groupBox1.Controls.Add(this.RdbDatosModalidad);
            this.groupBox1.Controls.Add(this.RdbDatosPersonales);
            this.groupBox1.Controls.Add(this.BtnModificar);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(174, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 112);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtmaterno);
            this.groupBox2.Controls.Add(this.txtnombre);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtpaterno);
            this.groupBox2.Controls.Add(this.txtci);
            this.groupBox2.Controls.Add(this.btnbuscar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.gvestudiante);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(37, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(856, 236);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SELECCION DE ESTUDIANTE";
            // 
            // CI
            // 
            this.CI.HeaderText = "CI";
            this.CI.Name = "CI";
            this.CI.ReadOnly = true;
            // 
            // ID_CARRERA
            // 
            this.ID_CARRERA.HeaderText = "ID_CARRERA";
            this.ID_CARRERA.Name = "ID_CARRERA";
            this.ID_CARRERA.ReadOnly = true;
            this.ID_CARRERA.Visible = false;
            // 
            // ID_PERSONA
            // 
            this.ID_PERSONA.HeaderText = "ID_PERSONA";
            this.ID_PERSONA.Name = "ID_PERSONA";
            this.ID_PERSONA.ReadOnly = true;
            this.ID_PERSONA.Visible = false;
            // 
            // ID_ESTUDIANTE
            // 
            this.ID_ESTUDIANTE.HeaderText = "ID_ESTUDIANTE";
            this.ID_ESTUDIANTE.Name = "ID_ESTUDIANTE";
            this.ID_ESTUDIANTE.ReadOnly = true;
            this.ID_ESTUDIANTE.Visible = false;
            // 
            // PATERNO
            // 
            this.PATERNO.HeaderText = "AP. PATERNO";
            this.PATERNO.Name = "PATERNO";
            this.PATERNO.ReadOnly = true;
            this.PATERNO.Width = 150;
            // 
            // MATERNO
            // 
            this.MATERNO.HeaderText = "AP. MATERNO";
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
            // SeleccionDeEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "SeleccionDeEstudiante";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SELECCION DE ESTUDIANTE PARA ACTUALIZACION";
            this.Load += new System.EventHandler(this.SeleccionDeEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvestudiante)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvestudiante;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtmaterno;
        private System.Windows.Forms.TextBox txtpaterno;
        private System.Windows.Forms.TextBox txtci;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.RadioButton RdbDatosPersonales;
        private System.Windows.Forms.RadioButton RdbDatosModalidad;
        private System.Windows.Forms.RadioButton RdbDatosCarrera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CARRERA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PERSONA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ESTUDIANTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARRERA;
    }
}