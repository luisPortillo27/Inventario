using INTERFACES.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTERFACES
{
    public partial class FormPrincipal : Form
    {
        public static string usuario, id;

        Form formActivo;
        public FormPrincipal(string usuario,string id)
        {
            InitializeComponent();
            SetUser(usuario,id);
        }
        static void SetUser(string _usuario, string _id)
        {
            usuario = _usuario;
            id = _id;
        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Control de Inventarios";
            if (!id.Equals("Administrador"))
            {
                btnAdministrar.Enabled = false;
                btnAdministrar.Visible = false;
            }
            lblSeccion.Text= TextoVertical( "PRODUCTOS");
            statusUser.Text = usuario;
            statusId.Text = id.ToString();
        }

        void CambiarColor(object sender,Color color, Color forecolor)
        {
            Button bt = sender as Button;
            bt.BackColor = color;
            bt.ForeColor = forecolor;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            CambiarColor(sender,Color.DodgerBlue,Color.White);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            CambiarColor(sender, Color.Transparent, Color.Black);
        }

        string TextoVertical(string texto)
        {
            string devuleto="";
            foreach (char s in texto)
            {
                devuleto+=s+"\n";
            }
            return devuleto;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormProductos(), sender);
        }

        void AbrirForm(Form form, object sender)
        {
            if (formActivo != null) { formActivo.Close(); }
            formActivo = form;
            formActivo.TopLevel = false;
            pnlFormHijo.Controls.Add(formActivo);
            formActivo.Dock = DockStyle.Fill;
            formActivo.BringToFront();
            formActivo.Show();
            Button button = sender as Button;
            lblSeccion.Text = TextoVertical(button.Text);
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormPedido(), sender);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormVentas(), sender);
        }

		private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
		{
            Application.Exit();
		}

		private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
		{
            this.Dispose();
		}

		private void button1_Click(object sender, EventArgs e)
		{
            try
            {
                Dispose();
                Application.Restart();
            }catch (Exception ex) { }
		}

		private void btnAdministrar_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormAdministrar(), sender);
        }
    }
}
