using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Policy;
using System.Runtime.CompilerServices;

namespace INTERFACES
{
    internal class ConexionBD
    {
        const string cadenaConcexion = "Data Source=localhost;Initial Catalog=Productos;Integrated Security=True";
        static SqlConnection conn;
        public static DataTable DataInicial()
        {
            DataTable dt = null;
            conn = new SqlConnection(cadenaConcexion);
            try
            {

                conn.Open();
                string consulta = "SELECT [ID],[PRODUCTO],[Descripcion],[UNIDADES],[Precio],[MARCA],[SUB-CATEGORIA] FROM [dbo].[VW_PRODUCTOS];";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conn);
                dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " 1");
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public static DataTable BusquedaPorFiltro(ComboBox cboxFiltro, TextBox txtBusqueda) {
            try
            {
                conn = new SqlConnection(cadenaConcexion);
                conn.Open();
                string filtro = cboxFiltro.SelectedItem.ToString();
                string consulta = "";
                try
                {
                    consulta = $"exec STP_BusquedaDeProducto {filtro}, '{txtBusqueda.Text}'";
                    SqlDataAdapter adapter = new SqlDataAdapter(consulta, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (Exception)
                {
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public bool ValidarUsuario(string usuario, string password)
        {

            try
            {
                conn = new SqlConnection(cadenaConcexion);
                conn.Open();
                string cmd = $"exec STP_ValidarUsuario '{usuario}','{password}'";
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Columns.Count > 2)
                    {
                        return true;
                    }
                }
                catch (Exception)
                {
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

            return false;
        }
        public static DataTable Consulta(string consulta)
        {
            DataTable dt = new DataTable();
            conn = new SqlConnection(cadenaConcexion);
            try
            {

                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conn);
                dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public static void NoQueryDUI(string consulta, string mensaje)
        {
            int estado = 0;
            try
            {
                conn = new SqlConnection(cadenaConcexion);
                conn.Open();
                SqlCommand cmd = new SqlCommand(consulta, conn);
                cmd.ExecuteNonQuery();
                if (!string.IsNullOrEmpty(mensaje)) { MessageBox.Show(mensaje); }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static bool ValidarUser(string user, string password) 
        {
            DataTable dataTable = new DataTable();
            string cmd = $"exec STP_ValidarUsuario '{user}','{password}'";
            dataTable=Consulta(cmd);
            try
            {
                int resultado = int.Parse(dataTable.Rows[0][0].ToString());
                if ((resultado == 1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
            return false;

        }
        public static int GetNumeroDePedido()
        {
            DataTable dt = new DataTable();
            dt = Consulta("select top(1) NumeroDePedido+1 from  PEDIDOS order by NumeroDePedido desc");
            try
            {
                int npedido = int.Parse(dt.Rows[0][0].ToString());
                return npedido;
            }
            catch (Exception)
            {
            }
            return -1;
        }
    }
    
}
