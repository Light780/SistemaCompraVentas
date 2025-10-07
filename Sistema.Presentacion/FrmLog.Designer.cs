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
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.PanelFiltros = new System.Windows.Forms.Panel();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.CboAccion = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.DtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.ChkFiltroFecha = new System.Windows.Forms.CheckBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TabGeneral.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.PanelBotones.SuspendLayout();
            this.PanelFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.TabPage1);
            this.TabGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabGeneral.Location = new System.Drawing.Point(0, 0);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1200, 650);
            this.TabGeneral.TabIndex = 0;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.DgvListado);
            this.TabPage1.Controls.Add(this.PanelBotones);
            this.TabPage1.Controls.Add(this.PanelFiltros);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(1192, 624);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Listado de Logs";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvListado.BackgroundColor = System.Drawing.Color.White;
            this.DgvListado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListado.Location = new System.Drawing.Point(3, 103);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(1186, 466);
            this.DgvListado.TabIndex = 2;
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // PanelBotones
            // 
            this.PanelBotones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelBotones.Controls.Add(this.LblTotal);
            this.PanelBotones.Controls.Add(this.BtnCerrar);
            this.PanelBotones.Controls.Add(this.BtnExportar);
            this.PanelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBotones.Location = new System.Drawing.Point(3, 569);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(1186, 52);
            this.PanelBotones.TabIndex = 1;
            // 
            // LblTotal
            // 
            this.LblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.LblTotal.Location = new System.Drawing.Point(850, 18);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(135, 15);
            this.LblTotal.TabIndex = 4;
            this.LblTotal.Text = "Total de registros: 0";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.Gray;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(1056, 10);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(120, 30);
            this.BtnCerrar.TabIndex = 3;
            this.BtnCerrar.Text = "❌ Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnExportar
            // 
            this.BtnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExportar.ForeColor = System.Drawing.Color.White;
            this.BtnExportar.Location = new System.Drawing.Point(10, 10);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(120, 30);
            this.BtnExportar.TabIndex = 0;
            this.BtnExportar.Text = "📥 Exportar";
            this.BtnExportar.UseVisualStyleBackColor = false;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // PanelFiltros
            // 
            this.PanelFiltros.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelFiltros.Controls.Add(this.BtnLimpiar);
            this.PanelFiltros.Controls.Add(this.BtnBuscar);
            this.PanelFiltros.Controls.Add(this.CboAccion);
            this.PanelFiltros.Controls.Add(this.Label4);
            this.PanelFiltros.Controls.Add(this.DtpFechaFin);
            this.PanelFiltros.Controls.Add(this.DtpFechaInicio);
            this.PanelFiltros.Controls.Add(this.ChkFiltroFecha);
            this.PanelFiltros.Controls.Add(this.Label3);
            this.PanelFiltros.Controls.Add(this.Label2);
            this.PanelFiltros.Controls.Add(this.TxtBuscar);
            this.PanelFiltros.Controls.Add(this.Label1);
            this.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFiltros.Location = new System.Drawing.Point(3, 3);
            this.PanelFiltros.Name = "PanelFiltros";
            this.PanelFiltros.Size = new System.Drawing.Size(1186, 100);
            this.PanelFiltros.TabIndex = 0;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Gray;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(500, 63);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(90, 27);
            this.BtnLimpiar.TabIndex = 10;
            this.BtnLimpiar.Text = "🗑️ Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(500, 33);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(90, 27);
            this.BtnBuscar.TabIndex = 9;
            this.BtnBuscar.Text = "🔍 Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // CboAccion
            // 
            this.CboAccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAccion.FormattingEnabled = true;
            this.CboAccion.Location = new System.Drawing.Point(350, 65);
            this.CboAccion.Name = "CboAccion";
            this.CboAccion.Size = new System.Drawing.Size(130, 21);
            this.CboAccion.TabIndex = 8;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(188, 68);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(38, 13);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Hasta:";
            // 
            // DtpFechaFin
            // 
            this.DtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaFin.Location = new System.Drawing.Point(230, 65);
            this.DtpFechaFin.Name = "DtpFechaFin";
            this.DtpFechaFin.Size = new System.Drawing.Size(100, 20);
            this.DtpFechaFin.TabIndex = 6;
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaInicio.Location = new System.Drawing.Point(80, 65);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.DtpFechaInicio.TabIndex = 5;
            // 
            // ChkFiltroFecha
            // 
            this.ChkFiltroFecha.AutoSize = true;
            this.ChkFiltroFecha.Checked = true;
            this.ChkFiltroFecha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkFiltroFecha.Location = new System.Drawing.Point(350, 37);
            this.ChkFiltroFecha.Name = "ChkFiltroFecha";
            this.ChkFiltroFecha.Size = new System.Drawing.Size(104, 17);
            this.ChkFiltroFecha.TabIndex = 4;
            this.ChkFiltroFecha.Text = "Filtrar por fechas";
            this.ChkFiltroFecha.UseVisualStyleBackColor = true;
            this.ChkFiltroFecha.CheckedChanged += new System.EventHandler(this.ChkFiltroFecha_CheckedChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(10, 68);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(41, 13);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Desde:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(10, 38);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(43, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Buscar:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(80, 35);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(250, 20);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Label1.Location = new System.Drawing.Point(10, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(135, 15);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Filtros de Búsqueda";
            // 
            // FrmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Auditoría - Logs del Sistema";
            this.Load += new System.EventHandler(this.FrmLog_Load);
            this.TabGeneral.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.PanelBotones.ResumeLayout(false);
            this.PanelBotones.PerformLayout();
            this.PanelFiltros.ResumeLayout(false);
            this.PanelFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.Panel PanelFiltros;
        private System.Windows.Forms.Panel PanelBotones;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.CheckBox ChkFiltroFecha;
        private System.Windows.Forms.DateTimePicker DtpFechaInicio;
        private System.Windows.Forms.DateTimePicker DtpFechaFin;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.ComboBox CboAccion;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnExportar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label LblTotal;
    }
}