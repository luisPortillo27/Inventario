using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTERFACES
{
    public partial class FORMEDIT : Form
    {
        SqlConnection conectar = new SqlConnection("server=localhost; database=Productos; integrated security=true");

        public FORMEDIT()
        {
            InitializeComponent();
            //idUs.codigoUsuario(cbxId);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void FORMEDIT_Load(object sender, EventArgs e)
        {
            string query = "select * from VW_USUARIOS";
            DataTable datos = ConexionBD.Consulta(query);
			datos = ConexionBD.Consulta(query);
            dataGridView1.DataSource = datos;
			string query2 = "select * from VW_USUARIOS";
            DataTable data2 = ConexionBD.Consulta(query2); ;
            for (int i = 0; i < data2.Rows.Count; i++)
            {
                cbxId.Items.Add(data2.Rows[i][0]);
			}
            
            cbxId.SelectedIndex = 0;
        }

        // Validando que no se acepten campos vacios
        public void ValidarEspacios()
        {
            string user, pass, id;
            user=txtUsuario.Text;
            pass=txtPassword.Text;
            id=cbxId.Text;

            if (string.IsNullOrEmpty(user))
            {
                error.SetError(txtUsuario, "Ingrese el nuevo usuario");
                txtUsuario.Focus();
            }
            if (string.IsNullOrEmpty(pass))
            {
                error.SetError(txtPassword, "Ingrese la nueva contraseña");
                txtPassword.Focus();
            }
            if (string.IsNullOrEmpty(id))
            {
                error.SetError(cbxId, "Seleccione el ID");
                cbxId.Focus();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtPassword.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Invocando el metodo para validar los campos nulos
            ValidarEspacios();

            try
            {
                    ConexionBD.NoQueryDUI($"exec STP_UpdateUsuario {cbxId.Text},'{txtUsuario.Text}','{txtPassword.Text}'","");
            }
            catch (Exception excp)
            {

                MessageBox.Show("Error"+ excp.Message);
            }
            conectar.Close();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            string query = "select * from VW_USUARIOS";
            DataTable datos = new DataTable();
            datos = ConexionBD.Consulta(query);

            dataGridView1.DataSource = datos;
        }

        // Evento KeyPress para que el campo usuario acepte solo letras
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar == 8 || e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 32))
            {
                txtUsuario.Clear();
                MessageBox.Show("Solo se permiten letras", "¡ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtUsuario.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                int id;  int.TryParse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString(),out id);
				cbxId.SelectedItem = id;
			}
            catch (NullReferenceException)
            {
            }
        }
	}
}