namespace Sistema.Presentacion
{
    partial class FrmLog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.PanelFiltros = new System.Windows.Forms.Panel();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.CboAccion = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.DtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.ChkFiltroFecha = new System.Windows.Forms.CheckBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.PanelInferior = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).BeginInit();
            this.PanelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.PanelInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.PanelSuperior.Controls.Add(this.LblDescripcion);
            this.PanelSuperior.Controls.Add(this.LblTitulo);
            this.PanelSuperior.Controls.Add(this.PictureBoxIcon);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Padding = new System.Windows.Forms.Padding(20);
            this.PanelSuperior.Size = new System.Drawing.Size(1200, 100);
            this.PanelSuperior.TabIndex = 0;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.LblDescripcion.Location = new System.Drawing.Point(83, 60);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(575, 19);
            this.LblDescripcion.TabIndex = 2;
            this.LblDescripcion.Text = "Consulte todas las actividades realizadas en el sistema: accesos, modificaciones " +
    "y operaciones";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(80, 25);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(300, 32);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "📋 Registro de Auditoría";
            // 
            // PictureBoxIcon
            // 
            this.PictureBoxIcon.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxIcon.Location = new System.Drawing.Point(20, 25);
            this.PictureBoxIcon.Name = "PictureBoxIcon";
            this.PictureBoxIcon.Size = new System.Drawing.Size(50, 50);
            this.PictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxIcon.TabIndex = 0;
            this.PictureBoxIcon.TabStop = false;
            // 
            // PanelFiltros
            // 
            this.PanelFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.PanelFiltros.Controls.Add(this.BtnLimpiar);
            this.PanelFiltros.Controls.Add(this.BtnBuscar);
            this.PanelFiltros.Controls.Add(this.CboAccion);
            this.PanelFiltros.Controls.Add(this.Label4);
            this.PanelFiltros.Controls.Add(this.DtpFechaFin);
            this.PanelFiltros.Controls.Add(this.DtpFechaInicio);
            this.PanelFiltros.Controls.Add(this.ChkFiltroFecha);
            this.PanelFiltros.Controls.Add(this.Label2);
            this.PanelFiltros.Controls.Add(this.TxtBuscar);
            this.PanelFiltros.Controls.Add(this.Label1);
            this.PanelFiltros.Controls.Add(this.Label3);
            this.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFiltros.Location = new System.Drawing.Point(0, 100);
            this.PanelFiltros.Name = "PanelFiltros";
            this.PanelFiltros.Padding = new System.Windows.Forms.Padding(20);
            this.PanelFiltros.Size = new System.Drawing.Size(1200, 130);
            this.PanelFiltros.TabIndex = 1;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(920, 66);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(110, 30);
            this.BtnLimpiar.TabIndex = 10;
            this.BtnLimpiar.Text = "🔄 Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(800, 66);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(110, 30);
            this.BtnBuscar.TabIndex = 9;
            this.BtnBuscar.Text = "🔍 Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // CboAccion
            // 
            this.CboAccion.BackColor = System.Drawing.Color.White;
            this.CboAccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboAccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CboAccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.CboAccion.FormattingEnabled = true;
            this.CboAccion.Location = new System.Drawing.Point(634, 70);
            this.CboAccion.Name = "CboAccion";
            this.CboAccion.Size = new System.Drawing.Size(150, 23);
            this.CboAccion.TabIndex = 8;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.Label4.Location = new System.Drawing.Point(630, 50);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(47, 15);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Acción:";
            // 
            // DtpFechaFin
            // 
            this.DtpFechaFin.CalendarFont = new System.Drawing.Font("Segoe UI", 9F);
            this.DtpFechaFin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaFin.Location = new System.Drawing.Point(494, 70);
            this.DtpFechaFin.Name = "DtpFechaFin";
            this.DtpFechaFin.Size = new System.Drawing.Size(120, 23);
            this.DtpFechaFin.TabIndex = 6;
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.CalendarFont = new System.Drawing.Font("Segoe UI", 9F);
            this.DtpFechaInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaInicio.Location = new System.Drawing.Point(334, 70);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.Size = new System.Drawing.Size(120, 23);
            this.DtpFechaInicio.TabIndex = 5;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.Label3.Location = new System.Drawing.Point(290, 72);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(39, 15);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Desde";
            // 
            // ChkFiltroFecha
            // 
            this.ChkFiltroFecha.AutoSize = true;
            this.ChkFiltroFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ChkFiltroFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ChkFiltroFecha.Location = new System.Drawing.Point(290, 50);
            this.ChkFiltroFecha.Name = "ChkFiltroFecha";
            this.ChkFiltroFecha.Size = new System.Drawing.Size(126, 19);
            this.ChkFiltroFecha.TabIndex = 3;
            this.ChkFiltroFecha.Text = "📅 Filtrar por Fecha";
            this.ChkFiltroFecha.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.Label2.Location = new System.Drawing.Point(24, 50);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(109, 15);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Buscar por Usuario:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.Color.White;
            this.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.TxtBuscar.Location = new System.Drawing.Point(24, 70);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(250, 25);
            this.TxtBuscar.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Label1.Location = new System.Drawing.Point(20, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(164, 19);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "🔍 Filtros de Búsqueda";
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.BackgroundColor = System.Drawing.Color.White;
            this.DgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListado.ColumnHeadersHeight = 40;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListado.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListado.EnableHeadersVisualStyles = false;
            this.DgvListado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.DgvListado.Location = new System.Drawing.Point(0, 230);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvListado.RowHeadersVisible = false;
            this.DgvListado.RowTemplate.Height = 32;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(1200, 348);
            this.DgvListado.TabIndex = 2;
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // PanelInferior
            // 
            this.PanelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.PanelInferior.Controls.Add(this.BtnCerrar);
            this.PanelInferior.Controls.Add(this.BtnExportar);
            this.PanelInferior.Controls.Add(this.LblTotal);
            this.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInferior.Location = new System.Drawing.Point(0, 578);
            this.PanelInferior.Name = "PanelInferior";
            this.PanelInferior.Padding = new System.Windows.Forms.Padding(20);
            this.PanelInferior.Size = new System.Drawing.Size(1200, 72);
            this.PanelInferior.TabIndex = 3;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(1030, 19);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(150, 35);
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.Text = "✖ Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnExportar
            // 
            this.BtnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.BtnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExportar.FlatAppearance.BorderSize = 0;
            this.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExportar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnExportar.ForeColor = System.Drawing.Color.White;
            this.BtnExportar.Location = new System.Drawing.Point(869, 19);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(150, 35);
            this.BtnExportar.TabIndex = 1;
            this.BtnExportar.Text = "📥 Exportar";
            this.BtnExportar.UseVisualStyleBackColor = false;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.LblTotal.Location = new System.Drawing.Point(20, 26);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(166, 19);
            this.LblTotal.TabIndex = 0;
            this.LblTotal.Text = "📊 Total de registros: 0";
            // 
            // FrmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.DgvListado);
            this.Controls.Add(this.PanelInferior);
            this.Controls.Add(this.PanelFiltros);
            this.Controls.Add(this.PanelSuperior);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "📋 Auditoría - Registro del Sistema";
            this.Load += new System.EventHandler(this.FrmLog_Load);
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).EndInit();
            this.PanelFiltros.ResumeLayout(false);
            this.PanelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.PanelInferior.ResumeLayout(false);
            this.PanelInferior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.PictureBox PictureBoxIcon;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblDescripcion;

        private System.Windows.Forms.Panel PanelFiltros;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.CheckBox ChkFiltroFecha;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.DateTimePicker DtpFechaInicio;
        private System.Windows.Forms.DateTimePicker DtpFechaFin;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.ComboBox CboAccion;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnLimpiar;

        private System.Windows.Forms.DataGridView DgvListado;

        private System.Windows.Forms.Panel PanelInferior;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button BtnExportar;
        private System.Windows.Forms.Button BtnCerrar;
    }
}