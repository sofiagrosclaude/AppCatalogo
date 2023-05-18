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
                comando.CommandText = "Select Codigo, Nombre, A.Descripcion, ImagenUrl, C.Descripcion as Categoria, Precio, M.Descripcion as Marca\r\nFrom ARTICULOS A, CATEGORIAS C, MARCAS M\r\nwhere C.Id = A.IdCategoria AND M.Id = A.IdMarca";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];

                    if (!(lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)lector["Descripcion"];
                    
                    if (!(lector["ImagenUrl"] is DBNull)) //solo intenta leer si no es 
                        aux.ImagenUrl = (string)lector["ImagenUrl"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)lector["Categoria"];
                    aux.Precio = lector.GetDecimal(5);
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)lector["Marca"];

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
                datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Precio, IdCategoria, IdMarca, ImagenUrl)values('" + nuevo.Codigo + "', '" + nuevo.Nombre + "', " + nuevo.Precio + ", @idCategoria, @idMarca, @imagenUrl)");
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

        public void modificar(Articulo modificar)
        {

        }
    }

    
}
