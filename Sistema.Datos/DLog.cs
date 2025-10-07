using System;
using System.Data;
using System.Data.SqlClient;
using Sistema.Entidades;

namespace Sistema.Datos
{
    /// <summary>
    /// Capa de acceso a datos para el registro de logs
    /// </summary>
    public class DLog
    {
        /// <summary>
        /// Inserta un nuevo registro de log en la base de datos
        /// </summary>
        public string Insertar(Log obj)
        {
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("log_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.Add("@IdUsuario", SqlDbType.Int).Value =
                    obj.IdUsuario.HasValue ? (object)obj.IdUsuario.Value : DBNull.Value;
                Comando.Parameters.Add("@Usuario", SqlDbType.VarChar).Value =
                    obj.Usuario ?? (object)DBNull.Value;
                Comando.Parameters.Add("@Accion", SqlDbType.VarChar).Value = obj.Accion;
                Comando.Parameters.Add("@Tabla", SqlDbType.VarChar).Value = obj.Tabla;
                Comando.Parameters.Add("@IdRegistro", SqlDbType.Int).Value =
                    obj.IdRegistro.HasValue ? (object)obj.IdRegistro.Value : DBNull.Value;
                Comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value =
                    obj.Descripcion ?? (object)DBNull.Value;
                Comando.Parameters.Add("@DireccionIP", SqlDbType.VarChar).Value =
                    obj.DireccionIP ?? (object)DBNull.Value;
                Comando.Parameters.Add("@NombreMaquina", SqlDbType.VarChar).Value =
                    obj.NombreMaquina ?? (object)DBNull.Value;
                Comando.Parameters.Add("@Exitoso", SqlDbType.Bit).Value = obj.Exitoso;
                Comando.Parameters.Add("@MensajeError", SqlDbType.VarChar).Value =
                    obj.MensajeError ?? (object)DBNull.Value;

                SqlCon.Open();
                Comando.ExecuteNonQuery();
                return "OK";
            }
            catch (Exception ex)
            {
                // En caso de error al registrar el log, no propagamos la excepción
                // para evitar interrumpir el flujo principal de la aplicación
                System.Diagnostics.Debug.WriteLine($"Error al registrar log: {ex.Message}");
                return ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        /// <summary>
        /// Lista todos los logs con filtros opcionales
        /// </summary>
        public DataTable Listar(DateTime? fechaInicio = null, DateTime? fechaFin = null,
            int? idUsuario = null, string accion = null, string tabla = null)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("log_listar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.Add("@FechaInicio", SqlDbType.DateTime).Value =
                    fechaInicio ?? (object)DBNull.Value;
                Comando.Parameters.Add("@FechaFin", SqlDbType.DateTime).Value =
                    fechaFin ?? (object)DBNull.Value;
                Comando.Parameters.Add("@IdUsuario", SqlDbType.Int).Value =
                    idUsuario ?? (object)DBNull.Value;
                Comando.Parameters.Add("@Accion", SqlDbType.VarChar).Value =
                    accion ?? (object)DBNull.Value;
                Comando.Parameters.Add("@Tabla", SqlDbType.VarChar).Value =
                    tabla ?? (object)DBNull.Value;

                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        /// <summary>
        /// Obtiene estadísticas de logs en un rango de fechas
        /// </summary>
        public DataTable ObtenerEstadisticas(DateTime fechaInicio, DateTime fechaFin)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("log_estadisticas", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.Add("@FechaInicio", SqlDbType.DateTime).Value = fechaInicio;
                Comando.Parameters.Add("@FechaFin", SqlDbType.DateTime).Value = fechaFin;

                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        /// <summary>
        /// Limpia logs antiguos según días de antigüedad
        /// </summary>
        public int LimpiarAntiguos(int diasAntiguedad = 90)
        {
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("log_limpiar_antiguos", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.Add("@DiasAntiguedad", SqlDbType.Int).Value = diasAntiguedad;

                SqlCon.Open();
                return (int)Comando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
    }
}