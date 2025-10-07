using System;
using System.Data;
using System.Net;
using System.Net.Sockets;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    /// <summary>
    /// Clase utilitaria para registrar logs de forma sencilla en toda la aplicación
    /// </summary>
    public static class Logger
    {
        // Usuario actual del sistema (debe ser configurado al hacer login)
        private static int? _idUsuarioActual = null;
        private static string _nombreUsuarioActual = null;

        /// <summary>
        /// Configura el usuario actual para los logs
        /// Debe llamarse después del login exitoso
        /// </summary>
        public static void ConfigurarUsuario(int idUsuario, string nombreUsuario)
        {
            _idUsuarioActual = idUsuario;
            _nombreUsuarioActual = nombreUsuario;
        }

        /// <summary>
        /// Limpia el usuario actual (útil para logout)
        /// </summary>
        public static void LimpiarUsuario()
        {
            _idUsuarioActual = null;
            _nombreUsuarioActual = null;
        }

        /// <summary>
        /// Registra una acción exitosa
        /// </summary>
        public static void RegistrarAccion(string accion, string tabla, int? idRegistro = null, string descripcion = null)
        {
            try
            {
                Log log = new Log
                {
                    IdUsuario = _idUsuarioActual,
                    Usuario = _nombreUsuarioActual ?? "Sistema",
                    Accion = accion,
                    Tabla = tabla,
                    IdRegistro = idRegistro,
                    Descripcion = descripcion,
                    DireccionIP = ObtenerDireccionIP(),
                    NombreMaquina = Environment.MachineName,
                    Exitoso = true
                };

                DLog datos = new DLog();
                datos.Insertar(log);
            }
            catch (Exception ex)
            {
                // Si falla el log, no interrumpimos la operación principal
                System.Diagnostics.Debug.WriteLine($"Error al registrar log: {ex.Message}");
            }
        }

        /// <summary>
        /// Registra una acción que falló
        /// </summary>
        public static void RegistrarError(string accion, string tabla, Exception error, int? idRegistro = null, string descripcion = null)
        {
            try
            {
                Log log = new Log
                {
                    IdUsuario = _idUsuarioActual,
                    Usuario = _nombreUsuarioActual ?? "Sistema",
                    Accion = accion,
                    Tabla = tabla,
                    IdRegistro = idRegistro,
                    Descripcion = descripcion,
                    DireccionIP = ObtenerDireccionIP(),
                    NombreMaquina = Environment.MachineName,
                    Exitoso = false,
                    MensajeError = error?.Message
                };

                DLog datos = new DLog();
                datos.Insertar(log);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error al registrar log de error: {ex.Message}");
            }
        }

        /// <summary>
        /// Registra un login exitoso
        /// </summary>
        public static void RegistrarLogin(int idUsuario, string nombreUsuario)
        {
            ConfigurarUsuario(idUsuario, nombreUsuario);
            RegistrarAccion(AccionLog.LOGIN, "Usuario", idUsuario, $"Login exitoso: {nombreUsuario}");
        }

        /// <summary>
        /// Registra un logout
        /// </summary>
        public static void RegistrarLogout()
        {
            RegistrarAccion(AccionLog.LOGOUT, "Usuario", _idUsuarioActual, $"Logout: {_nombreUsuarioActual}");
            LimpiarUsuario();
        }

        /// <summary>
        /// Registra una creación de registro
        /// </summary>
        public static void RegistrarCreacion(string tabla, int idRegistro, string descripcion = null)
        {
            RegistrarAccion(AccionLog.CREATE, tabla, idRegistro, descripcion ?? $"Registro creado en {tabla}");
        }

        /// <summary>
        /// Registra una actualización de registro
        /// </summary>
        public static void RegistrarActualizacion(string tabla, int idRegistro, string descripcion = null)
        {
            RegistrarAccion(AccionLog.UPDATE, tabla, idRegistro, descripcion ?? $"Registro actualizado en {tabla}");
        }

        /// <summary>
        /// Registra una eliminación de registro
        /// </summary>
        public static void RegistrarEliminacion(string tabla, int idRegistro, string descripcion = null)
        {
            RegistrarAccion(AccionLog.DELETE, tabla, idRegistro, descripcion ?? $"Registro eliminado en {tabla}");
        }

        /// <summary>
        /// Registra una activación de registro
        /// </summary>
        public static void RegistrarActivacion(string tabla, int idRegistro, string descripcion = null)
        {
            RegistrarAccion(AccionLog.ACTIVATE, tabla, idRegistro, descripcion ?? $"Registro activado en {tabla}");
        }

        /// <summary>
        /// Registra una desactivación de registro
        /// </summary>
        public static void RegistrarDesactivacion(string tabla, int idRegistro, string descripcion = null)
        {
            RegistrarAccion(AccionLog.DEACTIVATE, tabla, idRegistro, descripcion ?? $"Registro desactivado en {tabla}");
        }

        /// <summary>
        /// Registra una consulta/lectura de datos
        /// </summary>
        public static void RegistrarConsulta(string tabla, string descripcion = null)
        {
            RegistrarAccion(AccionLog.READ, tabla, null, descripcion ?? $"Consulta realizada en {tabla}");
        }

        /// <summary>
        /// Registra una exportación de datos
        /// </summary>
        public static void RegistrarExportacion(string tabla, string tipoExportacion, string descripcion = null)
        {
            RegistrarAccion(AccionLog.EXPORT, tabla, null,
                descripcion ?? $"Datos exportados de {tabla} a {tipoExportacion}");
        }

        /// <summary>
        /// Registra una impresión de reporte
        /// </summary>
        public static void RegistrarImpresion(string tipoReporte, string descripcion = null)
        {
            RegistrarAccion(AccionLog.PRINT, tipoReporte, null,
                descripcion ?? $"Reporte impreso: {tipoReporte}");
        }

        /// <summary>
        /// Lista logs con filtros opcionales
        /// </summary>
        public static DataTable Listar(DateTime? fechaInicio = null, DateTime? fechaFin = null,
            int? idUsuario = null, string accion = null, string tabla = null)
        {
            try
            {
                DLog datos = new DLog();
                return datos.Listar(fechaInicio, fechaFin, idUsuario, accion, tabla);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error al listar logs: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Obtiene la dirección IP local de la máquina
        /// </summary>
        private static string ObtenerDireccionIP()
        {
            try
            {
                string hostName = Dns.GetHostName();
                IPAddress[] addresses = Dns.GetHostAddresses(hostName);

                foreach (IPAddress address in addresses)
                {
                    if (address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return address.ToString();
                    }
                }

                return "127.0.0.1";
            }
            catch
            {
                return "No disponible";
            }
        }
    }
}