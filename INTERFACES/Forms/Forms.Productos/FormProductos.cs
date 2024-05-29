using INTERFACES.Forms.Froms.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTERFACES.Forms
{

    public partial class FormProductos : Form
    {

        public FormProductos()
        {
            InitializeComponent();
        }
        
        private void FormProductos_Load(object sender, EventArgs e)
        {
            dataGrid.DataSource = ConexionBD.DataInicial();
            cboxFiltro.SelectedIndex = 0;
            RedimensionarDataGrid();
            string nivelDeAcceso = FormPrincipal.id;
            if (!nivelDeAcceso.Equals("Administrador"))
            {
                btnBasura.Enabled = false;
                btnBasura.Visible = false;
            }
        }
        void RedimensionarDataGrid()
        {
            try
            {
				dataGrid.Columns[0].Width = 40;
				dataGrid.Columns[1].Width = (int)Math.Round(dataGrid.Width * 0.35);
				dataGrid.Columns[3].Width = 80;
				dataGrid.Columns[4].Width = 80;
			}
            catch (ArgumentOutOfRangeException){}
            catch (Exception) { }
            
		}
        void CambiarColor(object sender, Color color)
        {
            Button bt = sender as Button;
            bt.BackColor = color;
        }

        

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            dataGrid.DataSource = ConexionBD.BusquedaPorFiltro(cboxFiltro,txtBusqueda);
            RedimensionarDataGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (GetID() >= 0)
            {
                FormAddUpd formAdd = new FormAddUpd("Editar Producto", GetID(),false);
                formAdd.ShowDialog();
            }
            RefresDatos();
        }

        private void btnBasura_MouseEnter(object sender, EventArgs e)
        {
            CambiarColor(sender, Color.Red);
        }

        private void btnNuevoP_MouseEnter(object sender, EventArgs e)
        {
            CambiarColor(sender, Color.Yellow);
        }

        private void btnEditar_MouseEnter(object sender, EventArgs e)
        {
            CambiarColor(sender, Color.MediumVioletRed);
        }
        void ButtonLeave(object sender, EventArgs e)
        {
            CambiarColor(sender as Button, Color.Transparent);
        }

        private void btnBasura_Click(object sender, EventArgs e)
        {
            string mensaje= "¡Estas seguro de querer eliminar este producto?\nEste se eliminara de forma permante.";
            FormMensaje formMensaje = new FormMensaje(mensaje,"Advertencia",GetID());
            formMensaje.ShowDialog();
            RefresDatos();
        }
        int GetID()
        {
            int id;

            try
            {
                id = int.Parse(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[0].Value.ToString());
                Console.WriteLine(id);
                return id;
            }
            catch (Exception)
            {
            }
            return -1;
        }

        void RefresDatos()
        {
            dataGrid.DataSource = ConexionBD.DataInicial();
        }

        private void btnNuevoP_Click(object sender, EventArgs e)
        {
            int maxUnidades;
            maxUnidades = int.Parse(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[3].Value.ToString());
            FormCantidad formCantidad = new FormCantidad(GetID(),maxUnidades);
            formCantidad.ShowDialog();
            RefresDatos();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            CambiarColor(sender,Color.Lime);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            CambiarColor(sender, Color.Transparent);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddUpd formAddUpd = new FormAddUpd("Agregar Producto",-1,true);
            formAddUpd.ShowDialog();
            RefresDatos();
        }

		private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
		{
            string filtro = cboxFiltro.Text;
            if(filtro.Equals("ID") && !char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
		}
	}
}

