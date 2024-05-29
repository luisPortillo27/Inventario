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
    public partial class FormMensaje : Form
    {
        string Mensaje;
        string Titulo;
        int id;
        public FormMensaje(string mensaje, string titulo,int id)
        {
            InitializeComponent();
            Mensaje = mensaje;
            Titulo = titulo;
            this.id = id;
        }

        private void FormMensaje_Load(object sender, EventArgs e)
        {
            //Console.Beep();
            lblAdvertencia.Text = Mensaje;
            this.Text = Titulo;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ConexionBD.NoQueryDUI($"UPDATE PRODUCTOS SET ACTIVO = 0 WHERE ID_Producto={this.id}","Se elimino correctamente.");
            this.Close();
        }
    }
}
