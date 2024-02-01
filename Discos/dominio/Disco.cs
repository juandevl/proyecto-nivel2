using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Disco
    {
        public int Id { get; set; }
        [DisplayName("Título")]
        public string Titulo { get; set; }
        [DisplayName("Imagen Tapa")]
        public string UrlImagenTapa { get; set; }
        [DisplayName("Cantidad de Canciones")]
        public int CantidadCanciones { get; set; }
        [DisplayName("Fecha lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }
        public Estilo Estilo { get; set; }
        [DisplayName("Formato")]
        public TipoEdicion TipoEdicion { get; set; }
        public bool Activo { get; set; }

        public Disco() 
        {
            this.Estilo = new Estilo();
            this.TipoEdicion = new TipoEdicion();
            this.FechaLanzamiento = new DateTime();
        }

    }
}
