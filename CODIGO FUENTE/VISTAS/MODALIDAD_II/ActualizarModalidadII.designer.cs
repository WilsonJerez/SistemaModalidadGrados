namespace VISTAS.MODALIDAD_II
{
    partial class ActualizarModalidadII
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
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtGridModalidadII = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMaterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPaterno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GriTutor = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCiTu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtMaternoTu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPaternoTu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtNombreTu = new System.Windows.Forms.TextBox();
            this.BtnBuscarTutor = new System.Windows.Forms.Button();
            this.GridContratos = new System.Windows.Forms.DataGridView();
            this.BtnCambiarTribunal = new System.Windows.Forms.Button();
            this.ID_MODALIDAD_II = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CONTRATOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATERNOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERNOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CONTRATOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATERNOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERNOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBREC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRO_TUTORIAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridModalidadII)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GriTutor)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridContratos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(552, 38);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 0;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(359, 39);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(152, 20);
            this.TxtNombre.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.DtGridModalidadII);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtMaterno);
            this.groupBox1.Controls.Add(this.TxtCi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtPaterno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(62, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 196);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MODALIDADES DE GRADO II";
            // 
            // DtGridModalidadII
            // 
            this.DtGridModalidadII.AllowUserToAddRows = false;
            this.DtGridModalidadII.AllowUserToDeleteRows = false;
            this.DtGridModalidadII.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGridModalidadII.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_MODALIDAD_II,
            this.ID_CONTRATO,
            this.CI,
            this.PATERNO,
            this.MATERNO,
            this.NOMBRE});
            this.DtGridModalidadII.Location = new System.Drawing.Point(18, 67);
            this.DtGridModalidadII.Name = "DtGridModalidadII";
            this.DtGridModalidadII.ReadOnly = true;
            this.DtGridModalidadII.RowHeadersVisible = false;
            this.DtGridModalidadII.Size = new System.Drawing.Size(608, 113);
            this.DtGridModalidadII.TabIndex = 9;
            this.DtGridModalidadII.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtGridModalidadII_CellMouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CI";
            // 
            // TxtCi
            // 
            this.TxtCi.Location = new System.Drawing.Point(25, 40);
            this.TxtCi.Name = "TxtCi";
            this.TxtCi.Size = new System.Drawing.Size(100, 20);
            this.TxtCi.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "MATERNO";
            // 
            // TxtMaterno
            // 
            this.TxtMaterno.Location = new System.Drawing.Point(252, 39);
            this.TxtMaterno.Name = "TxtMaterno";
            this.TxtMaterno.Size = new System.Drawing.Size(100, 20);
            this.TxtMaterno.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PATERNO";
            // 
            // TxtPaterno
            // 
            this.TxtPaterno.Location = new System.Drawing.Point(135, 39);
            this.TxtPaterno.Name = "TxtPaterno";
            this.TxtPaterno.Size = new System.Drawing.Size(100, 20);
            this.TxtPaterno.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOMBRE";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.GriTutor);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(63, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 97);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TUTOR DEL ESTUDIANTE";
            // 
            // GriTutor
            // 
            this.GriTutor.AllowUserToAddRows = false;
            this.GriTutor.AllowUserToDeleteRows = false;
            this.GriTutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GriTutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CONTRATOT,
            this.CIT,
            this.PATERNOT,
            this.MATERNOT,
            this.NOMBRET});
            this.GriTutor.Location = new System.Drawing.Point(19, 25);
            this.GriTutor.Name = "GriTutor";
            this.GriTutor.ReadOnly = true;
            this.GriTutor.RowHeadersVisible = false;
            this.GriTutor.Size = new System.Drawing.Size(608, 52);
            this.GriTutor.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TxtMaternoTu);
            this.groupBox3.Controls.Add(this.TxtCiTu);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TxtPaternoTu);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TxtNombreTu);
            this.groupBox3.Controls.Add(this.BtnBuscarTutor);
            this.groupBox3.Controls.Add(this.GridContratos);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(17, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(743, 233);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "NUEVO TUTOR PARA EL ESTUDIANTE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "CI";
            // 
            // TxtCiTu
            // 
            this.TxtCiTu.Location = new System.Drawing.Point(25, 55);
            this.TxtCiTu.Name = "TxtCiTu";
            this.TxtCiTu.Size = new System.Drawing.Size(100, 20);
            this.TxtCiTu.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "MATERNO";
            // 
            // TxtMaternoTu
            // 
            this.TxtMaternoTu.Location = new System.Drawing.Point(246, 54);
            this.TxtMaternoTu.Name = "TxtMaternoTu";
            this.TxtMaternoTu.Size = new System.Drawing.Size(100, 20);
            this.TxtMaternoTu.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "PATERNO";
            // 
            // TxtPaternoTu
            // 
            this.TxtPaternoTu.Location = new System.Drawing.Point(131, 54);
            this.TxtPaternoTu.Name = "TxtPaternoTu";
            this.TxtPaternoTu.Size = new System.Drawing.Size(100, 20);
            this.TxtPaternoTu.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "NOMBRE";
            // 
            // TxtNombreTu
            // 
            this.TxtNombreTu.Location = new System.Drawing.Point(363, 55);
            this.TxtNombreTu.Name = "TxtNombreTu";
            this.TxtNombreTu.Size = new System.Drawing.Size(152, 20);
            this.TxtNombreTu.TabIndex = 12;
            // 
            // BtnBuscarTutor
            // 
            this.BtnBuscarTutor.Location = new System.Drawing.Point(525, 52);
            this.BtnBuscarTutor.Name = "BtnBuscarTutor";
            this.BtnBuscarTutor.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarTutor.TabIndex = 11;
            this.BtnBuscarTutor.Text = "BUSCAR";
            this.BtnBuscarTutor.UseVisualStyleBackColor = true;
            this.BtnBuscarTutor.Click += new System.EventHandler(this.BtnBuscarTutor_Click);
            // 
            // GridContratos
            // 
            this.GridContratos.AllowUserToAddRows = false;
            this.GridContratos.AllowUserToDeleteRows = false;
            this.GridContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridContratos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CONTRATOC,
            this.CIC,
            this.PATERNOC,
            this.MATERNOC,
            this.NOMBREC,
            this.NRO_TUTORIAS});
            this.GridContratos.Enabled = false;
            this.GridContratos.Location = new System.Drawing.Point(19, 79);
            this.GridContratos.Name = "GridContratos";
            this.GridContratos.ReadOnly = true;
            this.GridContratos.RowHeadersVisible = false;
            this.GridContratos.Size = new System.Drawing.Size(705, 139);
            this.GridContratos.TabIndex = 10;
            this.GridContratos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridContratos_CellMouseDoubleClick);
            // 
            // BtnCambiarTribunal
            // 
            this.BtnCambiarTribunal.Location = new System.Drawing.Point(320, 631);
            this.BtnCambiarTribunal.Name = "BtnCambiarTribunal";
            this.BtnCambiarTribunal.Size = new System.Drawing.Size(137, 33);
            this.BtnCambiarTribunal.TabIndex = 6;
            this.BtnCambiarTribunal.Text = "ACTUALIZAR";
            this.BtnCambiarTribunal.UseVisualStyleBackColor = true;
            this.BtnCambiarTribunal.Click += new System.EventHandler(this.BtnCambiarTribunal_Click);
            // 
            // ID_MODALIDAD_II
            // 
            this.ID_MODALIDAD_II.HeaderText = "ID_MODALIDAD_II";
            this.ID_MODALIDAD_II.Name = "ID_MODALIDAD_II";
            this.ID_MODALIDAD_II.ReadOnly = true;
            this.ID_MODALIDAD_II.Visible = false;
            // 
            // ID_CONTRATO
            // 
            this.ID_CONTRATO.HeaderText = "ID_CONTRATO";
            this.ID_CONTRATO.Name = "ID_CONTRATO";
            this.ID_CONTRATO.ReadOnly = true;
            this.ID_CONTRATO.Visible = false;
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
            // ID_CONTRATOT
            // 
            this.ID_CONTRATOT.HeaderText = "ID_CONTRATO";
            this.ID_CONTRATOT.Name = "ID_CONTRATOT";
            this.ID_CONTRATOT.ReadOnly = true;
            this.ID_CONTRATOT.Visible = false;
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
            this.NOMBRET.Width = 200;
            // 
            // ID_CONTRATOC
            // 
            this.ID_CONTRATOC.HeaderText = "ID_CONTRATO";
            this.ID_CONTRATOC.Name = "ID_CONTRATOC";
            this.ID_CONTRATOC.ReadOnly = true;
            this.ID_CONTRATOC.Visible = false;
            // 
            // CIC
            // 
            this.CIC.HeaderText = "CI";
            this.CIC.Name = "CIC";
            this.CIC.ReadOnly = true;
            // 
            // PATERNOC
            // 
            this.PATERNOC.HeaderText = "PATERNO";
            this.PATERNOC.Name = "PATERNOC";
            this.PATERNOC.ReadOnly = true;
            this.PATERNOC.Width = 150;
            // 
            // MATERNOC
            // 
            this.MATERNOC.HeaderText = "MATERNO";
            this.MATERNOC.Name = "MATERNOC";
            this.MATERNOC.ReadOnly = true;
            this.MATERNOC.Width = 150;
            // 
            // NOMBREC
            // 
            this.NOMBREC.HeaderText = "NOMBRE";
            this.NOMBREC.Name = "NOMBREC";
            this.NOMBREC.ReadOnly = true;
            this.NOMBREC.Width = 200;
            // 
            // NRO_TUTORIAS
            // 
            this.NRO_TUTORIAS.HeaderText = "NRO_TUTORIAS";
            this.NRO_TUTORIAS.Name = "NRO_TUTORIAS";
            this.NRO_TUTORIAS.ReadOnly = true;
            // 
            // ActualizarModalidadII
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 672);
            this.Controls.Add(this.BtnCambiarTribunal);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ActualizarModalidadII";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACTUALIZAR MODALIDAD II";
            this.Load += new System.EventHandler(this.ActualizarModalidadII_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridModalidadII)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GriTutor)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridContratos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DtGridModalidadII;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMaterno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPaterno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GriTutor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView GridContratos;
        private System.Windows.Forms.Button BtnCambiarTribunal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCiTu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtMaternoTu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPaternoTu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtNombreTu;
        private System.Windows.Forms.Button BtnBuscarTutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MODALIDAD_II;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CONTRATOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATERNOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERNOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRET;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CONTRATOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATERNOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERNOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBREC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRO_TUTORIAS;
    }
}