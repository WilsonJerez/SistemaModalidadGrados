namespace VISTAS.AULA
{
    partial class ModificarAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarAula));
            this.CmbPiso = new System.Windows.Forms.ComboBox();
            this.TxtN_Aula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbinactivo = new System.Windows.Forms.RadioButton();
            this.rdbactivo = new System.Windows.Forms.RadioButton();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.gvaulas = new System.Windows.Forms.DataGridView();
            this.n_aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcapacidadmodif = new System.Windows.Forms.TextBox();
            this.cmbpisocmodif = new System.Windows.Forms.ComboBox();
            this.txtn_aulamodif = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbinactivomod = new System.Windows.Forms.RadioButton();
            this.rdbactivomod = new System.Windows.Forms.RadioButton();
            this.lblid = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvaulas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmbPiso
            // 
            this.CmbPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPiso.FormattingEnabled = true;
            this.CmbPiso.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CmbPiso.Location = new System.Drawing.Point(84, 37);
            this.CmbPiso.Name = "CmbPiso";
            this.CmbPiso.Size = new System.Drawing.Size(145, 21);
            this.CmbPiso.TabIndex = 10;
            this.CmbPiso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbPiso_KeyDown);
            // 
            // TxtN_Aula
            // 
            this.TxtN_Aula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtN_Aula.Location = new System.Drawing.Point(84, 71);
            this.TxtN_Aula.Name = "TxtN_Aula";
            this.TxtN_Aula.Size = new System.Drawing.Size(145, 20);
            this.TxtN_Aula.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "PISO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nº AULA";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.CmbPiso);
            this.groupBox1.Controls.Add(this.gvaulas);
            this.groupBox1.Controls.Add(this.TxtN_Aula);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 263);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR AULA POR:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbinactivo);
            this.groupBox4.Controls.Add(this.rdbactivo);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(21, 113);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(136, 86);
            this.groupBox4.TabIndex = 22;
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
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(239, 98);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(87, 27);
            this.btnbuscar.TabIndex = 21;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // gvaulas
            // 
            this.gvaulas.AllowUserToAddRows = false;
            this.gvaulas.AllowUserToDeleteRows = false;
            this.gvaulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvaulas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n_aula,
            this.disponible,
            this.piso,
            this.id_aula,
            this.capacidad,
            this.estado});
            this.gvaulas.Location = new System.Drawing.Point(347, 40);
            this.gvaulas.Name = "gvaulas";
            this.gvaulas.ReadOnly = true;
            this.gvaulas.Size = new System.Drawing.Size(342, 170);
            this.gvaulas.TabIndex = 12;
            this.gvaulas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvaulas_CellMouseDoubleClick);
            this.gvaulas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvaulas_CellContentClick);
            // 
            // n_aula
            // 
            this.n_aula.HeaderText = "Nº AULA";
            this.n_aula.Name = "n_aula";
            this.n_aula.ReadOnly = true;
            // 
            // disponible
            // 
            this.disponible.HeaderText = "disponible";
            this.disponible.Name = "disponible";
            this.disponible.ReadOnly = true;
            this.disponible.Visible = false;
            // 
            // piso
            // 
            this.piso.HeaderText = "PISO";
            this.piso.Name = "piso";
            this.piso.ReadOnly = true;
            // 
            // id_aula
            // 
            this.id_aula.HeaderText = "Id_Aula";
            this.id_aula.Name = "id_aula";
            this.id_aula.ReadOnly = true;
            this.id_aula.Visible = false;
            // 
            // capacidad
            // 
            this.capacidad.HeaderText = "CAPACIDAD";
            this.capacidad.Name = "capacidad";
            this.capacidad.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // txtcapacidadmodif
            // 
            this.txtcapacidadmodif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcapacidadmodif.Location = new System.Drawing.Point(134, 105);
            this.txtcapacidadmodif.Name = "txtcapacidadmodif";
            this.txtcapacidadmodif.Size = new System.Drawing.Size(145, 20);
            this.txtcapacidadmodif.TabIndex = 18;
            // 
            // cmbpisocmodif
            // 
            this.cmbpisocmodif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpisocmodif.FormattingEnabled = true;
            this.cmbpisocmodif.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbpisocmodif.Location = new System.Drawing.Point(134, 69);
            this.cmbpisocmodif.Name = "cmbpisocmodif";
            this.cmbpisocmodif.Size = new System.Drawing.Size(145, 21);
            this.cmbpisocmodif.TabIndex = 17;
            this.cmbpisocmodif.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbpisocmodif_KeyDown);
            // 
            // txtn_aulamodif
            // 
            this.txtn_aulamodif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtn_aulamodif.Location = new System.Drawing.Point(134, 28);
            this.txtn_aulamodif.Name = "txtn_aulamodif";
            this.txtn_aulamodif.Size = new System.Drawing.Size(145, 20);
            this.txtn_aulamodif.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "CAPACIDAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "PISO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nº AULA";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnmodificar);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lblid);
            this.groupBox2.Controls.Add(this.txtcapacidadmodif);
            this.groupBox2.Controls.Add(this.cmbpisocmodif);
            this.groupBox2.Controls.Add(this.txtn_aulamodif);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(39, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 207);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MODIFICAR AULA:";
            // 
            // btnmodificar
            // 
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(293, 158);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(87, 27);
            this.btnmodificar.TabIndex = 20;
            this.btnmodificar.Text = "ACTUALIZAR";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbinactivomod);
            this.groupBox3.Controls.Add(this.rdbactivomod);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(322, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 86);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ESTADO";
            // 
            // rdbinactivomod
            // 
            this.rdbinactivomod.AutoSize = true;
            this.rdbinactivomod.Location = new System.Drawing.Point(22, 46);
            this.rdbinactivomod.Name = "rdbinactivomod";
            this.rdbinactivomod.Size = new System.Drawing.Size(78, 19);
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
            this.rdbactivomod.Size = new System.Drawing.Size(66, 19);
            this.rdbactivomod.TabIndex = 0;
            this.rdbactivomod.TabStop = true;
            this.rdbactivomod.Text = "ACTIVO";
            this.rdbactivomod.UseVisualStyleBackColor = true;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(290, 50);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(10, 15);
            this.lblid.TabIndex = 19;
            this.lblid.Text = ".";
            this.lblid.Visible = false;
            // 
            // ModificarAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 513);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ModificarAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACTUALIZAR AULA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvaulas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbPiso;
        private System.Windows.Forms.TextBox TxtN_Aula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvaulas;
        private System.Windows.Forms.TextBox txtcapacidadmodif;
        private System.Windows.Forms.ComboBox cmbpisocmodif;
        private System.Windows.Forms.TextBox txtn_aulamodif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbinactivomod;
        private System.Windows.Forms.RadioButton rdbactivomod;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdbinactivo;
        private System.Windows.Forms.RadioButton rdbactivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_aula;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_aula;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}