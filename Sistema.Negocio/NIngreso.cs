using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NIngreso
    {
        public static DataTable Listar()
        {
            try
            {
                DIngreso Datos = new DIngreso();
                DataTable resultado = Datos.Listar();

                // Registrar la consulta
                Logger.RegistrarConsulta("Ingreso",
                    $"Listado de ingresos - Total registros: {resultado.Rows.Count}");

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar el error
                Logger.RegistrarError(AccionLog.READ, "Ingreso", ex,
                    null,
                    "Error al listar ingresos");
                throw;
            }
        }

        public static DataTable Buscar(string Valor)
        {
            try
            {
                DIngreso Datos = new DIngreso();
                DataTable resultado = Datos.Buscar(Valor);

                // Registrar la búsqueda
                Logger.RegistrarConsulta("Ingreso",
                    $"Búsqueda de ingresos con valor: '{Valor}' - Resultados: {resultado.Rows.Count}");

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar el error
                Logger.RegistrarError(AccionLog.READ, "Ingreso", ex,
                    null,
                    $"Error al buscar ingresos con valor: '{Valor}'");
                throw;
            }
        }

        public static DataTable ListarDetalle(int Id)
        {
            try
            {
                DIngreso Datos = new DIngreso();
                DataTable resultado = Datos.ListarDetalle(Id);

                // Registrar la consulta
                Logger.RegistrarConsulta("DetalleIngreso",
                    $"Consulta de detalle de ingreso ID: {Id} - Items: {resultado.Rows.Count}");

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar el error
                Logger.RegistrarError(AccionLog.READ, "DetalleIngreso", ex,
                    Id,
                    $"Error al mostrar detalle de ingreso ID: {Id}");
                throw;
            }
        }

        public static DataTable ConsultaFechas(DateTime FechaInicio, DateTime FechaFin)
        {
            try
            {
                DIngreso Datos = new DIngreso();
                DataTable resultado = Datos.ConsultaFechas(FechaInicio, FechaFin);

                // Registrar la consulta
                Logger.RegistrarConsulta("Ingreso",
                    $"Consulta de ingresos por fechas: {FechaInicio:dd/MM/yyyy} a {FechaFin:dd/MM/yyyy} - " +
                    $"Resultados: {resultado.Rows.Count}");

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar el error
                Logger.RegistrarError(AccionLog.READ, "Ingreso", ex,
                    null,
                    $"Error al consultar ingresos por fechas: {FechaInicio:dd/MM/yyyy} a {FechaFin:dd/MM/yyyy}");
                throw;
            }
        }

        public static string Insertar(int IdProveedor,int IdUsuario,string TipoComprobante,string SerieComprobante,string NumComprobante,decimal Impuesto,decimal Total,DataTable Detalles)
        {
            DIngreso Datos = new DIngreso();
            string resultado = "";

            try
            {
                Ingreso Obj = new Ingreso();
                Obj.IdProveedor = IdProveedor;
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
                    Logger.RegistrarCreacion("Ingreso", Obj.IdIngreso,
                        $"Ingreso: {TipoComprobante} {SerieComprobante}-{NumComprobante}, Total: {Total:C}");
                }

                return resultado;
            }
            catch (Exception ex)
            {
                Logger.RegistrarError(AccionLog.CREATE, "Ingreso", ex, null,
                    $"Error al insertar ingreso: {TipoComprobante} {SerieComprobante}-{NumComprobante}");
                throw;
            }
        }
        public static string Anular(int Id)
        {
            DIngreso Datos = new DIngreso();
            string resultado = "";

            try
            {
                resultado = Datos.Anular(Id);

                // Logging simple
                if (resultado == "OK")
                {
                    Logger.RegistrarAccion("ANULAR", "Ingreso", Id,
                        $"Ingreso anulado - ID: {Id}");
                }

                return resultado;
            }
            catch (Exception ex)
            {
                Logger.RegistrarError("ANULAR", "Ingreso", ex, Id,
                    $"Error al anular ingreso ID: {Id}");
                throw;
            }
        }
    }
}
