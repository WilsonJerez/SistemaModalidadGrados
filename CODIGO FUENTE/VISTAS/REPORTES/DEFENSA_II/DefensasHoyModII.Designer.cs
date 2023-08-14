namespace VISTAS.REPORTES.DEFENSA_II
{
    partial class DefensasHoyModII
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
            this.BtnGenReporte = new System.Windows.Forms.Button();
            this.RdbHoy = new System.Windows.Forms.RadioButton();
            this.RdbOtraFecha = new System.Windows.Forms.RadioButton();
            this.Txthoy = new System.Windows.Forms.TextBox();
            this.TxtOtraFecha = new System.Windows.Forms.TextBox();
            this.CrvReporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // BtnGenReporte
            // 
            this.BtnGenReporte.Location = new System.Drawing.Point(428, 71);
            this.BtnGenReporte.Name = "BtnGenReporte";
            this.BtnGenReporte.Size = new System.Drawing.Size(173, 35);
            this.BtnGenReporte.TabIndex = 0;
            this.BtnGenReporte.Text = "GENERAR REPORTE";
            this.BtnGenReporte.UseVisualStyleBackColor = true;
            this.BtnGenReporte.Click += new System.EventHandler(this.BtnGenReporte_Click);
            // 
            // RdbHoy
            // 
            this.RdbHoy.AutoSize = true;
            this.RdbHoy.BackColor = System.Drawing.Color.Transparent;
            this.RdbHoy.Checked = true;
            this.RdbHoy.Location = new System.Drawing.Point(12, 23);
            this.RdbHoy.Name = "RdbHoy";
            this.RdbHoy.Size = new System.Drawing.Size(80, 17);
            this.RdbHoy.TabIndex = 1;
            this.RdbHoy.TabStop = true;
            this.RdbHoy.Text = "PARA HOY";
            this.RdbHoy.UseVisualStyleBackColor = false;
            // 
            // RdbOtraFecha
            // 
            this.RdbOtraFecha.AutoSize = true;
            this.RdbOtraFecha.BackColor = System.Drawing.Color.Transparent;
            this.RdbOtraFecha.Location = new System.Drawing.Point(137, 24);
            this.RdbOtraFecha.Name = "RdbOtraFecha";
            this.RdbOtraFecha.Size = new System.Drawing.Size(93, 17);
            this.RdbOtraFecha.TabIndex = 2;
            this.RdbOtraFecha.TabStop = true;
            this.RdbOtraFecha.Text = "OTRA FECHA";
            this.RdbOtraFecha.UseVisualStyleBackColor = false;
            // 
            // Txthoy
            // 
            this.Txthoy.Location = new System.Drawing.Point(12, 47);
            this.Txthoy.Name = "Txthoy";
            this.Txthoy.ReadOnly = true;
            this.Txthoy.Size = new System.Drawing.Size(100, 20);
            this.Txthoy.TabIndex = 3;
            // 
            // TxtOtraFecha
            // 
            this.TxtOtraFecha.Location = new System.Drawing.Point(137, 47);
            this.TxtOtraFecha.Name = "TxtOtraFecha";
            this.TxtOtraFecha.Size = new System.Drawing.Size(100, 20);
            this.TxtOtraFecha.TabIndex = 4;
            // 
            // CrvReporte
            // 
            this.CrvReporte.ActiveViewIndex = -1;
            this.CrvReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvReporte.DisplayGroupTree = false;
            this.CrvReporte.Location = new System.Drawing.Point(8, 120);
            this.CrvReporte.Name = "CrvReporte";
            this.CrvReporte.SelectionFormula = "";
            this.CrvReporte.Size = new System.Drawing.Size(1012, 543);
            this.CrvReporte.TabIndex = 5;
            this.CrvReporte.ViewTimeSelectionFormula = "";
            // 
            // DefensasHoyModII
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 662);
            this.Controls.Add(this.CrvReporte);
            this.Controls.Add(this.TxtOtraFecha);
            this.Controls.Add(this.Txthoy);
            this.Controls.Add(this.RdbOtraFecha);
            this.Controls.Add(this.RdbHoy);
            this.Controls.Add(this.BtnGenReporte);
            this.MaximizeBox = false;
            this.Name = "DefensasHoyModII";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE DE DEFENSAS PARA HOY Y OTRAS FECHAS PARA LA MODALIDAD DE GRADO II";
            this.Load += new System.EventHandler(this.DefensasHoyModII_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenReporte;
        private System.Windows.Forms.RadioButton RdbHoy;
        private System.Windows.Forms.RadioButton RdbOtraFecha;
        private System.Windows.Forms.TextBox Txthoy;
        private System.Windows.Forms.TextBox TxtOtraFecha;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvReporte;
    }
}