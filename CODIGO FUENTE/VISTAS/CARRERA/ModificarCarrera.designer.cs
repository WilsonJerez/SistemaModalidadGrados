namespace VISTAS.CARRERA
{
    partial class ModificarCarrera
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
            this.gvcarrera = new System.Windows.Forms.DataGridView();
            this.carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_facultad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcarreramodif = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbinactivomod = new System.Windows.Forms.RadioButton();
            this.rdbactivomod = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbinactivo = new System.Windows.Forms.RadioButton();
            this.rdbactivo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvcarrera)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvcarrera
            // 
            this.gvcarrera.AllowUserToAddRows = false;
            this.gvcarrera.AllowUserToDeleteRows = false;
            this.gvcarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvcarrera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carrera,
            this.estado,
            this.id_carrera,
            this.id_facultad});
            this.gvcarrera.Location = new System.Drawing.Point(78, 73);
            this.gvcarrera.Name = "gvcarrera";
            this.gvcarrera.ReadOnly = true;
            this.gvcarrera.RowHeadersVisible = false;
            this.gvcarrera.Size = new System.Drawing.Size(355, 132);
            this.gvcarrera.TabIndex = 9;
            this.gvcarrera.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvcarrera_CellMouseDoubleClick);
            // 
            // carrera
            // 
            this.carrera.HeaderText = "carrera";
            this.carrera.Name = "carrera";
            this.carrera.ReadOnly = true;
            this.carrera.Width = 250;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // id_carrera
            // 
            this.id_carrera.HeaderText = "id_carrera";
            this.id_carrera.Name = "id_carrera";
            this.id_carrera.ReadOnly = true;
            this.id_carrera.Visible = false;
            // 
            // id_facultad
            // 
            this.id_facultad.HeaderText = "id_facultad";
            this.id_facultad.Name = "id_facultad";
            this.id_facultad.ReadOnly = true;
            this.id_facultad.Visible = false;
            // 
            // txtcarreramodif
            // 
            this.txtcarreramodif.Location = new System.Drawing.Point(119, 39);
            this.txtcarreramodif.Name = "txtcarreramodif";
            this.txtcarreramodif.Size = new System.Drawing.Size(180, 20);
            this.txtcarreramodif.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "CARRERA";
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(217, 85);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(111, 30);
            this.btnmodificar.TabIndex = 15;
            this.btnmodificar.Text = "MODIFICAR";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rdbinactivomod);
            this.groupBox2.Controls.Add(this.rdbactivomod);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(318, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 48);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ESTADO";
            // 
            // rdbinactivomod
            // 
            this.rdbinactivomod.AutoSize = true;
            this.rdbinactivomod.Location = new System.Drawing.Point(101, 21);
            this.rdbinactivomod.Name = "rdbinactivomod";
            this.rdbinactivomod.Size = new System.Drawing.Size(75, 17);
            this.rdbinactivomod.TabIndex = 1;
            this.rdbinactivomod.Text = "INACTIVO";
            this.rdbinactivomod.UseVisualStyleBackColor = true;
            // 
            // rdbactivomod
            // 
            this.rdbactivomod.AutoSize = true;
            this.rdbactivomod.Checked = true;
            this.rdbactivomod.Location = new System.Drawing.Point(22, 21);
            this.rdbactivomod.Name = "rdbactivomod";
            this.rdbactivomod.Size = new System.Drawing.Size(64, 17);
            this.rdbactivomod.TabIndex = 0;
            this.rdbactivomod.TabStop = true;
            this.rdbactivomod.Text = "ACTIVO";
            this.rdbactivomod.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.btnmodificar);
            this.groupBox3.Controls.Add(this.txtcarreramodif);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(11, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(559, 128);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MODIFICAR CARRERA:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(322, 30);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(111, 30);
            this.btnbuscar.TabIndex = 14;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbinactivo);
            this.groupBox4.Controls.Add(this.rdbactivo);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(78, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(236, 52);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ESTADO";
            // 
            // rdbinactivo
            // 
            this.rdbinactivo.AutoSize = true;
            this.rdbinactivo.Location = new System.Drawing.Point(121, 21);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.gvcarrera);
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(11, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 227);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR CARRERA POR:";
            // 
            // ModificarCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 382);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificarCarrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarCarrera";
            ((System.ComponentModel.ISupportInitialize)(this.gvcarrera)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvcarrera;
        private System.Windows.Forms.TextBox txtcarreramodif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbinactivomod;
        private System.Windows.Forms.RadioButton rdbactivomod;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdbinactivo;
        private System.Windows.Forms.RadioButton rdbactivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_facultad;
    }
}