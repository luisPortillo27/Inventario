using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTERFACES.Forms
{
    public partial class FormAddUpd : Form
    {
        string title;
        int ID;
        bool add;
        public FormAddUpd(string title, int ID, bool Add)
        {
            InitializeComponent(); 
            this.title = title;
            this.ID = ID;
            this.add = Add;
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            if (!add) 
            {
                FormParaUpdate();
            }
            else
            {
                this.Text = title;
                lblTitulo.Text = "AGREGANDO UN NUEVO PRODUCTO";
                btnOK.Text = "ACEPTAR";
                btnOK.BackColor = Color.Lime;
                btnCancelar.BackColor = Color.Tomato;
                cargarMarcasyCategorias();
            }

        }
        void SetDefaultData()
        {
            DataTable dt = new DataTable();
            dt = ConexionBD.Consulta($"SELECT * FROM VW_PRODUCTOS WHERE ID = {this.ID}");
            txtNombre.Text = dt.Rows[0][1].ToString();
            txtDescripcion.Text = dt.Rows[0][2].ToString();
            numericUnidades.Value = int.Parse(dt.Rows[0][3].ToString());
            numericPrecio.Value = decimal.Parse(dt.Rows[0][4].ToString());
            cboxMarca.SelectedItem = (dt.Rows[0][5].ToString());
            cboxCategoria.SelectedItem = (dt.Rows[0][6].ToString());
        }

        void udpate()
        {
            string consulta = $"exec STP_UpdateProducto {this.ID},'{txtNombre.Text}','{txtDescripcion.Text}',{numericUnidades.Value},{numericPrecio.Value},'{cboxMarca.SelectedItem.ToString()}','{cboxCategoria.SelectedItem.ToString()}'";

            ConexionBD.NoQueryDUI(consulta, "Se actualizó correctamente");
            this.Close();
        }
        void insert()
        {
            if(txtNombre.Text.Equals(string.Empty)||numericUnidades.Value<=0||numericPrecio.Value<=0) 
            {
                errorP.SetError(btnOK, "Los campos NOMBRE, UNIDADES DISPONIBLES Y PRECIO son necesarios");
                
            }else
            {
                string consulta = $"exec STP_AgregarProducto '{txtNombre.Text}','{txtDescripcion.Text}',{numericUnidades.Value},{numericPrecio.Value},'{cboxMarca.SelectedItem.ToString()}','{cboxCategoria.SelectedItem.ToString()}'";

                ConexionBD.NoQueryDUI(consulta, "Se agrego el porducto correctamente");
                this.Close();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (add)
            {
                insert();

            }else
            {
                udpate();
            }
        }

        private void FormParaUpdate()
        {
            cargarMarcasyCategorias();
            this.Text = this.title;
            lblTitulo.Text = $"EDITANDO EL PRODUCTO {this.ID}";
            SetDefaultData();
            this.Focus();
        }
        void cargarMarcasyCategorias()
        {
            List<string> listmarca = new List<string>();
            List<string> listcategoria = new List<string>();
            DataTable dt = new DataTable();
            dt = ConexionBD.Consulta($"select distinct nombre from marcas");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listmarca.Add(dt.Rows[i][0].ToString());
            }

            DataTable dt2 = new DataTable();
            dt = ConexionBD.Consulta($"select distinct nombre from subcategorias");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listcategoria.Add(dt.Rows[i][0].ToString());
            }
            cboxMarca.Items.AddRange(listmarca.ToArray());
            cboxCategoria.Items.AddRange(listcategoria.ToArray());
        }

        private void numericUnidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Cancela la entrada de caracteres no numéricos
                e.Handled = true;
            }
        }

        private void numericPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                // Cancela la entrada de caracteres no numéricos
                e.Handled = true;
            }
        }
    }
}
