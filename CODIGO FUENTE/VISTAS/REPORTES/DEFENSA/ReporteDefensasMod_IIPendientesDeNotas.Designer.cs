﻿namespace VISTAS.REPORTES.DEFENSA
{
    partial class ReporteDefensasMod_IIPendientesDeNotas
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
            this.CrvReporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.BtnGenerarReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CrvReporte
            // 
            this.CrvReporte.ActiveViewIndex = -1;
            this.CrvReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvReporte.DisplayGroupTree = false;
            this.CrvReporte.Location = new System.Drawing.Point(7, 89);
            this.CrvReporte.Name = "CrvReporte";
            this.CrvReporte.SelectionFormula = "";
            this.CrvReporte.Size = new System.Drawing.Size(994, 598);
            this.CrvReporte.TabIndex = 0;
            this.CrvReporte.ViewTimeSelectionFormula = "";
            // 
            // BtnGenerarReporte
            // 
            this.BtnGenerarReporte.Location = new System.Drawing.Point(436, 38);
            this.BtnGenerarReporte.Name = "BtnGenerarReporte";
            this.BtnGenerarReporte.Size = new System.Drawing.Size(136, 23);
            this.BtnGenerarReporte.TabIndex = 1;
            this.BtnGenerarReporte.Text = "GENERAR REPORTE";
            this.BtnGenerarReporte.UseVisualStyleBackColor = true;
            this.BtnGenerarReporte.Click += new System.EventHandler(this.BtnGenerarReporte_Click);
            // 
            // ReporteDefensasMod_IIPendientesDeNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 684);
            this.Controls.Add(this.BtnGenerarReporte);
            this.Controls.Add(this.CrvReporte);
            this.MaximizeBox = false;
            this.Name = "ReporteDefensasMod_IIPendientesDeNotas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE DE DEFENSAS DE LA MODALIDAD DE GRADO II PENDIENTES DE NOTAS";
            this.Load += new System.EventHandler(this.ReporteDefensasMod_IIPendientesDeNotas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvReporte;
        private System.Windows.Forms.Button BtnGenerarReporte;
    }
}