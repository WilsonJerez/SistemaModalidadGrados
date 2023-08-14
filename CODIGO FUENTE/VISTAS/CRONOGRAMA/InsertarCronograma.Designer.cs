namespace VISTAS.CRONOGRAMA
{
    partial class InsertarCronograma
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
            this.CI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_MODALIDAD_II = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_MODALIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_INSCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtMaternoB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPaternoB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombreB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCiB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFiltrarModalidadII = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtFechFin = new System.Windows.Forms.TextBox();
            this.BtnQuitarFecha = new System.Windows.Forms.Button();
            this.BtnAgregarFecha = new System.Windows.Forms.Button();
            this.GridFechas = new System.Windows.Forms.DataGridView();
            this.NRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnGuardarCronograma = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.GridModalidadII)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFechas)).BeginInit();
            this.SuspendLayout();
            // 
            // GridModalidadII
            // 
            this.GridModalidadII.AllowUserToAddRows = false;
            this.GridModalidadII.AllowUserToDeleteRows = false;
            this.GridModalidadII.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridModalidadII.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CI,
            this.ID_MODALIDAD_II,
            this.PATERNO,
            this.MATERNO,
            this.NOMBRE,
            this.TEMA,
            this.TIPO_MODALIDAD,
            this.FECHA_INSCRIPCION});
            this.GridModalidadII.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.GridModalidadII.Location = new System.Drawing.Point(19, 90);
            this.GridModalidadII.Name = "GridModalidadII";
            this.GridModalidadII.ReadOnly = true;
            this.GridModalidadII.RowHeadersVisible = false;
            this.GridModalidadII.Size = new System.Drawing.Size(709, 133);
            this.GridModalidadII.TabIndex = 0;
            this.GridModalidadII.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridModalidadII_CellMouseDoubleClick);
            // 
            // CI
            // 
            this.CI.HeaderText = "CI";
            this.CI.Name = "CI";
            this.CI.ReadOnly = true;
            // 
            // ID_MODALIDAD_II
            // 
            this.ID_MODALIDAD_II.HeaderText = "ID_MODALIDAD_II";
            this.ID_MODALIDAD_II.Name = "ID_MODALIDAD_II";
            this.ID_MODALIDAD_II.ReadOnly = true;
            this.ID_MODALIDAD_II.Visible = false;
            // 
            // PATERNO
            // 
            this.PATERNO.HeaderText = "PATERNO";
            this.PATERNO.Name = "PATERNO";
            this.PATERNO.ReadOnly = true;
            // 
            // MATERNO
            // 
            this.MATERNO.HeaderText = "MATERNO";
            this.MATERNO.Name = "MATERNO";
            this.MATERNO.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // TEMA
            // 
            this.TEMA.HeaderText = "TEMA";
            this.TEMA.Name = "TEMA";
            this.TEMA.ReadOnly = true;
            // 
            // TIPO_MODALIDAD
            // 
            this.TIPO_MODALIDAD.HeaderText = "TIPO MODALIDAD";
            this.TIPO_MODALIDAD.Name = "TIPO_MODALIDAD";
            this.TIPO_MODALIDAD.ReadOnly = true;
            // 
            // FECHA_INSCRIPCION
            // 
            this.FECHA_INSCRIPCION.HeaderText = "FECHA INSCRIPCION";
            this.FECHA_INSCRIPCION.Name = "FECHA_INSCRIPCION";
            this.FECHA_INSCRIPCION.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TxtMaternoB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtPaternoB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtNombreB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtCiB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnFiltrarModalidadII);
            this.groupBox1.Controls.Add(this.GridModalidadII);
            this.groupBox1.Location = new System.Drawing.Point(20, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 229);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ESTUDIANTES EN LA MODALIDAD DE GRADO II";
            // 
            // TxtMaternoB
            // 
            this.TxtMaternoB.Location = new System.Drawing.Point(269, 61);
            this.TxtMaternoB.Name = "TxtMaternoB";
            this.TxtMaternoB.Size = new System.Drawing.Size(100, 20);
            this.TxtMaternoB.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "MATERNO";
            // 
            // TxtPaternoB
            // 
            this.TxtPaternoB.Location = new System.Drawing.Point(134, 61);
            this.TxtPaternoB.Name = "TxtPaternoB";
            this.TxtPaternoB.Size = new System.Drawing.Size(100, 20);
            this.TxtPaternoB.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "PATERNO";
            // 
            // TxtNombreB
            // 
            this.TxtNombreB.Location = new System.Drawing.Point(399, 61);
            this.TxtNombreB.Name = "TxtNombreB";
            this.TxtNombreB.Size = new System.Drawing.Size(100, 20);
            this.TxtNombreB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOMBRE";
            // 
            // TxtCiB
            // 
            this.TxtCiB.Location = new System.Drawing.Point(19, 61);
            this.TxtCiB.Name = "TxtCiB";
            this.TxtCiB.Size = new System.Drawing.Size(100, 20);
            this.TxtCiB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CI";
            // 
            // BtnFiltrarModalidadII
            // 
            this.BtnFiltrarModalidadII.BackColor = System.Drawing.SystemColors.Control;
            this.BtnFiltrarModalidadII.Location = new System.Drawing.Point(524, 57);
            this.BtnFiltrarModalidadII.Name = "BtnFiltrarModalidadII";
            this.BtnFiltrarModalidadII.Size = new System.Drawing.Size(74, 27);
            this.BtnFiltrarModalidadII.TabIndex = 1;
            this.BtnFiltrarModalidadII.Text = "FILTRAR";
            this.BtnFiltrarModalidadII.UseVisualStyleBackColor = false;
            this.BtnFiltrarModalidadII.Click += new System.EventHandler(this.BtnFiltrarModalidadII_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtFechFin);
            this.groupBox2.Controls.Add(this.BtnQuitarFecha);
            this.groupBox2.Controls.Add(this.BtnAgregarFecha);
            this.groupBox2.Controls.Add(this.GridFechas);
            this.groupBox2.Location = new System.Drawing.Point(39, 258);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 210);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FECHAS DE PRESENTACION DE INFORMES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "FECHA MAXIMA";
            this.label5.Visible = false;
            // 
            // TxtFechFin
            // 
            this.TxtFechFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TxtFechFin.Location = new System.Drawing.Point(269, 32);
            this.TxtFechFin.Name = "TxtFechFin";
            this.TxtFechFin.ReadOnly = true;
            this.TxtFechFin.Size = new System.Drawing.Size(115, 20);
            this.TxtFechFin.TabIndex = 5;
            this.TxtFechFin.Visible = false;
            // 
            // BtnQuitarFecha
            // 
            this.BtnQuitarFecha.BackColor = System.Drawing.SystemColors.Control;
            this.BtnQuitarFecha.Enabled = false;
            this.BtnQuitarFecha.Location = new System.Drawing.Point(269, 99);
            this.BtnQuitarFecha.Name = "BtnQuitarFecha";
            this.BtnQuitarFecha.Size = new System.Drawing.Size(115, 35);
            this.BtnQuitarFecha.TabIndex = 4;
            this.BtnQuitarFecha.Text = "QUITAR FECHA";
            this.BtnQuitarFecha.UseVisualStyleBackColor = false;
            this.BtnQuitarFecha.Click += new System.EventHandler(this.BtnQuitarFecha_Click);
            // 
            // BtnAgregarFecha
            // 
            this.BtnAgregarFecha.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAgregarFecha.Enabled = false;
            this.BtnAgregarFecha.Location = new System.Drawing.Point(269, 58);
            this.BtnAgregarFecha.Name = "BtnAgregarFecha";
            this.BtnAgregarFecha.Size = new System.Drawing.Size(115, 35);
            this.BtnAgregarFecha.TabIndex = 3;
            this.BtnAgregarFecha.Text = "AGREGAR FECHA";
            this.BtnAgregarFecha.UseVisualStyleBackColor = false;
            this.BtnAgregarFecha.Click += new System.EventHandler(this.BtnAgregarFecha_Click);
            // 
            // GridFechas
            // 
            this.GridFechas.AllowUserToAddRows = false;
            this.GridFechas.AllowUserToDeleteRows = false;
            this.GridFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFechas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NRO,
            this.FECHA});
            this.GridFechas.Enabled = false;
            this.GridFechas.Location = new System.Drawing.Point(11, 19);
            this.GridFechas.Name = "GridFechas";
            this.GridFechas.RowHeadersVisible = false;
            this.GridFechas.Size = new System.Drawing.Size(249, 185);
            this.GridFechas.TabIndex = 2;
            this.GridFechas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridFechas_CellEndEdit);
            // 
            // NRO
            // 
            this.NRO.HeaderText = "NRO";
            this.NRO.Name = "NRO";
            this.NRO.ReadOnly = true;
            this.NRO.Width = 50;
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.Width = 185;
            // 
            // BtnGuardarCronograma
            // 
            this.BtnGuardarCronograma.Enabled = false;
            this.BtnGuardarCronograma.Location = new System.Drawing.Point(346, 498);
            this.BtnGuardarCronograma.Name = "BtnGuardarCronograma";
            this.BtnGuardarCronograma.Size = new System.Drawing.Size(154, 36);
            this.BtnGuardarCronograma.TabIndex = 4;
            this.BtnGuardarCronograma.Text = "GUARDAR CRONOGRAMA";
            this.BtnGuardarCronograma.UseVisualStyleBackColor = true;
            this.BtnGuardarCronograma.Click += new System.EventHandler(this.BtnGuardarCronograma_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.DarkGray;
            this.monthCalendar1.Location = new System.Drawing.Point(523, 277);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // InsertarCronograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 546);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.BtnGuardarCronograma);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "InsertarCronograma";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INSERTAR NUEVO CRONOGRAMA";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.InsertarCronograma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridModalidadII)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFechas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridModalidadII;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GridFechas;
        private System.Windows.Forms.TextBox TxtMaternoB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPaternoB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombreB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCiB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFiltrarModalidadII;
        private System.Windows.Forms.Button BtnGuardarCronograma;
        private System.Windows.Forms.Button BtnQuitarFecha;
        private System.Windows.Forms.Button BtnAgregarFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtFechFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MODALIDAD_II;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_MODALIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_INSCRIPCION;


    }
}