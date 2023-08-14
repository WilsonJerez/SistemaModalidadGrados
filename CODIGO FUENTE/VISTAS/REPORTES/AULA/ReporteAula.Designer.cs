namespace VISTAS.REPORTES.AULA
{
    partial class ReporteAula
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RbActivas = new System.Windows.Forms.RadioButton();
            this.RbInactivas = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RbMenorQue = new System.Windows.Forms.RadioButton();
            this.RbMayorQue = new System.Windows.Forms.RadioButton();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtPiso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGenerarReporte = new System.Windows.Forms.Button();
            this.CrvReporteAulas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.TxtPiso);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnGenerarReporte);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(156, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS PARA GENERAR REPORTE";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RbActivas);
            this.groupBox3.Controls.Add(this.RbInactivas);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(382, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 105);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ESTADO DEL AULA";
            // 
            // RbActivas
            // 
            this.RbActivas.AutoSize = true;
            this.RbActivas.Checked = true;
            this.RbActivas.Location = new System.Drawing.Point(34, 27);
            this.RbActivas.Name = "RbActivas";
            this.RbActivas.Size = new System.Drawing.Size(70, 17);
            this.RbActivas.TabIndex = 5;
            this.RbActivas.TabStop = true;
            this.RbActivas.Text = "ACTIVAS";
            this.RbActivas.UseVisualStyleBackColor = true;
            // 
            // RbInactivas
            // 
            this.RbInactivas.AutoSize = true;
            this.RbInactivas.Location = new System.Drawing.Point(34, 65);
            this.RbInactivas.Name = "RbInactivas";
            this.RbInactivas.Size = new System.Drawing.Size(81, 17);
            this.RbInactivas.TabIndex = 6;
            this.RbInactivas.Text = "INACTIVAS";
            this.RbInactivas.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RbMenorQue);
            this.groupBox2.Controls.Add(this.RbMayorQue);
            this.groupBox2.Controls.Add(this.TxtCantidad);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(141, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 105);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CAPACIDAD DEL AULA";
            // 
            // RbMenorQue
            // 
            this.RbMenorQue.AutoSize = true;
            this.RbMenorQue.Location = new System.Drawing.Point(6, 65);
            this.RbMenorQue.Name = "RbMenorQue";
            this.RbMenorQue.Size = new System.Drawing.Size(91, 17);
            this.RbMenorQue.TabIndex = 8;
            this.RbMenorQue.Text = "MENOR QUE";
            this.RbMenorQue.UseVisualStyleBackColor = true;
            // 
            // RbMayorQue
            // 
            this.RbMayorQue.AutoSize = true;
            this.RbMayorQue.Checked = true;
            this.RbMayorQue.Location = new System.Drawing.Point(6, 27);
            this.RbMayorQue.Name = "RbMayorQue";
            this.RbMayorQue.Size = new System.Drawing.Size(90, 17);
            this.RbMayorQue.TabIndex = 8;
            this.RbMayorQue.TabStop = true;
            this.RbMayorQue.Text = "MAYOR QUE";
            this.RbMayorQue.UseVisualStyleBackColor = true;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(126, 45);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(81, 20);
            this.TxtCantidad.TabIndex = 4;
            this.TxtCantidad.Text = "0";
            // 
            // TxtPiso
            // 
            this.TxtPiso.Location = new System.Drawing.Point(38, 67);
            this.TxtPiso.Name = "TxtPiso";
            this.TxtPiso.Size = new System.Drawing.Size(68, 20);
            this.TxtPiso.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PISO";
            // 
            // BtnGenerarReporte
            // 
            this.BtnGenerarReporte.Location = new System.Drawing.Point(287, 140);
            this.BtnGenerarReporte.Name = "BtnGenerarReporte";
            this.BtnGenerarReporte.Size = new System.Drawing.Size(141, 28);
            this.BtnGenerarReporte.TabIndex = 0;
            this.BtnGenerarReporte.Text = "GENERAR REPORTE";
            this.BtnGenerarReporte.UseVisualStyleBackColor = true;
            this.BtnGenerarReporte.Click += new System.EventHandler(this.BtnGenerarReporte_Click);
            // 
            // CrvReporteAulas
            // 
            this.CrvReporteAulas.ActiveViewIndex = -1;
            this.CrvReporteAulas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvReporteAulas.DisplayGroupTree = false;
            this.CrvReporteAulas.Location = new System.Drawing.Point(12, 212);
            this.CrvReporteAulas.Name = "CrvReporteAulas";
            this.CrvReporteAulas.SelectionFormula = "";
            this.CrvReporteAulas.Size = new System.Drawing.Size(992, 521);
            this.CrvReporteAulas.TabIndex = 1;
            this.CrvReporteAulas.ViewTimeSelectionFormula = "";
            // 
            // ReporteAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 734);
            this.Controls.Add(this.CrvReporteAulas);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ReporteAula";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTES DE AULAS";
            this.Load += new System.EventHandler(this.ReporteAula_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvReporteAulas;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.TextBox TxtPiso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGenerarReporte;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RbActivas;
        private System.Windows.Forms.RadioButton RbInactivas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RbMenorQue;
        private System.Windows.Forms.RadioButton RbMayorQue;
    }
}