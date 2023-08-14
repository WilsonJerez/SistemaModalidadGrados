namespace VISTAS.DOCENTE
{
    partial class InsertarDocente
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
            this.CkbSinMail = new System.Windows.Forms.CheckBox();
            this.CkbSinCelular = new System.Windows.Forms.CheckBox();
            this.CkbSinTelefono = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RbtnDni = new System.Windows.Forms.RadioButton();
            this.RbtnCi = new System.Windows.Forms.RadioButton();
            this.Txtci = new System.Windows.Forms.TextBox();
            this.CmbCargos = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtEspecialidad = new System.Windows.Forms.TextBox();
            this.TxtProfesion = new System.Windows.Forms.TextBox();
            this.TxtCurriculum = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtmaterno = new System.Windows.Forms.TextBox();
            this.txtpaterno = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.BtnrGuardar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CkbSinDirecion = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.CkbSinDirecion);
            this.groupBox1.Controls.Add(this.CkbSinMail);
            this.groupBox1.Controls.Add(this.CkbSinCelular);
            this.groupBox1.Controls.Add(this.CkbSinTelefono);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.CmbCargos);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtmail);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.txtcelular);
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Controls.Add(this.txtmaterno);
            this.groupBox1.Controls.Add(this.txtpaterno);
            this.groupBox1.Controls.Add(this.BtnrGuardar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(30, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 613);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS PERSONALES PARA UN ACADEMICO";
            // 
            // CkbSinMail
            // 
            this.CkbSinMail.AutoSize = true;
            this.CkbSinMail.Location = new System.Drawing.Point(318, 326);
            this.CkbSinMail.Name = "CkbSinMail";
            this.CkbSinMail.Size = new System.Drawing.Size(46, 19);
            this.CkbSinMail.TabIndex = 31;
            this.CkbSinMail.Text = "SIN";
            this.CkbSinMail.UseVisualStyleBackColor = true;
            this.CkbSinMail.CheckedChanged += new System.EventHandler(this.CkbSinMail_CheckedChanged);
            // 
            // CkbSinCelular
            // 
            this.CkbSinCelular.AutoSize = true;
            this.CkbSinCelular.Location = new System.Drawing.Point(672, 238);
            this.CkbSinCelular.Name = "CkbSinCelular";
            this.CkbSinCelular.Size = new System.Drawing.Size(46, 19);
            this.CkbSinCelular.TabIndex = 30;
            this.CkbSinCelular.Text = "SIN";
            this.CkbSinCelular.UseVisualStyleBackColor = true;
            this.CkbSinCelular.CheckedChanged += new System.EventHandler(this.CkbSinCelular_CheckedChanged);
            // 
            // CkbSinTelefono
            // 
            this.CkbSinTelefono.AutoSize = true;
            this.CkbSinTelefono.Location = new System.Drawing.Point(318, 237);
            this.CkbSinTelefono.Name = "CkbSinTelefono";
            this.CkbSinTelefono.Size = new System.Drawing.Size(46, 19);
            this.CkbSinTelefono.TabIndex = 29;
            this.CkbSinTelefono.Text = "SIN";
            this.CkbSinTelefono.UseVisualStyleBackColor = true;
            this.CkbSinTelefono.CheckedChanged += new System.EventHandler(this.CkbSinTelefono_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RbtnDni);
            this.groupBox3.Controls.Add(this.RbtnCi);
            this.groupBox3.Controls.Add(this.Txtci);
            this.groupBox3.Location = new System.Drawing.Point(30, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 82);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TIPO IDENTIFICADOR";
            // 
            // RbtnDni
            // 
            this.RbtnDni.AutoSize = true;
            this.RbtnDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnDni.Location = new System.Drawing.Point(20, 54);
            this.RbtnDni.Name = "RbtnDni";
            this.RbtnDni.Size = new System.Drawing.Size(46, 19);
            this.RbtnDni.TabIndex = 27;
            this.RbtnDni.TabStop = true;
            this.RbtnDni.Text = "DNI";
            this.RbtnDni.UseVisualStyleBackColor = true;
            // 
            // RbtnCi
            // 
            this.RbtnCi.AutoSize = true;
            this.RbtnCi.Checked = true;
            this.RbtnCi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnCi.Location = new System.Drawing.Point(20, 26);
            this.RbtnCi.Name = "RbtnCi";
            this.RbtnCi.Size = new System.Drawing.Size(36, 19);
            this.RbtnCi.TabIndex = 26;
            this.RbtnCi.TabStop = true;
            this.RbtnCi.Text = "CI";
            this.RbtnCi.UseVisualStyleBackColor = true;
            // 
            // Txtci
            // 
            this.Txtci.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtci.Location = new System.Drawing.Point(103, 39);
            this.Txtci.Name = "Txtci";
            this.Txtci.Size = new System.Drawing.Size(216, 22);
            this.Txtci.TabIndex = 10;
            // 
            // CmbCargos
            // 
            this.CmbCargos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCargos.Items.AddRange(new object[] {
            "TARIJA",
            "POTOSI",
            "LA PAZ",
            "COCHABAMBA",
            "SANTA CRUZ",
            "PANDO",
            "SUCRE",
            "ORURO"});
            this.CmbCargos.Location = new System.Drawing.Point(133, 25);
            this.CmbCargos.Name = "CmbCargos";
            this.CmbCargos.Size = new System.Drawing.Size(222, 24);
            this.CmbCargos.TabIndex = 25;
            this.CmbCargos.SelectedIndexChanged += new System.EventHandler(this.CmbCargos_SelectedIndexChanged);
            this.CmbCargos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbCargos_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "CARGO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtEspecialidad);
            this.groupBox2.Controls.Add(this.TxtProfesion);
            this.groupBox2.Controls.Add(this.TxtCurriculum);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(28, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 181);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CURRICULUM";
            // 
            // TxtEspecialidad
            // 
            this.TxtEspecialidad.Location = new System.Drawing.Point(156, 131);
            this.TxtEspecialidad.Multiline = true;
            this.TxtEspecialidad.Name = "TxtEspecialidad";
            this.TxtEspecialidad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtEspecialidad.Size = new System.Drawing.Size(207, 39);
            this.TxtEspecialidad.TabIndex = 31;
            // 
            // TxtProfesion
            // 
            this.TxtProfesion.Location = new System.Drawing.Point(156, 88);
            this.TxtProfesion.Multiline = true;
            this.TxtProfesion.Name = "TxtProfesion";
            this.TxtProfesion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtProfesion.Size = new System.Drawing.Size(207, 39);
            this.TxtProfesion.TabIndex = 30;
            // 
            // TxtCurriculum
            // 
            this.TxtCurriculum.Location = new System.Drawing.Point(156, 41);
            this.TxtCurriculum.Multiline = true;
            this.TxtCurriculum.Name = "TxtCurriculum";
            this.TxtCurriculum.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtCurriculum.Size = new System.Drawing.Size(207, 39);
            this.TxtCurriculum.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 15);
            this.label14.TabIndex = 25;
            this.label14.Text = "ESPECIALIDAD";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 15);
            this.label13.TabIndex = 24;
            this.label13.Text = "PROFESION";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "CURRICULUM";
            // 
            // txtmail
            // 
            this.txtmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmail.Location = new System.Drawing.Point(131, 324);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(181, 22);
            this.txtmail.TabIndex = 17;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(131, 277);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(181, 22);
            this.txtdireccion.TabIndex = 16;
            // 
            // txtcelular
            // 
            this.txtcelular.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelular.Location = new System.Drawing.Point(485, 236);
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(181, 22);
            this.txtcelular.TabIndex = 15;
            // 
            // txttelefono
            // 
            this.txttelefono.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.Location = new System.Drawing.Point(131, 235);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(181, 22);
            this.txttelefono.TabIndex = 14;
            // 
            // txtmaterno
            // 
            this.txtmaterno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaterno.Location = new System.Drawing.Point(483, 159);
            this.txtmaterno.Name = "txtmaterno";
            this.txtmaterno.Size = new System.Drawing.Size(181, 22);
            this.txtmaterno.TabIndex = 13;
            // 
            // txtpaterno
            // 
            this.txtpaterno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaterno.Location = new System.Drawing.Point(129, 159);
            this.txtpaterno.Name = "txtpaterno";
            this.txtpaterno.Size = new System.Drawing.Size(181, 22);
            this.txtpaterno.TabIndex = 12;
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(129, 198);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(181, 22);
            this.txtnombre.TabIndex = 11;
            // 
            // BtnrGuardar
            // 
            this.BtnrGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnrGuardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnrGuardar.Location = new System.Drawing.Point(255, 558);
            this.BtnrGuardar.Name = "BtnrGuardar";
            this.BtnrGuardar.Size = new System.Drawing.Size(122, 36);
            this.BtnrGuardar.TabIndex = 9;
            this.BtnrGuardar.Text = "REGISTRAR";
            this.BtnrGuardar.UseVisualStyleBackColor = false;
            this.BtnrGuardar.Click += new System.EventHandler(this.BtnrGuardar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "MAIL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "DIRECCION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(381, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "CELULAR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "TELEFONO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(379, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "AP. MATERNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "AP. PATERNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE";
            // 
            // CkbSinDirecion
            // 
            this.CkbSinDirecion.AutoSize = true;
            this.CkbSinDirecion.Location = new System.Drawing.Point(318, 276);
            this.CkbSinDirecion.Name = "CkbSinDirecion";
            this.CkbSinDirecion.Size = new System.Drawing.Size(46, 19);
            this.CkbSinDirecion.TabIndex = 32;
            this.CkbSinDirecion.Text = "SIN";
            this.CkbSinDirecion.UseVisualStyleBackColor = true;
            this.CkbSinDirecion.CheckedChanged += new System.EventHandler(this.CkbSinDirecion_CheckedChanged);
            // 
            // InsertarDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 634);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "InsertarDocente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE PERSONAL ACADEMICO";
            this.Load += new System.EventHandler(this.InsertarDocente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtmaterno;
        private System.Windows.Forms.TextBox txtpaterno;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox Txtci;
        private System.Windows.Forms.Button BtnrGuardar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtEspecialidad;
        private System.Windows.Forms.TextBox TxtProfesion;
        private System.Windows.Forms.TextBox TxtCurriculum;
        protected System.Windows.Forms.ComboBox CmbCargos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RbtnDni;
        private System.Windows.Forms.RadioButton RbtnCi;
        private System.Windows.Forms.CheckBox CkbSinMail;
        private System.Windows.Forms.CheckBox CkbSinCelular;
        private System.Windows.Forms.CheckBox CkbSinTelefono;
        private System.Windows.Forms.CheckBox CkbSinDirecion;
    }
}