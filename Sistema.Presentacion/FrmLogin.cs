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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Tabla = new  DataTable();
                Tabla = NUsuario.Login(TxtEmail.Text.Trim(),TxtClave.Text.Trim());
                if (Tabla.Rows.Count <= 0)
                {
                    MessageBox.Show("El Email o la clave es incorrecta.", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    if (Convert.ToBoolean(Tabla.Rows[0][4]) == false)
                    {
                        MessageBox.Show("Este usuario no esta activo.", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int idUsuario = Convert.ToInt32(Tabla.Rows[0]["IdUsuario"]);
                        string nombreUsuario = Tabla.Rows[0]["Nombre"].ToString();
                        int idRol = Convert.ToInt32(Tabla.Rows[0]["IdRol"]);
                        string nombreRol = Tabla.Rows[0]["Rol"].ToString();
                        bool estado = Convert.ToBoolean(Tabla.Rows[0][4]);

                        // IMPORTANTE: Configurar el usuario actual para los logs
                        Logger.RegistrarLogin(idUsuario, nombreUsuario);

                        FrmPrincipal Frm = new FrmPrincipal();
                        Variables.IdUsuario = idUsuario;
                        Frm.IdUsuario = idUsuario;
                        Frm.IdRol = idRol;
                        Frm.Rol = nombreRol;
                        Frm.Nombre = nombreUsuario;
                        Frm.Estado = estado;
                        Frm.Show();
                        this.Hide();
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
