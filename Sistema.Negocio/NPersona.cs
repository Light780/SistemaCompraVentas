using Sistema.Datos;
using Sistema.Entidades;
using System;
using System.Data;

namespace Sistema.Negocio
{
    public class NPersona
    {
        public static DataTable Listar()
        {
            try
            {
                DPersona Datos = new DPersona();
                DataTable resultado = Datos.Listar();

                // Registrar la consulta
                Logger.RegistrarConsulta("Persona",
                    $"Listado de personas - Total registros: {resultado.Rows.Count}");

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar el error
                Logger.RegistrarError(AccionLog.READ, "Persona", ex,
                    null,
                    "Error al listar personas");
                throw;
            }
        }
        public static DataTable ListarProveedores()
        {
            try
            {
                DPersona Datos = new DPersona();
                DataTable resultado = Datos.ListarProveedores();

                // Registrar la consulta
                Logger.RegistrarConsulta("Persona",
                    $"Listado de proveedores - Total registros: {resultado.Rows.Count}");

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar el error
                Logger.RegistrarError(AccionLog.READ, "Persona", ex,
                    null,
                    "Error al listar proveedores");
                throw;
            }
        }

        public static DataTable ListarClientes()
        {
            try
            {
                DPersona Datos = new DPersona();
                DataTable resultado = Datos.ListarClientes();

                // Registrar la consulta
                Logger.RegistrarConsulta("Persona",
                    $"Listado de clientes - Total registros: {resultado.Rows.Count}");

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar el error
                Logger.RegistrarError(AccionLog.READ, "Persona", ex,
                    null,
                    "Error al listar clientes");
                throw;
            }
        }

        public static DataTable Buscar(string Valor)
        {
            try
            {
                DPersona Datos = new DPersona();
                DataTable resultado = Datos.Buscar(Valor);

                // Registrar la búsqueda
                Logger.RegistrarConsulta("Persona",
                    $"Búsqueda de personas con valor: '{Valor}' - Resultados: {resultado.Rows.Count}");

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar el error
                Logger.RegistrarError(AccionLog.READ, "Persona", ex,
                    null,
                    $"Error al buscar personas con valor: '{Valor}'");
                throw;
            }
        }
        public static DataTable BuscarProveedores(string Valor)
        {
            try
            {
                DPersona Datos = new DPersona();
                DataTable resultado = Datos.BuscarProveedores(Valor);

                // Registrar la búsqueda
                Logger.RegistrarConsulta("Persona",
                    $"Búsqueda de proveedores con valor: '{Valor}' - Resultados: {resultado.Rows.Count}");

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar el error
                Logger.RegistrarError(AccionLog.READ, "Persona", ex,
                    null,
                    $"Error al buscar proveedores con valor: '{Valor}'");
                throw;
            }
        }
        public static DataTable BuscarClientes(string Valor)
        {
            try
            {
                DPersona Datos = new DPersona();
                DataTable resultado = Datos.BuscarClientes(Valor);

                // Registrar la búsqueda
                Logger.RegistrarConsulta("Persona",
                    $"Búsqueda de clientes con valor: '{Valor}' - Resultados: {resultado.Rows.Count}");

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar el error
                Logger.RegistrarError(AccionLog.READ, "Persona", ex,
                    null,
                    $"Error al buscar clientes con valor: '{Valor}'");
                throw;
            }
        }
        public static string Insertar(string TipoPersona, string Nombre, string TipoDocumento, string NumDocumento, string Direccion, string Telefono, string Email)
        {
            DPersona Datos = new DPersona();
            string resultado = "";

            try
            {
                // Validar si el documento ya existe (si se proporcionó)
                if (!string.IsNullOrEmpty(NumDocumento))
                {
                    string Existe = Datos.Existe(NumDocumento);
                    if (Existe.Equals("1"))
                    {
                        resultado = "Ya existe una persona con ese documento.";

                        // Registrar el intento fallido
                        Logger.RegistrarError(AccionLog.CREATE, "Persona",
                            new Exception(resultado),
                            null,
                            $"Intento de crear {TipoPersona} con documento duplicado: {Email} - Nombre: {Nombre}");

                        return resultado;
                    }
                }

                // Crear el objeto Persona
                Persona Obj = new Persona();
                Obj.TipoPersona = TipoPersona;
                Obj.Nombre = Nombre;
                Obj.TipoDocumento = TipoDocumento;
                Obj.NumDocumento = NumDocumento;
                Obj.Direccion = Direccion;
                Obj.Telefono = Telefono;
                Obj.Email = Email;

                // Insertar en la base de datos
                resultado = Datos.Insertar(Obj);

                // Si fue exitoso, registrar el log
                if (resultado == "OK")
                {
                    string tipoDescripcion = TipoPersona == "Cliente" ? "Cliente" : "Proveedor";
                    Logger.RegistrarCreacion("Persona", Obj.IdPersona,
                        $"{tipoDescripcion} creado: {Nombre} - Documento: {TipoDocumento} {NumDocumento}, " +
                        $"Teléfono: {Telefono ?? "N/A"}, Email: {Email ?? "N/A"}");
                }
                else
                {
                    // Si hubo error, registrarlo
                    Logger.RegistrarError(AccionLog.CREATE, "Persona",
                        new Exception(resultado),
                        null,
                        $"Error al crear {TipoPersona}: {Nombre}");
                }

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar la excepción
                Logger.RegistrarError(AccionLog.CREATE, "Persona", ex,
                    null,
                    $"Excepción al insertar {TipoPersona}: {Nombre}");

                throw;
            }
        }

        public static string Actualizar(int Id, string TipoPersona,string NumDocumentoAnt, string Nombre, string TipoDocumento, string NumDocumento, string Direccion, string Telefono, string Email)
        {
            DPersona Datos = new DPersona();
            Persona Obj = new Persona();
            string resultado = "";

            try
            {
                // Si el documento no cambió o está vacío, actualizar directamente
                if (NumDocumentoAnt.Equals(Email) || string.IsNullOrEmpty(NumDocumentoAnt))
                {
                    Obj.IdPersona = Id;
                    Obj.TipoPersona = TipoPersona;
                    Obj.Nombre = Nombre;
                    Obj.TipoDocumento = TipoDocumento;
                    Obj.NumDocumento = NumDocumento;
                    Obj.Direccion = Direccion;
                    Obj.Telefono = Telefono;
                    Obj.Email = Email;

                    resultado = Datos.Actualizar(Obj);

                    // Registrar la actualización exitosa
                    if (resultado == "OK")
                    {
                        string tipoDescripcion = TipoPersona == "Cliente" ? "Cliente" : "Proveedor";
                        Logger.RegistrarActualizacion("Persona", Id,
                            $"{tipoDescripcion} actualizado: {Nombre} - Documento: {TipoDocumento} {NumDocumento}");
                    }
                    else
                    {
                        Logger.RegistrarError(AccionLog.UPDATE, "Persona",
                            new Exception(resultado),
                            Id,
                            $"Error al actualizar {TipoPersona}: {Nombre}");
                    }

                    return resultado;
                }
                else
                {
                    // Si el documento cambió, verificar que no exista
                    string Existe = Datos.Existe(NumDocumento);
                    if (Existe.Equals("1"))
                    {
                        resultado = "Ya existe una persona con ese documento.";

                        // Registrar intento de cambiar a documento duplicado
                        Logger.RegistrarError(AccionLog.UPDATE, "Persona",
                            new Exception(resultado),
                            Id,
                            $"Intento de cambiar a documento duplicado: de '{NumDocumentoAnt}' a '{NumDocumento}' - {TipoPersona}: {Nombre}");

                        return resultado;
                    }
                    else
                    {
                        Obj.IdPersona = Id;
                        Obj.TipoPersona = TipoPersona;
                        Obj.Nombre = Nombre;
                        Obj.TipoDocumento = TipoDocumento;
                        Obj.NumDocumento = NumDocumento;
                        Obj.Direccion = Direccion;
                        Obj.Telefono = Telefono;
                        Obj.Email = Email;

                        resultado = Datos.Actualizar(Obj);

                        if (resultado == "OK")
                        {
                            string tipoDescripcion = TipoPersona == "Cliente" ? "Cliente" : "Proveedor";
                            Logger.RegistrarActualizacion("Persona", Id,
                                $"{tipoDescripcion} actualizado: {Nombre} - {NumDocumento}");
                        }
                        else
                        {
                            Logger.RegistrarError(AccionLog.UPDATE, "Persona",
                                new Exception(resultado),
                                Id,
                                $"Error al actualizar {TipoPersona}: {Nombre}");
                        }

                        return resultado;
                    }
                }
            }
            catch (Exception ex)
            {
                // Registrar la excepción
                Logger.RegistrarError(AccionLog.UPDATE, "Persona", ex,
                    Id,
                    $"Excepción al actualizar {TipoPersona}: {Nombre}");

                throw;
            }

        }

        public static string Eliminar(int Id)
        {
            DPersona Datos = new DPersona();
            string resultado = "";

            try
            {
                resultado = Datos.Eliminar(Id);

                // Registrar la eliminación
                if (resultado == "OK")
                {
                    Logger.RegistrarEliminacion("Persona", Id,
                        $"Persona eliminada - ID: {Id}");
                }
                else
                {
                    Logger.RegistrarError(AccionLog.DELETE, "Persona",
                        new Exception(resultado),
                        Id,
                        $"Error al eliminar persona ID: {Id}");
                }

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar la excepción
                Logger.RegistrarError(AccionLog.DELETE, "Persona", ex,
                    Id,
                    $"Excepción al eliminar persona ID: {Id}");

                throw;
            }
        }
    }
}
