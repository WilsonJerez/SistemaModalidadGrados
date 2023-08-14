namespace VISTAS.REPORTES.MODALIDAD_II
{
    partial class RepModalidadIIPorTutor
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
            this.BtnGenReporte = new System.Windows.Forms.Button();
            this.GvTutores = new System.Windows.Forms.DataGridView();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.TxtMaterno = new System.Windows.Forms.TextBox();
            this.dd = new System.Windows.Forms.Label();
            this.Txtpaterno = new System.Windows.Forms.TextBox();
            this.dddd = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.ss = new System.Windows.Forms.Label();
            this.TxtCi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CrvPorTutor = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvTutores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BtnGenReporte);
            this.groupBox1.Controls.Add(this.GvTutores);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.dd);
            this.groupBox1.Controls.Add(this.BtnFiltrar);
            this.groupBox1.Controls.Add(this.TxtMaterno);
            this.groupBox1.Controls.Add(this.Txtpaterno);
            this.groupBox1.Controls.Add(this.dddd);
            this.groupBox1.Controls.Add(this.ss);
            this.groupBox1.Controls.Add(this.TxtCi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(96, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECCION DEL TUTOR";
            // 
            // BtnGenReporte
            // 
            this.BtnGenReporte.Location = new System.Drawing.Point(347, 177);
            this.BtnGenReporte.Name = "BtnGenReporte";
            this.BtnGenReporte.Size = new System.Drawing.Size(150, 34);
            this.BtnGenReporte.TabIndex = 2;
            this.BtnGenReporte.Text = "GENERAR REPORTE";
            this.BtnGenReporte.UseVisualStyleBackColor = true;
            this.BtnGenReporte.Click += new System.EventHandler(this.BtnGenReporte_Click);
            // 
            // GvTutores
            // 
            this.GvTutores.AllowUserToAddRows = false;
            this.GvTutores.AllowUserToDeleteRows = false;
            this.GvTutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvTutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CI,
            this.ID_CONTRATO,
            this.PATERNO,
            this.MATERNO,
            this.NOMBRE});
            this.GvTutores.Location = new System.Drawing.Point(65, 74);
            this.GvTutores.Name = "GvTutores";
            this.GvTutores.ReadOnly = true;
            this.GvTutores.RowHeadersVisible = false;
            this.GvTutores.Size = new System.Drawing.Size(705, 97);
            this.GvTutores.TabIndex = 9;
            this.GvTutores.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GvTutores_CellMouseDoubleClick);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(722, 42);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(69, 26);
            this.BtnFiltrar.TabIndex = 8;
            this.BtnFiltrar.Text = "FILTRAR";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click_1);
            // 
            // TxtMaterno
            // 
            this.TxtMaterno.Location = new System.Drawing.Point(366, 46);
            this.TxtMaterno.Name = "TxtMaterno";
            this.TxtMaterno.Size = new System.Drawing.Size(154, 20);
            this.TxtMaterno.TabIndex = 7;
            // 
            // dd
            // 
            this.dd.AutoSize = true;
            this.dd.Location = new System.Drawing.Point(541, 25);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(54, 13);
            this.dd.TabIndex = 6;
            this.dd.Text = "NOMBRE";
            // 
            // Txtpaterno
            // 
            this.Txtpaterno.Location = new System.Drawing.Point(194, 46);
            this.Txtpaterno.Name = "Txtpaterno";
            this.Txtpaterno.Size = new System.Drawing.Size(153, 20);
            this.Txtpaterno.TabIndex = 5;
            // 
            // dddd
            // 
            this.dddd.AutoSize = true;
            this.dddd.Location = new System.Drawing.Point(363, 25);
            this.dddd.Name = "dddd";
            this.dddd.Size = new System.Drawing.Size(81, 13);
            this.dddd.TabIndex = 4;
            this.dddd.Text = "AP. MATERNO";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(544, 46);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(172, 20);
            this.TxtNombre.TabIndex = 3;
            // 
            // ss
            // 
            this.ss.AutoSize = true;
            this.ss.Location = new System.Drawing.Point(191, 25);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(79, 13);
            this.ss.TabIndex = 2;
            this.ss.Text = "AP. PATERNO";
            // 
            // TxtCi
            // 
            this.TxtCi.Location = new System.Drawing.Point(65, 46);
            this.TxtCi.Name = "TxtCi";
            this.TxtCi.Size = new System.Drawing.Size(118, 20);
            this.TxtCi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CI/DNI";
            // 
            // CrvPorTutor
            // 
            this.CrvPorTutor.ActiveViewIndex = -1;
            this.CrvPorTutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvPorTutor.DisplayGroupTree = false;
            this.CrvPorTutor.Location = new System.Drawing.Point(8, 239);
            this.CrvPorTutor.Name = "CrvPorTutor";
            this.CrvPorTutor.SelectionFormula = "";
            this.CrvPorTutor.Size = new System.Drawing.Size(1011, 482);
            this.CrvPorTutor.TabIndex = 1;
            this.CrvPorTutor.ViewTimeSelectionFormula = "";
            // 
            // CI
            // 
            this.CI.HeaderText = "CI";
            this.CI.Name = "CI";
            this.CI.ReadOnly = true;
            // 
            // ID_CONTRATO
            // 
            this.ID_CONTRATO.HeaderText = "Column1";
            this.ID_CONTRATO.Name = "ID_CONTRATO";
            this.ID_CONTRATO.ReadOnly = true;
            this.ID_CONTRATO.Visible = false;
            // 
            // PATERNO
            // 
            this.PATERNO.HeaderText = "AP. PATERNO";
            this.PATERNO.Name = "PATERNO";
            this.PATERNO.ReadOnly = true;
            this.PATERNO.Width = 200;
            // 
            // MATERNO
            // 
            this.MATERNO.HeaderText = "AP. MATERNO";
            this.MATERNO.Name = "MATERNO";
            this.MATERNO.ReadOnly = true;
            this.MATERNO.Width = 200;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            this.NOMBRE.Width = 200;
            // 
            // RepModalidadIIPorTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 724);
            this.Controls.Add(this.CrvPorTutor);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "RepModalidadIIPorTutor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE DE LAS TUTORIAS DE UN TUTOR";
            this.Load += new System.EventHandler(this.RepModalidadIIPorTutor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvTutores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMaterno;
        private System.Windows.Forms.Label dd;
        private System.Windows.Forms.TextBox Txtpaterno;
        private System.Windows.Forms.Label dddd;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label ss;
        private System.Windows.Forms.TextBox TxtCi;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.DataGridView GvTutores;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvPorTutor;
        private System.Windows.Forms.Button BtnGenReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;

    }
}