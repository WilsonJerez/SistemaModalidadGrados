namespace VISTAS.REPORTES.DEFENSA
{
    partial class ReporteDefensasMod_IPendientesDeNotas
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
            this.BtnGenerarReporte.Location = new System.Drawing.Point(439, 43);
            this.BtnGenerarReporte.Name = "BtnGenerarReporte";
            this.BtnGenerarReporte.Size = new System.Drawing.Size(127, 27);
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
            this.CrvReporte.Location = new System.Drawing.Point(8, 90);
            this.CrvReporte.Name = "CrvReporte";
            this.CrvReporte.SelectionFormula = "";
            this.CrvReporte.Size = new System.Drawing.Size(988, 636);
            this.CrvReporte.TabIndex = 1;
            this.CrvReporte.ViewTimeSelectionFormula = "";
            // 
            // ReporteDefensasMod_IPendientesDeNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 728);
            this.Controls.Add(this.CrvReporte);
            this.Controls.Add(this.BtnGenerarReporte);
            this.MaximizeBox = false;
            this.Name = "ReporteDefensasMod_IPendientesDeNotas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE DE DEFENSAS PENDIENTES DE NOTAS DE LA MODALIDAD DE GRADO I";
            this.Load += new System.EventHandler(this.ReporteDefensasMod_IPendientesDeNotas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerarReporte;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvReporte;
    }
}