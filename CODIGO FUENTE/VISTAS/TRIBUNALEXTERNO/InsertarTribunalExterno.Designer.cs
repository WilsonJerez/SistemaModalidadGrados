namespace VISTAS.TRIBUNALEXTERNO
{
    partial class InsertarTribunalExterno
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
            this.CkbSinCelular = new System.Windows.Forms.CheckBox();
            this.CkbSinMail = new System.Windows.Forms.CheckBox();
            this.CkbSinTelefono = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RbtnDni = new System.Windows.Forms.RadioButton();
            this.RbtnCi = new System.Windows.Forms.RadioButton();
            this.Txtci = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtmaterno = new System.Windows.Forms.TextBox();
            this.txtpaterno = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CkbSinCelular
            // 
            this.CkbSinCelular.AutoSize = true;
            this.CkbSinCelular.BackColor = System.Drawing.Color.Transparent;
            this.CkbSinCelular.Location = new System.Drawing.Point(687, 199);
            this.CkbSinCelular.Name = "CkbSinCelular";
            this.CkbSinCelular.Size = new System.Drawing.Size(44, 17);
            this.CkbSinCelular.TabIndex = 51;
            this.CkbSinCelular.Text = "SIN";
            this.CkbSinCelular.UseVisualStyleBackColor = false;
            this.CkbSinCelular.CheckedChanged += new System.EventHandler(this.CkbSinCelular_CheckedChanged);
            // 
            // CkbSinMail
            // 
            this.CkbSinMail.AutoSize = true;
            this.CkbSinMail.BackColor = System.Drawing.Color.Transparent;
            this.CkbSinMail.Location = new System.Drawing.Point(305, 275);
            this.CkbSinMail.Name = "CkbSinMail";
            this.CkbSinMail.Size = new System.Drawing.Size(44, 17);
            this.CkbSinMail.TabIndex = 50;
            this.CkbSinMail.Text = "SIN";
            this.CkbSinMail.UseVisualStyleBackColor = false;
            this.CkbSinMail.CheckedChanged += new System.EventHandler(this.CkbSinMail_CheckedChanged);
            // 
            // CkbSinTelefono
            // 
            this.CkbSinTelefono.AutoSize = true;
            this.CkbSinTelefono.BackColor = System.Drawing.Color.Transparent;
            this.CkbSinTelefono.Location = new System.Drawing.Point(305, 205);
            this.CkbSinTelefono.Name = "CkbSinTelefono";
            this.CkbSinTelefono.Size = new System.Drawing.Size(44, 17);
            this.CkbSinTelefono.TabIndex = 49;
            this.CkbSinTelefono.Text = "SIN";
            this.CkbSinTelefono.UseVisualStyleBackColor = false;
            this.CkbSinTelefono.CheckedChanged += new System.EventHandler(this.CkbSinTelefono_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.RbtnDni);
            this.groupBox3.Controls.Add(this.RbtnCi);
            this.groupBox3.Controls.Add(this.Txtci);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(16, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 82);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TIPO IDENTIFICADOR";
            // 
            // RbtnDni
            // 
            this.RbtnDni.AutoSize = true;
            this.RbtnDni.Location = new System.Drawing.Point(20, 54);
            this.RbtnDni.Name = "RbtnDni";
            this.RbtnDni.Size = new System.Drawing.Size(44, 17);
            this.RbtnDni.TabIndex = 27;
            this.RbtnDni.Text = "DNI";
            this.RbtnDni.UseVisualStyleBackColor = true;
            // 
            // RbtnCi
            // 
            this.RbtnCi.AutoSize = true;
            this.RbtnCi.Checked = true;
            this.RbtnCi.Location = new System.Drawing.Point(20, 26);
            this.RbtnCi.Name = "RbtnCi";
            this.RbtnCi.Size = new System.Drawing.Size(35, 17);
            this.RbtnCi.TabIndex = 26;
            this.RbtnCi.TabStop = true;
            this.RbtnCi.Text = "CI";
            this.RbtnCi.UseVisualStyleBackColor = true;
            this.RbtnCi.CheckedChanged += new System.EventHandler(this.RbtnCi_CheckedChanged);
            // 
            // Txtci
            // 
            this.Txtci.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtci.Location = new System.Drawing.Point(103, 39);
            this.Txtci.Name = "Txtci";
            this.Txtci.Size = new System.Drawing.Size(216, 22);
            this.Txtci.TabIndex = 10;
            // 
            // txtmail
            // 
            this.txtmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmail.Location = new System.Drawing.Point(118, 275);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(181, 20);
            this.txtmail.TabIndex = 47;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(118, 240);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(181, 20);
            this.txtdireccion.TabIndex = 46;
            // 
            // txtcelular
            // 
            this.txtcelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelular.Location = new System.Drawing.Point(494, 199);
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(181, 20);
            this.txtcelular.TabIndex = 45;
            // 
            // txttelefono
            // 
            this.txttelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.Location = new System.Drawing.Point(118, 203);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(181, 20);
            this.txttelefono.TabIndex = 44;
            // 
            // txtmaterno
            // 
            this.txtmaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaterno.Location = new System.Drawing.Point(494, 126);
            this.txtmaterno.Name = "txtmaterno";
            this.txtmaterno.Size = new System.Drawing.Size(181, 20);
            this.txtmaterno.TabIndex = 43;
            // 
            // txtpaterno
            // 
            this.txtpaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaterno.Location = new System.Drawing.Point(118, 130);
            this.txtpaterno.Name = "txtpaterno";
            this.txtpaterno.Size = new System.Drawing.Size(181, 20);
            this.txtpaterno.TabIndex = 42;
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(119, 167);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(181, 20);
            this.txtnombre.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "MAIL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "DIRECCION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(390, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "CELULAR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "TELEFONO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "AP. MATERNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "AP. PATERNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "NOMBRE";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(321, 328);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(138, 35);
            this.BtnRegistrar.TabIndex = 52;
            this.BtnRegistrar.Text = "REGISTRAR";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // InsertarTribunalExterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.ClientSize = new System.Drawing.Size(776, 375);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.CkbSinCelular);
            this.Controls.Add(this.CkbSinMail);
            this.Controls.Add(this.CkbSinTelefono);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtmaterno);
            this.Controls.Add(this.txtpaterno);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "InsertarTribunalExterno";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRAR TRIBUNAL EXTERNO";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CkbSinCelular;
        private System.Windows.Forms.CheckBox CkbSinMail;
        private System.Windows.Forms.CheckBox CkbSinTelefono;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RbtnDni;
        private System.Windows.Forms.RadioButton RbtnCi;
        private System.Windows.Forms.TextBox Txtci;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtmaterno;
        private System.Windows.Forms.TextBox txtpaterno;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRegistrar;
    }
}