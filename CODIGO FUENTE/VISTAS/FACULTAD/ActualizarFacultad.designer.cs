namespace VISTAS.FACULTAD
{
    partial class ActualizarFacultad
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
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtFacultadModif = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GrdFacultad = new System.Windows.Forms.DataGridView();
            this.id_facultad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbinactivo = new System.Windows.Forms.RadioButton();
            this.rdbactivo = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbinactivomod = new System.Windows.Forms.RadioButton();
            this.rdbactivomod = new System.Windows.Forms.RadioButton();
            this.LblId = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdFacultad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(149, 130);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(111, 30);
            this.BtnModificar.TabIndex = 23;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnBuscar.Location = new System.Drawing.Point(207, 51);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(111, 30);
            this.BtnBuscar.TabIndex = 22;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtFacultadModif
            // 
            this.TxtFacultadModif.Location = new System.Drawing.Point(123, 20);
            this.TxtFacultadModif.Name = "TxtFacultadModif";
            this.TxtFacultadModif.Size = new System.Drawing.Size(180, 20);
            this.TxtFacultadModif.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "FACULTAD";
            // 
            // GrdFacultad
            // 
            this.GrdFacultad.AllowUserToAddRows = false;
            this.GrdFacultad.AllowUserToDeleteRows = false;
            this.GrdFacultad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdFacultad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_facultad,
            this.facultad,
            this.estado});
            this.GrdFacultad.Location = new System.Drawing.Point(48, 161);
            this.GrdFacultad.Name = "GrdFacultad";
            this.GrdFacultad.ReadOnly = true;
            this.GrdFacultad.RowHeadersVisible = false;
            this.GrdFacultad.Size = new System.Drawing.Size(384, 132);
            this.GrdFacultad.TabIndex = 17;
            this.GrdFacultad.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GrdFacultad_CellMouseDoubleClick);
            // 
            // id_facultad
            // 
            this.id_facultad.DataPropertyName = "id_facultad";
            this.id_facultad.HeaderText = "id_facultad";
            this.id_facultad.Name = "id_facultad";
            this.id_facultad.ReadOnly = true;
            this.id_facultad.Visible = false;
            // 
            // facultad
            // 
            this.facultad.DataPropertyName = "facultad";
            this.facultad.HeaderText = "facultad";
            this.facultad.Name = "facultad";
            this.facultad.ReadOnly = true;
            this.facultad.Width = 300;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(48, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 143);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR  POR FACULTAD:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbinactivo);
            this.groupBox4.Controls.Add(this.rdbactivo);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(14, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(136, 70);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ESTADO";
            // 
            // rdbinactivo
            // 
            this.rdbinactivo.AutoSize = true;
            this.rdbinactivo.Location = new System.Drawing.Point(22, 46);
            this.rdbinactivo.Name = "rdbinactivo";
            this.rdbinactivo.Size = new System.Drawing.Size(78, 19);
            this.rdbinactivo.TabIndex = 1;
            this.rdbinactivo.Text = "INACTIVO";
            this.rdbinactivo.UseVisualStyleBackColor = true;
            // 
            // rdbactivo
            // 
            this.rdbactivo.AutoSize = true;
            this.rdbactivo.Checked = true;
            this.rdbactivo.Location = new System.Drawing.Point(22, 21);
            this.rdbactivo.Name = "rdbactivo";
            this.rdbactivo.Size = new System.Drawing.Size(66, 19);
            this.rdbactivo.TabIndex = 0;
            this.rdbactivo.TabStop = true;
            this.rdbactivo.Text = "ACTIVO";
            this.rdbactivo.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.rdbinactivomod);
            this.groupBox3.Controls.Add(this.rdbactivomod);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(34, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 65);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ESTADO";
            // 
            // rdbinactivomod
            // 
            this.rdbinactivomod.AutoSize = true;
            this.rdbinactivomod.Location = new System.Drawing.Point(22, 46);
            this.rdbinactivomod.Name = "rdbinactivomod";
            this.rdbinactivomod.Size = new System.Drawing.Size(75, 17);
            this.rdbinactivomod.TabIndex = 1;
            this.rdbinactivomod.TabStop = true;
            this.rdbinactivomod.Text = "INACTIVO";
            this.rdbinactivomod.UseVisualStyleBackColor = true;
            // 
            // rdbactivomod
            // 
            this.rdbactivomod.AutoSize = true;
            this.rdbactivomod.Location = new System.Drawing.Point(22, 21);
            this.rdbactivomod.Name = "rdbactivomod";
            this.rdbactivomod.Size = new System.Drawing.Size(64, 17);
            this.rdbactivomod.TabIndex = 0;
            this.rdbactivomod.TabStop = true;
            this.rdbactivomod.Text = "ACTIVO";
            this.rdbactivomod.UseVisualStyleBackColor = true;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.BackColor = System.Drawing.Color.Transparent;
            this.LblId.Location = new System.Drawing.Point(260, 21);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(0, 13);
            this.LblId.TabIndex = 24;
            this.LblId.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.LblId);
            this.groupBox2.Controls.Add(this.BtnModificar);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.TxtFacultadModif);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(50, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 176);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS A MODIFICAR DE LA FACULTAD";
            // 
            // ActualizarFacultad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(478, 485);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GrdFacultad);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ActualizarFacultad";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACTUALIZAR FACULTAD";
            this.Load += new System.EventHandler(this.ActualizarFacultad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdFacultad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtFacultadModif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GrdFacultad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdbinactivo;
        private System.Windows.Forms.RadioButton rdbactivo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbinactivomod;
        private System.Windows.Forms.RadioButton rdbactivomod;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_facultad;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultad;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}