using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;



namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
           

            try
            {
                conexion.ConnectionString = "server=DESKTOP-VNUL8N7\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select A.Id, Codigo, Nombre, A.Descripcion, ImagenUrl, C.Descripcion as Categoria, Precio, M.Descripcion as Marca, A.IdCategoria, A.IdMarca From ARTICULOS A, CATEGORIAS C, MARCAS M where C.Id = A.IdCategoria AND M.Id = A.IdMarca";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    

                    if (!(lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)lector["Descripcion"];
                    
                    if (!(lector["ImagenUrl"] is DBNull)) 
                        aux.ImagenUrl = (string)lector["ImagenUrl"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)lector["Categoria"];
                   
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)lector["IdMarca"];
                    aux.Marca.Descripcion = (string)lector["Marca"];

                    aux.Precio = lector.GetDecimal(6);
                    
                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdCategoria, IdMarca, ImagenUrl)values('" + nuevo.Codigo + "', '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', " + nuevo.Precio + ", @idCategoria, @idMarca, @imagenUrl)");
                datos.setearParametro("@idCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@idMarca", nuevo.Marca.Id);
                datos.setearParametro("@imagenUrl", nuevo.ImagenUrl);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdCategoria = @idCategoria, IdMarca = @idMarca, Precio = @precio, ImagenUrl = @imagenUrl where Id = @id");
                datos.setearParametro("@codigo", art.Codigo);
                datos.setearParametro("@nombre", art.Nombre);
                datos.setearParametro("@descripcion", art.Descripcion);
                datos.setearParametro("@idCategoria", art.Categoria.Id);
                datos.setearParametro("@idMarca", art.Marca.Id);
                datos.setearParametro("@precio", art.Precio);
                datos.setearParametro("@imagenUrl", art.ImagenUrl);
                datos.setearParametro("@id", art.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Articulo> filtrar(string cualidad, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "Select A.Id, Codigo, Nombre, A.Descripcion, ImagenUrl, C.Descripcion as Categoria, Precio, M.Descripcion as Marca, A.IdCategoria, A.IdMarca From ARTICULOS A, CATEGORIAS C, MARCAS M where C.Id = A.IdCategoria And M.Id = A.IdMarca And ";
                if(cualidad == "Precio")
                {
                    switch(criterio)
                    {
                        case "Desde":
                            consulta += "Precio >= " + filtro;
                            break;
                        case "Hasta":
                            consulta += "Precio <= " + filtro;
                            break;
                    }
                }
                else if(cualidad == "Marca")
                {
                    switch (criterio)
                    {
                        case "Empieza con":
                            consulta += "M.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Contiene":
                            consulta += "M.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Empieza con":
                            consulta += "C.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Contiene":
                            consulta += "C.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Precio = datos.Lector.GetDecimal(6);


                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                                      
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];


                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

    
}
