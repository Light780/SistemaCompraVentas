namespace Sistema.Presentacion
{
    partial class FrmLogin
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
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.PanelIzquierdo = new System.Windows.Forms.Panel();
            this.LblBienvenida = new System.Windows.Forms.Label();
            this.LblSubtitulo = new System.Windows.Forms.Label();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.PanelDerecho = new System.Windows.Forms.Panel();
            this.PanelFormulario = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PanelEmail = new System.Windows.Forms.Panel();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.PictureBoxEmail = new System.Windows.Forms.PictureBox();
            this.PanelClave = new System.Windows.Forms.Panel();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.LblClave = new System.Windows.Forms.Label();
            this.PictureBoxClave = new System.Windows.Forms.PictureBox();
            this.BtnMostrarClave = new System.Windows.Forms.Button();
            this.ChkRecordar = new System.Windows.Forms.CheckBox();
            this.BtnAcceder = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblVersion = new System.Windows.Forms.Label();
            this.PanelPrincipal.SuspendLayout();
            this.PanelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.PanelDerecho.SuspendLayout();
            this.PanelFormulario.SuspendLayout();
            this.PanelEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEmail)).BeginInit();
            this.PanelClave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxClave)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.White;
            this.PanelPrincipal.Controls.Add(this.PanelDerecho);
            this.PanelPrincipal.Controls.Add(this.PanelIzquierdo);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(900, 550);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // PanelIzquierdo
            // 
            this.PanelIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.PanelIzquierdo.Controls.Add(this.PictureBoxLogo);
            this.PanelIzquierdo.Controls.Add(this.LblSubtitulo);
            this.PanelIzquierdo.Controls.Add(this.LblBienvenida);
            this.PanelIzquierdo.Controls.Add(this.LblVersion);
            this.PanelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.PanelIzquierdo.Name = "PanelIzquierdo";
            this.PanelIzquierdo.Size = new System.Drawing.Size(380, 550);
            this.PanelIzquierdo.TabIndex = 0;
            // 
            // LblBienvenida
            // 
            this.LblBienvenida.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.LblBienvenida.ForeColor = System.Drawing.Color.White;
            this.LblBienvenida.Location = new System.Drawing.Point(30, 200);
            this.LblBienvenida.Name = "LblBienvenida";
            this.LblBienvenida.Size = new System.Drawing.Size(320, 60);
            this.LblBienvenida.TabIndex = 0;
            this.LblBienvenida.Text = "¡Bienvenido!";
            this.LblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblSubtitulo
            // 
            this.LblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.LblSubtitulo.Location = new System.Drawing.Point(30, 260);
            this.LblSubtitulo.Name = "LblSubtitulo";
            this.LblSubtitulo.Size = new System.Drawing.Size(320, 60);
            this.LblSubtitulo.TabIndex = 1;
            this.LblSubtitulo.Text = "Sistema de Gestión de\nCompras y Ventas";
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Location = new System.Drawing.Point(115, 50);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(150, 150);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLogo.TabIndex = 2;
            this.PictureBoxLogo.TabStop = false;
            // 
            // LblVersion
            // 
            this.LblVersion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.LblVersion.Location = new System.Drawing.Point(30, 510);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(320, 20);
            this.LblVersion.TabIndex = 3;
            this.LblVersion.Text = "Versión 1.0.0";
            this.LblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelDerecho
            // 
            this.PanelDerecho.BackColor = System.Drawing.Color.White;
            this.PanelDerecho.Controls.Add(this.PanelFormulario);
            this.PanelDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDerecho.Location = new System.Drawing.Point(380, 0);
            this.PanelDerecho.Name = "PanelDerecho";
            this.PanelDerecho.Padding = new System.Windows.Forms.Padding(40);
            this.PanelDerecho.Size = new System.Drawing.Size(520, 550);
            this.PanelDerecho.TabIndex = 1;
            // 
            // PanelFormulario
            // 
            this.PanelFormulario.Controls.Add(this.LblTitulo);
            this.PanelFormulario.Controls.Add(this.PanelEmail);
            this.PanelFormulario.Controls.Add(this.PanelClave);
            this.PanelFormulario.Controls.Add(this.ChkRecordar);
            this.PanelFormulario.Controls.Add(this.BtnAcceder);
            this.PanelFormulario.Controls.Add(this.BtnCancelar);
            this.PanelFormulario.Location = new System.Drawing.Point(40, 80);
            this.PanelFormulario.Name = "PanelFormulario";
            this.PanelFormulario.Size = new System.Drawing.Size(440, 390);
            this.PanelFormulario.TabIndex = 0;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.LblTitulo.Location = new System.Drawing.Point(0, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(440, 50);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Iniciar Sesión";
            // 
            // PanelEmail
            // 
            this.PanelEmail.BackColor = System.Drawing.Color.White;
            this.PanelEmail.Controls.Add(this.PictureBoxEmail);
            this.PanelEmail.Controls.Add(this.LblEmail);
            this.PanelEmail.Controls.Add(this.TxtEmail);
            this.PanelEmail.Location = new System.Drawing.Point(0, 80);
            this.PanelEmail.Name = "PanelEmail";
            this.PanelEmail.Size = new System.Drawing.Size(440, 70);
            this.PanelEmail.TabIndex = 1;
            // 
            // LblEmail
            // 
            this.LblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.LblEmail.Location = new System.Drawing.Point(0, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(440, 20);
            this.LblEmail.TabIndex = 0;
            this.LblEmail.Text = "Correo Electrónico";
            // 
            // PictureBoxEmail
            // 
            this.PictureBoxEmail.Location = new System.Drawing.Point(10, 30);
            this.PictureBoxEmail.Name = "PictureBoxEmail";
            this.PictureBoxEmail.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxEmail.TabIndex = 1;
            this.PictureBoxEmail.TabStop = false;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TxtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.TxtEmail.Location = new System.Drawing.Point(50, 30);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(380, 30);
            this.TxtEmail.TabIndex = 2;
            this.TxtEmail.Text = "administrador@prueba.com";
            // 
            // PanelClave
            // 
            this.PanelClave.BackColor = System.Drawing.Color.White;
            this.PanelClave.Controls.Add(this.PictureBoxClave);
            this.PanelClave.Controls.Add(this.LblClave);
            this.PanelClave.Controls.Add(this.TxtClave);
            this.PanelClave.Controls.Add(this.BtnMostrarClave);
            this.PanelClave.Location = new System.Drawing.Point(0, 160);
            this.PanelClave.Name = "PanelClave";
            this.PanelClave.Size = new System.Drawing.Size(440, 70);
            this.PanelClave.TabIndex = 2;
            // 
            // LblClave
            // 
            this.LblClave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LblClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.LblClave.Location = new System.Drawing.Point(0, 0);
            this.LblClave.Name = "LblClave";
            this.LblClave.Size = new System.Drawing.Size(440, 20);
            this.LblClave.TabIndex = 0;
            this.LblClave.Text = "Contraseña";
            // 
            // PictureBoxClave
            // 
            this.PictureBoxClave.Location = new System.Drawing.Point(10, 30);
            this.PictureBoxClave.Name = "PictureBoxClave";
            this.PictureBoxClave.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxClave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxClave.TabIndex = 1;
            this.PictureBoxClave.TabStop = false;
            // 
            // TxtClave
            // 
            this.TxtClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.TxtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtClave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TxtClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.TxtClave.Location = new System.Drawing.Point(50, 30);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '●';
            this.TxtClave.Size = new System.Drawing.Size(340, 30);
            this.TxtClave.TabIndex = 2;
            this.TxtClave.Text = "123";
            // 
            // BtnMostrarClave
            // 
            this.BtnMostrarClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.BtnMostrarClave.FlatAppearance.BorderSize = 0;
            this.BtnMostrarClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrarClave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnMostrarClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.BtnMostrarClave.Location = new System.Drawing.Point(395, 30);
            this.BtnMostrarClave.Name = "BtnMostrarClave";
            this.BtnMostrarClave.Size = new System.Drawing.Size(35, 30);
            this.BtnMostrarClave.TabIndex = 3;
            this.BtnMostrarClave.Text = "👁";
            this.BtnMostrarClave.UseVisualStyleBackColor = false;
            // 
            // ChkRecordar
            // 
            this.ChkRecordar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ChkRecordar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.ChkRecordar.Location = new System.Drawing.Point(0, 240);
            this.ChkRecordar.Name = "ChkRecordar";
            this.ChkRecordar.Size = new System.Drawing.Size(200, 24);
            this.ChkRecordar.TabIndex = 3;
            this.ChkRecordar.Text = "Recordar mi sesión";
            this.ChkRecordar.UseVisualStyleBackColor = true;
            // 
            // BtnAcceder
            // 
            this.BtnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BtnAcceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAcceder.FlatAppearance.BorderSize = 0;
            this.BtnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAcceder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnAcceder.ForeColor = System.Drawing.Color.White;
            this.BtnAcceder.Location = new System.Drawing.Point(0, 285);
            this.BtnAcceder.Name = "BtnAcceder";
            this.BtnAcceder.Size = new System.Drawing.Size(440, 45);
            this.BtnAcceder.TabIndex = 4;
            this.BtnAcceder.Text = "INICIAR SESIÓN";
            this.BtnAcceder.UseVisualStyleBackColor = false;
            this.BtnAcceder.Click += new System.EventHandler(this.BtnAcceder_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.White;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.BtnCancelar.Location = new System.Drawing.Point(0, 340);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(440, 45);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.PanelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso al Sistema";
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.PanelDerecho.ResumeLayout(false);
            this.PanelFormulario.ResumeLayout(false);
            this.PanelEmail.ResumeLayout(false);
            this.PanelEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEmail)).EndInit();
            this.PanelClave.ResumeLayout(false);
            this.PanelClave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxClave)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Panel PanelIzquierdo;
        private System.Windows.Forms.Panel PanelDerecho;
        private System.Windows.Forms.Label LblBienvenida;
        private System.Windows.Forms.Label LblSubtitulo;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label LblVersion;
        private System.Windows.Forms.Panel PanelFormulario;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Panel PanelEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.PictureBox PictureBoxEmail;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Panel PanelClave;
        private System.Windows.Forms.Label LblClave;
        private System.Windows.Forms.PictureBox PictureBoxClave;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.Button BtnMostrarClave;
        private System.Windows.Forms.CheckBox ChkRecordar;
        private System.Windows.Forms.Button BtnAcceder;
        private System.Windows.Forms.Button BtnCancelar;
    }
}