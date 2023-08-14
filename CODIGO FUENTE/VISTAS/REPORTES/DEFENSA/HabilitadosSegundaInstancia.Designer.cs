namespace VISTAS.REPORTES.DEFENSA
{
    partial class HabilitadosSegundaInstancia
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
            this.CrvHabilitadosSegundaInstancia = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // BtnGenerarReporte
            // 
            this.BtnGenerarReporte.Location = new System.Drawing.Point(363, 44);
            this.BtnGenerarReporte.Name = "BtnGenerarReporte";
            this.BtnGenerarReporte.Size = new System.Drawing.Size(171, 27);
            this.BtnGenerarReporte.TabIndex = 0;
            this.BtnGenerarReporte.Text = "GENERAR REPORTE";
            this.BtnGenerarReporte.UseVisualStyleBackColor = true;
            this.BtnGenerarReporte.Click += new System.EventHandler(this.BtnGenerarReporte_Click);
            // 
            // CrvHabilitadosSegundaInstancia
            // 
            this.CrvHabilitadosSegundaInstancia.ActiveViewIndex = -1;
            this.CrvHabilitadosSegundaInstancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvHabilitadosSegundaInstancia.DisplayGroupTree = false;
            this.CrvHabilitadosSegundaInstancia.Location = new System.Drawing.Point(0, 92);
            this.CrvHabilitadosSegundaInstancia.Name = "CrvHabilitadosSegundaInstancia";
            this.CrvHabilitadosSegundaInstancia.SelectionFormula = "";
            this.CrvHabilitadosSegundaInstancia.Size = new System.Drawing.Size(901, 612);
            this.CrvHabilitadosSegundaInstancia.TabIndex = 1;
            this.CrvHabilitadosSegundaInstancia.ViewTimeSelectionFormula = "";
            // 
            // HabilitadosSegundaInstancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 704);
            this.Controls.Add(this.CrvHabilitadosSegundaInstancia);
            this.Controls.Add(this.BtnGenerarReporte);
            this.MaximizeBox = false;
            this.Name = "HabilitadosSegundaInstancia";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE HABILITADOS PARA DEFENSA EN SEGUNDA INSTANCIA DE LA MODALIDAD II";
            this.Load += new System.EventHandler(this.HabilitadosSegundaInstancia_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerarReporte;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvHabilitadosSegundaInstancia;
    }
}