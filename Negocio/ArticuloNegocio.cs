using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {

            AccesoDatos acceso = new AccesoDatos();
            try
            {
                acceso.setearConsulta("Select A.ID, A.Codigo Codigo, A.Nombre, A.Descripcion, A.Precio, C.Descripcion Categoria, C.Id IdCategoria, M.Id IdMarca, M.Descripcion Marca From ARTICULOS A join CATEGORIAS C on A.IdCategoria = C.Id join MARCAS M on A.IdMarca = M.Id");
                acceso.ejecutarLectura();
                List<Articulo> lista = new List<Articulo>();
                while (acceso.Lector.Read())
                {
                    Articulo aux = new Articulo();


                    aux.ID = (int)acceso.Lector["Id"];
                    aux.Codigo = (string)acceso.Lector["Codigo"];

                    aux.Nombre = (string)acceso.Lector["Nombre"];

                    aux.Descripcion = (string)acceso.Lector["Descripcion"];

                    aux.Precio = (decimal)acceso.Lector["Precio"];

                    //aux.Precio = acceso.Lector.GetSqlMoney(5);



                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)acceso.Lector["Categoria"];
                    aux.Categoria.ID = (int)acceso.Lector["IdCategoria"];

                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)acceso.Lector["Marca"];
                    aux.Marca.ID = (int)acceso.Lector["IdMarca"];

                    lista.Add(aux);
                }

                acceso.cerrarConexion();
                return lista;
            }

            catch (Exception ex)
            {
                throw;
            }

            finally
            {
                acceso.cerrarConexion();
            }
        }
        //fin del método listar(), el cual hace la consulta y devuelve la lista;
    }
}
