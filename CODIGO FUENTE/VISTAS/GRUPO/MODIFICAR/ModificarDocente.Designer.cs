namespace VISTAS.GRUPO.MODIFICAR
{
    partial class ModificarDocente
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnFiltrarDocente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMaterno = new System.Windows.Forms.TextBox();
            this.TxtPaterno = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.DtgvContratos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtMaternoRe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPaternoRe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNombreRe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCiRe = new System.Windows.Forms.TextBox();
            this.BtnModificarDocente = new System.Windows.Forms.Button();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CONTRATOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AP_PATERNOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AP_MATERNOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvContratos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.BtnFiltrarDocente);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtNombre);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtCi);
            this.groupBox2.Controls.Add(this.TxtMaterno);
            this.groupBox2.Controls.Add(this.TxtPaterno);
            this.groupBox2.Controls.Add(this.DtgvContratos);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(22, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 184);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DOCENTES A SELECCIONAR PARA REEMPLAZO";
            // 
            // BtnFiltrarDocente
            // 
            this.BtnFiltrarDocente.Location = new System.Drawing.Point(478, 36);
            this.BtnFiltrarDocente.Name = "BtnFiltrarDocente";
            this.BtnFiltrarDocente.Size = new System.Drawing.Size(77, 23);
            this.BtnFiltrarDocente.TabIndex = 12;
            this.BtnFiltrarDocente.Text = "FILTRAR";
            this.BtnFiltrarDocente.UseVisualStyleBackColor = true;
            this.BtnFiltrarDocente.Click += new System.EventHandler(this.BtnFiltrarDocente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "CI/DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "MATERNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "PATERNO";
            // 
            // TxtCi
            // 
            this.TxtCi.Location = new System.Drawing.Point(16, 38);
            this.TxtCi.Name = "TxtCi";
            this.TxtCi.Size = new System.Drawing.Size(93, 20);
            this.TxtCi.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "NOMBRE";
            // 
            // TxtMaterno
            // 
            this.TxtMaterno.Location = new System.Drawing.Point(236, 39);
            this.TxtMaterno.Name = "TxtMaterno";
            this.TxtMaterno.Size = new System.Drawing.Size(114, 20);
            this.TxtMaterno.TabIndex = 5;
            // 
            // TxtPaterno
            // 
            this.TxtPaterno.Location = new System.Drawing.Point(115, 38);
            this.TxtPaterno.Name = "TxtPaterno";
            this.TxtPaterno.Size = new System.Drawing.Size(114, 20);
            this.TxtPaterno.TabIndex = 4;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(356, 39);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(114, 20);
            this.TxtNombre.TabIndex = 3;
            // 
            // DtgvContratos
            // 
            this.DtgvContratos.AllowUserToAddRows = false;
            this.DtgvContratos.AllowUserToDeleteRows = false;
            this.DtgvContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvContratos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.ID_CONTRATOD,
            this.AP_PATERNOD,
            this.AP_MATERNOD,
            this.NOMBRED});
            this.DtgvContratos.Location = new System.Drawing.Point(15, 65);
            this.DtgvContratos.Name = "DtgvContratos";
            this.DtgvContratos.ReadOnly = true;
            this.DtgvContratos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgvContratos.RowHeadersVisible = false;
            this.DtgvContratos.Size = new System.Drawing.Size(539, 102);
            this.DtgvContratos.TabIndex = 2;
            this.DtgvContratos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgvContratos_CellMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtMaternoRe);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtNombreRe);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtPaternoRe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtCiRe);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(22, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 83);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL DOCENTE ACTUAL DEL GRUPO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "AP. MATERNO";
            // 
            // TxtMaternoRe
            // 
            this.TxtMaternoRe.Location = new System.Drawing.Point(271, 43);
            this.TxtMaternoRe.Name = "TxtMaternoRe";
            this.TxtMaternoRe.ReadOnly = true;
            this.TxtMaternoRe.Size = new System.Drawing.Size(125, 20);
            this.TxtMaternoRe.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "AP. PATERNO";
            // 
            // TxtPaternoRe
            // 
            this.TxtPaternoRe.Location = new System.Drawing.Point(120, 43);
            this.TxtPaternoRe.Name = "TxtPaternoRe";
            this.TxtPaternoRe.ReadOnly = true;
            this.TxtPaternoRe.Size = new System.Drawing.Size(125, 20);
            this.TxtPaternoRe.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "NOMBRE";
            // 
            // TxtNombreRe
            // 
            this.TxtNombreRe.Location = new System.Drawing.Point(413, 42);
            this.TxtNombreRe.Name = "TxtNombreRe";
            this.TxtNombreRe.ReadOnly = true;
            this.TxtNombreRe.Size = new System.Drawing.Size(148, 20);
            this.TxtNombreRe.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CI";
            // 
            // TxtCiRe
            // 
            this.TxtCiRe.Location = new System.Drawing.Point(6, 43);
            this.TxtCiRe.Name = "TxtCiRe";
            this.TxtCiRe.ReadOnly = true;
            this.TxtCiRe.Size = new System.Drawing.Size(100, 20);
            this.TxtCiRe.TabIndex = 0;
            // 
            // BtnModificarDocente
            // 
            this.BtnModificarDocente.Location = new System.Drawing.Point(235, 336);
            this.BtnModificarDocente.Name = "BtnModificarDocente";
            this.BtnModificarDocente.Size = new System.Drawing.Size(143, 35);
            this.BtnModificarDocente.TabIndex = 6;
            this.BtnModificarDocente.Text = "REALIZAR CAMBIO DE DOCENTE";
            this.BtnModificarDocente.UseVisualStyleBackColor = true;
            this.BtnModificarDocente.Click += new System.EventHandler(this.BtnModificarDocente_Click);
            // 
            // CID
            // 
            this.CID.HeaderText = "CI";
            this.CID.Name = "CID";
            this.CID.ReadOnly = true;
            this.CID.Width = 120;
            // 
            // ID_CONTRATOD
            // 
            this.ID_CONTRATOD.HeaderText = "id_contrato";
            this.ID_CONTRATOD.Name = "ID_CONTRATOD";
            this.ID_CONTRATOD.ReadOnly = true;
            this.ID_CONTRATOD.Visible = false;
            // 
            // AP_PATERNOD
            // 
            this.AP_PATERNOD.HeaderText = "AP. PATERNO";
            this.AP_PATERNOD.Name = "AP_PATERNOD";
            this.AP_PATERNOD.ReadOnly = true;
            this.AP_PATERNOD.Width = 120;
            // 
            // AP_MATERNOD
            // 
            this.AP_MATERNOD.HeaderText = "AP. MATERNO";
            this.AP_MATERNOD.Name = "AP_MATERNOD";
            this.AP_MATERNOD.ReadOnly = true;
            this.AP_MATERNOD.Width = 120;
            // 
            // NOMBRED
            // 
            this.NOMBRED.HeaderText = "NOMBRE";
            this.NOMBRED.Name = "NOMBRED";
            this.NOMBRED.ReadOnly = true;
            this.NOMBRED.Width = 180;
            // 
            // ModificarDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 383);
            this.Controls.Add(this.BtnModificarDocente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificarDocente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODIFICAR DOCENTE PARA EL GRUPO";
            this.Load += new System.EventHandler(this.ModificarDocente_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvContratos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnFiltrarDocente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMaterno;
        private System.Windows.Forms.TextBox TxtPaterno;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.DataGridView DtgvContratos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtMaternoRe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPaternoRe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNombreRe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCiRe;
        private System.Windows.Forms.Button BtnModificarDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CONTRATOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn AP_PATERNOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn AP_MATERNOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRED;
    }
}