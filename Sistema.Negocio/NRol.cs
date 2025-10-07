using Sistema.Datos;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio
{
    public class NRol
    {
        public static DataTable Listar()
        {
            try
            {
                DRol Datos = new DRol();
                DataTable resultado = Datos.Listar();

                // Registrar la consulta
                Logger.RegistrarConsulta("Rol",
                    $"Listado de roles - Total registros: {resultado.Rows.Count}");

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar el error
                Logger.RegistrarError(AccionLog.READ, "Rol", ex,
                    null,
                    "Error al listar roles");
                throw;
            }
        }
    }
}
