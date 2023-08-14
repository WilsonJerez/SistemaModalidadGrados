namespace VISTAS.REPORTES.DEFENSA
{
    partial class HabilitadosModalidadII
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
            this.CrvHabilitadosModalidadII = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.BtnGenReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CrvHabilitadosModalidadII
            // 
            this.CrvHabilitadosModalidadII.ActiveViewIndex = -1;
            this.CrvHabilitadosModalidadII.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvHabilitadosModalidadII.DisplayGroupTree = false;
            this.CrvHabilitadosModalidadII.Location = new System.Drawing.Point(1, 85);
            this.CrvHabilitadosModalidadII.Name = "CrvHabilitadosModalidadII";
            this.CrvHabilitadosModalidadII.SelectionFormula = "";
            this.CrvHabilitadosModalidadII.Size = new System.Drawing.Size(924, 631);
            this.CrvHabilitadosModalidadII.TabIndex = 0;
            this.CrvHabilitadosModalidadII.ViewTimeSelectionFormula = "";
            // 
            // BtnGenReporte
            // 
            this.BtnGenReporte.Location = new System.Drawing.Point(388, 31);
            this.BtnGenReporte.Name = "BtnGenReporte";
            this.BtnGenReporte.Size = new System.Drawing.Size(189, 30);
            this.BtnGenReporte.TabIndex = 1;
            this.BtnGenReporte.Text = "GENERAR REPORTE";
            this.BtnGenReporte.UseVisualStyleBackColor = true;
            this.BtnGenReporte.Click += new System.EventHandler(this.BtnGenReporte_Click);
            // 
            // HabilitadosModalidadII
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(925, 718);
            this.Controls.Add(this.BtnGenReporte);
            this.Controls.Add(this.CrvHabilitadosModalidadII);
            this.MaximizeBox = false;
            this.Name = "HabilitadosModalidadII";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE DE ESTUDIANTES HABILITADOS PARA LA MODALIDAD DE GRADO II";
            this.Load += new System.EventHandler(this.HabilitadosModalidadII_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvHabilitadosModalidadII;
        private System.Windows.Forms.Button BtnGenReporte;
    }
}