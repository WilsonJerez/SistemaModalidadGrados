namespace VISTAS.CRONOGRAMA
{
    partial class ActualizarCronograma
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
            this.GridModalidadII = new System.Windows.Forms.DataGridView();
            this.GridCronograma = new System.Windows.Forms.DataGridView();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CRONOGRAMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_MODALIDAD_IIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbInactivo = new System.Windows.Forms.RadioButton();
            this.RbActivo = new System.Windows.Forms.RadioButton();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPaterno = new System.Windows.Forms.TextBox();
            this.TxtCi = new System.Windows.Forms.TextBox();
            this.TxtMaterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtFechaFin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDetalle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.CI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_MODALIDAD_II = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_MODALIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_INSCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridModalidadII)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCronograma)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridModalidadII
            // 
            this.GridModalidadII.AllowUserToAddRows = false;
            this.GridModalidadII.AllowUserToDeleteRows = false;
            this.GridModalidadII.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridModalidadII.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CI,
            this.PATERNO,
            this.MATERNO,
            this.NOMBRE,
            this.ID_MODALIDAD_II,
            this.TIPO_MODALIDAD,
            this.FECHA_INSCRIPCION});
            this.GridModalidadII.Location = new System.Drawing.Point(9, 69);
            this.GridModalidadII.Name = "GridModalidadII";
            this.GridModalidadII.ReadOnly = true;
            this.GridModalidadII.RowHeadersVisible = false;
            this.GridModalidadII.Size = new System.Drawing.Size(748, 150);
            this.GridModalidadII.TabIndex = 0;
            this.GridModalidadII.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridModalidadII_CellMouseDoubleClick);
            // 
            // GridCronograma
            // 
            this.GridCronograma.AllowUserToAddRows = false;
            this.GridCronograma.AllowUserToDeleteRows = false;
            this.GridCronograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCronograma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FECHA,
            this.ID_CRONOGRAMA,
            this.ID_MODALIDAD_IIC,
            this.DESCRIPCION,
            this.ESTADO});
            this.GridCronograma.Location = new System.Drawing.Point(6, 23);
            this.GridCronograma.Name = "GridCronograma";
            this.GridCronograma.ReadOnly = true;
            this.GridCronograma.RowHeadersVisible = false;
            this.GridCronograma.Size = new System.Drawing.Size(332, 133);
            this.GridCronograma.TabIndex = 1;
            this.GridCronograma.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridCronograma_CellMouseDoubleClick);
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            // 
            // ID_CRONOGRAMA
            // 
            this.ID_CRONOGRAMA.HeaderText = "ID_CRONOGRAMA";
            this.ID_CRONOGRAMA.Name = "ID_CRONOGRAMA";
            this.ID_CRONOGRAMA.ReadOnly = true;
            this.ID_CRONOGRAMA.Visible = false;
            // 
            // ID_MODALIDAD_IIC
            // 
            this.ID_MODALIDAD_IIC.HeaderText = "ID_MODALIDAD_IIC";
            this.ID_MODALIDAD_IIC.Name = "ID_MODALIDAD_IIC";
            this.ID_MODALIDAD_IIC.ReadOnly = true;
            this.ID_MODALIDAD_IIC.Visible = false;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DETALLE";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.Width = 300;
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.Visible = false;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Enabled = false;
            this.BtnActualizar.Location = new System.Drawing.Point(358, 422);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(95, 31);
            this.BtnActualizar.TabIndex = 2;
            this.BtnActualizar.Text = "ACTUALIZAR";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "FECHA";
            // 
            // TxtFecha
            // 
            this.TxtFecha.Enabled = false;
            this.TxtFecha.Location = new System.Drawing.Point(443, 37);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(133, 20);
            this.TxtFecha.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.RbInactivo);
            this.groupBox1.Controls.Add(this.RbActivo);
            this.groupBox1.Controls.Add(this.BtnFiltrar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtPaterno);
            this.groupBox1.Controls.Add(this.TxtCi);
            this.groupBox1.Controls.Add(this.TxtMaterno);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.GridModalidadII);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(15, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 235);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MODALIDADES DE GRADO II";
            // 
            // RbInactivo
            // 
            this.RbInactivo.AutoSize = true;
            this.RbInactivo.Location = new System.Drawing.Point(564, 46);
            this.RbInactivo.Name = "RbInactivo";
            this.RbInactivo.Size = new System.Drawing.Size(94, 17);
            this.RbInactivo.TabIndex = 11;
            this.RbInactivo.Text = "FINALIZADAS";
            this.RbInactivo.UseVisualStyleBackColor = true;
            // 
            // RbActivo
            // 
            this.RbActivo.AutoSize = true;
            this.RbActivo.Checked = true;
            this.RbActivo.Location = new System.Drawing.Point(450, 46);
            this.RbActivo.Name = "RbActivo";
            this.RbActivo.Size = new System.Drawing.Size(116, 17);
            this.RbActivo.TabIndex = 10;
            this.RbActivo.TabStop = true;
            this.RbActivo.Text = "EN DESARROLLO";
            this.RbActivo.UseVisualStyleBackColor = true;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(656, 40);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(92, 27);
            this.BtnFiltrar.TabIndex = 9;
            this.BtnFiltrar.Text = "FILTRAR";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "PATERNO";
            // 
            // TxtPaterno
            // 
            this.TxtPaterno.Location = new System.Drawing.Point(115, 44);
            this.TxtPaterno.Name = "TxtPaterno";
            this.TxtPaterno.Size = new System.Drawing.Size(100, 20);
            this.TxtPaterno.TabIndex = 4;
            // 
            // TxtCi
            // 
            this.TxtCi.Location = new System.Drawing.Point(9, 44);
            this.TxtCi.Name = "TxtCi";
            this.TxtCi.Size = new System.Drawing.Size(100, 20);
            this.TxtCi.TabIndex = 8;
            // 
            // TxtMaterno
            // 
            this.TxtMaterno.Location = new System.Drawing.Point(221, 44);
            this.TxtMaterno.Name = "TxtMaterno";
            this.TxtMaterno.Size = new System.Drawing.Size(100, 20);
            this.TxtMaterno.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "CI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "MATERNO";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(328, 44);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.TxtFechaFin);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtDetalle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CmbEstado);
            this.groupBox2.Controls.Add(this.TxtFecha);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.GridCronograma);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(56, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 168);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ACTUALIZAR CRONOGRAMA";
            // 
            // TxtFechaFin
            // 
            this.TxtFechaFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TxtFechaFin.Location = new System.Drawing.Point(442, 11);
            this.TxtFechaFin.Name = "TxtFechaFin";
            this.TxtFechaFin.ReadOnly = true;
            this.TxtFechaFin.Size = new System.Drawing.Size(133, 20);
            this.TxtFechaFin.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "FECHA MAXIMA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(382, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "ESTADO";
            this.label7.Visible = false;
            // 
            // TxtDetalle
            // 
            this.TxtDetalle.Enabled = false;
            this.TxtDetalle.Location = new System.Drawing.Point(442, 63);
            this.TxtDetalle.MaxLength = 200;
            this.TxtDetalle.Multiline = true;
            this.TxtDetalle.Name = "TxtDetalle";
            this.TxtDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDetalle.Size = new System.Drawing.Size(133, 35);
            this.TxtDetalle.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "DETALLE";
            // 
            // CmbEstado
            // 
            this.CmbEstado.Enabled = false;
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.CmbEstado.Location = new System.Drawing.Point(443, 104);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(132, 21);
            this.CmbEstado.TabIndex = 5;
            this.CmbEstado.Visible = false;
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
            this.NOMBRE.Width = 150;
            // 
            // ID_MODALIDAD_II
            // 
            this.ID_MODALIDAD_II.HeaderText = "ID_MODALIDAD_II";
            this.ID_MODALIDAD_II.Name = "ID_MODALIDAD_II";
            this.ID_MODALIDAD_II.ReadOnly = true;
            this.ID_MODALIDAD_II.Visible = false;
            // 
            // TIPO_MODALIDAD
            // 
            this.TIPO_MODALIDAD.HeaderText = "TIPO_MODALIDAD";
            this.TIPO_MODALIDAD.Name = "TIPO_MODALIDAD";
            this.TIPO_MODALIDAD.ReadOnly = true;
            this.TIPO_MODALIDAD.Width = 250;
            // 
            // FECHA_INSCRIPCION
            // 
            this.FECHA_INSCRIPCION.HeaderText = "FECHA INSCRIPCION";
            this.FECHA_INSCRIPCION.Name = "FECHA_INSCRIPCION";
            this.FECHA_INSCRIPCION.ReadOnly = true;
            // 
            // ActualizarCronograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 465);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnActualizar);
            this.Name = "ActualizarCronograma";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACTUALIZAR CRONOGRAMA";
            this.Load += new System.EventHandler(this.ActualizarCronograma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridModalidadII)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCronograma)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridModalidadII;
        private System.Windows.Forms.DataGridView GridCronograma;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.TextBox TxtCi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDetalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CRONOGRAMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MODALIDAD_IIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.TextBox TxtFechaFin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton RbInactivo;
        private System.Windows.Forms.RadioButton RbActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MODALIDAD_II;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_MODALIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_INSCRIPCION;
    }
}