namespace VISTAS.TURNO
{
    partial class ActualizarTurno
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
            this.Inactivo = new System.Windows.Forms.RadioButton();
            this.Activo = new System.Windows.Forms.RadioButton();
            this.TxtMinutoSalida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtHoraSalida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMinutoEntrada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.TxtHoraEntrada = new System.Windows.Forms.TextBox();
            this.TxtTurno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GridTurno = new System.Windows.Forms.DataGridView();
            this.ID_TURNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TURNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA_INICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA_FINAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTurno)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Inactivo);
            this.groupBox1.Controls.Add(this.Activo);
            this.groupBox1.Controls.Add(this.TxtMinutoSalida);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtHoraSalida);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtMinutoEntrada);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BtnActualizar);
            this.groupBox1.Controls.Add(this.TxtHoraEntrada);
            this.groupBox1.Controls.Add(this.TxtTurno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(109, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 217);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS A MODIFICAR PARA EL TURNO";
            // 
            // Inactivo
            // 
            this.Inactivo.AutoSize = true;
            this.Inactivo.Location = new System.Drawing.Point(185, 136);
            this.Inactivo.Name = "Inactivo";
            this.Inactivo.Size = new System.Drawing.Size(75, 17);
            this.Inactivo.TabIndex = 14;
            this.Inactivo.TabStop = true;
            this.Inactivo.Text = "INACTIVO";
            this.Inactivo.UseVisualStyleBackColor = true;
            // 
            // Activo
            // 
            this.Activo.AutoSize = true;
            this.Activo.Location = new System.Drawing.Point(115, 136);
            this.Activo.Name = "Activo";
            this.Activo.Size = new System.Drawing.Size(64, 17);
            this.Activo.TabIndex = 13;
            this.Activo.TabStop = true;
            this.Activo.Text = "ACTIVO";
            this.Activo.UseVisualStyleBackColor = true;
            // 
            // TxtMinutoSalida
            // 
            this.TxtMinutoSalida.Location = new System.Drawing.Point(170, 91);
            this.TxtMinutoSalida.Name = "TxtMinutoSalida";
            this.TxtMinutoSalida.Size = new System.Drawing.Size(30, 20);
            this.TxtMinutoSalida.TabIndex = 12;
            this.TxtMinutoSalida.Text = "mm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = ":";
            // 
            // TxtHoraSalida
            // 
            this.TxtHoraSalida.Location = new System.Drawing.Point(121, 91);
            this.TxtHoraSalida.Name = "TxtHoraSalida";
            this.TxtHoraSalida.Size = new System.Drawing.Size(30, 20);
            this.TxtHoraSalida.TabIndex = 10;
            this.TxtHoraSalida.Text = "hh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "HORA SALIDA";
            // 
            // TxtMinutoEntrada
            // 
            this.TxtMinutoEntrada.Location = new System.Drawing.Point(170, 55);
            this.TxtMinutoEntrada.Name = "TxtMinutoEntrada";
            this.TxtMinutoEntrada.Size = new System.Drawing.Size(30, 20);
            this.TxtMinutoEntrada.TabIndex = 8;
            this.TxtMinutoEntrada.Text = "mm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = ":";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnActualizar.Location = new System.Drawing.Point(89, 175);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(111, 36);
            this.BtnActualizar.TabIndex = 6;
            this.BtnActualizar.Text = "ACTUALIZAR TURNO";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // TxtHoraEntrada
            // 
            this.TxtHoraEntrada.Location = new System.Drawing.Point(121, 55);
            this.TxtHoraEntrada.Name = "TxtHoraEntrada";
            this.TxtHoraEntrada.Size = new System.Drawing.Size(30, 20);
            this.TxtHoraEntrada.TabIndex = 4;
            this.TxtHoraEntrada.Text = "hh";
            // 
            // TxtTurno
            // 
            this.TxtTurno.Location = new System.Drawing.Point(117, 20);
            this.TxtTurno.Name = "TxtTurno";
            this.TxtTurno.Size = new System.Drawing.Size(152, 20);
            this.TxtTurno.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "HORA INGRESO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "TURNO";
            // 
            // GridTurno
            // 
            this.GridTurno.AllowUserToAddRows = false;
            this.GridTurno.AllowUserToDeleteRows = false;
            this.GridTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTurno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_TURNO,
            this.TURNO,
            this.HORA_INICIO,
            this.HORA_FINAL,
            this.ESTADO});
            this.GridTurno.Location = new System.Drawing.Point(53, 23);
            this.GridTurno.Name = "GridTurno";
            this.GridTurno.ReadOnly = true;
            this.GridTurno.RowHeadersVisible = false;
            this.GridTurno.Size = new System.Drawing.Size(406, 150);
            this.GridTurno.TabIndex = 15;
            this.GridTurno.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridTurno_CellMouseDoubleClick);
            // 
            // ID_TURNO
            // 
            this.ID_TURNO.HeaderText = "ID_TURNO";
            this.ID_TURNO.Name = "ID_TURNO";
            this.ID_TURNO.ReadOnly = true;
            this.ID_TURNO.Visible = false;
            // 
            // TURNO
            // 
            this.TURNO.HeaderText = "TURNO";
            this.TURNO.Name = "TURNO";
            this.TURNO.ReadOnly = true;
            // 
            // HORA_INICIO
            // 
            this.HORA_INICIO.HeaderText = "HORA INICIO";
            this.HORA_INICIO.Name = "HORA_INICIO";
            this.HORA_INICIO.ReadOnly = true;
            // 
            // HORA_FINAL
            // 
            this.HORA_FINAL.HeaderText = "HORA SALIDA";
            this.HORA_FINAL.Name = "HORA_FINAL";
            this.HORA_FINAL.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // ActualizarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VISTAS.Properties.Resources.formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(512, 437);
            this.Controls.Add(this.GridTurno);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ActualizarTurno";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACTUALIZAR TURNO";
            this.Load += new System.EventHandler(this.ActualizarTurno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTurno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtMinutoSalida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtHoraSalida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMinutoEntrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.TextBox TxtHoraEntrada;
        private System.Windows.Forms.TextBox TxtTurno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TURNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TURNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA_INICIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA_FINAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.RadioButton Inactivo;
        private System.Windows.Forms.RadioButton Activo;
    }
}