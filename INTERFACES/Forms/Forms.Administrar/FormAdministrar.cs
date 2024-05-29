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
    public partial class FormAdministrar : Form
    {
        SqlConnection conectar = new SqlConnection("server=localhost; database=Productos; integrated security=true");

        // Llamando a la clase SelecRoles
        public FormAdministrar()
        {
            InitializeComponent();

            // Cargar funciones de la clase.
            cargarRoles();
            actualizarTabla();
        }
        void cargarRoles()
        {
            List<string> roles = new List<string>();

            DataTable dt = new DataTable();
            dt = ConexionBD.Consulta($"select distinct [NombreRol] from roles");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                roles.Add(dt.Rows[i][0].ToString());
            }
            cbxRol.Items.AddRange(roles.ToArray());
        }
        // Metodo para actualizar los datos de la tabla
        public void actualizarTabla()
        {
            string query = "select * from VW_USUARIOS";

            DataTable datos = new DataTable();
            datos = ConexionBD.Consulta(query);
            // Llamando registros al dataGridView1.
            dataGridView1.DataSource = datos;
        }

        // Referencia para el formulario EDIT
        private void btnedit_Click(object sender, EventArgs e)
        {
            Form edit = new FORMEDIT();
            edit.ShowDialog();
        }

        private void FormAdministrar_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtClave.Clear();
        }

        // Validando las entradas de datos, no se permiten campos vacios
        public void ValidarEspacios()
        {
            string user, pass;
            user = txtUser.Text;
            pass = txtClave.Text;

            if (string.IsNullOrEmpty(user))
            {
                error.SetError(panel1, "Ingrese el usuario");
                txtUser.Focus();    
            }
            if (string.IsNullOrEmpty(pass))
            {
                error.SetError(panel2, "Ingrese la contraseña");
                txtClave.Focus();
            }
        }

        //  Agregando registros a SQL
        private void button6_Click(object sender, EventArgs e)
        {
            ValidarEspacios();
            try
            {
                conectar.Open();

                SqlCommand comando = new SqlCommand("STP_RegistrarUsuario", conectar);
                comando.CommandType = CommandType.StoredProcedure;

                //  No se permitiran campos vacios
                if (!string.IsNullOrEmpty(txtUser.Text) && !string.IsNullOrEmpty(txtClave.Text) && cbxRol.SelectedIndex >= 0)
                {
                    comando.Parameters.AddWithValue("@Nombre", txtUser.Text);
                    comando.Parameters.AddWithValue("@clave", txtClave.Text);
                    comando.Parameters.AddWithValue("@rol", cbxRol.Text);

                    int filas = comando.ExecuteNonQuery();
                    if (filas > 0)
                    {
                        MessageBox.Show("Registro agregado exitosamente");
                        actualizarTabla();
                    }
                }
                else
                {
                    MessageBox.Show("Error al agregar el usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exep)
            {
                MessageBox.Show("Error:" + exep.Message, "ERROR");
            }
            conectar.Close();
        }

        // Eliminar registros
        private void btneliminar_Click(object sender, EventArgs e)
        {
            conectar.Open();

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filasSelec = dataGridView1.SelectedRows[0];
                if (filasSelec != null && filasSelec.Cells[0].Value != null)
                {
                    string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    string consulta = "delete from USUARIOS where ID_Usuario=" + id;
                    SqlCommand comando = new SqlCommand(consulta, conectar);
                    comando.Parameters.AddWithValue("@id", id);

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro eliminado exitosamente");
                    actualizarTabla();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila", "¡ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            actualizarTabla();
            conectar.Close();

        }

        // Actualizar el dataGrid luego de realizar modificaciones.
        private void button1_Click(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        // Utilizacion del evento KeyPress para validar con el codigo ASCI los datos de entrada
        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar == 8 || e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 32))
            {
                txtUser.Clear();
                MessageBox.Show("Solo se permiten letras", "¡ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // evento manejado = si.
                e.Handled = true;
                return;
            }
        }
    }
}