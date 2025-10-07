using System;
using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NVenta
    {
        public static DataTable Listar()
        {
            try
            {
                DVenta Datos = new DVenta();
                DataTable resultado = Datos.Listar();

                // Registrar la consulta
                Logger.RegistrarConsulta("Venta",
                    $"Listado de ventas - Total registros: {resultado.Rows.Count}");

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar el error
                Logger.RegistrarError(AccionLog.READ, "Venta", ex,
                    null,
                    "Error al listar ventas");
                throw;
            }
        }

        public static DataTable Buscar(string Valor)
        {
            try
            {
                DVenta Datos = new DVenta();
                DataTable resultado = Datos.Buscar(Valor);

                // Registrar la búsqueda
                Logger.RegistrarConsulta("Venta",
                    $"Búsqueda de ventas con valor: '{Valor}' - Resultados: {resultado.Rows.Count}");

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar el error
                Logger.RegistrarError(AccionLog.READ, "Venta", ex,
                    null,
                    $"Error al buscar ventas con valor: '{Valor}'");
                throw;
            }
        }
        public static DataTable ConsultaFechas(DateTime FechaInicio,DateTime FechaFin)
        {
            try
            {
                DVenta Datos = new DVenta();
                DataTable resultado = Datos.ConsultaFechas(FechaInicio, FechaFin);

                // Registrar la consulta
                Logger.RegistrarConsulta("Venta",
                    $"Consulta de ventas por fechas: {FechaInicio:dd/MM/yyyy} a {FechaFin:dd/MM/yyyy} - " +
                    $"Resultados: {resultado.Rows.Count}");

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar el error
                Logger.RegistrarError(AccionLog.READ, "Venta", ex,
                    null,
                    $"Error al consultar ventas por fechas: {FechaInicio:dd/MM/yyyy} a {FechaFin:dd/MM/yyyy}");
                throw;
            }
        }

        public static DataTable ListarDetalle(int Id)
        {
            try
            {
                DVenta Datos = new DVenta();
                DataTable resultado = Datos.ListarDetalle(Id);

                // Registrar la consulta
                Logger.RegistrarConsulta("DetalleVenta",
                    $"Consulta de detalle de venta ID: {Id} - Items: {resultado.Rows.Count}");

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar el error
                Logger.RegistrarError(AccionLog.READ, "DetalleVenta", ex,
                    Id,
                    $"Error al mostrar detalle de venta ID: {Id}");
                throw;
            }
        }

        public static string Insertar(int IdCliente,int IdUsuario,string TipoComprobante,string SerieComprobante,string NumComprobante,decimal Impuesto,decimal Total,DataTable Detalles)
        {
            DVenta Datos = new DVenta();
            string resultado = "";
            try
            {
                Venta Obj = new Venta();
                Obj.IdCliente = IdCliente;
                Obj.IdUsuario = IdUsuario;
                Obj.TipoComprobante = TipoComprobante;
                Obj.SerieComprobante = SerieComprobante;
                Obj.NumComprobante = NumComprobante;
                Obj.Impuesto = Impuesto;
                Obj.Total = Total;
                Obj.Detalles = Detalles;
                resultado = Datos.Insertar(Obj);

                // Logging simple
                if (resultado == "OK")
                {
                    Logger.RegistrarCreacion("Venta", Obj.IdVenta,
                        $"Venta: {TipoComprobante} {SerieComprobante}-{NumComprobante}, Total: {Total:C}");
                }

                return resultado;
            }
            catch (Exception ex)
            {
                Logger.RegistrarError(AccionLog.CREATE, "Venta", ex, null,
                    $"Error al insertar venta: {TipoComprobante} {SerieComprobante}-{NumComprobante}");
                throw;
            }

        }
        public static string Anular(int Id)
        {
            DVenta Datos = new DVenta();
            string resultado = "";

            try
            {
                resultado = Datos.Anular(Id);

                // Logging simple
                if (resultado == "OK")
                {
                    Logger.RegistrarAccion("ANULAR", "Venta", Id,
                        $"Venta anulada - ID: {Id}");
                }

                return resultado;
            }
            catch (Exception ex)
            {
                Logger.RegistrarError("ANULAR", "Venta", ex, Id,
                    $"Error al anular venta ID: {Id}");
                throw;
            }
        }
    }
}
