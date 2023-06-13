using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;



namespace ConexionDb
{
    public class ProductosNegocio
    {

        public List<Productos> listar()
        {
            List<Productos> lista = new List<Productos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.Id,Nombre, Codigo, ImagenUrl, Precio,A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, M.Id as IdMarca, C.Id as IdCategoria from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca and A.IdCategoria= C.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();
                
                while (lector.Read())
                {
                    Productos aux = new Productos();
                    aux.Id = (int)lector["Id"];
                    aux.CodArt = (String)lector["Codigo"];
                    aux.Nombre = (String)lector["Nombre"];
                    aux.Descripcion = (String)lector["Descripcion"];
                    aux.Precio = (decimal)lector["Precio"];
                    aux.Imagen = (String)lector["ImagenUrl"];
                    if (!(lector["ImagenUrl"] is DBNull))
                        aux.Imagen = (String)lector["ImagenUrl"];
                    aux.Marca = new Marca();
                    aux.Marca.Id= (int)lector["IdMarca"];
                    aux.Marca.Descripcion = (String)lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)lector["IdCategoria"];
                    aux.Categoria.Descripcion = (String)lector["Categoria"];
                    
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

        public void agregar(Productos productoNuevo) 
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS (Nombre, Codigo,Precio, Descripcion,IdMarca,IdCategoria, ImagenUrl)values(@Nombre,@Codigo,@Precio,@Descripcion,@IdMarca,@IdCategoria, @Imagen) ");
                datos.setearParametros("@Nombre", productoNuevo.Nombre);
                datos.setearParametros("Codigo", productoNuevo.CodArt);
                datos.setearParametros("@Precio", productoNuevo.Precio);
                datos.setearParametros("@Descripcion", productoNuevo.Descripcion);
                datos.setearParametros("@IdMarca", productoNuevo.Marca.Id);
                datos.setearParametros("IdCategoria", productoNuevo.Categoria.Id);
                datos.setearParametros("@Imagen", productoNuevo.Imagen);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
            
        }

        public void modificar(Productos seleccionado) {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Nombre = @Nombre, Descripcion = @Descripcion,Codigo= @CodArt,ImagenUrl= @img, Precio=@Precio,IdMarca=@IdMarca,IdCategoria=@IdCategoria where Id=@Id ");
                datos.setearParametros("@Nombre", seleccionado.Nombre);
                datos.setearParametros("@Descripcion", seleccionado.Descripcion);
                datos.setearParametros("@CodArt", seleccionado.CodArt);
                datos.setearParametros("@img",seleccionado.Imagen);
                datos.setearParametros("@Precio", seleccionado.Precio);
                datos.setearParametros("@IdMarca", seleccionado.Marca.Id);
                
                datos.setearParametros("@IdCategoria", seleccionado.Categoria.Id);
                
                datos.setearParametros("@Id", seleccionado.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            { datos.cerrarConexion(); }
        }
        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();  
            try
            {
                datos.setearConsulta("delete from ARTICULOS Where Id = @Id");
                datos.setearParametros("@Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion();}
        }
    }
   
}
