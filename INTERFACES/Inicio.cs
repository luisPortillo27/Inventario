using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTERFACES
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(( e.KeyChar==8 ||e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 32))
            {
                txtuser.Clear();
                MessageBox.Show("Solo se permiten letras", "¡ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void btinicio_Click(object sender, EventArgs e)
        {
            string usuario, password;
            usuario = txtuser.Text;
            password = txtclave.Text;
            ValidarCampos();

            if (ConexionBD.ValidarUser(usuario, password))
            {

                DataTable dataTable = ConexionBD.Consulta($"select Usuario,Rol from VW_USUARIOS where Usuario = '{usuario}'");
                string usr, rol;
                usr = dataTable.Rows[0][0].ToString();
                rol = dataTable.Rows[0][1].ToString();
                MessageBox.Show("Inicio de sesion exitoso");
				this.Visible = false;
				FormPrincipal formPrincipal = new FormPrincipal(usr, rol);
                formPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Inicio de sesion fallido");
            }


        }

        //  Ocultar los digitos del Password.
        private void ocultar_Click(object sender, EventArgs e)
        {
            mostrar.BringToFront();
            txtclave.PasswordChar = '*';
        }

        // Mostrar los digitos del Password.
        private void mostrar_Click(object sender, EventArgs e)
        {
            ocultar.BringToFront();
            txtclave.PasswordChar = '\0';
        }

        //  Realizar limpieza donde se almacenan datos.
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtuser.Clear();
            txtclave.Clear();
        }
        void ValidarCampos()
        {
            string usuario, password;
            usuario = txtuser.Text;
            password = txtclave.Text;

            // Realizar la eliminaion de espacios en Username y Password
            string username = usuario.Replace(" ", "");
            string contra = password.Replace(" ", "");
            //MessageBox.Show("el nombre es: " + username + "\nla contraseña es: " + contra, "Datos ingresados");

            //  Validando que no sean nulos los campos en Username y Password
            if (string.IsNullOrEmpty(usuario))
            {
                error.SetError(txtuser, "Debe ingresar el usuario");
                txtuser.Focus();
            }
            if (string.IsNullOrEmpty(password))
            {
                error.SetError(txtclave, "Debe ingresar la contraseña");
                txtclave.Focus();
            }
        }
	}
}
