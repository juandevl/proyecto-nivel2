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
		private List<Disco> discoList;
		private List<Estilo> estiloList;
		private List<TipoEdicion> tipoEdicionList;
		
		public frmDiscos()
		{
			InitializeComponent();
		}

		private void frmDiscos_Load(object sender, EventArgs e)
		{
			cargarListaEstilos();
			cargarListaDiscos();
			cargarListaTipoEdicion();
			cargarListaDGV();
            //Cargamos las opciones del filtrado por genero
            cbFiltrarGenero.DataSource = estiloList;
			//Modificamos para que la altura sea automatica
			//dgvDiscos.Height = (dgvDiscos.RowTemplate.Height * Math.Min(dgvDiscos.RowCount, 10)) + dgvDiscos.ColumnHeadersHeight;
			//dgvDiscos.ScrollBars = (dgvDiscos.RowCount > 5) ? ScrollBars.Vertical : ScrollBars.None;
		}
		private void defaultColumns()
		{
            dgvDiscos.Columns["FechaLanzamiento"].Visible = false;
            dgvDiscos.Columns["Id"].Visible = false;
            dgvDiscos.Columns["Activo"].Visible = false;
        }
		//Funcion para cargar la lista de estilos en el formulario
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
				this.estiloList = estilos;
				//cbFiltrarGenero.DataSource = estilos;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		//Funcion para cargar la lista de discos de la base de datos
		private void cargarListaDiscos()
		{
			try
			{
				DiscoNegocio discoNegocio = new DiscoNegocio();
				//cargamos el listado de discos de la base de datos
				this.discoList = discoNegocio.DiscosList();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		//Funcion para cargar la lista de tipo de edicion de la base de datos
		private void cargarListaTipoEdicion()
		{
			try
			{
				TipoEdicionNegocio tipoNegocio = new TipoEdicionNegocio();
				this.tipoEdicionList = tipoNegocio.listaTiposEdicion();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		//Funcion de carga de DataGridView con opcion de filtrado por genero
		private void cargarListaDGV(Estilo genero = null)
		{
			try
			{
                //DiscoNegocio neg = new DiscoNegocio();
				//Si el genero no es null, entonces se busca filtrar la lista que se muestra
                if (genero != null)
				{
					List<Disco> discos;
					//discos = neg.filtrarDiscoGenero(genero);
					discos = this.discoList.FindAll(disco => disco.Estilo.Descripcion == genero.Descripcion && disco.Activo == true);
					//Si la lista discos tiene algun elemento, lo muestra
					//sino, oculta la tabla y da un mensaje de aviso.
                    if (discos.Count > 0)
                    {
						dgvDiscos.DataSource = null;
                        dgvDiscos.DataSource = discos;
						defaultColumns();
                        dgvDiscos.Visible = true;
                    }
                    else
                    {
                        dgvDiscos.Visible = false;
                        MessageBox.Show("No se encontraron discos.\nPor favor, seleccione otro género.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
				}
				else
				{
					dgvDiscos.DataSource = null;
					dgvDiscos.DataSource = this.discoList.FindAll(disco => disco.Activo == true);
					defaultColumns();
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
			//
			DiscoNegocio negocio = new DiscoNegocio();
			this.discoList = negocio.DiscosList();
			cargarListaDGV();
		}

		private void btnEliminarDisco_Click(object sender, EventArgs e)
		{
			Disco disco = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
			DialogResult msg = MessageBox.Show($"Desea eliminar el disco: '{disco.Titulo}'?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (msg == DialogResult.Yes)
			{
				DiscoNegocio negocio = new DiscoNegocio();
				//**********
				//Descomentar si se desea eliminar el disco de la base de datos
				//negocio.eliminarDisco(disc);
				//**********

				//Deshabilitamos el disco de la base de datos
				//negocio.deshabilitarDisco(disco);
				//Deshabilitamos el disco de la lista de la aplicacion
				this.discoList.Find(disc => disc.Id == disco.Id).Activo = false;
				MessageBox.Show("Se eliminó el disco");
				cargarListaDGV();
			}

		}

		private void btnModificarDisco_Click(object sender, EventArgs e)
		{
			//Disco discoSeleccionado = (Disco)dgvDiscos.SelectedRows[0].DataBoundItem;
			Disco discoSeleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
			frmCargarDisco modificar = new frmCargarDisco(discoSeleccionado);
			modificar.ShowDialog();
			
				//DiscoNegocio negocio = new DiscoNegocio();
				//this.discoList = negocio.DiscosList();
				//cargarListaDGV();
			
			
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

        private void btnRecuperarDiscos_Click(object sender, EventArgs e)
        {
			DiscoNegocio negocio = new DiscoNegocio();
			DialogResult result = MessageBox.Show("Desea recuperar los discos eliminados?", "Recuperar discos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			//Recuperamos los discos deshabilitados
			if(result == DialogResult.Yes)
			{
				//Descomentar para manejar la informacion de la base de datos
				//recuperamos los discos de la base de datos
				//negocio.recuperarDiscos();

				//restauramos los discos de la lista original de la aplicacion
				this.discoList.FindAll(disco => !disco.Activo).ForEach(disco => disco.Activo = true);

				MessageBox.Show("Se recuperaron los discos eliminados", "Éxito");
				//Volvemos a cargar la lista del dataGridView
				cargarListaDGV();
			}
        }
    }
}
