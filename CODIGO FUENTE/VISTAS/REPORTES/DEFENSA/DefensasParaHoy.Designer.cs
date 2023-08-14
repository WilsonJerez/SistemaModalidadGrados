namespace VISTAS.REPORTES.DEFENSA
{
    partial class DefensasParaHoy
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
            this.RbtnParaHoy = new System.Windows.Forms.RadioButton();
            this.RbtnOtraFecha = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtFechaOtra = new System.Windows.Forms.TextBox();
            this.TxtFechaHoy = new System.Windows.Forms.TextBox();
            this.CrvDefHoy = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RbtnParaHoy
            // 
            this.RbtnParaHoy.AutoSize = true;
            this.RbtnParaHoy.Location = new System.Drawing.Point(20, 26);
            this.RbtnParaHoy.Name = "RbtnParaHoy";
            this.RbtnParaHoy.Size = new System.Drawing.Size(80, 17);
            this.RbtnParaHoy.TabIndex = 0;
            this.RbtnParaHoy.TabStop = true;
            this.RbtnParaHoy.Text = "PARA HOY";
            this.RbtnParaHoy.UseVisualStyleBackColor = true;
            // 
            // RbtnOtraFecha
            // 
            this.RbtnOtraFecha.AutoSize = true;
            this.RbtnOtraFecha.Location = new System.Drawing.Point(167, 26);
            this.RbtnOtraFecha.Name = "RbtnOtraFecha";
            this.RbtnOtraFecha.Size = new System.Drawing.Size(93, 17);
            this.RbtnOtraFecha.TabIndex = 1;
            this.RbtnOtraFecha.TabStop = true;
            this.RbtnOtraFecha.Text = "OTRA FECHA";
            this.RbtnOtraFecha.UseVisualStyleBackColor = true;
            this.RbtnOtraFecha.CheckedChanged += new System.EventHandler(this.RbtnOtraFecha_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "GENERAR REPORTE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TxtFechaOtra);
            this.groupBox1.Controls.Add(this.TxtFechaHoy);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.RbtnOtraFecha);
            this.groupBox1.Controls.Add(this.RbtnParaHoy);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(6, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1046, 137);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PARAMETROS DEL REPORTE";
            // 
            // TxtFechaOtra
            // 
            this.TxtFechaOtra.Location = new System.Drawing.Point(167, 49);
            this.TxtFechaOtra.Name = "TxtFechaOtra";
            this.TxtFechaOtra.ReadOnly = true;
            this.TxtFechaOtra.Size = new System.Drawing.Size(115, 20);
            this.TxtFechaOtra.TabIndex = 4;
            // 
            // TxtFechaHoy
            // 
            this.TxtFechaHoy.Location = new System.Drawing.Point(20, 49);
            this.TxtFechaHoy.Name = "TxtFechaHoy";
            this.TxtFechaHoy.ReadOnly = true;
            this.TxtFechaHoy.Size = new System.Drawing.Size(100, 20);
            this.TxtFechaHoy.TabIndex = 3;
            // 
            // CrvDefHoy
            // 
            this.CrvDefHoy.ActiveViewIndex = -1;
            this.CrvDefHoy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvDefHoy.DisplayGroupTree = false;
            this.CrvDefHoy.Location = new System.Drawing.Point(6, 174);
            this.CrvDefHoy.Name = "CrvDefHoy";
            this.CrvDefHoy.SelectionFormula = "";
            this.CrvDefHoy.Size = new System.Drawing.Size(1055, 580);
            this.CrvDefHoy.TabIndex = 5;
            this.CrvDefHoy.ViewTimeSelectionFormula = "";
            // 
            // DefensasParaHoy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 750);
            this.Controls.Add(this.CrvDefHoy);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "DefensasParaHoy";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE DE DEFENSAS";
            this.Load += new System.EventHandler(this.DefensasParaHoy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton RbtnParaHoy;
        private System.Windows.Forms.RadioButton RbtnOtraFecha;
        private System.Windows.Forms.Button button1;
        //private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvDefensasHoy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtFechaHoy;
        private System.Windows.Forms.TextBox TxtFechaOtra;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvDefHoy;

    }
}