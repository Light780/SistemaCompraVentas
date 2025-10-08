using Sistema.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;
        public int IdUsuario;
        public int IdRol;
        public string Nombre;
        public string Rol;
        public bool Estado;
        public bool Cerrando = false;

        public FrmPrincipal()
        {
            InitializeComponent();
            menuStrip.Renderer = new RendererEx();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void TimerReloj_Tick(object sender, EventArgs e)
        {
            StFechaHora.Text = "🕐 " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void CategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria frm = new FrmCategoria();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArticulo frm = new FrmArticulo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void RolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRol frm = new FrmRol();
            frm.MdiParent = this;
            frm.Show();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // Actualizar información del usuario en el panel lateral
            LblNombreUsuario.Text = this.Nombre;
            LblRolUsuario.Text = this.Rol;
            StUsuario.Text = "👤 " + this.Nombre;
            StRol.Text = "🔐 " + this.Rol;

            // Mensaje de bienvenida mejorado
            StBarraInferior.Text = "Sistema de Compras y Ventas v1.0";

            // Configurar permisos según el rol
            ConfigurarPermisosPorRol();

            // Crear accesos rápidos
            CrearAccesosRapidos();

            // Iniciar el timer del reloj
            timerReloj.Start();
        }

        private void ConfigurarPermisosPorRol()
        {
            if (this.Rol.Equals("Administrador"))
            {
                MnuAlmacen.Enabled = true;
                MnuIngresos.Enabled = true;
                MnuVentas.Enabled = true;
                MnuAccesos.Enabled = true;
                MnuConsultas.Enabled = true;
                TsCompras.Enabled = true;
                TsVentas.Enabled = true;
                TsAlmacen.Enabled = true;
                TsProveedores.Enabled = true;
                TsClientes.Enabled = true;
                TsConsultas.Enabled = true;
                TsReportes.Enabled = true;
            }
            else if (this.Rol.Equals("Vendedor"))
            {
                MnuAlmacen.Enabled = false;
                MnuIngresos.Enabled = false;
                MnuVentas.Enabled = true;
                MnuAccesos.Enabled = false;
                MnuConsultas.Enabled = true;
                TsCompras.Enabled = false;
                TsVentas.Enabled = true;
                TsAlmacen.Enabled = false;
                TsProveedores.Enabled = false;
                TsClientes.Enabled = true;
                TsConsultas.Enabled = true;
                TsReportes.Enabled = true;
            }
            else if (this.Rol.Equals("Almacenero"))
            {
                MnuAlmacen.Enabled = true;
                MnuIngresos.Enabled = true;
                MnuVentas.Enabled = false;
                MnuAccesos.Enabled = false;
                MnuConsultas.Enabled = true;
                TsCompras.Enabled = true;
                TsVentas.Enabled = false;
                TsAlmacen.Enabled = true;
                TsProveedores.Enabled = true;
                TsClientes.Enabled = false;
                TsConsultas.Enabled = true;
                TsReportes.Enabled = true;
            }
        }


        private void CrearAccesosRapidos()
        {
            FlowLayoutAccesos.Controls.Clear();

            if (this.Rol.Equals("Administrador"))
            {
                AgregarBotonAccesoRapido("📦 Categorías", CategoríasToolStripMenuItem_Click);
                AgregarBotonAccesoRapido("📋 Artículos", ArtículosToolStripMenuItem_Click);
                AgregarBotonAccesoRapido("🏢 Proveedores", ProveedoresToolStripMenuItem_Click);
                AgregarBotonAccesoRapido("📥 Compras", ComprasToolStripMenuItem_Click);
                AgregarBotonAccesoRapido("👥 Clientes", ClientesToolStripMenuItem_Click);
                AgregarBotonAccesoRapido("💰 Ventas", VentasToolStripMenuItem1_Click);
                AgregarBotonAccesoRapido("👤 Usuarios", UsuariosToolStripMenuItem_Click);
                AgregarBotonAccesoRapido("📊 Consultas", ConsultaVentasToolStripMenuItem_Click);
            }
            else if (this.Rol.Equals("Vendedor"))
            {
                AgregarBotonAccesoRapido("👥 Clientes", ClientesToolStripMenuItem_Click);
                AgregarBotonAccesoRapido("💰 Ventas", VentasToolStripMenuItem1_Click);
                AgregarBotonAccesoRapido("📊 Consulta Ventas", ConsultaVentasToolStripMenuItem_Click);
            }
            else if (this.Rol.Equals("Almacenero"))
            {
                AgregarBotonAccesoRapido("📦 Categorías", CategoríasToolStripMenuItem_Click);
                AgregarBotonAccesoRapido("📋 Artículos", ArtículosToolStripMenuItem_Click);
                AgregarBotonAccesoRapido("🏢 Proveedores", ProveedoresToolStripMenuItem_Click);
                AgregarBotonAccesoRapido("📥 Compras", ComprasToolStripMenuItem_Click);
                AgregarBotonAccesoRapido("📊 Consulta Compras", consultaComprasToolStripMenuItem_Click);
            }
        }

        private void AgregarBotonAccesoRapido(string texto, EventHandler onClick)
        {
            Button btn = new Button();
            btn.Text = texto;
            btn.Width = 190;
            btn.Height = 40;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(52, 73, 94);
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(10, 0, 0, 0);
            btn.Cursor = Cursors.Hand;
            btn.Margin = new Padding(0, 2, 0, 2);
            btn.Click += onClick;

            // Efectos hover
            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(41, 128, 185);
            };
            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(52, 73, 94);
            };

            FlowLayoutAccesos.Controls.Add(btn);
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea cerrar la sesión?",
                "Cerrar Sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                // Registrar el cierre de sesión
                try
                {
                    Logger.RegistrarLogout();
                }
                catch { }

                // Cerrar todos los formularios hijos
                foreach (Form childForm in this.MdiChildren)
                {
                    childForm.Close();
                }

                // Mostrar el formulario de login
                FrmLogin loginForm = new FrmLogin();
                loginForm.Show();
                this.Hide();
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Cerrando == true)
            {
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea salir del sistema?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Cerrando = true;
                // Registrar el cierre de sesión
                try
                {
                    Logger.RegistrarLogout();
                }
                catch { }

                Application.Exit();
            }
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedor frm = new FrmProveedor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngreso frm = new FrmIngreso();
            frm.MdiParent = this;
            frm.Show();
        }

        private void VentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVenta frm = new FrmVenta();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ConsultaVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta_VentaFechas frm = new FrmConsulta_VentaFechas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void consultaComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta_IngresoFechas frm = new FrmConsulta_IngresoFechas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void auditoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLog frm = new FrmLog();
            frm.MdiParent = this;
            frm.Show();
        }


    }
}
