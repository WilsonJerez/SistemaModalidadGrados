namespace VISTAS.REPORTES.MODALIDAD_I
{
    partial class ReporteTemas
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
            this.CkbTipoModalidad = new System.Windows.Forms.CheckBox();
            this.CmbTipoModalidad = new System.Windows.Forms.ComboBox();
            this.TxtFacultad = new System.Windows.Forms.TextBox();
            this.CkbCarrera = new System.Windows.Forms.CheckBox();
            this.CkbFacultad = new System.Windows.Forms.CheckBox();
            this.BtnGenerarReporte = new System.Windows.Forms.Button();
            this.CmbCarrera = new System.Windows.Forms.ComboBox();
            this.CrvTemas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.CkbTipoModalidad);
            this.groupBox1.Controls.Add(this.CmbTipoModalidad);
            this.groupBox1.Controls.Add(this.TxtFacultad);
            this.groupBox1.Controls.Add(this.CkbCarrera);
            this.groupBox1.Controls.Add(this.CkbFacultad);
            this.groupBox1.Controls.Add(this.BtnGenerarReporte);
            this.groupBox1.Controls.Add(this.CmbCarrera);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1026, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PARAMETROS PARA EL REPORTE";
            // 
            // CkbTipoModalidad
            // 
            this.CkbTipoModalidad.AutoSize = true;
            this.CkbTipoModalidad.Location = new System.Drawing.Point(706, 31);
            this.CkbTipoModalidad.Name = "CkbTipoModalidad";
            this.CkbTipoModalidad.Size = new System.Drawing.Size(118, 17);
            this.CkbTipoModalidad.TabIndex = 6;
            this.CkbTipoModalidad.Text = "TIPO MODALIDAD";
            this.CkbTipoModalidad.UseVisualStyleBackColor = true;
            this.CkbTipoModalidad.CheckedChanged += new System.EventHandler(this.CkbTipoModalidad_CheckedChanged);
            // 
            // CmbTipoModalidad
            // 
            this.CmbTipoModalidad.Enabled = false;
            this.CmbTipoModalidad.FormattingEnabled = true;
            this.CmbTipoModalidad.Location = new System.Drawing.Point(706, 54);
            this.CmbTipoModalidad.Name = "CmbTipoModalidad";
            this.CmbTipoModalidad.Size = new System.Drawing.Size(314, 21);
            this.CmbTipoModalidad.TabIndex = 5;
            this.CmbTipoModalidad.SelectedIndexChanged += new System.EventHandler(this.CmbTipoModalidad_SelectedIndexChanged);
            this.CmbTipoModalidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbTipoModalidad_KeyDown);
            // 
            // TxtFacultad
            // 
            this.TxtFacultad.Location = new System.Drawing.Point(28, 54);
            this.TxtFacultad.Name = "TxtFacultad";
            this.TxtFacultad.ReadOnly = true;
            this.TxtFacultad.Size = new System.Drawing.Size(302, 20);
            this.TxtFacultad.TabIndex = 4;
            // 
            // CkbCarrera
            // 
            this.CkbCarrera.AutoSize = true;
            this.CkbCarrera.Location = new System.Drawing.Point(357, 31);
            this.CkbCarrera.Name = "CkbCarrera";
            this.CkbCarrera.Size = new System.Drawing.Size(78, 17);
            this.CkbCarrera.TabIndex = 3;
            this.CkbCarrera.Text = "CARRERA";
            this.CkbCarrera.UseVisualStyleBackColor = true;
            this.CkbCarrera.CheckedChanged += new System.EventHandler(this.CkbCarrera_CheckedChanged);
            // 
            // CkbFacultad
            // 
            this.CkbFacultad.AutoSize = true;
            this.CkbFacultad.Location = new System.Drawing.Point(28, 31);
            this.CkbFacultad.Name = "CkbFacultad";
            this.CkbFacultad.Size = new System.Drawing.Size(82, 17);
            this.CkbFacultad.TabIndex = 2;
            this.CkbFacultad.Text = "FACULTAD";
            this.CkbFacultad.UseVisualStyleBackColor = true;
            this.CkbFacultad.CheckedChanged += new System.EventHandler(this.CkbFacultad_CheckedChanged);
            // 
            // BtnGenerarReporte
            // 
            this.BtnGenerarReporte.Location = new System.Drawing.Point(437, 108);
            this.BtnGenerarReporte.Name = "BtnGenerarReporte";
            this.BtnGenerarReporte.Size = new System.Drawing.Size(152, 35);
            this.BtnGenerarReporte.TabIndex = 1;
            this.BtnGenerarReporte.Text = "GENERAR REPORTE";
            this.BtnGenerarReporte.UseVisualStyleBackColor = true;
            this.BtnGenerarReporte.Click += new System.EventHandler(this.BtnGenerarReporte_Click);
            // 
            // CmbCarrera
            // 
            this.CmbCarrera.Enabled = false;
            this.CmbCarrera.FormattingEnabled = true;
            this.CmbCarrera.Location = new System.Drawing.Point(357, 54);
            this.CmbCarrera.Name = "CmbCarrera";
            this.CmbCarrera.Size = new System.Drawing.Size(314, 21);
            this.CmbCarrera.TabIndex = 0;
            this.CmbCarrera.SelectedIndexChanged += new System.EventHandler(this.CmbCarrera_SelectedIndexChanged);
            this.CmbCarrera.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbCarrera_KeyDown);
            // 
            // CrvTemas
            // 
            this.CrvTemas.ActiveViewIndex = -1;
            this.CrvTemas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvTemas.DisplayGroupTree = false;
            this.CrvTemas.Location = new System.Drawing.Point(14, 178);
            this.CrvTemas.Name = "CrvTemas";
            this.CrvTemas.SelectionFormula = "";
            this.CrvTemas.Size = new System.Drawing.Size(1026, 503);
            this.CrvTemas.TabIndex = 1;
            this.CrvTemas.ViewTimeSelectionFormula = "";
            // 
            // ReporteTemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 693);
            this.Controls.Add(this.CrvTemas);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ReporteTemas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE DE TEMAS";
            this.Load += new System.EventHandler(this.ReporteTemas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvTemas;
        private System.Windows.Forms.TextBox TxtFacultad;
        private System.Windows.Forms.CheckBox CkbCarrera;
        private System.Windows.Forms.CheckBox CkbFacultad;
        private System.Windows.Forms.Button BtnGenerarReporte;
        private System.Windows.Forms.ComboBox CmbCarrera;
        private System.Windows.Forms.CheckBox CkbTipoModalidad;
        private System.Windows.Forms.ComboBox CmbTipoModalidad;
    }
}