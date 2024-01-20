using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using ConexionDB;

namespace negocio
{
    public class DiscoNegocio
    {
        public List<Disco> DiscosList()
        {
            List<Disco> discos = new List<Disco>();
            AccesoDatos tabla_discos = new AccesoDatos("DISCOS_DB");
            try
            {
                tabla_discos.query("SELECT D.Id, Titulo, CantidadCanciones, UrlImagenTapa, E.Descripcion Genero, T.Descripcion Formato FROM DISCOS D JOIN ESTILOS E ON D.IdEstilo = E.Id JOIN TIPOSEDICION T ON D.IdTipoEdicion = T.Id");
                tabla_discos.ejecutarLectura();

                while (tabla_discos.Lector.Read())
                {
                    Disco aux = new Disco();
                    //aux.Id = (int)tabla_discos.Lector["Id"];
                    aux.Id = tabla_discos.Lector.GetInt32(0);
                    aux.Titulo = (string)tabla_discos.Lector["Titulo"];
                    aux.UrlImagenTapa = (string)tabla_discos.Lector["UrlImagenTapa"];
                    aux.CantidadCanciones = (int)tabla_discos.Lector["CantidadCanciones"];
                    aux.Estilo.Descripcion = (string)tabla_discos.Lector["Genero"];
                    aux.TipoEdicion.Descripcion = (string)tabla_discos.Lector["Formato"];

                    discos.Add(aux);
                }

                return discos;

            }
            catch (Exception ex) 
            {
                throw ex;
            }
            finally
            {
                tabla_discos.cerrarConexion();
            }
        }

        public void insertarDisco(Disco disco)
        {
            AccesoDatos tabla_disco = new AccesoDatos("DISCOS_DB");
            string fecha = disco.FechaLanzamiento.ToString("yyyy-MM-dd HH:mm:ss");


            //############      REVISAR ESTE CODIGO ###############

            //string query = $"INSERT INTO DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, IdTipoEdicion) VALUES ('{disco.Titulo}','{fecha}',{disco.CantidadCanciones},'{disco.UrlImagenTapa}',(SELECT Id FROM ESTILOS WHERE Descripcion = '{disco.Estilo.Descripcion}'),(SELECT Id FROM TIPOSEDICION WHERE Descripcion = '{disco.TipoEdicion.Descripcion}')"; 
            string query = $"INSERT INTO DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, IdTipoEdicion) VALUES ('{disco.Titulo}','{fecha}',{disco.CantidadCanciones},'{disco.UrlImagenTapa}',3,2)";


            try
            {
                tabla_disco.query(query);
                tabla_disco.insertarConsulta();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                tabla_disco.cerrarConexion();
            }
            
        }
    }
}
