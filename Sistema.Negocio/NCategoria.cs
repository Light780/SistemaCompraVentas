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
    public class NCategoria
    {
        public static DataTable Listar()
        {
            try
            {
                DCategoria Datos = new DCategoria();
                DataTable resultado = Datos.Listar();

                // Registrar la consulta
                Logger.RegistrarConsulta("Categoria",
                    $"Listado de categorías - Total registros: {resultado.Rows.Count}");

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar el error
                Logger.RegistrarError(AccionLog.READ, "Categoria", ex,
                    null,
                    "Error al listar categorías");
                throw;
            }
        }

        public static DataTable Seleccionar()
        {
            try
            {
                DCategoria Datos = new DCategoria();
                DataTable resultado = Datos.Seleccionar();

                // Registrar la consulta
                Logger.RegistrarConsulta("Categoria",
                    $"Selección de categorías activas - Total: {resultado.Rows.Count}");

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar el error
                Logger.RegistrarError(AccionLog.READ, "Categoria", ex,
                    null,
                    "Error al seleccionar categorías activas");
                throw;
            }
        }

        public static DataTable Buscar(String Valor)
        {
            try
            {
                DCategoria Datos = new DCategoria();
                DataTable resultado = Datos.Buscar(Valor);

                // Registrar la búsqueda
                Logger.RegistrarConsulta("Categoria",
                    $"Búsqueda de categorías con valor: '{Valor}' - Resultados: {resultado.Rows.Count}");

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar el error
                Logger.RegistrarError(AccionLog.READ, "Categoria", ex,
                    null,
                    $"Error al buscar categorías con valor: '{Valor}'");
                throw;
            }
        }

        public static string Insertar(string Nombre, string Descripcion)
        {
            DCategoria Datos = new DCategoria();
            string resultado = "";

            try
            {
                // Validar si la categoría ya existe
                string Existe = Datos.Existe(Nombre);
                if (Existe.Equals("1"))
                {
                    resultado = "La categoría ya existe.";

                    // Registrar el intento fallido
                    Logger.RegistrarError(AccionLog.CREATE, "Categoria",
                        new Exception(resultado),
                        null,
                        $"Intento de crear categoría duplicada: {Nombre}");

                    return resultado;
                }
                else
                {
                    // Crear el objeto Categoria
                    Categoria Obj = new Categoria();
                    Obj.Nombre = Nombre;
                    Obj.Descripcion = Descripcion;

                    // Insertar en la base de datos
                    resultado = Datos.Insertar(Obj);

                    // Si fue exitoso, registrar el log
                    if (resultado == "OK")
                    {
                        Logger.RegistrarCreacion("Categoria", Obj.IdCategoria,
                            $"Categoría creada: {Nombre} - Descripción: {Descripcion ?? "Sin descripción"}");
                    }
                    else
                    {
                        // Si hubo error, registrarlo
                        Logger.RegistrarError(AccionLog.CREATE, "Categoria",
                            new Exception(resultado),
                            null,
                            $"Error al crear categoría: {Nombre}");
                    }

                    return resultado;
                }
            }
            catch (Exception ex)
            {
                // Registrar la excepción
                Logger.RegistrarError(AccionLog.CREATE, "Categoria", ex,
                    null,
                    $"Excepción al insertar categoría: {Nombre}");

                throw;
            }
        }

        public static string Actualizar(int Id,string NombreAnt, string Nombre, string Descripcion)
        {
            DCategoria Datos = new DCategoria();
            Categoria Obj = new Categoria();
            string resultado = "";

            try
            {
                // Si el nombre no cambió, actualizar directamente
                if (NombreAnt.Equals(Nombre))
                {
                    Obj.IdCategoria = Id;
                    Obj.Nombre = Nombre;
                    Obj.Descripcion = Descripcion;

                    resultado = Datos.Actualizar(Obj);

                    // Registrar la actualización exitosa
                    if (resultado == "OK")
                    {
                        Logger.RegistrarActualizacion("Categoria", Id,
                            $"Categoría actualizada: {Nombre} - Descripción: {Descripcion ?? "Sin descripción"}");
                    }
                    else
                    {
                        Logger.RegistrarError(AccionLog.UPDATE, "Categoria",
                            new Exception(resultado),
                            Id,
                            $"Error al actualizar categoría: {Nombre}");
                    }

                    return resultado;
                }
                else
                {
                    // Si el nombre cambió, verificar que no exista
                    string Existe = Datos.Existe(Nombre);
                    if (Existe.Equals("1"))
                    {
                        resultado = "La categoría con ese nombre ya existe.";

                        // Registrar intento de cambiar a nombre duplicado
                        Logger.RegistrarError(AccionLog.UPDATE, "Categoria",
                            new Exception(resultado),
                            Id,
                            $"Intento de cambiar a nombre duplicado: de '{NombreAnt}' a '{Nombre}'");

                        return resultado;
                    }
                    else
                    {
                        Obj.IdCategoria = Id;
                        Obj.Nombre = Nombre;
                        Obj.Descripcion = Descripcion;

                        resultado = Datos.Actualizar(Obj);

                        // Registrar actualización con cambio de nombre
                        if (resultado == "OK")
                        {
                            Logger.RegistrarActualizacion("Categoria", Id,
                                $"Categoría actualizada: Nombre cambiado de '{NombreAnt}' a '{Nombre}' - Descripción: {Descripcion ?? "Sin descripción"}");
                        }
                        else
                        {
                            Logger.RegistrarError(AccionLog.UPDATE, "Categoria",
                                new Exception(resultado),
                                Id,
                                $"Error al actualizar categoría con cambio de nombre: '{Nombre}'");
                        }

                        return resultado;
                    }
                }
            }
            catch (Exception ex)
            {
                // Registrar la excepción
                Logger.RegistrarError(AccionLog.UPDATE, "Categoria", ex,
                    Id,
                    $"Excepción al actualizar categoría: {Nombre}");

                throw;
            }
        }

        public static string Eliminar(int Id)
        {
            DCategoria Datos = new DCategoria();
            string resultado = "";

            try
            {
                resultado = Datos.Eliminar(Id);

                // Registrar la eliminación
                if (resultado == "OK")
                {
                    Logger.RegistrarEliminacion("Categoria", Id,
                        $"Categoría eliminada - ID: {Id}");
                }
                else
                {
                    Logger.RegistrarError(AccionLog.DELETE, "Categoria",
                        new Exception(resultado),
                        Id,
                        $"Error al eliminar categoría ID: {Id}");
                }

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar la excepción
                Logger.RegistrarError(AccionLog.DELETE, "Categoria", ex,
                    Id,
                    $"Excepción al eliminar categoría ID: {Id}");

                throw;
            }
        }

        public static string Activar(int Id)
        {
            DCategoria Datos = new DCategoria();
            string resultado = "";

            try
            {
                resultado = Datos.Activar(Id);

                // Registrar la activación
                if (resultado == "OK")
                {
                    Logger.RegistrarActivacion("Categoria", Id,
                        $"Categoría activada - ID: {Id}");
                }
                else
                {
                    Logger.RegistrarError(AccionLog.ACTIVATE, "Categoria",
                        new Exception(resultado),
                        Id,
                        $"Error al activar categoría ID: {Id}");
                }

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar la excepción
                Logger.RegistrarError(AccionLog.ACTIVATE, "Categoria", ex,
                    Id,
                    $"Excepción al activar categoría ID: {Id}");

                throw;
            }
        }

        public static string Desactivar(int Id)
        {
            DCategoria Datos = new DCategoria();
            string resultado = "";

            try
            {
                resultado = Datos.Desactivar(Id);

                // Registrar la desactivación
                if (resultado == "OK")
                {
                    Logger.RegistrarDesactivacion("Categoria", Id,
                        $"Categoría desactivada - ID: {Id}");
                }
                else
                {
                    Logger.RegistrarError(AccionLog.DEACTIVATE, "Categoria",
                        new Exception(resultado),
                        Id,
                        $"Error al desactivar categoría ID: {Id}");
                }

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar la excepción
                Logger.RegistrarError(AccionLog.DEACTIVATE, "Categoria", ex,
                    Id,
                    $"Excepción al desactivar categoría ID: {Id}");

                throw;
            }
        }
    }
}
