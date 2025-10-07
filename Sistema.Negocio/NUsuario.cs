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
    public class NUsuario
    {
        public static DataTable Listar()
        {
            try
            {
                DUsuario Datos = new DUsuario();
                DataTable resultado = Datos.Listar();

                // Registrar la consulta
                Logger.RegistrarConsulta("Usuario",
                    $"Listado de usuarios - Total registros: {resultado.Rows.Count}");

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar el error
                Logger.RegistrarError(AccionLog.READ, "Usuario", ex,
                    null,
                    "Error al listar usuarios");
                throw;
            }
        }

        public static DataTable Buscar(string Valor)
        {
            try
            {
                DUsuario Datos = new DUsuario();
                DataTable resultado = Datos.Buscar(Valor);

                // Registrar la búsqueda
                Logger.RegistrarConsulta("Usuario",
                    $"Búsqueda de usuarios con valor: '{Valor}' - Resultados: {resultado.Rows.Count}");

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar el error
                Logger.RegistrarError(AccionLog.READ, "Usuario", ex,
                    null,
                    $"Error al buscar usuarios con valor: '{Valor}'");
                throw;
            }
        }
        public static DataTable Login(string Email, string Clave)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Login(Email, Clave);
        }

        public static string Insertar(int IdRol, string Nombre, string TipoDocumento, string NumDocumento, string Direccion, string Telefono, string Email, string Clave)
        {
            DUsuario Datos = new DUsuario();
            string resultado = "";

            try
            {
                string Existe = Datos.Existe(Email);
                if (Existe.Equals("1"))
                {
                    resultado = "El usuario con ese email ya existe.";
                    Logger.RegistrarError(AccionLog.CREATE, "Usuario",
                        new Exception(resultado), null, $"Intento de crear usuario con email duplicado: {Email}");
                    return resultado;
                }
                else
                {
                    Usuario Obj = new Usuario();
                    Obj.IdRol = IdRol;
                    Obj.Nombre = Nombre;
                    Obj.TipoDocumento = TipoDocumento;
                    Obj.NumDocumento = NumDocumento;
                    Obj.Direccion = Direccion;
                    Obj.Telefono = Telefono;
                    Obj.Email = Email;
                    Obj.Clave = Clave;

                    resultado = Datos.Insertar(Obj);

                    if (resultado == "OK")
                    {
                        // Registrar la creación exitosa
                        Logger.RegistrarCreacion("Usuario", Obj.IdUsuario,
                            $"Usuario creado: {Nombre} ({Email})");
                    }

                    return resultado;
                }
            }
            catch (Exception ex)
            {
                Logger.RegistrarError(AccionLog.CREATE, "Usuario", ex, null,
                    $"Error al insertar usuario: {Nombre}");
                throw;
            }
        }

        public static string Actualizar(int Id, int IdRol, string Nombre, string TipoDocumento, string NumDocumento, string Direccion, string Telefono, string EmailAnt, string Email, string Clave)
        {
            DUsuario Datos = new DUsuario();
            Usuario Obj = new Usuario();
            string resultado = "";

            try
            {
                if (EmailAnt.Equals(Email))
                {
                    Obj.IdUsuario = Id;
                    Obj.IdRol = IdRol;
                    Obj.Nombre = Nombre;
                    Obj.TipoDocumento = TipoDocumento;
                    Obj.NumDocumento = NumDocumento;
                    Obj.Direccion = Direccion;
                    Obj.Telefono = Telefono;
                    Obj.Email = Email;
                    Obj.Clave = Clave;

                    resultado = Datos.Actualizar(Obj);

                    if (resultado == "OK")
                    {
                        Logger.RegistrarActualizacion("Usuario", Id,
                            $"Usuario actualizado: {Nombre} ({Email})");
                    }

                    return resultado;
                }
                else
                {
                    string Existe = Datos.Existe(Email);
                    if (Existe.Equals("1"))
                    {
                        resultado = "El usuario con ese email ya existe.";
                        Logger.RegistrarError(AccionLog.UPDATE, "Usuario",
                            new Exception(resultado), Id, $"Intento de actualizar a email duplicado: {Email}");
                        return resultado;
                    }
                    else
                    {
                        Obj.IdUsuario = Id;
                        Obj.IdRol = IdRol;
                        Obj.Nombre = Nombre;
                        Obj.TipoDocumento = TipoDocumento;
                        Obj.NumDocumento = NumDocumento;
                        Obj.Direccion = Direccion;
                        Obj.Telefono = Telefono;
                        Obj.Email = Email;
                        Obj.Clave = Clave;

                        resultado = Datos.Actualizar(Obj);

                        if (resultado == "OK")
                        {
                            Logger.RegistrarActualizacion("Usuario", Id,
                                $"Usuario actualizado: {Nombre} (Email cambiado de {EmailAnt} a {Email})");
                        }

                        return resultado;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.RegistrarError(AccionLog.UPDATE, "Usuario", ex, Id,
                    $"Error al actualizar usuario: {Nombre}");
                throw;
            }

        }

        public static string Eliminar(int Id)
        {
            DUsuario Datos = new DUsuario();
            string resultado = "";

            try
            {
                resultado = Datos.Eliminar(Id);

                if (resultado == "OK")
                {
                    Logger.RegistrarEliminacion("Usuario", Id, "Usuario eliminado");
                }

                return resultado;
            }
            catch (Exception ex)
            {
                Logger.RegistrarError(AccionLog.DELETE, "Usuario", ex, Id,
                    "Error al eliminar usuario");
                throw;
            }
        }

        public static string Activar(int Id)
        {
            DUsuario Datos = new DUsuario();
            string resultado = "";

            try
            {
                resultado = Datos.Activar(Id);

                if (resultado == "OK")
                {
                    Logger.RegistrarActivacion("Usuario", Id, "Usuario activado");
                }

                return resultado;
            }
            catch (Exception ex)
            {
                Logger.RegistrarError(AccionLog.ACTIVATE, "Usuario", ex, Id);
                throw;
            }
        }

        public static string Desactivar(int Id)
        {
            DUsuario Datos = new DUsuario();
            string resultado = "";

            try
            {
                resultado = Datos.Desactivar(Id);

                if (resultado == "OK")
                {
                    Logger.RegistrarDesactivacion("Usuario", Id, "Usuario desactivado");
                }

                return resultado;
            }
            catch (Exception ex)
            {
                Logger.RegistrarError(AccionLog.DEACTIVATE, "Usuario", ex, Id);
                throw;
            }
        }
    }
}
