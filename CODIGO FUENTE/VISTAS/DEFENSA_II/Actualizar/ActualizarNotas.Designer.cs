namespace VISTAS.DEFENSA_II.Actualizar
{
    partial class ActualizarNotas
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
            this.GridDefensa = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtCi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GridTribunal = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CkbNotas = new System.Windows.Forms.CheckBox();
            this.CkbNroActa = new System.Windows.Forms.CheckBox();
            this.TxtActa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtEstado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPromedio = new System.Windows.Forms.TextBox();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.ID_DEFENSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRO_ACTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_DEFENSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATERNOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERNOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TRIBUNAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDefensa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTribunal)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.GridDefensa);
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.TxtCi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtMaterno);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtPaterno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 177);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MODALIDADES DE GRADO II";
            // 
            // GridDefensa
            // 
            this.GridDefensa.AllowUserToAddRows = false;
            this.GridDefensa.AllowUserToDeleteRows = false;
            this.GridDefensa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDefensa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_DEFENSA,
            this.NRO_ACTA,
            this.NOTA,
            this.CI,
            this.PATERNO,
            this.MATERNO,
            this.NOMBRE,
            this.FECHA_DEFENSA,
            this.ESTADO});
            this.GridDefensa.Location = new System.Drawing.Point(14, 73);
            this.GridDefensa.Name = "GridDefensa";
            this.GridDefensa.ReadOnly = true;
            this.GridDefensa.RowHeadersVisible = false;
            this.GridDefensa.Size = new System.Drawing.Size(654, 91);
            this.GridDefensa.TabIndex = 10;
            this.GridDefensa.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridDefensa_CellMouseDoubleClick);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(565, 42);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(92, 27);
            this.BtnBuscar.TabIndex = 9;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtCi
            // 
            this.TxtCi.Location = new System.Drawing.Point(28, 44);
            this.TxtCi.Name = "TxtCi";
            this.TxtCi.Size = new System.Drawing.Size(115, 20);
            this.TxtCi.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "CI";
            // 
            // TxtMaterno
            // 
            this.TxtMaterno.Location = new System.Drawing.Point(296, 44);
            this.TxtMaterno.Name = "TxtMaterno";
            this.TxtMaterno.Size = new System.Drawing.Size(115, 20);
            this.TxtMaterno.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "MATERNO";
            // 
            // TxtPaterno
            // 
            this.TxtPaterno.Location = new System.Drawing.Point(155, 44);
            this.TxtPaterno.Name = "TxtPaterno";
            this.TxtPaterno.Size = new System.Drawing.Size(115, 20);
            this.TxtPaterno.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "PATERNO";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(427, 44);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(115, 20);
            this.TxtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE";
            // 
            // GridTribunal
            // 
            this.GridTribunal.AllowUserToAddRows = false;
            this.GridTribunal.AllowUserToDeleteRows = false;
            this.GridTribunal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTribunal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIT,
            this.PATERNOT,
            this.MATERNOT,
            this.NOMBRET,
            this.NOTAT,
            this.ID_TRIBUNAL});
            this.GridTribunal.Location = new System.Drawing.Point(14, 72);
            this.GridTribunal.Name = "GridTribunal";
            this.GridTribunal.RowHeadersVisible = false;
            this.GridTribunal.Size = new System.Drawing.Size(653, 89);
            this.GridTribunal.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.CkbNotas);
            this.groupBox2.Controls.Add(this.CkbNroActa);
            this.groupBox2.Controls.Add(this.TxtActa);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtEstado);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TxtPromedio);
            this.groupBox2.Controls.Add(this.BtnActualizar);
            this.groupBox2.Controls.Add(this.GridTribunal);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(26, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(689, 263);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TRIBUNAL";
            // 
            // CkbNotas
            // 
            this.CkbNotas.AutoSize = true;
            this.CkbNotas.Location = new System.Drawing.Point(444, 42);
            this.CkbNotas.Name = "CkbNotas";
            this.CkbNotas.Size = new System.Drawing.Size(133, 17);
            this.CkbNotas.TabIndex = 17;
            this.CkbNotas.Text = "ACTUALIZAR NOTAS";
            this.CkbNotas.UseVisualStyleBackColor = true;
            // 
            // CkbNroActa
            // 
            this.CkbNroActa.AutoSize = true;
            this.CkbNroActa.Location = new System.Drawing.Point(444, 19);
            this.CkbNroActa.Name = "CkbNroActa";
            this.CkbNroActa.Size = new System.Drawing.Size(151, 17);
            this.CkbNroActa.TabIndex = 16;
            this.CkbNroActa.Text = "ACTUALIZAR NRO ACTA";
            this.CkbNroActa.UseVisualStyleBackColor = true;
            this.CkbNroActa.CheckedChanged += new System.EventHandler(this.CkbNroActa_CheckedChanged);
            // 
            // TxtActa
            // 
            this.TxtActa.Location = new System.Drawing.Point(268, 32);
            this.TxtActa.Name = "TxtActa";
            this.TxtActa.Size = new System.Drawing.Size(142, 20);
            this.TxtActa.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "NUMERO DE ACTA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ESTADO DE LA DEFENSA";
            // 
            // TxtEstado
            // 
            this.TxtEstado.Location = new System.Drawing.Point(347, 187);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.ReadOnly = true;
            this.TxtEstado.Size = new System.Drawing.Size(135, 20);
            this.TxtEstado.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "PROMEDIO FINAL";
            // 
            // TxtPromedio
            // 
            this.TxtPromedio.Location = new System.Drawing.Point(196, 187);
            this.TxtPromedio.Name = "TxtPromedio";
            this.TxtPromedio.ReadOnly = true;
            this.TxtPromedio.Size = new System.Drawing.Size(100, 20);
            this.TxtPromedio.TabIndex = 10;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Enabled = false;
            this.BtnActualizar.Location = new System.Drawing.Point(278, 228);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(132, 23);
            this.BtnActualizar.TabIndex = 9;
            this.BtnActualizar.Text = "ACTUALIZAR NOTAS";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // ID_DEFENSA
            // 
            this.ID_DEFENSA.HeaderText = "ID_DEFENSA";
            this.ID_DEFENSA.Name = "ID_DEFENSA";
            this.ID_DEFENSA.ReadOnly = true;
            this.ID_DEFENSA.Visible = false;
            // 
            // NRO_ACTA
            // 
            this.NRO_ACTA.HeaderText = "NRO_ACTA";
            this.NRO_ACTA.Name = "NRO_ACTA";
            this.NRO_ACTA.ReadOnly = true;
            this.NRO_ACTA.Visible = false;
            // 
            // NOTA
            // 
            this.NOTA.HeaderText = "NOTA";
            this.NOTA.Name = "NOTA";
            this.NOTA.ReadOnly = true;
            this.NOTA.Visible = false;
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
            // FECHA_DEFENSA
            // 
            this.FECHA_DEFENSA.HeaderText = "FECHA_DEFENSA";
            this.FECHA_DEFENSA.Name = "FECHA_DEFENSA";
            this.FECHA_DEFENSA.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.Visible = false;
            // 
            // CIT
            // 
            this.CIT.HeaderText = "CI";
            this.CIT.Name = "CIT";
            this.CIT.ReadOnly = true;
            // 
            // PATERNOT
            // 
            this.PATERNOT.HeaderText = "PATERNO";
            this.PATERNOT.Name = "PATERNOT";
            this.PATERNOT.ReadOnly = true;
            this.PATERNOT.Width = 150;
            // 
            // MATERNOT
            // 
            this.MATERNOT.HeaderText = "MATERNO";
            this.MATERNOT.Name = "MATERNOT";
            this.MATERNOT.ReadOnly = true;
            this.MATERNOT.Width = 150;
            // 
            // NOMBRET
            // 
            this.NOMBRET.HeaderText = "NOMBRE";
            this.NOMBRET.Name = "NOMBRET";
            this.NOMBRET.ReadOnly = true;
            this.NOMBRET.Width = 150;
            // 
            // NOTAT
            // 
            this.NOTAT.HeaderText = "NOTA";
            this.NOTAT.Name = "NOTAT";
            // 
            // ID_TRIBUNAL
            // 
            this.ID_TRIBUNAL.HeaderText = "ID_TRIBUNAL";
            this.ID_TRIBUNAL.Name = "ID_TRIBUNAL";
            this.ID_TRIBUNAL.ReadOnly = true;
            this.ID_TRIBUNAL.Visible = false;
            // 
            // ActualizarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 489);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ActualizarNotas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACTUALIZAR NOTAS DEFENSA MODALIDAD II";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDefensa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTribunal)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtCi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GridDefensa;
        private System.Windows.Forms.DataGridView GridTribunal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPromedio;
        private System.Windows.Forms.TextBox TxtActa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CkbNotas;
        private System.Windows.Forms.CheckBox CkbNroActa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DEFENSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRO_ACTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_DEFENSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATERNOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERNOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRET;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TRIBUNAL;
    }
}