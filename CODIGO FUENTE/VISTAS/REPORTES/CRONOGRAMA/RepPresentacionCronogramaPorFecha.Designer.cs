namespace VISTAS.REPORTES.CRONOGRAMA
{
    partial class RepPresentacionCronogramaPorFecha
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
            this.BtnGenerarReporte = new System.Windows.Forms.Button();
            this.RdbHoy = new System.Windows.Forms.RadioButton();
            this.RdbOtra = new System.Windows.Forms.RadioButton();
            this.TxtFechaHoy = new System.Windows.Forms.TextBox();
            this.TxtFechaOtra = new System.Windows.Forms.TextBox();
            this.CrvReporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // BtnGenerarReporte
            // 
            this.BtnGenerarReporte.Location = new System.Drawing.Point(494, 75);
            this.BtnGenerarReporte.Name = "BtnGenerarReporte";
            this.BtnGenerarReporte.Size = new System.Drawing.Size(138, 23);
            this.BtnGenerarReporte.TabIndex = 0;
            this.BtnGenerarReporte.Text = "GENAR REPORTE";
            this.BtnGenerarReporte.UseVisualStyleBackColor = true;
            this.BtnGenerarReporte.Click += new System.EventHandler(this.BtnGenerarReporte_Click);
            // 
            // RdbHoy
            // 
            this.RdbHoy.AutoSize = true;
            this.RdbHoy.BackColor = System.Drawing.Color.Transparent;
            this.RdbHoy.Checked = true;
            this.RdbHoy.Location = new System.Drawing.Point(56, 25);
            this.RdbHoy.Name = "RdbHoy";
            this.RdbHoy.Size = new System.Drawing.Size(80, 17);
            this.RdbHoy.TabIndex = 1;
            this.RdbHoy.TabStop = true;
            this.RdbHoy.Text = "PARA HOY";
            this.RdbHoy.UseVisualStyleBackColor = false;
            // 
            // RdbOtra
            // 
            this.RdbOtra.AutoSize = true;
            this.RdbOtra.BackColor = System.Drawing.Color.Transparent;
            this.RdbOtra.Location = new System.Drawing.Point(204, 25);
            this.RdbOtra.Name = "RdbOtra";
            this.RdbOtra.Size = new System.Drawing.Size(93, 17);
            this.RdbOtra.TabIndex = 2;
            this.RdbOtra.Text = "OTRA FECHA";
            this.RdbOtra.UseVisualStyleBackColor = false;
            // 
            // TxtFechaHoy
            // 
            this.TxtFechaHoy.Location = new System.Drawing.Point(56, 52);
            this.TxtFechaHoy.Name = "TxtFechaHoy";
            this.TxtFechaHoy.ReadOnly = true;
            this.TxtFechaHoy.Size = new System.Drawing.Size(100, 20);
            this.TxtFechaHoy.TabIndex = 3;
            // 
            // TxtFechaOtra
            // 
            this.TxtFechaOtra.Location = new System.Drawing.Point(204, 52);
            this.TxtFechaOtra.Name = "TxtFechaOtra";
            this.TxtFechaOtra.Size = new System.Drawing.Size(100, 20);
            this.TxtFechaOtra.TabIndex = 4;
            // 
            // CrvReporte
            // 
            this.CrvReporte.ActiveViewIndex = -1;
            this.CrvReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvReporte.DisplayGroupTree = false;
            this.CrvReporte.Location = new System.Drawing.Point(8, 104);
            this.CrvReporte.Name = "CrvReporte";
            this.CrvReporte.SelectionFormula = "";
            this.CrvReporte.Size = new System.Drawing.Size(1110, 573);
            this.CrvReporte.TabIndex = 5;
            this.CrvReporte.ViewTimeSelectionFormula = "";
            // 
            // RepPresentacionCronogramaPorFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1126, 675);
            this.Controls.Add(this.CrvReporte);
            this.Controls.Add(this.TxtFechaOtra);
            this.Controls.Add(this.TxtFechaHoy);
            this.Controls.Add(this.RdbOtra);
            this.Controls.Add(this.RdbHoy);
            this.Controls.Add(this.BtnGenerarReporte);
            this.MaximizeBox = false;
            this.Name = "RepPresentacionCronogramaPorFecha";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE DE ESTUDIANTES QUE DEBEN PRESENTAR SU INFORME PARA UNA DETERMINADA FECHA";
            this.Load += new System.EventHandler(this.RepPresentacionCronogramaPorFecha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerarReporte;
        private System.Windows.Forms.RadioButton RdbHoy;
        private System.Windows.Forms.RadioButton RdbOtra;
        private System.Windows.Forms.TextBox TxtFechaHoy;
        private System.Windows.Forms.TextBox TxtFechaOtra;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvReporte;
    }
}