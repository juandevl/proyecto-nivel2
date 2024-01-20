using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Disco
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string UrlImagenTapa { get; set; }
        public int CantidadCanciones { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public Estilo Estilo { get; set; }
        public TipoEdicion TipoEdicion { get; set; }
        public Disco() 
        {
            this.Estilo = new Estilo();
            this.TipoEdicion = new TipoEdicion();
            this.FechaLanzamiento = new DateTime();
        }

    }
}
