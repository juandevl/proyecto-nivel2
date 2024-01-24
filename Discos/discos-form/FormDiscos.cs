using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;
using cargar_disco_form;

namespace discos_form
{
    public partial class frmDiscos : Form
    {
        public frmDiscos()
        {
            InitializeComponent();
        }

        private void frmDiscos_Load(object sender, EventArgs e)
        {
            cargarListaDGV();
            //Modificamos para que la altura sea automatica
            dgvDiscos.Height = (dgvDiscos.RowTemplate.Height * Math.Min(dgvDiscos.RowCount, 10)) + dgvDiscos.ColumnHeadersHeight;
            //dgvDiscos.ScrollBars = (dgvDiscos.RowCount > 5) ? ScrollBars.Vertical : ScrollBars.None;
        }
        private void cargarListaDGV()
        {
            try
            {
                List<Disco> listaDiscos;
                DiscoNegocio negocio = new DiscoNegocio();
                listaDiscos = negocio.DiscosList();
                dgvDiscos.DataSource = listaDiscos;
                dgvDiscos.Columns["FechaLanzamiento"].Visible = false;
                dgvDiscos.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarDisco_Click(object sender, EventArgs e)
        {
            frmCargarDisco cargarDisco = new frmCargarDisco();
            cargarDisco.ShowDialog();
            cargarListaDGV();
        }

        private void btnEliminarDisco_Click(object sender, EventArgs e)
        {
            //int id = (int)dgvDiscos.CurrentRow.Cells["Id"].Value;
            
            Disco disc = (Disco)dgvDiscos.SelectedRows[0].DataBoundItem;
            DialogResult msg = MessageBox.Show($"Deseas eliminar el disco: '{disc.Titulo}'?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (msg == DialogResult.OK)
            {
                DiscoNegocio negocio = new DiscoNegocio();
                negocio.eliminarDisco(disc);
                MessageBox.Show("Se elimino el disco");
                cargarListaDGV();
            }

        }

        private void btnModificarDisco_Click(object sender, EventArgs e)
        {
            //Disco discoSeleccionado = (Disco)dgvDiscos.SelectedRows[0].DataBoundItem;
            Disco discoSeleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            frmCargarDisco modificar = new frmCargarDisco(discoSeleccionado);
            modificar.ShowDialog();

        }
    }
}
