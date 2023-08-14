namespace VISTAS.GRUPO.MODIFICAR
{
    partial class DatosDelGrupo
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
            this.CmbTurno = new System.Windows.Forms.ComboBox();
            this.CmbAula = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CkbAula = new System.Windows.Forms.CheckBox();
            this.CkbTurno = new System.Windows.Forms.CheckBox();
            this.CkbFechaFinal = new System.Windows.Forms.CheckBox();
            this.CkbFechaInicio = new System.Windows.Forms.CheckBox();
            this.CkbGrupo = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.TxtGrupo = new System.Windows.Forms.TextBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmbTurno
            // 
            this.CmbTurno.Enabled = false;
            this.CmbTurno.FormattingEnabled = true;
            this.CmbTurno.Location = new System.Drawing.Point(20, 155);
            this.CmbTurno.Name = "CmbTurno";
            this.CmbTurno.Size = new System.Drawing.Size(200, 21);
            this.CmbTurno.TabIndex = 5;
            this.CmbTurno.SelectedIndexChanged += new System.EventHandler(this.CmbTurno_SelectedIndexChanged);
            this.CmbTurno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbTurno_KeyDown);
            // 
            // CmbAula
            // 
            this.CmbAula.Enabled = false;
            this.CmbAula.FormattingEnabled = true;
            this.CmbAula.Location = new System.Drawing.Point(244, 155);
            this.CmbAula.Name = "CmbAula";
            this.CmbAula.Size = new System.Drawing.Size(200, 21);
            this.CmbAula.TabIndex = 0;
            this.CmbAula.SelectedIndexChanged += new System.EventHandler(this.CmbAula_SelectedIndexChanged);
            this.CmbAula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbAula_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.CkbAula);
            this.groupBox2.Controls.Add(this.CkbTurno);
            this.groupBox2.Controls.Add(this.CkbFechaFinal);
            this.groupBox2.Controls.Add(this.CkbFechaInicio);
            this.groupBox2.Controls.Add(this.CkbGrupo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.DtpFechaFinal);
            this.groupBox2.Controls.Add(this.DtpFechaInicio);
            this.groupBox2.Controls.Add(this.TxtGrupo);
            this.groupBox2.Controls.Add(this.CmbAula);
            this.groupBox2.Controls.Add(this.CmbTurno);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(18, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 206);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS DEL GRUPO";
            // 
            // CkbAula
            // 
            this.CkbAula.AutoSize = true;
            this.CkbAula.Location = new System.Drawing.Point(244, 135);
            this.CkbAula.Name = "CkbAula";
            this.CkbAula.Size = new System.Drawing.Size(54, 17);
            this.CkbAula.TabIndex = 18;
            this.CkbAula.Text = "AULA";
            this.CkbAula.UseVisualStyleBackColor = true;
            this.CkbAula.CheckedChanged += new System.EventHandler(this.CkbAula_CheckedChanged);
            // 
            // CkbTurno
            // 
            this.CkbTurno.AutoSize = true;
            this.CkbTurno.Location = new System.Drawing.Point(20, 135);
            this.CkbTurno.Name = "CkbTurno";
            this.CkbTurno.Size = new System.Drawing.Size(65, 17);
            this.CkbTurno.TabIndex = 17;
            this.CkbTurno.Text = "TURNO";
            this.CkbTurno.UseVisualStyleBackColor = true;
            this.CkbTurno.CheckedChanged += new System.EventHandler(this.CkbTurno_CheckedChanged);
            // 
            // CkbFechaFinal
            // 
            this.CkbFechaFinal.AutoSize = true;
            this.CkbFechaFinal.Location = new System.Drawing.Point(244, 71);
            this.CkbFechaFinal.Name = "CkbFechaFinal";
            this.CkbFechaFinal.Size = new System.Drawing.Size(155, 17);
            this.CkbFechaFinal.TabIndex = 16;
            this.CkbFechaFinal.Text = "FECHA DE FINALIZACION";
            this.CkbFechaFinal.UseVisualStyleBackColor = true;
            this.CkbFechaFinal.CheckedChanged += new System.EventHandler(this.CkbFechaFinal_CheckedChanged);
            // 
            // CkbFechaInicio
            // 
            this.CkbFechaInicio.AutoSize = true;
            this.CkbFechaInicio.Location = new System.Drawing.Point(20, 71);
            this.CkbFechaInicio.Name = "CkbFechaInicio";
            this.CkbFechaInicio.Size = new System.Drawing.Size(114, 17);
            this.CkbFechaInicio.TabIndex = 15;
            this.CkbFechaInicio.Text = "FECHA DE INICIO";
            this.CkbFechaInicio.UseVisualStyleBackColor = true;
            this.CkbFechaInicio.CheckedChanged += new System.EventHandler(this.CkbFechaInicio_CheckedChanged);
            // 
            // CkbGrupo
            // 
            this.CkbGrupo.AutoSize = true;
            this.CkbGrupo.Location = new System.Drawing.Point(200, 19);
            this.CkbGrupo.Name = "CkbGrupo";
            this.CkbGrupo.Size = new System.Drawing.Size(65, 17);
            this.CkbGrupo.TabIndex = 14;
            this.CkbGrupo.Text = "GRUPO";
            this.CkbGrupo.UseVisualStyleBackColor = true;
            this.CkbGrupo.CheckedChanged += new System.EventHandler(this.CkbGrupo_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, -16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 13;
            // 
            // DtpFechaFinal
            // 
            this.DtpFechaFinal.Enabled = false;
            this.DtpFechaFinal.Location = new System.Drawing.Point(244, 94);
            this.DtpFechaFinal.Name = "DtpFechaFinal";
            this.DtpFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaFinal.TabIndex = 12;
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.Enabled = false;
            this.DtpFechaInicio.Location = new System.Drawing.Point(20, 94);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaInicio.TabIndex = 11;
            // 
            // TxtGrupo
            // 
            this.TxtGrupo.Enabled = false;
            this.TxtGrupo.Location = new System.Drawing.Point(172, 37);
            this.TxtGrupo.Name = "TxtGrupo";
            this.TxtGrupo.Size = new System.Drawing.Size(120, 20);
            this.TxtGrupo.TabIndex = 9;
            this.TxtGrupo.TextChanged += new System.EventHandler(this.TxtGrupo_TextChanged);
            this.TxtGrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtGrupo_KeyPress);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(178, 249);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(144, 29);
            this.BtnModificar.TabIndex = 7;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // DatosDelGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 297);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatosDelGrupo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODIFICAR DATOS DEL GRUPO";
            this.Load += new System.EventHandler(this.DatosDelGrupo_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbTurno;
        private System.Windows.Forms.ComboBox CmbAula;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker DtpFechaFinal;
        private System.Windows.Forms.DateTimePicker DtpFechaInicio;
        private System.Windows.Forms.TextBox TxtGrupo;
        private System.Windows.Forms.CheckBox CkbAula;
        private System.Windows.Forms.CheckBox CkbTurno;
        private System.Windows.Forms.CheckBox CkbFechaFinal;
        private System.Windows.Forms.CheckBox CkbFechaInicio;
        private System.Windows.Forms.CheckBox CkbGrupo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnModificar;
    }
}