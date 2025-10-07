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
    public class NArticulo
    {
        public static DataTable Listar()
        {
            try
            {
                DArticulo Datos = new DArticulo();
                DataTable resultado = Datos.Listar();

                // Registrar la consulta
                Logger.RegistrarConsulta("Articulo",
                    $"Listado de artículos - Total registros: {resultado.Rows.Count}");

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar el error
                Logger.RegistrarError(AccionLog.READ, "Articulo", ex,
                    null,
                    "Error al listar artículos");
                throw;
            }
        }

        public static DataTable Buscar(string Valor)
        {
            try
            {
                DArticulo Datos = new DArticulo();
                DataTable resultado = Datos.Buscar(Valor);

                // Registrar la búsqueda
                Logger.RegistrarConsulta("Articulo",
                    $"Búsqueda de artículos con valor: '{Valor}' - Resultados: {resultado.Rows.Count}");

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar el error
                Logger.RegistrarError(AccionLog.READ, "Articulo", ex,
                    null,
                    $"Error al buscar artículos con valor: '{Valor}'");
                throw;
            }
        }

        public static DataTable BuscarVenta(string Valor)
        {
            try
            {
                DArticulo Datos = new DArticulo();
                DataTable resultado = Datos.BuscarVenta(Valor);

                // Registrar la búsqueda por código
                Logger.RegistrarConsulta("Articulo",
                    $"Búsqueda por código de venta: '{Valor}' - Resultados: {resultado.Rows.Count}");

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar el error
                Logger.RegistrarError(AccionLog.READ, "Articulo", ex,
                    null,
                    $"Error al buscar artículo por código: '{Valor}'");
                throw;
            }
        }
        public static DataTable BuscarCodigo(string Valor)
        {
            try
            {
                DArticulo Datos = new DArticulo();
                DataTable resultado = Datos.BuscarCodigo(Valor);

                // Registrar la búsqueda por código de ingreso
                Logger.RegistrarConsulta("Articulo",
                    $"Búsqueda por código de ingreso: '{Valor}' - Resultados: {resultado.Rows.Count}");

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar el error
                Logger.RegistrarError(AccionLog.READ, "Articulo", ex,
                    null,
                    $"Error al buscar artículo por código de ingreso: '{Valor}'");
                throw;
            }
        }

        public static DataTable BuscarCodigoVenta(string Valor)
        {
            try
            {
                DArticulo Datos = new DArticulo();
                DataTable resultado = Datos.BuscarCodigoVenta(Valor);

                // Registrar la búsqueda por código
                Logger.RegistrarConsulta("Articulo",
                    $"Búsqueda por código de venta: '{Valor}' - Resultados: {resultado.Rows.Count}");

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar el error
                Logger.RegistrarError(AccionLog.READ, "Articulo", ex,
                    null,
                    $"Error al buscar artículo por código: '{Valor}'");
                throw;
            }
        }
        public static string Insertar(int IdCategoria,string Codigo,string Nombre,decimal PrecioVenta,int Stock, string Descripcion, string Imagen)
        {
            DArticulo Datos = new DArticulo();
            string resultado = "";

            try
            {
                string Existe = Datos.Existe(Nombre);
                if (Existe.Equals("1"))
                {
                    resultado = "El código del artículo ya existe.";

                    // Registrar el intento fallido
                    Logger.RegistrarError(AccionLog.CREATE, "Articulo",
                        new Exception(resultado),
                        null,
                        $"Intento de crear artículo con nombre duplicado: {Codigo} - Nombre: {Nombre}");

                    return resultado;
                }
                else
                {
                    Articulo Obj = new Articulo();
                    Obj.IdCategoria = IdCategoria;
                    Obj.Codigo = Codigo;
                    Obj.Nombre = Nombre;
                    Obj.PrecioVenta = PrecioVenta;
                    Obj.Stock = Stock;
                    Obj.Descripcion = Descripcion;
                    Obj.Imagen = Imagen;
                    resultado = Datos.Insertar(Obj);

                    // Si fue exitoso, registrar el log
                    if (resultado == "OK")
                    {
                        Logger.RegistrarCreacion("Articulo", Obj.IdArticulo,
                            $"Artículo creado: {Nombre} (Código: {Codigo}) - " +
                            $"Precio: {PrecioVenta:C}, Stock inicial: {Stock}, Descripción: {Descripcion ?? "Sin descripción"}");
                    }
                    else
                    {
                        // Si hubo error, registrarlo
                        Logger.RegistrarError(AccionLog.CREATE, "Articulo",
                            new Exception(resultado),
                            null,
                            $"Error al crear artículo: {Nombre} (Código: {Codigo})");
                    }

                    return resultado;
                }
            }
            catch (Exception ex)
            {
                // Registrar la excepción
                Logger.RegistrarError(AccionLog.CREATE, "Articulo", ex,
                    null,
                    $"Excepción al insertar artículo: {Nombre} (Código: {Codigo})");

                throw;
            }
        }

        public static string Actualizar(int Id, int IdCategoria,string Codigo, string NombreAnt, string Nombre,decimal PrecioVenta,int Stock, string Descripcion, string Imagen)
        {
            DArticulo Datos = new DArticulo();
            Articulo Obj = new Articulo();
            string resultado = "";

            try
            {
                if (NombreAnt.Equals(Nombre))
                {
                    Obj.IdArticulo = Id;
                    Obj.IdCategoria = IdCategoria;
                    Obj.Codigo = Codigo;
                    Obj.Nombre = Nombre;
                    Obj.PrecioVenta = PrecioVenta;
                    Obj.Stock = Stock;
                    Obj.Descripcion = Descripcion;
                    Obj.Imagen = Imagen;
                    resultado = Datos.Actualizar(Obj);

                    // Registrar la actualización exitosa
                    if (resultado == "OK")
                    {
                        Logger.RegistrarActualizacion("Articulo", Id,
                            $"Artículo actualizado: {Nombre} (Código: {Codigo}) - " +
                            $"Precio: {PrecioVenta:C}, Stock: {Stock}, Descripción: {Descripcion ?? "Sin descripción"}");
                    }
                    else
                    {
                        Logger.RegistrarError(AccionLog.UPDATE, "Articulo",
                            new Exception(resultado),
                            Id,
                            $"Error al actualizar artículo: {Nombre}");
                    }

                    return resultado;
                }
                else
                {
                    string Existe = Datos.Existe(Nombre);
                    if (Existe.Equals("1"))
                    {
                        resultado = "El artículo ya existe.";

                        // Registrar intento de cambiar a código duplicado
                        Logger.RegistrarError(AccionLog.UPDATE, "Articulo",
                            new Exception(resultado),
                            Id,
                            $"Intento de cambiar a nombre duplicado: de '{NombreAnt}' a '{Nombre}' - Artículo: {Codigo}");

                        return resultado;
                    }
                    else
                    {
                        Obj.IdArticulo = Id;
                        Obj.IdCategoria = IdCategoria;
                        Obj.Codigo = Codigo;
                        Obj.Nombre = Nombre;
                        Obj.PrecioVenta = PrecioVenta;
                        Obj.Stock = Stock;
                        Obj.Descripcion = Descripcion;
                        Obj.Imagen = Imagen;
                        resultado = Datos.Actualizar(Obj);

                        // Registrar actualización con cambio de código
                        if (resultado == "OK")
                        {
                            Logger.RegistrarActualizacion("Articulo", Id,
                                $"Artículo actualizado: {Nombre} - {Codigo} - " +
                                $"Precio: {PrecioVenta:C}, Stock: {Stock}");
                        }
                        else
                        {
                            Logger.RegistrarError(AccionLog.UPDATE, "Articulo",
                                new Exception(resultado),
                                Id,
                                $"Error al actualizar artículo: {Nombre}");
                        }

                        return resultado;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.RegistrarError(AccionLog.UPDATE, "Articulo", ex,
                    Id,
                    $"Excepción al actualizar artículo: {Nombre} (Código: {Codigo})");
                throw;
            }
        }

        public static string Eliminar(int Id)
        {
            DArticulo Datos = new DArticulo();
            string resultado = "";

            try
            {
                resultado = Datos.Eliminar(Id);

                // Registrar la eliminación
                if (resultado == "OK")
                {
                    Logger.RegistrarEliminacion("Articulo", Id,
                        $"Artículo eliminado - ID: {Id}");
                }
                else
                {
                    Logger.RegistrarError(AccionLog.DELETE, "Articulo",
                        new Exception(resultado),
                        Id,
                        $"Error al eliminar artículo ID: {Id}");
                }

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar la excepción
                Logger.RegistrarError(AccionLog.DELETE, "Articulo", ex,
                    Id,
                    $"Excepción al eliminar artículo ID: {Id}");

                throw;
            }
        }

        public static string Activar(int Id)
        {
            DArticulo Datos = new DArticulo();
            string resultado = "";

            try
            {
                resultado = Datos.Activar(Id);

                // Registrar la activación
                if (resultado == "OK")
                {
                    Logger.RegistrarActivacion("Articulo", Id,
                        $"Artículo activado - ID: {Id}");
                }
                else
                {
                    Logger.RegistrarError(AccionLog.ACTIVATE, "Articulo",
                        new Exception(resultado),
                        Id,
                        $"Error al activar artículo ID: {Id}");
                }

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar la excepción
                Logger.RegistrarError(AccionLog.ACTIVATE, "Articulo", ex,
                    Id,
                    $"Excepción al activar artículo ID: {Id}");

                throw;
            }
        }

        public static string Desactivar(int Id)
        {
            DArticulo Datos = new DArticulo();
            string resultado = "";

            try
            {
                resultado = Datos.Desactivar(Id);

                // Registrar la desactivación
                if (resultado == "OK")
                {
                    Logger.RegistrarDesactivacion("Articulo", Id,
                        $"Artículo desactivado - ID: {Id}");
                }
                else
                {
                    Logger.RegistrarError(AccionLog.DEACTIVATE, "Articulo",
                        new Exception(resultado),
                        Id,
                        $"Error al desactivar artículo ID: {Id}");
                }

                return resultado;
            }
            catch (Exception ex)
            {
                // Registrar la excepción
                Logger.RegistrarError(AccionLog.DEACTIVATE, "Articulo", ex,
                    Id,
                    $"Excepción al desactivar artículo ID: {Id}");

                throw;
            }
        }
    }
}
