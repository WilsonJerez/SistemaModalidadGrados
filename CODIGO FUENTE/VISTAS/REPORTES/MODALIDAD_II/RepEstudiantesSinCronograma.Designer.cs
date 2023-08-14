namespace VISTAS.REPORTES.MODALIDAD_II
{
    partial class RepEstudiantesSinCronograma
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
            this.CrvReporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // BtnGenerarReporte
            // 
            this.BtnGenerarReporte.Location = new System.Drawing.Point(453, 37);
            this.BtnGenerarReporte.Name = "BtnGenerarReporte";
            this.BtnGenerarReporte.Size = new System.Drawing.Size(152, 32);
            this.BtnGenerarReporte.TabIndex = 0;
            this.BtnGenerarReporte.Text = "GENERAR REPORTE";
            this.BtnGenerarReporte.UseVisualStyleBackColor = true;
            this.BtnGenerarReporte.Click += new System.EventHandler(this.BtnGenerarReporte_Click);
            // 
            // CrvReporte
            // 
            this.CrvReporte.ActiveViewIndex = -1;
            this.CrvReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvReporte.DisplayGroupTree = false;
            this.CrvReporte.Location = new System.Drawing.Point(2, 87);
            this.CrvReporte.Name = "CrvReporte";
            this.CrvReporte.SelectionFormula = "";
            this.CrvReporte.Size = new System.Drawing.Size(1054, 591);
            this.CrvReporte.TabIndex = 1;
            this.CrvReporte.ViewTimeSelectionFormula = "";
            // 
            // RepEstudiantesSinCronograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1059, 677);
            this.Controls.Add(this.CrvReporte);
            this.Controls.Add(this.BtnGenerarReporte);
            this.MaximizeBox = false;
            this.Name = "RepEstudiantesSinCronograma";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE ESTUDIANTES INSCRITOS EN LA MODALIDAD DE GRADO II SIN PRESENTAR CRONOGRAM" +
                "A";
            this.Load += new System.EventHandler(this.RepEstudiantesSinCronograma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerarReporte;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvReporte;
    }
}