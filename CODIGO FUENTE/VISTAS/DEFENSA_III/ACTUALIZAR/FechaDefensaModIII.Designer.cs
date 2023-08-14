namespace VISTAS.DEFENSA_III.ACTUALIZAR
{
    partial class FechaDefensaModIII
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FechaDefensaModIII));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.BtnActualizarFecha = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnFiltrarDefensa = new System.Windows.Forms.Button();
            this.TxtCi = new System.Windows.Forms.TextBox();
            this.TxtMaterno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPaterno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DtgDefensas = new System.Windows.Forms.DataGridView();
            this.ID_DEFENSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_MOD_III = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_AULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_DEFENSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_MODALIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDefensas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(311, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(521, 290);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SELECCION DE LA FECHA PARA LA NUEVA DEFENSA";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.TxtFecha);
            this.groupBox3.Controls.Add(this.BtnActualizarFecha);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(296, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 179);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "NUVA FECHA PARA LA DEFENSA";
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(47, 43);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(100, 20);
            this.TxtFecha.TabIndex = 6;
            // 
            // BtnActualizarFecha
            // 
            this.BtnActualizarFecha.Enabled = false;
            this.BtnActualizarFecha.Location = new System.Drawing.Point(47, 122);
            this.BtnActualizarFecha.Name = "BtnActualizarFecha";
            this.BtnActualizarFecha.Size = new System.Drawing.Size(96, 34);
            this.BtnActualizarFecha.TabIndex = 5;
            this.BtnActualizarFecha.Text = "ACTUALIZAR FECHA";
            this.BtnActualizarFecha.UseVisualStyleBackColor = true;
            this.BtnActualizarFecha.Click += new System.EventHandler(this.BtnActualizarFecha_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(63, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 179);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SELECCION DE LA FECHA";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.DimGray;
            this.monthCalendar1.Location = new System.Drawing.Point(9, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.ControlText;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BtnFiltrarDefensa);
            this.groupBox1.Controls.Add(this.TxtCi);
            this.groupBox1.Controls.Add(this.TxtMaterno);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtPaterno);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.DtgDefensas);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(26, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1091, 199);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUCAR DEFENSAS";
            // 
            // BtnFiltrarDefensa
            // 
            this.BtnFiltrarDefensa.Location = new System.Drawing.Point(593, 44);
            this.BtnFiltrarDefensa.Name = "BtnFiltrarDefensa";
            this.BtnFiltrarDefensa.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltrarDefensa.TabIndex = 19;
            this.BtnFiltrarDefensa.Text = "BUSCAR";
            this.BtnFiltrarDefensa.UseVisualStyleBackColor = true;
            this.BtnFiltrarDefensa.Click += new System.EventHandler(this.BtnFiltrarDefensa_Click);
            // 
            // TxtCi
            // 
            this.TxtCi.Location = new System.Drawing.Point(29, 43);
            this.TxtCi.Name = "TxtCi";
            this.TxtCi.Size = new System.Drawing.Size(117, 20);
            this.TxtCi.TabIndex = 18;
            // 
            // TxtMaterno
            // 
            this.TxtMaterno.Location = new System.Drawing.Point(307, 44);
            this.TxtMaterno.Name = "TxtMaterno";
            this.TxtMaterno.Size = new System.Drawing.Size(117, 20);
            this.TxtMaterno.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "MATERNO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "CI";
            // 
            // TxtPaterno
            // 
            this.TxtPaterno.Location = new System.Drawing.Point(161, 44);
            this.TxtPaterno.Name = "TxtPaterno";
            this.TxtPaterno.Size = new System.Drawing.Size(117, 20);
            this.TxtPaterno.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "PATERNO";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(443, 44);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(117, 20);
            this.TxtNombre.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "NOMBRE";
            // 
            // DtgDefensas
            // 
            this.DtgDefensas.AllowUserToAddRows = false;
            this.DtgDefensas.AllowUserToDeleteRows = false;
            this.DtgDefensas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDefensas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_DEFENSA,
            this.ID_MOD_III,
            this.ID_AULA,
            this.CI,
            this.PATERNO,
            this.MATERNO,
            this.NOMBRE,
            this.FECHA_DEFENSA,
            this.HORA,
            this.AULA,
            this.TEMA,
            this.TIPO_MODALIDAD});
            this.DtgDefensas.Location = new System.Drawing.Point(11, 70);
            this.DtgDefensas.Name = "DtgDefensas";
            this.DtgDefensas.ReadOnly = true;
            this.DtgDefensas.RowHeadersVisible = false;
            this.DtgDefensas.Size = new System.Drawing.Size(1052, 123);
            this.DtgDefensas.TabIndex = 0;
            this.DtgDefensas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgDefensas_CellMouseDoubleClick);
            // 
            // ID_DEFENSA
            // 
            this.ID_DEFENSA.HeaderText = "ID_DEFENSA";
            this.ID_DEFENSA.Name = "ID_DEFENSA";
            this.ID_DEFENSA.ReadOnly = true;
            this.ID_DEFENSA.Visible = false;
            // 
            // ID_MOD_III
            // 
            this.ID_MOD_III.HeaderText = "ID_MOD_III";
            this.ID_MOD_III.Name = "ID_MOD_III";
            this.ID_MOD_III.ReadOnly = true;
            this.ID_MOD_III.Visible = false;
            // 
            // ID_AULA
            // 
            this.ID_AULA.HeaderText = "ID_AULA";
            this.ID_AULA.Name = "ID_AULA";
            this.ID_AULA.ReadOnly = true;
            this.ID_AULA.Visible = false;
            // 
            // CI
            // 
            this.CI.HeaderText = "CI/DNI";
            this.CI.Name = "CI";
            this.CI.ReadOnly = true;
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
            this.NOMBRE.Width = 150;
            // 
            // FECHA_DEFENSA
            // 
            this.FECHA_DEFENSA.HeaderText = "FECHA DEFENSA";
            this.FECHA_DEFENSA.Name = "FECHA_DEFENSA";
            this.FECHA_DEFENSA.ReadOnly = true;
            // 
            // HORA
            // 
            this.HORA.HeaderText = "HORA";
            this.HORA.Name = "HORA";
            this.HORA.ReadOnly = true;
            // 
            // AULA
            // 
            this.AULA.HeaderText = "AULA";
            this.AULA.Name = "AULA";
            this.AULA.ReadOnly = true;
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
            // FechaDefensaModIII
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1142, 558);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FechaDefensaModIII";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACTUALIZAR FECHA DEFENSA MINISTERIO";
            this.Load += new System.EventHandler(this.FechaDefensaModIII_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDefensas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Button BtnActualizarFecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnFiltrarDefensa;
        private System.Windows.Forms.TextBox TxtCi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMaterno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPaterno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DtgDefensas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DEFENSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MOD_III;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_AULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_DEFENSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA;
        private System.Windows.Forms.DataGridViewTextBoxColumn AULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_MODALIDAD;
    }
}