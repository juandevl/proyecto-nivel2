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
			cargarListaEstilos();
			//Modificamos para que la altura sea automatica
			dgvDiscos.Height = (dgvDiscos.RowTemplate.Height * Math.Min(dgvDiscos.RowCount, 10)) + dgvDiscos.ColumnHeadersHeight;
			//dgvDiscos.ScrollBars = (dgvDiscos.RowCount > 5) ? ScrollBars.Vertical : ScrollBars.None;
		}
		private void cargarListaEstilos()
		{
			try
			{
				List<Estilo> estilos;
				Estilo todos = new Estilo();
				todos.Id = 0;
				todos.Descripcion = "Todos";
				EstiloNegocio neg = new EstiloNegocio();
				estilos = neg.listaEstilos();
				estilos.Add(todos);
				cbFiltrarGenero.DataSource = estilos;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		private void cargarListaDGV(Estilo genero = null)
		{
			try
			{
                List<Disco> discos;
                DiscoNegocio neg = new DiscoNegocio();
                if (genero != null)
				{
                    discos = neg.filtrarDiscoGenero(genero);
                    if (discos.Count > 0)
                    {
                        dgvDiscos.DataSource = discos;
                        dgvDiscos.Columns["FechaLanzamiento"].Visible = false;
                        dgvDiscos.Columns["Id"].Visible = false;
                        dgvDiscos.Visible = true;
                    }
                    else
                    {
                        dgvDiscos.Visible = false;
                        MessageBox.Show("No se encontraron discos.\nPor favor, seleccione otro genero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
				}
				else
				{
					discos = neg.DiscosList();
					dgvDiscos.DataSource = discos;
					dgvDiscos.Columns["FechaLanzamiento"].Visible = false;
					dgvDiscos.Columns["Id"].Visible = false;
					dgvDiscos.Visible = true;
                }
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
			
			Disco disc = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
			DialogResult msg = MessageBox.Show($"Deseas eliminar el disco: '{disc.Titulo}'?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (msg == DialogResult.Yes)
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

		private void cbFiltrarGenero_DropDownClosed(object sender, EventArgs e)
		{
			Estilo genero = (Estilo)cbFiltrarGenero.SelectedItem;
			//Si el filtro selecciona "Todos" muestra la lista completa
			if ((genero.Descripcion == "Todos") || (genero.Id == 0) && genero != null)
			{
				cargarListaDGV();
				return;
			}
			//Si se selecciona cualquier otro item de la lista
			cargarListaDGV(genero);

		}
	}
}
