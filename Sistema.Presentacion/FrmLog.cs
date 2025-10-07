using System;
using System.Data;
using System.Windows.Forms;
using Sistema.Negocio;

namespace Sistema.Presentacion
{
    public partial class FrmLog : Form
    {
        public FrmLog()
        {
            InitializeComponent();
        }

        private void FrmLog_Load(object sender, EventArgs e)
        {
            // Configurar fechas por defecto (últimos 7 días)
            DtpFechaInicio.Value = DateTime.Now.AddDays(-7);
            DtpFechaFin.Value = DateTime.Now;

            // Cargar combo de acciones
            CargarComboAcciones();

            // Listar logs
            this.Listar();
        }

        private void CargarComboAcciones()
        {
            CboAccion.Items.Add("Todas");
            CboAccion.Items.Add("CREATE");
            CboAccion.Items.Add("READ");
            CboAccion.Items.Add("UPDATE");
            CboAccion.Items.Add("DELETE");
            CboAccion.Items.Add("LOGIN");
            CboAccion.Items.Add("LOGOUT");
            CboAccion.Items.Add("ACTIVATE");
            CboAccion.Items.Add("DEACTIVATE");
            CboAccion.Items.Add("EXPORT");
            CboAccion.Items.Add("PRINT");
            CboAccion.SelectedIndex = 0;
        }

        private void Listar()
        {
            try
            {
                // Preparar filtros
                DateTime? fechaInicio = ChkFiltroFecha.Checked ? (DateTime?)DtpFechaInicio.Value.Date : null;
                DateTime? fechaFin = ChkFiltroFecha.Checked ? (DateTime?)DtpFechaFin.Value.Date.AddDays(1).AddSeconds(-1) : null;
                string accion = CboAccion.SelectedIndex > 0 ? CboAccion.Text : null;

                // Obtener datos
                DataTable dt = Logger.Listar(fechaInicio, fechaFin, null, accion, null);
                DgvListado.DataSource = dt;

                this.Formato();
                LblTotal.Text = "Total de registros: " + dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar logs: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Formato()
        {
            DgvListado.Columns[0].Visible = false; // IdLog
            DgvListado.Columns[1].HeaderText = "Fecha y Hora";
            DgvListado.Columns[1].Width = 140;
            DgvListado.Columns[2].Visible = false; // IdUsuario
            DgvListado.Columns[3].HeaderText = "Usuario";
            DgvListado.Columns[3].Width = 120;
            DgvListado.Columns[4].HeaderText = "Acción";
            DgvListado.Columns[4].Width = 90;
            DgvListado.Columns[5].HeaderText = "Tabla";
            DgvListado.Columns[5].Width = 100;
            DgvListado.Columns[6].HeaderText = "ID Reg.";
            DgvListado.Columns[6].Width = 70;
            DgvListado.Columns[7].HeaderText = "Descripción";
            DgvListado.Columns[7].Width = 300;
            DgvListado.Columns[8].HeaderText = "Dirección IP";
            DgvListado.Columns[8].Width = 110;
            DgvListado.Columns[9].HeaderText = "Máquina";
            DgvListado.Columns[9].Width = 100;
            DgvListado.Columns[10].HeaderText = "Exitoso";
            DgvListado.Columns[10].Width = 60;
            DgvListado.Columns[11].HeaderText = "Mensaje de Error";
            DgvListado.Columns[11].Width = 250;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void ChkFiltroFecha_CheckedChanged(object sender, EventArgs e)
        {
            DtpFechaInicio.Enabled = ChkFiltroFecha.Checked;
            DtpFechaFin.Enabled = ChkFiltroFecha.Checked;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            ChkFiltroFecha.Checked = true;
            DtpFechaInicio.Value = DateTime.Now.AddDays(-7);
            DtpFechaFin.Value = DateTime.Now;
            CboAccion.SelectedIndex = 0;
            TxtBuscar.Text = "";
            this.Listar();
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvListado.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para exportar", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivo CSV|*.csv|Archivo de Texto|*.txt";
                saveFileDialog.Title = "Exportar logs";
                saveFileDialog.FileName = $"Logs_{DateTime.Now:yyyyMMdd_HHmmss}";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter writer = new System.IO.StreamWriter(saveFileDialog.FileName);

                    // Escribir encabezados
                    for (int i = 0; i < DgvListado.Columns.Count; i++)
                    {
                        if (DgvListado.Columns[i].Visible)
                        {
                            writer.Write(DgvListado.Columns[i].HeaderText);
                            if (i < DgvListado.Columns.Count - 1)
                                writer.Write(",");
                        }
                    }
                    writer.WriteLine();

                    // Escribir datos
                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        for (int i = 0; i < DgvListado.Columns.Count; i++)
                        {
                            if (DgvListado.Columns[i].Visible)
                            {
                                string value = row.Cells[i].Value?.ToString() ?? "";
                                // Escapar comillas y comas
                                if (value.Contains(",") || value.Contains("\""))
                                    value = "\"" + value.Replace("\"", "\"\"") + "\"";

                                writer.Write(value);
                                if (i < DgvListado.Columns.Count - 1)
                                    writer.Write(",");
                            }
                        }
                        writer.WriteLine();
                    }

                    writer.Close();
                    MessageBox.Show("Datos exportados correctamente", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Logger.RegistrarExportacion("Log", "CSV",
                        $"Exportados {DgvListado.Rows.Count} registros de logs");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (DgvListado.DataSource != null)
            {
                try
                {
                    DataTable dt = (DataTable)DgvListado.DataSource;
                    if (!string.IsNullOrEmpty(TxtBuscar.Text))
                    {
                        string filtro = string.Format(
                            "Usuario LIKE '%{0}%' OR Descripcion LIKE '%{0}%' OR Tabla LIKE '%{0}%'",
                            TxtBuscar.Text);
                        dt.DefaultView.RowFilter = filtro;
                    }
                    else
                    {
                        dt.DefaultView.RowFilter = "";
                    }

                    LblTotal.Text = "Total de registros: " + DgvListado.Rows.Count.ToString();
                }
                catch
                {
                    // Si hay error en el filtro, ignorar
                }
            }
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = DgvListado.Rows[e.RowIndex];

                    string mensaje = "DETALLES DEL LOG\n\n";
                    mensaje += $"Fecha: {row.Cells["Fecha"].Value}\n";
                    mensaje += $"Usuario: {row.Cells["Usuario"].Value}\n";
                    mensaje += $"Acción: {row.Cells["Accion"].Value}\n";
                    mensaje += $"Tabla: {row.Cells["Tabla"].Value}\n";
                    mensaje += $"ID Registro: {row.Cells["IdRegistro"].Value}\n";
                    mensaje += $"Descripción: {row.Cells["Descripcion"].Value}\n";
                    mensaje += $"IP: {row.Cells["DireccionIP"].Value}\n";
                    mensaje += $"Máquina: {row.Cells["NombreMaquina"].Value}\n";
                    mensaje += $"Exitoso: {row.Cells["Exitoso"].Value}\n";

                    if (row.Cells["MensajeError"].Value != DBNull.Value &&
                        !string.IsNullOrEmpty(row.Cells["MensajeError"].Value?.ToString()))
                    {
                        mensaje += $"\nError: {row.Cells["MensajeError"].Value}\n";
                    }

                    MessageBox.Show(mensaje, "Detalle del Log",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar detalles: " + ex.Message);
                }
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}