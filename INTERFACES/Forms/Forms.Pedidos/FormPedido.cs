
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTERFACES.Forms
{
    public partial class FormPedido : Form
    {
        int Udisponbles;
        public FormPedido()
        {
            InitializeComponent();
        }

        private void FormPedido_Load(object sender, EventArgs e)
        {
            RefreshDatos();   
            lblPedido.Text = lblPedido.Text+ConexionBD.GetNumeroDePedido();
            
        }
        void RefreshDatos()
        {
            DataTable dataTable = new DataTable();
            dataTable = ConexionBD.Consulta("SELECT * FROM VW_PEDIDOACTUAL");
            dataGrid.DataSource = dataTable;
			dataGrid.Columns[0].Width = 80;
			dataGrid.Columns[1].Width = 90;
			dataGrid.Columns[2].Width = (int)(dataGrid.Width * 0.35);
            lblProducto.Text="-";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
				int id;
				int.TryParse(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[1].Value.ToString(), out id);
				Udisponbles = UnidadesDisponibles(id);
				setPedido();
			}
            catch (NullReferenceException)
            {}
        }

        void setPedido()
        {
            try
            {
				lblProducto.Text = dataGrid.Rows[dataGrid.CurrentRow.Index]
                                        .Cells[2].Value
                                        .ToString();
                txtCantidad.Text = dataGrid.Rows[dataGrid.CurrentRow.Index]
										.Cells[3].Value
										.ToString(); ;
            }
            catch (Exception)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGrid.Rows.Count != 0)
            {
				ConexionBD.NoQueryDUI("exec [dbo].[STP_CancelarPedido]", "PEDIDO CANCELADO");
			}
            RefreshDatos() ;
        }
        void Vender()
        {
            int count = 0;
            int len; int.TryParse(dataGrid.RowCount.ToString(),out len);
            Console.WriteLine(len);
            if(len > 0)
            {
                int id, cantidad, vendedor, npedido;
                for (int i = 0; i < len; i++)
                {
                    int.TryParse(dataGrid.Rows[i].Cells[1].Value.ToString(), out id);
                    int.TryParse(dataGrid.Rows[i].Cells[3].Value.ToString(), out cantidad);
                    vendedor = 1000;
                    int.TryParse(dataGrid.Rows[i].Cells[0].Value.ToString(), out npedido);
                    ConexionBD.NoQueryDUI($"exec STP_RegistrarPedido {id},{cantidad},{vendedor},{npedido}","");
                }
                int.TryParse(dataGrid.Rows[0].Cells[0].Value.ToString(), out npedido);
                ConexionBD.NoQueryDUI($"exec [dbo].[STP_RegistrarVenta] {npedido}", "Venta Registrada");
                ConexionBD.NoQueryDUI("truncate table [dbo].[PEDIDOACTUAL]", "");
               
            }

        }   

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Vender();
            RefreshDatos();
        }

		private void BtnAceptarCambio_Click(object sender, EventArgs e)
		{
            int id, cantidad;
            int.TryParse(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[1].Value.ToString(), out id);
			int.TryParse(txtCantidad.Text, out cantidad);
            string consulta = $"exec STP_CambiarCantidadPedido {id}, {cantidad}";
			ConexionBD.NoQueryDUI(consulta,"");
            RefreshDatos();
		}

		private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
		{
            if (char.IsLetter(e.KeyChar)&& !char.IsDigit(e.KeyChar))
            {
				e.Handled = true;
                
            }
		}

		private void txtCantidad_TextChanged(object sender, EventArgs e)
		{
            int cantidad;
			int.TryParse(txtCantidad.Text,out cantidad);
            try
            {
				if (cantidad > Udisponbles)
				{
					BtnAceptarCambio.Enabled = false;
                    errorProvider1.SetError(BtnAceptarCambio,$"No hay suficientes unidades disponibles\r\nUnidadesDisponibles [{Udisponbles}]");
				}
				else
				{
					BtnAceptarCambio.Enabled = true;
                    errorProvider1.Clear();
				}
			}
            catch (Exception)
            {
            }
		}
        int UnidadesDisponibles(int id)
        {
            string consulta = $"select UnidadesDisponibles from Productos where ID_Producto = {id}";
            DataTable dt = ConexionBD.Consulta(consulta);

            try
            {
                int.TryParse(dt.Rows[0][0].ToString(), out id);
                return id;
            }catch (Exception) { }
            return default(int);
        }
	}
}
