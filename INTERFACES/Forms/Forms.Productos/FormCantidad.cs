
using System;
using System.Drawing;
using System.Windows.Forms;

namespace INTERFACES.Forms.Froms.Productos
{
    public partial class FormCantidad : Form
    {
        int id,maxUnidades;
        
        public FormCantidad(int id,int maxUnidades)
        {
            InitializeComponent();
            this.id = id;
            this.maxUnidades = maxUnidades;
        }

        private void FormCantidad_Load(object sender, EventArgs e)
        {
            textBox1.Text = 1.ToString();
            textBox1.Focus();
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Cancela la entrada de caracteres no numéricos
                e.Handled = true;
            }
        }

        void AgregarProducto()
        {
            string numero = textBox1.Text.ToString();
            
            int cantidad = int.Parse(numero);
            //CProducto producto = new CProducto(id,cantidad,nombre,precio);
            //CPedidos.AgregarProductos(nPedido,producto);
            string consulta = $"exec [dbo].[STP_NuevoProductoAPedido] {id},{cantidad}";
            ConexionBD.NoQueryDUI(consulta,"");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int unidades;
            int.TryParse(textBox1.Text,out unidades);
            if (unidades == 0 ) 
            { 
                btnOK.Enabled = false;
                btnOK.BackColor = Color.Gray;
            }
            else if (unidades > maxUnidades)
            {
            error.SetError(btnOK, "No hay suficientes unidades\nUnidades disponibles : "+maxUnidades.ToString());
                btnOK.Enabled = false;
                btnOK.BackColor = Color.Gray;
            }
            else
            {
                error.Clear();
                btnOK.Enabled=true;
            btnOK.BackColor = Color.Lime;
            }
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            AgregarProducto();
            this.Close();
        }

        
    }
}
