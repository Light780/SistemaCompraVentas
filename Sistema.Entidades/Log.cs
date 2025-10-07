using System;

namespace Sistema.Entidades
{
    /// <summary>
    /// Entidad para el registro de auditoría de operaciones del sistema
    /// </summary>
    public class Log
    {
        public int IdLog { get; set; }
        public DateTime Fecha { get; set; }
        public int? IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Accion { get; set; }
        public string Tabla { get; set; }
        public int? IdRegistro { get; set; }
        public string Descripcion { get; set; }
        public string DireccionIP { get; set; }
        public string NombreMaquina { get; set; }
        public bool Exitoso { get; set; }
        public string MensajeError { get; set; }

        public Log()
        {
            Fecha = DateTime.Now;
            Exitoso = true;
        }
    }

    /// <summary>
    /// Enumeración para tipos de acciones de auditoría
    /// </summary>
    public static class AccionLog
    {
        public const string CREATE = "CREATE";
        public const string READ = "READ";
        public const string UPDATE = "UPDATE";
        public const string DELETE = "DELETE";
        public const string LOGIN = "LOGIN";
        public const string LOGOUT = "LOGOUT";
        public const string ACTIVATE = "ACTIVATE";
        public const string DEACTIVATE = "DEACTIVATE";
        public const string EXPORT = "EXPORT";
        public const string PRINT = "PRINT";
    }
}