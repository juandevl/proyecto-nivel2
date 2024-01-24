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
        private Disco disco = null;
        public frmCargarDisco()
        {
            InitializeComponent();
        }
        public frmCargarDisco(Disco disco)
        {
            InitializeComponent();
            lblAltaDisco.Text = "Actualizacion de disco";
            this.disco = disco;


        }

        private void frmCargarDisco_Load(object sender, EventArgs e)
        {
            EstiloNegocio estiloNegocio = new EstiloNegocio();
            TipoEdicionNegocio tiposNegocio = new TipoEdicionNegocio();
            cbGenero.DataSource = estiloNegocio.listaEstilos();
            cbGenero.ValueMember = "Id";
            cbGenero.DisplayMember = "Descripcion";
            cbFormato.DataSource = tiposNegocio.listaTiposEdicion();
            cbFormato.ValueMember = "Id";
            cbFormato.DisplayMember = "Descripcion";

            if (!(disco is null))
            {
                tbTitulo.Text = disco.Titulo;
                tbUrlImagenDisco.Text = disco.UrlImagenTapa;
                numCantidadCanciones.Value = disco.CantidadCanciones;
                //cbGenero.SelectedItem = disco.Estilo;
                //cbFormato.SelectedItem = disco.TipoEdicion;
                cbGenero.SelectedValue = disco.Estilo.Id;
                cbFormato.SelectedValue = disco.TipoEdicion.Id;
                dtpFechaLanzamiento.Value = disco.FechaLanzamiento;
                cargarImagen(disco.UrlImagenTapa);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            DiscoNegocio disconegocio = new DiscoNegocio();
            
            try
            {   
                if (disco is null)
                    disco = new Disco();

                disco.Titulo = tbTitulo.Text;
                disco.CantidadCanciones = (int)numCantidadCanciones.Value;
                disco.UrlImagenTapa = tbUrlImagenDisco.Text;
                disco.FechaLanzamiento = dtpFechaLanzamiento.Value;
                disco.Estilo = (Estilo)cbGenero.SelectedItem;
                disco.TipoEdicion = (TipoEdicion)cbFormato.SelectedItem;

                if (disco.Id != 0)
                {
                    disconegocio.modificarDisco(disco);
                    MessageBox.Show("Se modifico exitosamente.", "Success", MessageBoxButtons.OK);
                }
                else
                {
                    disconegocio.insertarDisco(disco);
                    MessageBox.Show("Se cargo exitosamente.", "Success", MessageBoxButtons.OK);
                }

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
            cargarImagen(tbUrlImagenDisco.Text);
        }

        private void cargarImagen(string img)
        {
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
