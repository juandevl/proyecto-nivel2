using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace cargar_disco_form
{
    public partial class frmCargarDisco : Form
    {
        public frmCargarDisco()
        {
            InitializeComponent();
        }

        private void frmCargarDisco_Load(object sender, EventArgs e)
        {
            EstiloNegocio estiloNegocio = new EstiloNegocio();
            TipoEdicionNegocio tiposNegocio = new TipoEdicionNegocio();
            List<Estilo> estilos = estiloNegocio.listaEstilos();
            List<TipoEdicion> tipos = tiposNegocio.listaTiposEdicion();
            foreach(Estilo estilo in estilos)
            {
                cbGenero.Items.Add(estilo.Descripcion);
            }
            foreach(TipoEdicion tipo in tipos)
            {
                cbFormato.Items.Add(tipo.Descripcion);
            }

            cbGenero.SelectedIndex = 0;
            cbFormato.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Disco disco = new Disco();
            DiscoNegocio disconegocio = new DiscoNegocio();
            try
            {
                disco.Titulo = tbTitulo.Text;
                disco.CantidadCanciones = (int)numCantidadCanciones.Value;
                disco.UrlImagenTapa = tbUrlImagenDisco.Text;
                disco.FechaLanzamiento = dtpFechaLanzamiento.Value;
                disco.Estilo.Descripcion = cbGenero.Text;
                disco.TipoEdicion.Descripcion = cbFormato.Text;

                disconegocio.insertarDisco(disco);
                MessageBox.Show("Se inserto el nuevo disco.", "Success", MessageBoxButtons.OK);
                //MessageBox.Show($"{disco.Titulo}\r\n{disco.CantidadCanciones}\r\n{disco.UrlImagenTapa}\r\n{disco.FechaLanzamiento.ToShortDateString()}\r\n{disco.Estilo.Descripcion}\r\n{disco.TipoEdicion.Descripcion}");
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show(ex.ToString());
            }

        }

        private void tbUrlImagenDisco_Leave(object sender, EventArgs e)
        {
            string img = tbUrlImagenDisco.Text;
            try
            {
                pbPrevImagen.Load(img);

            }
            catch (Exception)
            {
                pbPrevImagen.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }
    }
}
