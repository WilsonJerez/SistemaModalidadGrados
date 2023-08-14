namespace VISTAS.MODALIDAD_II
{
    partial class RegistrarModalidadII
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
            this.GridEstudiantes = new System.Windows.Forms.DataGridView();
            this.TxtMaternoEst = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPaternoEst = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombreEst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCiEst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFiltrarEst = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtMaternoTuS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPaternoTuS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNombreTuS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCiTuS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnFiltrarTuS = new System.Windows.Forms.Button();
            this.GridTutores = new System.Windows.Forms.DataGridView();
            this.BtnAñadir = new System.Windows.Forms.Button();
            this.ID_MODALIDAD_IE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATERNOE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERNOE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBREE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEMAE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_MODALIDAD_I = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CONTRATOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRO_TUTORIAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATERNOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERNOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBREC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEstudiantes)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTutores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.GridEstudiantes);
            this.groupBox1.Controls.Add(this.TxtMaternoEst);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtPaternoEst);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtNombreEst);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtCiEst);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnFiltrarEst);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 205);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ESTUDIANTES  HABILITADOS";
            // 
            // GridEstudiantes
            // 
            this.GridEstudiantes.AllowUserToAddRows = false;
            this.GridEstudiantes.AllowUserToDeleteRows = false;
            this.GridEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_MODALIDAD_IE,
            this.CIE,
            this.PATERNOE,
            this.MATERNOE,
            this.NOMBREE,
            this.TEMAE,
            this.TIPO_MODALIDAD_I});
            this.GridEstudiantes.Location = new System.Drawing.Point(21, 72);
            this.GridEstudiantes.Name = "GridEstudiantes";
            this.GridEstudiantes.ReadOnly = true;
            this.GridEstudiantes.RowHeadersVisible = false;
            this.GridEstudiantes.Size = new System.Drawing.Size(764, 114);
            this.GridEstudiantes.TabIndex = 10;
            this.GridEstudiantes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridEstudiantes_CellMouseDoubleClick);
            // 
            // TxtMaternoEst
            // 
            this.TxtMaternoEst.Location = new System.Drawing.Point(262, 43);
            this.TxtMaternoEst.Name = "TxtMaternoEst";
            this.TxtMaternoEst.Size = new System.Drawing.Size(100, 20);
            this.TxtMaternoEst.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "MATERNO";
            // 
            // TxtPaternoEst
            // 
            this.TxtPaternoEst.Location = new System.Drawing.Point(141, 43);
            this.TxtPaternoEst.Name = "TxtPaternoEst";
            this.TxtPaternoEst.Size = new System.Drawing.Size(100, 20);
            this.TxtPaternoEst.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "PATERNO";
            // 
            // TxtNombreEst
            // 
            this.TxtNombreEst.Location = new System.Drawing.Point(382, 43);
            this.TxtNombreEst.Name = "TxtNombreEst";
            this.TxtNombreEst.Size = new System.Drawing.Size(100, 20);
            this.TxtNombreEst.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOMBRE";
            // 
            // TxtCiEst
            // 
            this.TxtCiEst.Location = new System.Drawing.Point(24, 43);
            this.TxtCiEst.Name = "TxtCiEst";
            this.TxtCiEst.Size = new System.Drawing.Size(100, 20);
            this.TxtCiEst.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "CI";
            // 
            // BtnFiltrarEst
            // 
            this.BtnFiltrarEst.BackColor = System.Drawing.SystemColors.Control;
            this.BtnFiltrarEst.Location = new System.Drawing.Point(511, 41);
            this.BtnFiltrarEst.Name = "BtnFiltrarEst";
            this.BtnFiltrarEst.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltrarEst.TabIndex = 1;
            this.BtnFiltrarEst.Text = "FILTRAR";
            this.BtnFiltrarEst.UseVisualStyleBackColor = false;
            this.BtnFiltrarEst.Click += new System.EventHandler(this.BtnFiltrarEst_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.TxtMaternoTuS);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtPaternoTuS);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtNombreTuS);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtCiTuS);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.BtnFiltrarTuS);
            this.groupBox2.Controls.Add(this.GridTutores);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(796, 200);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TUTORES SIN TUTORIAS";
            // 
            // TxtMaternoTuS
            // 
            this.TxtMaternoTuS.Location = new System.Drawing.Point(262, 43);
            this.TxtMaternoTuS.Name = "TxtMaternoTuS";
            this.TxtMaternoTuS.Size = new System.Drawing.Size(100, 20);
            this.TxtMaternoTuS.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(261, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "MATERNO";
            // 
            // TxtPaternoTuS
            // 
            this.TxtPaternoTuS.Location = new System.Drawing.Point(141, 43);
            this.TxtPaternoTuS.Name = "TxtPaternoTuS";
            this.TxtPaternoTuS.Size = new System.Drawing.Size(100, 20);
            this.TxtPaternoTuS.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(141, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "PATERNO";
            // 
            // TxtNombreTuS
            // 
            this.TxtNombreTuS.Location = new System.Drawing.Point(382, 41);
            this.TxtNombreTuS.Name = "TxtNombreTuS";
            this.TxtNombreTuS.Size = new System.Drawing.Size(100, 20);
            this.TxtNombreTuS.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(384, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "NOMBRE";
            // 
            // TxtCiTuS
            // 
            this.TxtCiTuS.Location = new System.Drawing.Point(24, 43);
            this.TxtCiTuS.Name = "TxtCiTuS";
            this.TxtCiTuS.Size = new System.Drawing.Size(100, 20);
            this.TxtCiTuS.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "CI";
            // 
            // BtnFiltrarTuS
            // 
            this.BtnFiltrarTuS.BackColor = System.Drawing.SystemColors.Control;
            this.BtnFiltrarTuS.Location = new System.Drawing.Point(512, 41);
            this.BtnFiltrarTuS.Name = "BtnFiltrarTuS";
            this.BtnFiltrarTuS.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltrarTuS.TabIndex = 1;
            this.BtnFiltrarTuS.Text = "FILTRAR";
            this.BtnFiltrarTuS.UseVisualStyleBackColor = false;
            this.BtnFiltrarTuS.Click += new System.EventHandler(this.BtnFiltrarTuS_Click);
            // 
            // GridTutores
            // 
            this.GridTutores.AllowUserToAddRows = false;
            this.GridTutores.AllowUserToDeleteRows = false;
            this.GridTutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CONTRATOC,
            this.NRO_TUTORIAS,
            this.CIC,
            this.PATERNOC,
            this.MATERNOC,
            this.NOMBREC});
            this.GridTutores.Enabled = false;
            this.GridTutores.Location = new System.Drawing.Point(21, 72);
            this.GridTutores.Name = "GridTutores";
            this.GridTutores.ReadOnly = true;
            this.GridTutores.RowHeadersVisible = false;
            this.GridTutores.Size = new System.Drawing.Size(764, 119);
            this.GridTutores.TabIndex = 0;
            this.GridTutores.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridTutores_CellMouseDoubleClick);
            // 
            // BtnAñadir
            // 
            this.BtnAñadir.Enabled = false;
            this.BtnAñadir.Location = new System.Drawing.Point(369, 438);
            this.BtnAñadir.Name = "BtnAñadir";
            this.BtnAñadir.Size = new System.Drawing.Size(111, 34);
            this.BtnAñadir.TabIndex = 7;
            this.BtnAñadir.Text = "REGISTRAR";
            this.BtnAñadir.UseVisualStyleBackColor = true;
            this.BtnAñadir.Click += new System.EventHandler(this.BtnAñadir_Click);
            // 
            // ID_MODALIDAD_IE
            // 
            this.ID_MODALIDAD_IE.HeaderText = "ID_MODALIDAD_I";
            this.ID_MODALIDAD_IE.Name = "ID_MODALIDAD_IE";
            this.ID_MODALIDAD_IE.ReadOnly = true;
            this.ID_MODALIDAD_IE.Visible = false;
            // 
            // CIE
            // 
            this.CIE.HeaderText = "CI";
            this.CIE.Name = "CIE";
            this.CIE.ReadOnly = true;
            // 
            // PATERNOE
            // 
            this.PATERNOE.HeaderText = "PATERNO";
            this.PATERNOE.Name = "PATERNOE";
            this.PATERNOE.ReadOnly = true;
            this.PATERNOE.Width = 200;
            // 
            // MATERNOE
            // 
            this.MATERNOE.HeaderText = "MATERNO";
            this.MATERNOE.Name = "MATERNOE";
            this.MATERNOE.ReadOnly = true;
            this.MATERNOE.Width = 200;
            // 
            // NOMBREE
            // 
            this.NOMBREE.HeaderText = "NOMBRE";
            this.NOMBREE.Name = "NOMBREE";
            this.NOMBREE.ReadOnly = true;
            this.NOMBREE.Width = 200;
            // 
            // TEMAE
            // 
            this.TEMAE.HeaderText = "TEMA";
            this.TEMAE.Name = "TEMAE";
            this.TEMAE.ReadOnly = true;
            this.TEMAE.Width = 300;
            // 
            // TIPO_MODALIDAD_I
            // 
            this.TIPO_MODALIDAD_I.HeaderText = "TIPO DE MODALIDAD";
            this.TIPO_MODALIDAD_I.Name = "TIPO_MODALIDAD_I";
            this.TIPO_MODALIDAD_I.ReadOnly = true;
            this.TIPO_MODALIDAD_I.Width = 200;
            // 
            // ID_CONTRATOC
            // 
            this.ID_CONTRATOC.HeaderText = "ID_CONTRATO";
            this.ID_CONTRATOC.Name = "ID_CONTRATOC";
            this.ID_CONTRATOC.ReadOnly = true;
            this.ID_CONTRATOC.Visible = false;
            // 
            // NRO_TUTORIAS
            // 
            this.NRO_TUTORIAS.HeaderText = "NRO_TUTORIAS";
            this.NRO_TUTORIAS.Name = "NRO_TUTORIAS";
            this.NRO_TUTORIAS.ReadOnly = true;
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
            this.PATERNOC.Width = 200;
            // 
            // MATERNOC
            // 
            this.MATERNOC.HeaderText = "MATERNO";
            this.MATERNOC.Name = "MATERNOC";
            this.MATERNOC.ReadOnly = true;
            this.MATERNOC.Width = 200;
            // 
            // NOMBREC
            // 
            this.NOMBREC.HeaderText = "NOMBRE";
            this.NOMBREC.Name = "NOMBREC";
            this.NOMBREC.ReadOnly = true;
            this.NOMBREC.Width = 200;
            // 
            // RegistrarModalidadII
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 506);
            this.Controls.Add(this.BtnAñadir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "RegistrarModalidadII";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INSERTAR ESTUDIANTE MODALIDAD DE GRADO II";
            this.Load += new System.EventHandler(this.RegistrarModalidadII_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEstudiantes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTutores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtNombreEst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCiEst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFiltrarEst;
        private System.Windows.Forms.TextBox TxtMaternoEst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPaternoEst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtMaternoTuS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPaternoTuS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNombreTuS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtCiTuS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnFiltrarTuS;
        private System.Windows.Forms.DataGridView GridTutores;
        private System.Windows.Forms.DataGridView GridEstudiantes;
        private System.Windows.Forms.Button BtnAñadir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MODALIDAD_IE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATERNOE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERNOE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBREE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMAE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_MODALIDAD_I;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CONTRATOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRO_TUTORIAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATERNOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERNOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBREC;
    }
}