using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using ConexionDB;

namespace negocio
{
    public class TipoEdicionNegocio
    {
        public List<TipoEdicion> listaTiposEdicion()
        {
            AccesoDatos tabla_tipo_edicion = new AccesoDatos("DISCOS_DB");
            List<TipoEdicion> lista = new List<TipoEdicion>();
            try
            {
                tabla_tipo_edicion.query("SELECT Id, Descripcion FROM TIPOSEDICION");
                tabla_tipo_edicion.ejecutarLectura();
                while (tabla_tipo_edicion.Lector.Read())
                {
                    TipoEdicion nuevo = new TipoEdicion();
                    nuevo.Id = (int)tabla_tipo_edicion.Lector["Id"];
                    nuevo.Descripcion = (string)tabla_tipo_edicion.Lector["Descripcion"];
                    lista.Add(nuevo);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                tabla_tipo_edicion.cerrarConexion();
            }
        }
    }
}
