namespace VISTAS.TIPOMODALIDAD
{
    partial class InsertarTipoModalidad
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTipoModalidadX = new System.Windows.Forms.TextBox();
            this.TxtDescripcionX = new System.Windows.Forms.TextBox();
            this.BtnGuardarx = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "TIPO MODALIDAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "DESCRIPCION";
            // 
            // TxtTipoModalidadX
            // 
            this.TxtTipoModalidadX.Location = new System.Drawing.Point(155, 36);
            this.TxtTipoModalidadX.Name = "TxtTipoModalidadX";
            this.TxtTipoModalidadX.Size = new System.Drawing.Size(150, 20);
            this.TxtTipoModalidadX.TabIndex = 2;
            // 
            // TxtDescripcionX
            // 
            this.TxtDescripcionX.Location = new System.Drawing.Point(155, 75);
            this.TxtDescripcionX.Multiline = true;
            this.TxtDescripcionX.Name = "TxtDescripcionX";
            this.TxtDescripcionX.Size = new System.Drawing.Size(150, 40);
            this.TxtDescripcionX.TabIndex = 3;
            // 
            // BtnGuardarx
            // 
            this.BtnGuardarx.BackColor = System.Drawing.SystemColors.Control;
            this.BtnGuardarx.Location = new System.Drawing.Point(123, 159);
            this.BtnGuardarx.Name = "BtnGuardarx";
            this.BtnGuardarx.Size = new System.Drawing.Size(111, 34);
            this.BtnGuardarx.TabIndex = 4;
            this.BtnGuardarx.Text = "GUARDAR";
            this.BtnGuardarx.UseVisualStyleBackColor = false;
            this.BtnGuardarx.Click += new System.EventHandler(this.BtnGuardarx_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BtnGuardarx);
            this.groupBox1.Controls.Add(this.TxtDescripcionX);
            this.groupBox1.Controls.Add(this.TxtTipoModalidadX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(9, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 201);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRAR TIPO DE MODALIDAD";
            // 
            // InsertarTipoModalidad
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(357, 241);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "InsertarTipoModalidad";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INSERTAR TIPO DE MODALIDAD";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion        
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTipoModalidadX;
        private System.Windows.Forms.TextBox TxtDescripcionX;
        private System.Windows.Forms.Button BtnGuardarx;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}