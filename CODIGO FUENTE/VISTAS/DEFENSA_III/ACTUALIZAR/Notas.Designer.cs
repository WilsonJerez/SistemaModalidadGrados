namespace VISTAS.DEFENSA_III.ACTUALIZAR
{
    partial class Notas
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
            this.DtgEstudiantes = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtMaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DtgTribunalesInternos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNotaExterna = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTribunalExterno = new System.Windows.Forms.TextBox();
            this.TxtPromedio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnActualizarNotas = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TxtNroActa = new System.Windows.Forms.TextBox();
            this.CkbActualizarNroActa = new System.Windows.Forms.CheckBox();
            this.ID_DEFENSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTA_DEFENSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_MOD_III = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CARRERA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_DEFENSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRO_ACTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TRIBUNAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AP_PATERNOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AP_MATERNOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgEstudiantes)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgTribunalesInternos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.DtgEstudiantes);
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.TxtMaterno);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtPaterno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.TxtCi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(26, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ESTUDIANTES QUE DEFENDIERON";
            // 
            // DtgEstudiantes
            // 
            this.DtgEstudiantes.AllowUserToAddRows = false;
            this.DtgEstudiantes.AllowUserToDeleteRows = false;
            this.DtgEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_DEFENSA,
            this.NOTA_DEFENSA,
            this.ID_MOD_III,
            this.CI,
            this.PATERNO,
            this.MATERNO,
            this.NOMBRE,
            this.CARRERA,
            this.FECHA_DEFENSA,
            this.NRO_ACTA});
            this.DtgEstudiantes.Location = new System.Drawing.Point(14, 69);
            this.DtgEstudiantes.Name = "DtgEstudiantes";
            this.DtgEstudiantes.ReadOnly = true;
            this.DtgEstudiantes.RowHeadersVisible = false;
            this.DtgEstudiantes.Size = new System.Drawing.Size(802, 101);
            this.DtgEstudiantes.TabIndex = 9;
            this.DtgEstudiantes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgEstudiantes_CellMouseDoubleClick);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(715, 41);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 8;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtMaterno
            // 
            this.TxtMaterno.Location = new System.Drawing.Point(285, 43);
            this.TxtMaterno.Name = "TxtMaterno";
            this.TxtMaterno.Size = new System.Drawing.Size(161, 20);
            this.TxtMaterno.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "AP. MATERNO";
            // 
            // TxtPaterno
            // 
            this.TxtPaterno.Location = new System.Drawing.Point(120, 43);
            this.TxtPaterno.Name = "TxtPaterno";
            this.TxtPaterno.Size = new System.Drawing.Size(161, 20);
            this.TxtPaterno.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "AP. PATERNO";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(452, 43);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(161, 20);
            this.TxtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE";
            // 
            // TxtCi
            // 
            this.TxtCi.Location = new System.Drawing.Point(15, 43);
            this.TxtCi.Name = "TxtCi";
            this.TxtCi.Size = new System.Drawing.Size(100, 20);
            this.TxtCi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CI/DNI";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.DtgTribunalesInternos);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(32, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(816, 104);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TRIBUNALES INTERNOS";
            // 
            // DtgTribunalesInternos
            // 
            this.DtgTribunalesInternos.AllowUserToAddRows = false;
            this.DtgTribunalesInternos.AllowUserToDeleteRows = false;
            this.DtgTribunalesInternos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgTribunalesInternos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_TRIBUNAL,
            this.CIT,
            this.AP_PATERNOT,
            this.AP_MATERNOT,
            this.NOMBRET,
            this.NOTA});
            this.DtgTribunalesInternos.Location = new System.Drawing.Point(18, 21);
            this.DtgTribunalesInternos.Name = "DtgTribunalesInternos";
            this.DtgTribunalesInternos.RowHeadersVisible = false;
            this.DtgTribunalesInternos.Size = new System.Drawing.Size(784, 69);
            this.DtgTribunalesInternos.TabIndex = 0;
            this.DtgTribunalesInternos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgTribunalesInternos_CellEndEdit);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TxtNotaExterna);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TxtTribunalExterno);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(87, 432);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(706, 77);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TRIBUNAL EXTERNO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(641, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "NOTA";
            // 
            // TxtNotaExterna
            // 
            this.TxtNotaExterna.Location = new System.Drawing.Point(644, 51);
            this.TxtNotaExterna.Name = "TxtNotaExterna";
            this.TxtNotaExterna.Size = new System.Drawing.Size(51, 20);
            this.TxtNotaExterna.TabIndex = 2;
            this.TxtNotaExterna.Text = "0";
            this.TxtNotaExterna.TextChanged += new System.EventHandler(this.TxtNotaExterna_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "NOMBRE COMPLETO";
            // 
            // TxtTribunalExterno
            // 
            this.TxtTribunalExterno.Location = new System.Drawing.Point(18, 51);
            this.TxtTribunalExterno.Name = "TxtTribunalExterno";
            this.TxtTribunalExterno.ReadOnly = true;
            this.TxtTribunalExterno.Size = new System.Drawing.Size(594, 20);
            this.TxtTribunalExterno.TabIndex = 0;
            // 
            // TxtPromedio
            // 
            this.TxtPromedio.Location = new System.Drawing.Point(390, 550);
            this.TxtPromedio.Name = "TxtPromedio";
            this.TxtPromedio.ReadOnly = true;
            this.TxtPromedio.Size = new System.Drawing.Size(100, 20);
            this.TxtPromedio.TabIndex = 3;
            this.TxtPromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(391, 535);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "PROMEDIO FINAL";
            // 
            // BtnActualizarNotas
            // 
            this.BtnActualizarNotas.Location = new System.Drawing.Point(359, 587);
            this.BtnActualizarNotas.Name = "BtnActualizarNotas";
            this.BtnActualizarNotas.Size = new System.Drawing.Size(163, 37);
            this.BtnActualizarNotas.TabIndex = 5;
            this.BtnActualizarNotas.Text = "ACTUALIZAR NOTAS";
            this.BtnActualizarNotas.UseVisualStyleBackColor = true;
            this.BtnActualizarNotas.Click += new System.EventHandler(this.BtnActualizarNotas_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.TxtNroActa);
            this.groupBox4.Controls.Add(this.CkbActualizarNroActa);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(292, 234);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(371, 72);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "NUMERO DE ACTA";
            // 
            // TxtNroActa
            // 
            this.TxtNroActa.Location = new System.Drawing.Point(66, 29);
            this.TxtNroActa.Name = "TxtNroActa";
            this.TxtNroActa.Size = new System.Drawing.Size(100, 20);
            this.TxtNroActa.TabIndex = 2;
            // 
            // CkbActualizarNroActa
            // 
            this.CkbActualizarNroActa.AutoSize = true;
            this.CkbActualizarNroActa.Location = new System.Drawing.Point(187, 31);
            this.CkbActualizarNroActa.Name = "CkbActualizarNroActa";
            this.CkbActualizarNroActa.Size = new System.Drawing.Size(169, 17);
            this.CkbActualizarNroActa.TabIndex = 0;
            this.CkbActualizarNroActa.Text = "ACTUALIZAR NRO DE ACTA";
            this.CkbActualizarNroActa.UseVisualStyleBackColor = true;
            this.CkbActualizarNroActa.CheckedChanged += new System.EventHandler(this.CkbActualizarNroActa_CheckedChanged);
            // 
            // ID_DEFENSA
            // 
            this.ID_DEFENSA.HeaderText = "ID_DEFENSA";
            this.ID_DEFENSA.Name = "ID_DEFENSA";
            this.ID_DEFENSA.ReadOnly = true;
            this.ID_DEFENSA.Visible = false;
            // 
            // NOTA_DEFENSA
            // 
            this.NOTA_DEFENSA.HeaderText = "NOTA_DEFENSA";
            this.NOTA_DEFENSA.Name = "NOTA_DEFENSA";
            this.NOTA_DEFENSA.ReadOnly = true;
            this.NOTA_DEFENSA.Visible = false;
            // 
            // ID_MOD_III
            // 
            this.ID_MOD_III.HeaderText = "ID_MOD_III";
            this.ID_MOD_III.Name = "ID_MOD_III";
            this.ID_MOD_III.ReadOnly = true;
            this.ID_MOD_III.Visible = false;
            // 
            // CI
            // 
            this.CI.HeaderText = "CI/DNI";
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
            // CARRERA
            // 
            this.CARRERA.HeaderText = "CARRERA";
            this.CARRERA.Name = "CARRERA";
            this.CARRERA.ReadOnly = true;
            this.CARRERA.Width = 150;
            // 
            // FECHA_DEFENSA
            // 
            this.FECHA_DEFENSA.HeaderText = "FECHA_DEFENSA";
            this.FECHA_DEFENSA.Name = "FECHA_DEFENSA";
            this.FECHA_DEFENSA.ReadOnly = true;
            // 
            // NRO_ACTA
            // 
            this.NRO_ACTA.HeaderText = "NRO_ACTA";
            this.NRO_ACTA.Name = "NRO_ACTA";
            this.NRO_ACTA.ReadOnly = true;
            this.NRO_ACTA.Visible = false;
            // 
            // ID_TRIBUNAL
            // 
            this.ID_TRIBUNAL.Frozen = true;
            this.ID_TRIBUNAL.HeaderText = "ID_TRIBUNAL";
            this.ID_TRIBUNAL.Name = "ID_TRIBUNAL";
            this.ID_TRIBUNAL.Visible = false;
            // 
            // CIT
            // 
            this.CIT.Frozen = true;
            this.CIT.HeaderText = "CI/DNI";
            this.CIT.Name = "CIT";
            this.CIT.ReadOnly = true;
            // 
            // AP_PATERNOT
            // 
            this.AP_PATERNOT.Frozen = true;
            this.AP_PATERNOT.HeaderText = "AP. PATERNO";
            this.AP_PATERNOT.Name = "AP_PATERNOT";
            this.AP_PATERNOT.ReadOnly = true;
            this.AP_PATERNOT.Width = 200;
            // 
            // AP_MATERNOT
            // 
            this.AP_MATERNOT.Frozen = true;
            this.AP_MATERNOT.HeaderText = "AP. MATERNO";
            this.AP_MATERNOT.Name = "AP_MATERNOT";
            this.AP_MATERNOT.ReadOnly = true;
            this.AP_MATERNOT.Width = 200;
            // 
            // NOMBRET
            // 
            this.NOMBRET.Frozen = true;
            this.NOMBRET.HeaderText = "NOMBRE";
            this.NOMBRET.Name = "NOMBRET";
            this.NOMBRET.ReadOnly = true;
            this.NOMBRET.Width = 200;
            // 
            // NOTA
            // 
            this.NOTA.HeaderText = "NOTA";
            this.NOTA.Name = "NOTA";
            this.NOTA.Width = 80;
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 643);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.BtnActualizarNotas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtPromedio);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Notas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACTUALIZAR NOTAS DEFENSA MINISTERIO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgEstudiantes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgTribunalesInternos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DtgEstudiantes;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtMaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DtgTribunalesInternos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtTribunalExterno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNotaExterna;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPromedio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnActualizarNotas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TxtNroActa;
        private System.Windows.Forms.CheckBox CkbActualizarNroActa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DEFENSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTA_DEFENSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MOD_III;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARRERA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_DEFENSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRO_ACTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TRIBUNAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn AP_PATERNOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn AP_MATERNOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRET;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTA;
    }
}