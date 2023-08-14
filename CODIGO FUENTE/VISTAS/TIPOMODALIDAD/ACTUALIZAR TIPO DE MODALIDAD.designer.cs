namespace VISTAS.TIPOMODALIDAD.ACTUALIZAR
{
    partial class ACTUALIZAR_TIPO_DE_MODALIDAD
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
            this.label7 = new System.Windows.Forms.Label();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.TxtDescripcionTipo = new System.Windows.Forms.TextBox();
            this.TxtTipoModalidadX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.GridTipoModalidad = new System.Windows.Forms.DataGridView();
            this.ID_TIPO_MODALIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_MODALIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoModalidad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CmbEstado);
            this.groupBox1.Controls.Add(this.TxtDescripcionTipo);
            this.groupBox1.Controls.Add(this.TxtTipoModalidadX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(37, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 140);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACTUALIZAR TIPO DE MODALIDAD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "ESTADO";
            // 
            // CmbEstado
            // 
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.CmbEstado.Location = new System.Drawing.Point(398, 33);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(132, 21);
            this.CmbEstado.TabIndex = 9;
            this.CmbEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbEstado_KeyDown);
            // 
            // TxtDescripcionTipo
            // 
            this.TxtDescripcionTipo.Location = new System.Drawing.Point(156, 62);
            this.TxtDescripcionTipo.Multiline = true;
            this.TxtDescripcionTipo.Name = "TxtDescripcionTipo";
            this.TxtDescripcionTipo.Size = new System.Drawing.Size(374, 40);
            this.TxtDescripcionTipo.TabIndex = 3;
            // 
            // TxtTipoModalidadX
            // 
            this.TxtTipoModalidadX.Location = new System.Drawing.Point(156, 30);
            this.TxtTipoModalidadX.Name = "TxtTipoModalidadX";
            this.TxtTipoModalidadX.Size = new System.Drawing.Size(150, 20);
            this.TxtTipoModalidadX.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "DESCRIPCION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "TIPO MODALIDAD";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.Location = new System.Drawing.Point(271, 338);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(111, 34);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // GridTipoModalidad
            // 
            this.GridTipoModalidad.AllowUserToAddRows = false;
            this.GridTipoModalidad.AllowUserToDeleteRows = false;
            this.GridTipoModalidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTipoModalidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_TIPO_MODALIDAD,
            this.TIPO_MODALIDAD,
            this.DESCRIPCION,
            this.ESTADO});
            this.GridTipoModalidad.Location = new System.Drawing.Point(37, 33);
            this.GridTipoModalidad.Name = "GridTipoModalidad";
            this.GridTipoModalidad.ReadOnly = true;
            this.GridTipoModalidad.RowHeadersVisible = false;
            this.GridTipoModalidad.Size = new System.Drawing.Size(572, 133);
            this.GridTipoModalidad.TabIndex = 7;
            this.GridTipoModalidad.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridTipoModalidad_CellMouseDoubleClick);
            // 
            // ID_TIPO_MODALIDAD
            // 
            this.ID_TIPO_MODALIDAD.HeaderText = "ID_TIPO_MODALIDAD";
            this.ID_TIPO_MODALIDAD.Name = "ID_TIPO_MODALIDAD";
            this.ID_TIPO_MODALIDAD.ReadOnly = true;
            this.ID_TIPO_MODALIDAD.Visible = false;
            // 
            // TIPO_MODALIDAD
            // 
            this.TIPO_MODALIDAD.HeaderText = "TIPO_MODALIDAD";
            this.TIPO_MODALIDAD.Name = "TIPO_MODALIDAD";
            this.TIPO_MODALIDAD.ReadOnly = true;
            this.TIPO_MODALIDAD.Width = 200;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.Width = 300;
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // ACTUALIZAR_TIPO_DE_MODALIDAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 384);
            this.Controls.Add(this.GridTipoModalidad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnActualizar);
            this.MaximizeBox = false;
            this.Name = "ACTUALIZAR_TIPO_DE_MODALIDAD";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACTUALIZAR TIPO MODALIDAD";
            this.Load += new System.EventHandler(this.ACTUALIZAR_TIPO_DE_MODALIDAD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoModalidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox TxtDescripcionTipo;
        private System.Windows.Forms.TextBox TxtTipoModalidadX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GridTipoModalidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TIPO_MODALIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_MODALIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
    }
}