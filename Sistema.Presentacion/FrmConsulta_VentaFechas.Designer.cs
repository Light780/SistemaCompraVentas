namespace Sistema.Presentacion
{
    partial class FrmConsulta_VentaFechas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PanelMostrar = new System.Windows.Forms.Panel();
            this.DgvMostrarDetalle = new System.Windows.Forms.DataGridView();
            this.PanelTotalesDetalle = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtSubtotalD = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtTotalImpuestoD = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtTotalD = new System.Windows.Forms.TextBox();
            this.BtnCerrarDetalle = new System.Windows.Forms.Button();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PanelInferior = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.PanelBusqueda = new System.Windows.Forms.Panel();
            this.btnComprobante = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnExportar = new System.Windows.Forms.Button();
            this.TabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.PanelMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrarDetalle)).BeginInit();
            this.PanelTotalesDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.PanelInferior.SuspendLayout();
            this.PanelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabPage1);
            this.TabGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabGeneral.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TabGeneral.Location = new System.Drawing.Point(0, 0);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1200, 700);
            this.TabGeneral.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.PanelMostrar);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Controls.Add(this.PanelInferior);
            this.tabPage1.Controls.Add(this.PanelBusqueda);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(20);
            this.tabPage1.Size = new System.Drawing.Size(1192, 670);
            this.tabPage1.TabIndex = 0;
            // 
            // PanelMostrar
            // 
            this.PanelMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelMostrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMostrar.Controls.Add(this.DgvMostrarDetalle);
            this.PanelMostrar.Controls.Add(this.PanelTotalesDetalle);
            this.PanelMostrar.Controls.Add(this.BtnCerrarDetalle);
            this.PanelMostrar.Location = new System.Drawing.Point(150, 150);
            this.PanelMostrar.Name = "PanelMostrar";
            this.PanelMostrar.Size = new System.Drawing.Size(900, 450);
            this.PanelMostrar.TabIndex = 3;
            this.PanelMostrar.Visible = false;
            // 
            // DgvMostrarDetalle
            // 
            this.DgvMostrarDetalle.AllowUserToAddRows = false;
            this.DgvMostrarDetalle.AllowUserToDeleteRows = false;
            this.DgvMostrarDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvMostrarDetalle.BackgroundColor = System.Drawing.Color.White;
            this.DgvMostrarDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvMostrarDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMostrarDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DgvMostrarDetalle.ColumnHeadersHeight = 35;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvMostrarDetalle.DefaultCellStyle = dataGridViewCellStyle11;
            this.DgvMostrarDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.DgvMostrarDetalle.EnableHeadersVisualStyles = false;
            this.DgvMostrarDetalle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.DgvMostrarDetalle.Location = new System.Drawing.Point(0, 0);
            this.DgvMostrarDetalle.Name = "DgvMostrarDetalle";
            this.DgvMostrarDetalle.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMostrarDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DgvMostrarDetalle.RowHeadersVisible = false;
            this.DgvMostrarDetalle.RowHeadersWidth = 51;
            this.DgvMostrarDetalle.RowTemplate.Height = 30;
            this.DgvMostrarDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMostrarDetalle.Size = new System.Drawing.Size(898, 298);
            this.DgvMostrarDetalle.TabIndex = 1;
            // 
            // PanelTotalesDetalle
            // 
            this.PanelTotalesDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.PanelTotalesDetalle.Controls.Add(this.label12);
            this.PanelTotalesDetalle.Controls.Add(this.TxtSubtotalD);
            this.PanelTotalesDetalle.Controls.Add(this.label13);
            this.PanelTotalesDetalle.Controls.Add(this.TxtTotalImpuestoD);
            this.PanelTotalesDetalle.Controls.Add(this.label14);
            this.PanelTotalesDetalle.Controls.Add(this.TxtTotalD);
            this.PanelTotalesDetalle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelTotalesDetalle.Location = new System.Drawing.Point(0, 298);
            this.PanelTotalesDetalle.Name = "PanelTotalesDetalle";
            this.PanelTotalesDetalle.Padding = new System.Windows.Forms.Padding(15);
            this.PanelTotalesDetalle.Size = new System.Drawing.Size(898, 100);
            this.PanelTotalesDetalle.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label12.Location = new System.Drawing.Point(498, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Subtotal:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtSubtotalD
            // 
            this.TxtSubtotalD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSubtotalD.BackColor = System.Drawing.Color.White;
            this.TxtSubtotalD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSubtotalD.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.TxtSubtotalD.Location = new System.Drawing.Point(628, 15);
            this.TxtSubtotalD.Name = "TxtSubtotalD";
            this.TxtSubtotalD.ReadOnly = true;
            this.TxtSubtotalD.Size = new System.Drawing.Size(150, 25);
            this.TxtSubtotalD.TabIndex = 1;
            this.TxtSubtotalD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label13.Location = new System.Drawing.Point(498, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 23);
            this.label13.TabIndex = 2;
            this.label13.Text = "IGV:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtTotalImpuestoD
            // 
            this.TxtTotalImpuestoD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTotalImpuestoD.BackColor = System.Drawing.Color.White;
            this.TxtTotalImpuestoD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTotalImpuestoD.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.TxtTotalImpuestoD.Location = new System.Drawing.Point(628, 45);
            this.TxtTotalImpuestoD.Name = "TxtTotalImpuestoD";
            this.TxtTotalImpuestoD.ReadOnly = true;
            this.TxtTotalImpuestoD.Size = new System.Drawing.Size(150, 25);
            this.TxtTotalImpuestoD.TabIndex = 3;
            this.TxtTotalImpuestoD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.label14.Location = new System.Drawing.Point(498, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 25);
            this.label14.TabIndex = 4;
            this.label14.Text = "TOTAL:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtTotalD
            // 
            this.TxtTotalD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTotalD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(237)))), ((int)(((byte)(218)))));
            this.TxtTotalD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTotalD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TxtTotalD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.TxtTotalD.Location = new System.Drawing.Point(628, 75);
            this.TxtTotalD.Name = "TxtTotalD";
            this.TxtTotalD.ReadOnly = true;
            this.TxtTotalD.Size = new System.Drawing.Size(150, 29);
            this.TxtTotalD.TabIndex = 5;
            this.TxtTotalD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnCerrarDetalle
            // 
            this.BtnCerrarDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.BtnCerrarDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrarDetalle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnCerrarDetalle.FlatAppearance.BorderSize = 0;
            this.BtnCerrarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarDetalle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnCerrarDetalle.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarDetalle.Location = new System.Drawing.Point(0, 398);
            this.BtnCerrarDetalle.Name = "BtnCerrarDetalle";
            this.BtnCerrarDetalle.Size = new System.Drawing.Size(898, 50);
            this.BtnCerrarDetalle.TabIndex = 3;
            this.BtnCerrarDetalle.Text = "✖ Cerrar Detalle";
            this.BtnCerrarDetalle.UseVisualStyleBackColor = false;
            this.BtnCerrarDetalle.Click += new System.EventHandler(this.BtnCerrarDetalle_Click);
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.AllowUserToResizeRows = false;
            this.DgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvListado.BackgroundColor = System.Drawing.Color.White;
            this.DgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvListado.ColumnHeadersHeight = 40;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListado.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgvListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListado.EnableHeadersVisualStyles = false;
            this.DgvListado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.DgvListado.Location = new System.Drawing.Point(20, 110);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvListado.RowHeadersVisible = false;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 35;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(1152, 470);
            this.DgvListado.TabIndex = 1;
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PanelInferior
            // 
            this.PanelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.PanelInferior.Controls.Add(this.BtnExportar);
            this.PanelInferior.Controls.Add(this.BtnCerrar);
            this.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInferior.Location = new System.Drawing.Point(20, 580);
            this.PanelInferior.Name = "PanelInferior";
            this.PanelInferior.Padding = new System.Windows.Forms.Padding(15);
            this.PanelInferior.Size = new System.Drawing.Size(1152, 70);
            this.PanelInferior.TabIndex = 2;
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
            this.BtnCerrar.Location = new System.Drawing.Point(1002, 18);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(135, 35);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "✖ Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // PanelBusqueda
            // 
            this.PanelBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.PanelBusqueda.Controls.Add(this.btnComprobante);
            this.PanelBusqueda.Controls.Add(this.label1);
            this.PanelBusqueda.Controls.Add(this.DtpFechaInicio);
            this.PanelBusqueda.Controls.Add(this.label2);
            this.PanelBusqueda.Controls.Add(this.DtpFechaFin);
            this.PanelBusqueda.Controls.Add(this.BtnBuscar);
            this.PanelBusqueda.Controls.Add(this.BtnLimpiar);
            this.PanelBusqueda.Controls.Add(this.LblTotal);
            this.PanelBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBusqueda.Location = new System.Drawing.Point(20, 20);
            this.PanelBusqueda.Name = "PanelBusqueda";
            this.PanelBusqueda.Padding = new System.Windows.Forms.Padding(15);
            this.PanelBusqueda.Size = new System.Drawing.Size(1152, 90);
            this.PanelBusqueda.TabIndex = 0;
            // 
            // btnComprobante
            // 
            this.btnComprobante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnComprobante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprobante.FlatAppearance.BorderSize = 0;
            this.btnComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprobante.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnComprobante.ForeColor = System.Drawing.Color.White;
            this.btnComprobante.Location = new System.Drawing.Point(601, 43);
            this.btnComprobante.Name = "btnComprobante";
            this.btnComprobante.Size = new System.Drawing.Size(148, 25);
            this.btnComprobante.TabIndex = 7;
            this.btnComprobante.Text = "📋 Comprobante";
            this.btnComprobante.UseVisualStyleBackColor = false;
            this.btnComprobante.Click += new System.EventHandler(this.BtnComprobante_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "📅 Fecha Inicio:";
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.DtpFechaInicio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaInicio.Location = new System.Drawing.Point(15, 43);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.Size = new System.Drawing.Size(150, 25);
            this.DtpFechaInicio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(180, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "📅 Fecha Fin:";
            // 
            // DtpFechaFin
            // 
            this.DtpFechaFin.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.DtpFechaFin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaFin.Location = new System.Drawing.Point(180, 43);
            this.DtpFechaFin.Name = "DtpFechaFin";
            this.DtpFechaFin.Size = new System.Drawing.Size(150, 25);
            this.DtpFechaFin.TabIndex = 3;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(345, 43);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(120, 25);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "🔍 Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(475, 43);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(120, 25);
            this.BtnLimpiar.TabIndex = 5;
            this.BtnLimpiar.Text = "🗑️ Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTotal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.LblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.LblTotal.Location = new System.Drawing.Point(952, 43);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(185, 25);
            this.LblTotal.TabIndex = 6;
            this.LblTotal.Text = "Total registros: 0";
            this.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
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
            this.BtnExportar.Location = new System.Drawing.Point(846, 18);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(150, 35);
            this.BtnExportar.TabIndex = 3;
            this.BtnExportar.Text = "📥 Exportar";
            this.BtnExportar.UseVisualStyleBackColor = false;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // FrmConsulta_VentaFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.TabGeneral);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmConsulta_VentaFechas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "💰 Consulta de Ventas por Fechas";
            this.TabGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.PanelMostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrarDetalle)).EndInit();
            this.PanelTotalesDetalle.ResumeLayout(false);
            this.PanelTotalesDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.PanelInferior.ResumeLayout(false);
            this.PanelBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Panel PanelBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpFechaInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpFechaFin;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Panel PanelInferior;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel PanelMostrar;
        private System.Windows.Forms.DataGridView DgvMostrarDetalle;
        private System.Windows.Forms.Panel PanelTotalesDetalle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtSubtotalD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtTotalImpuestoD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtTotalD;
        private System.Windows.Forms.Button BtnCerrarDetalle;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.Button btnComprobante;
        private System.Windows.Forms.Button BtnExportar;
    }
}