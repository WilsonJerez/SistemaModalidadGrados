namespace VISTAS.REPORTES.DEFENSA
{
    partial class ReporteGraduadosPorFechas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnGenerarReporte = new System.Windows.Forms.Button();
            this.TxtFecha2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFecha1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CrvReporteGraduados = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BtnGenerarReporte);
            this.groupBox1.Controls.Add(this.TxtFecha2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtFecha1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(936, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS PARA GENERAR EL REPORTE";
            // 
            // BtnGenerarReporte
            // 
            this.BtnGenerarReporte.Location = new System.Drawing.Point(365, 74);
            this.BtnGenerarReporte.Name = "BtnGenerarReporte";
            this.BtnGenerarReporte.Size = new System.Drawing.Size(206, 34);
            this.BtnGenerarReporte.TabIndex = 4;
            this.BtnGenerarReporte.Text = "GENERAR REPORTE";
            this.BtnGenerarReporte.UseVisualStyleBackColor = true;
            this.BtnGenerarReporte.Click += new System.EventHandler(this.BtnGenerarReporte_Click);
            // 
            // TxtFecha2
            // 
            this.TxtFecha2.Location = new System.Drawing.Point(528, 32);
            this.TxtFecha2.Name = "TxtFecha2";
            this.TxtFecha2.Size = new System.Drawing.Size(100, 20);
            this.TxtFecha2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "FECHA 2";
            // 
            // TxtFecha1
            // 
            this.TxtFecha1.Location = new System.Drawing.Point(365, 32);
            this.TxtFecha1.Name = "TxtFecha1";
            this.TxtFecha1.Size = new System.Drawing.Size(100, 20);
            this.TxtFecha1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FECHA 1";
            // 
            // CrvReporteGraduados
            // 
            this.CrvReporteGraduados.ActiveViewIndex = -1;
            this.CrvReporteGraduados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvReporteGraduados.DisplayGroupTree = false;
            this.CrvReporteGraduados.Location = new System.Drawing.Point(9, 137);
            this.CrvReporteGraduados.Name = "CrvReporteGraduados";
            this.CrvReporteGraduados.SelectionFormula = "";
            this.CrvReporteGraduados.Size = new System.Drawing.Size(976, 546);
            this.CrvReporteGraduados.TabIndex = 1;
            this.CrvReporteGraduados.ViewTimeSelectionFormula = "";
            // 
            // ReporteGraduadosPorFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(994, 684);
            this.Controls.Add(this.CrvReporteGraduados);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ReporteGraduadosPorFechas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE DE ESTUDIANTES GRADUADOS EN UN INTERVALO DE FECHAS";
            this.Load += new System.EventHandler(this.ReporteGraduadosPorFechas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtFecha2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFecha1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGenerarReporte;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvReporteGraduados;
    }
}