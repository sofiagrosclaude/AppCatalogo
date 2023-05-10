using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    class ArticuloNegocio
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
                comando.CommandText = "Select Codigo, Nombre, A.Descripcion, ImagenUrl, C.Descripcion as Tipo, Precio, M.Descripcion as Marca\r\nFrom ARTICULOS A, CATEGORIAS C, MARCAS M\r\nwhere C.Id = A.IdCategoria AND M.Id = A.IdMarca";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.ImagenUrl = (string)lector["ImagenUrl"];
                    aux.Tipo = new Categoria();
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
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

    }
}
