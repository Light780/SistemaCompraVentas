namespace Sistema.Presentacion
{
    partial class FrmRol
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.LblInfoDescripcion = new System.Windows.Forms.Label();
            this.LblInfoTitulo = new System.Windows.Forms.Label();
            this.PanelInferior = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.TabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.PanelInfo.SuspendLayout();
            this.PanelInferior.SuspendLayout();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).BeginInit();
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
            this.TabGeneral.Size = new System.Drawing.Size(800, 600);
            this.TabGeneral.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Controls.Add(this.PanelInfo);
            this.tabPage1.Controls.Add(this.PanelInferior);
            this.tabPage1.Controls.Add(this.PanelSuperior);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(20);
            this.tabPage1.Size = new System.Drawing.Size(792, 570);
            this.tabPage1.TabIndex = 0;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListado.ColumnHeadersHeight = 45;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListado.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListado.EnableHeadersVisualStyles = false;
            this.DgvListado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.DgvListado.Location = new System.Drawing.Point(20, 200);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvListado.RowHeadersVisible = false;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 40;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(752, 280);
            this.DgvListado.TabIndex = 2;
            // 
            // PanelInfo
            // 
            this.PanelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(205)))));
            this.PanelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelInfo.Controls.Add(this.LblInfoDescripcion);
            this.PanelInfo.Controls.Add(this.LblInfoTitulo);
            this.PanelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelInfo.Location = new System.Drawing.Point(20, 120);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Padding = new System.Windows.Forms.Padding(15);
            this.PanelInfo.Size = new System.Drawing.Size(752, 80);
            this.PanelInfo.TabIndex = 1;
            // 
            // LblInfoDescripcion
            // 
            this.LblInfoDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LblInfoDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.LblInfoDescripcion.Location = new System.Drawing.Point(15, 38);
            this.LblInfoDescripcion.Name = "LblInfoDescripcion";
            this.LblInfoDescripcion.Size = new System.Drawing.Size(720, 30);
            this.LblInfoDescripcion.TabIndex = 1;
            this.LblInfoDescripcion.Text = "Los roles definen los permisos y accesos de los usuarios en el sistema. Esta es u" +
    "na vista de solo lectura para consulta.";
            // 
            // LblInfoTitulo
            // 
            this.LblInfoTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LblInfoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.LblInfoTitulo.Location = new System.Drawing.Point(15, 15);
            this.LblInfoTitulo.Name = "LblInfoTitulo";
            this.LblInfoTitulo.Size = new System.Drawing.Size(720, 20);
            this.LblInfoTitulo.TabIndex = 0;
            this.LblInfoTitulo.Text = "ℹ️ Información Importante";
            // 
            // PanelInferior
            // 
            this.PanelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.PanelInferior.Controls.Add(this.BtnCerrar);
            this.PanelInferior.Controls.Add(this.LblTotal);
            this.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInferior.Location = new System.Drawing.Point(20, 480);
            this.PanelInferior.Name = "PanelInferior";
            this.PanelInferior.Padding = new System.Windows.Forms.Padding(15);
            this.PanelInferior.Size = new System.Drawing.Size(752, 70);
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
            this.BtnCerrar.Location = new System.Drawing.Point(687, 18);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(50, 35);
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.Text = "✖";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.LblTotal.Location = new System.Drawing.Point(15, 23);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(300, 25);
            this.LblTotal.TabIndex = 0;
            this.LblTotal.Text = "📊 Total de Roles: 0";
            this.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.PanelSuperior.Controls.Add(this.LblDescripcion);
            this.PanelSuperior.Controls.Add(this.LblTitulo);
            this.PanelSuperior.Controls.Add(this.PictureBoxIcon);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(20, 20);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Padding = new System.Windows.Forms.Padding(20);
            this.PanelSuperior.Size = new System.Drawing.Size(752, 100);
            this.PanelSuperior.TabIndex = 0;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.LblDescripcion.Location = new System.Drawing.Point(80, 55);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(650, 25);
            this.LblDescripcion.TabIndex = 2;
            this.LblDescripcion.Text = "Consulta los roles disponibles en el sistema y sus permisos asociados";
            // 
            // LblTitulo
            // 
            this.LblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(80, 20);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(650, 35);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "🔐 Gestión de Roles de Usuario";
            // 
            // PictureBoxIcon
            // 
            this.PictureBoxIcon.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxIcon.Location = new System.Drawing.Point(20, 25);
            this.PictureBoxIcon.Name = "PictureBoxIcon";
            this.PictureBoxIcon.Size = new System.Drawing.Size(50, 50);
            this.PictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxIcon.TabIndex = 0;
            this.PictureBoxIcon.TabStop = false;
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // FrmRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.TabGeneral);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "FrmRol";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🔐 Roles del Sistema";
            this.Load += new System.EventHandler(this.FrmRol_Load);
            this.TabGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.PanelInfo.ResumeLayout(false);
            this.PanelInferior.ResumeLayout(false);
            this.PanelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TabControl TabGeneral;
        protected System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.DataGridView DgvListado;
        protected System.Windows.Forms.ErrorProvider ErrorIcono;
        protected System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.PictureBox PictureBoxIcon;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Panel PanelInfo;
        private System.Windows.Forms.Label LblInfoTitulo;
        private System.Windows.Forms.Label LblInfoDescripcion;
        private System.Windows.Forms.Panel PanelInferior;
        private System.Windows.Forms.Button BtnCerrar;
    }
}