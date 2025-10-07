using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Negocio;

namespace Sistema.Presentacion
{
    public partial class FrmConsulta_VentaFechas : Form
    {
        public FrmConsulta_VentaFechas()
        {
            InitializeComponent();
        }
        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = NVenta.ConsultaFechas(Convert.ToDateTime(DtpFechaInicio.Value),Convert.ToDateTime(DtpFechaFin.Value));
                this.Formato();
                this.Limpiar();
                LblTotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato()
        {
            // Ocultar columnas innecesarias
            DgvListado.Columns[0].Visible = false; // Seleccionar
            DgvListado.Columns[1].Visible = false; // IdIngreso
            DgvListado.Columns[2].Visible = false; // IdProveedor

            // Configurar columnas visibles
            DgvListado.Columns[3].Width = 200;
            DgvListado.Columns[3].HeaderText = "Cliente";

            DgvListado.Columns[4].Width = 100;
            DgvListado.Columns[4].HeaderText = "Fecha";
            DgvListado.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";

            DgvListado.Columns[5].Width = 120;
            DgvListado.Columns[5].HeaderText = "Tipo Comprobante";

            DgvListado.Columns[6].Width = 80;
            DgvListado.Columns[6].HeaderText = "Serie";
            DgvListado.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DgvListado.Columns[7].Width = 100;
            DgvListado.Columns[7].HeaderText = "Número";
            DgvListado.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DgvListado.Columns[8].Width = 100;
            DgvListado.Columns[8].HeaderText = "Impuesto";
            DgvListado.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvListado.Columns[8].DefaultCellStyle.Format = "C2";

            DgvListado.Columns[9].Width = 120;
            DgvListado.Columns[9].HeaderText = "Total";
            DgvListado.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvListado.Columns[9].DefaultCellStyle.Format = "C2";
            DgvListado.Columns[9].DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);

            DgvListado.Columns[10].Width = 100;
            DgvListado.Columns[10].HeaderText = "Estado";
            DgvListado.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DgvListado.Columns[11].Width = 120;
            DgvListado.Columns[11].HeaderText = "Usuario";

            // Colorear filas según estado
            foreach (DataGridViewRow row in DgvListado.Rows)
            {
                if (row.Cells[10].Value != null)
                {
                    string estado = row.Cells[10].Value.ToString();
                    if (estado == "Anulado")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(248, 215, 218);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(114, 28, 36);
                    }
                    else if (estado == "Aceptado")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 218);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(21, 87, 36);
                    }
                }
            }
        }
        private void Limpiar()
        {
            DgvListado.Columns[0].Visible = false;
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FrmConsulta_VentaFechas_Load(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DgvMostrarDetalle.DataSource = NVenta.ListarDetalle(Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value));
                decimal Total, SubTotal;
                decimal Impuesto = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Impuesto"].Value);
                Total = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Total"].Value);
                SubTotal = Total / (1 + Impuesto);
                TxtSubtotalD.Text = SubTotal.ToString("#0.00#");
                TxtTotalImpuestoD.Text = (Total - SubTotal).ToString("#0.00#");
                TxtTotalD.Text = Total.ToString("#0.00#");
                PanelMostrar.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnComprobante_Click(object sender, EventArgs e)
        {
            try
            {
                Variables.IdVenta = Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value);
                Reportes.FrmReporteComprobanteVenta reporte = new Reportes.FrmReporteComprobanteVenta();
                reporte.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar la búsqueda y restablecer fechas por defecto
            DtpFechaInicio.Value = DateTime.Now.AddMonths(-1);
            DtpFechaFin.Value = DateTime.Now;
            DgvListado.DataSource = null;
            LblTotal.Text = "Total registros: 0";
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCerrarDetalle_Click(object sender, EventArgs e)
        {
            PanelMostrar.Visible = false;
        }
    }
}
