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
            List<Disco> listaDiscos;
            DiscoNegocio negocio = new DiscoNegocio();
            listaDiscos = negocio.DiscosList();
            dgvDiscos.DataSource = listaDiscos;
            dgvDiscos.Columns["FechaLanzamiento"].Visible = false;

            //Modificamos para que la altura sea automatica
            //int maxRow = 10;
            dgvDiscos.Height = (dgvDiscos.RowTemplate.Height * Math.Min(dgvDiscos.RowCount, 10)) + dgvDiscos.ColumnHeadersHeight;
            dgvDiscos.ScrollBars = (dgvDiscos.RowCount > 10) ? ScrollBars.Vertical : ScrollBars.None;
        }

        private void btnAgregarDisco_Click(object sender, EventArgs e)
        {
            frmCargarDisco cargarDisco = new frmCargarDisco();
            cargarDisco.ShowDialog();
        }
    }
}
