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
        }

    }
}
