namespace VISTAS.REPORTES.MODALIDAD_I
{
    partial class ReporteModalidad_I_I
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
            this.CrvReporteModalidad_I_I = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbInactivo = new System.Windows.Forms.RadioButton();
            this.RbActivo = new System.Windows.Forms.RadioButton();
            this.CkbGrupo = new System.Windows.Forms.CheckBox();
            this.CmbGrupos = new System.Windows.Forms.ComboBox();
            this.CmbCarreras = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbTipoModalidad = new System.Windows.Forms.ComboBox();
            this.CkbTipoModalidad = new System.Windows.Forms.CheckBox();
            this.TxtGestion = new System.Windows.Forms.TextBox();
            this.CkbCarrera = new System.Windows.Forms.CheckBox();
            this.BtnGenerarReporte = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CrvReporteModalidad_I_I
            // 
            this.CrvReporteModalidad_I_I.ActiveViewIndex = -1;
            this.CrvReporteModalidad_I_I.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvReporteModalidad_I_I.Cursor = System.Windows.Forms.Cursors.Cross;
            this.CrvReporteModalidad_I_I.DisplayGroupTree = false;
            this.CrvReporteModalidad_I_I.Location = new System.Drawing.Point(12, 175);
            this.CrvReporteModalidad_I_I.Name = "CrvReporteModalidad_I_I";
            this.CrvReporteModalidad_I_I.SelectionFormula = "";
            this.CrvReporteModalidad_I_I.Size = new System.Drawing.Size(1115, 508);
            this.CrvReporteModalidad_I_I.TabIndex = 0;
            this.CrvReporteModalidad_I_I.ViewTimeSelectionFormula = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.RbInactivo);
            this.groupBox1.Controls.Add(this.RbActivo);
            this.groupBox1.Controls.Add(this.CkbGrupo);
            this.groupBox1.Controls.Add(this.CmbGrupos);
            this.groupBox1.Controls.Add(this.CmbCarreras);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CmbTipoModalidad);
            this.groupBox1.Controls.Add(this.CkbTipoModalidad);
            this.groupBox1.Controls.Add(this.TxtGestion);
            this.groupBox1.Controls.Add(this.CkbCarrera);
            this.groupBox1.Controls.Add(this.BtnGenerarReporte);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(93, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 157);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PARAMETROS PARA GENERAR EL REPORTE";
            // 
            // RbInactivo
            // 
            this.RbInactivo.AutoSize = true;
            this.RbInactivo.Location = new System.Drawing.Point(315, 90);
            this.RbInactivo.Name = "RbInactivo";
            this.RbInactivo.Size = new System.Drawing.Size(63, 17);
            this.RbInactivo.TabIndex = 14;
            this.RbInactivo.TabStop = true;
            this.RbInactivo.Text = "Inactivo";
            this.RbInactivo.UseVisualStyleBackColor = true;
            // 
            // RbActivo
            // 
            this.RbActivo.AutoSize = true;
            this.RbActivo.Checked = true;
            this.RbActivo.Location = new System.Drawing.Point(230, 90);
            this.RbActivo.Name = "RbActivo";
            this.RbActivo.Size = new System.Drawing.Size(55, 17);
            this.RbActivo.TabIndex = 13;
            this.RbActivo.TabStop = true;
            this.RbActivo.Text = "Activo";
            this.RbActivo.UseVisualStyleBackColor = true;
            // 
            // CkbGrupo
            // 
            this.CkbGrupo.AutoSize = true;
            this.CkbGrupo.Location = new System.Drawing.Point(230, 44);
            this.CkbGrupo.Name = "CkbGrupo";
            this.CkbGrupo.Size = new System.Drawing.Size(91, 17);
            this.CkbGrupo.TabIndex = 10;
            this.CkbGrupo.Text = "POR GRUPO";
            this.CkbGrupo.UseVisualStyleBackColor = true;
            this.CkbGrupo.CheckedChanged += new System.EventHandler(this.CkbGrupo_CheckedChanged);
            // 
            // CmbGrupos
            // 
            this.CmbGrupos.Enabled = false;
            this.CmbGrupos.FormattingEnabled = true;
            this.CmbGrupos.Location = new System.Drawing.Point(230, 63);
            this.CmbGrupos.Name = "CmbGrupos";
            this.CmbGrupos.Size = new System.Drawing.Size(148, 21);
            this.CmbGrupos.TabIndex = 1;
            this.CmbGrupos.SelectedIndexChanged += new System.EventHandler(this.CmbGrupos_SelectedIndexChanged);
            this.CmbGrupos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbGrupos_KeyDown);
            // 
            // CmbCarreras
            // 
            this.CmbCarreras.Enabled = false;
            this.CmbCarreras.FormattingEnabled = true;
            this.CmbCarreras.Location = new System.Drawing.Point(461, 63);
            this.CmbCarreras.Name = "CmbCarreras";
            this.CmbCarreras.Size = new System.Drawing.Size(218, 21);
            this.CmbCarreras.TabIndex = 3;
            this.CmbCarreras.SelectedIndexChanged += new System.EventHandler(this.CmbCarreras_SelectedIndexChanged);
            this.CmbCarreras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbCarreras_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "GESTION";
            // 
            // CmbTipoModalidad
            // 
            this.CmbTipoModalidad.Enabled = false;
            this.CmbTipoModalidad.FormattingEnabled = true;
            this.CmbTipoModalidad.Location = new System.Drawing.Point(729, 63);
            this.CmbTipoModalidad.Name = "CmbTipoModalidad";
            this.CmbTipoModalidad.Size = new System.Drawing.Size(218, 21);
            this.CmbTipoModalidad.TabIndex = 4;
            this.CmbTipoModalidad.SelectedIndexChanged += new System.EventHandler(this.CmbTipoModalidad_SelectedIndexChanged);
            this.CmbTipoModalidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbTipoModalidad_KeyDown);
            // 
            // CkbTipoModalidad
            // 
            this.CkbTipoModalidad.AutoSize = true;
            this.CkbTipoModalidad.Location = new System.Drawing.Point(729, 41);
            this.CkbTipoModalidad.Name = "CkbTipoModalidad";
            this.CkbTipoModalidad.Size = new System.Drawing.Size(144, 17);
            this.CkbTipoModalidad.TabIndex = 12;
            this.CkbTipoModalidad.Text = "POR TIPO MODALIDAD";
            this.CkbTipoModalidad.UseVisualStyleBackColor = true;
            this.CkbTipoModalidad.CheckedChanged += new System.EventHandler(this.CkbTipoModalidad_CheckedChanged);
            // 
            // TxtGestion
            // 
            this.TxtGestion.Location = new System.Drawing.Point(21, 63);
            this.TxtGestion.Name = "TxtGestion";
            this.TxtGestion.Size = new System.Drawing.Size(101, 20);
            this.TxtGestion.TabIndex = 0;
            // 
            // CkbCarrera
            // 
            this.CkbCarrera.AutoSize = true;
            this.CkbCarrera.Location = new System.Drawing.Point(461, 44);
            this.CkbCarrera.Name = "CkbCarrera";
            this.CkbCarrera.Size = new System.Drawing.Size(104, 17);
            this.CkbCarrera.TabIndex = 11;
            this.CkbCarrera.Text = "POR CARRERA";
            this.CkbCarrera.UseVisualStyleBackColor = true;
            this.CkbCarrera.CheckedChanged += new System.EventHandler(this.CkbCarrera_CheckedChanged);
            // 
            // BtnGenerarReporte
            // 
            this.BtnGenerarReporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnGenerarReporte.Location = new System.Drawing.Point(388, 119);
            this.BtnGenerarReporte.Name = "BtnGenerarReporte";
            this.BtnGenerarReporte.Size = new System.Drawing.Size(176, 32);
            this.BtnGenerarReporte.TabIndex = 6;
            this.BtnGenerarReporte.Text = "GENERAR REPORTE";
            this.BtnGenerarReporte.UseVisualStyleBackColor = true;
            this.BtnGenerarReporte.Click += new System.EventHandler(this.BtnGenerarReporte_Click);
            // 
            // ReporteModalidad_I_I
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1139, 695);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CrvReporteModalidad_I_I);
            this.MaximizeBox = false;
            this.Name = "ReporteModalidad_I_I";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE MODALIDAD I.I";
            this.Load += new System.EventHandler(this.ReporteModalidad_I_I_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvReporteModalidad_I_I;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbCarreras;
        private System.Windows.Forms.ComboBox CmbGrupos;
        private System.Windows.Forms.TextBox TxtGestion;
        private System.Windows.Forms.Button BtnGenerarReporte;
        private System.Windows.Forms.ComboBox CmbTipoModalidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CkbTipoModalidad;
        private System.Windows.Forms.CheckBox CkbCarrera;
        private System.Windows.Forms.CheckBox CkbGrupo;
        private System.Windows.Forms.RadioButton RbActivo;
        private System.Windows.Forms.RadioButton RbInactivo;
    }
}