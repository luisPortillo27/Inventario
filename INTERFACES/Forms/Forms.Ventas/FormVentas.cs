using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Xml.Linq;

namespace INTERFACES.Forms
{
	public partial class FormVentas : Form
	{
		const string server = "localhost";
		const string database = "Productos";

		SqlConnection cadenaConcexion = new SqlConnection("server=" + server + "; database=" + database + "; integrated security=True");
		bool PuedeConfirmar = false;
		bool PuedeImprimir = false;
		bool DineroSuficiente = false;

		public FormVentas()
		{
			InitializeComponent();
			TxtBox0.ReadOnly = true;
		}

		private void FormVentas_Load(object sender, EventArgs e)
		{
			cadenaConcexion.Open();

			string consulta = "select IDVenta from dbo.VENTAS";
			SqlCommand comando = new SqlCommand(consulta, cadenaConcexion);
			SqlDataReader lector = comando.ExecuteReader();

			while (lector.Read())
			{
				if (!CMBPedidos.Items.Contains(lector["IDVenta"]))
				{
					CMBPedidos.Items.Add(lector["IDVenta"]);
				}
			}
			DataTable dataTable = new DataTable();
			dataTable = ConexionBD.Consulta("select * from dbo.VENTAS");
			DGLista.DataSource = dataTable;
			cadenaConcexion.Close();
			DGFact.Size = new Size(Width = DGFact.Width, Height = (int)((int)panel1.Height * 0.5));
			DGLista.Size = new Size(Width = DGFact.Width, Height = (int)((int)panel1.Height * 0.5));
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			PuedeImprimir = false;
			TxtBox0.ReadOnly = false;
			TxtBox0.Text = "";
			DGFact.DataSource = null;
			DGFact.Rows.Clear();

			cadenaConcexion.Open();
			string consulta = "select *from dbo.VENTAS where IDVenta= '" + CMBPedidos.SelectedItem.ToString() + "'";
			SqlCommand comando = new SqlCommand(consulta, cadenaConcexion);

			SqlDataAdapter adapter = new SqlDataAdapter(comando);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);

			DGLista.DataSource = dataTable;
			cadenaConcexion.Close();

			cadenaConcexion.Open();
			consulta = "select *from dbo.VENTAS where IDVenta= '" + CMBPedidos.SelectedItem.ToString() + "'";
			comando = new SqlCommand(consulta, cadenaConcexion);
			SqlDataReader lector = comando.ExecuteReader();

			if (lector.HasRows)
			{
				while (lector.Read())
				{
					TxtVenta.ForeColor = Color.Green;
					TxtVenta.Text = lector["IDVenta"].ToString();
					TxtTotal.ForeColor = Color.Green;

					decimal tdv = (decimal)lector["TotalDeVenta"];
					TxtTotal.Text = tdv.ToString("0.00");

					TxtFecha.ForeColor = Color.Green;
					TxtFecha.Text = lector["FechaVenta"].ToString();

					LblEstado.ForeColor = Color.Green;
					LblEstado.Text = lector["n_Pedido"].ToString();

					PuedeConfirmar = true;
				}
			}
			else
			{
				try
				{
					decimal suma = 0;

					foreach (DataGridViewRow fila in DGLista.Rows)
					{
						if (!fila.IsNewRow && fila.Cells[4].Value != null && fila.Cells[4].Value != DBNull.Value)
						{
							suma += Convert.ToDecimal(fila.Cells[4].Value);
						}

					}
					TxtVenta.ForeColor = Color.DarkGray;
					TxtVenta.Text = "Pendiente";

					TxtTotal.ForeColor = Color.DarkGray;
					TxtTotal.Text = suma.ToString();

					TxtFecha.ForeColor = Color.DarkGray;
					TxtFecha.Text = DateTime.Now.ToString();

					LblEstado.ForeColor = Color.Orange;
					LblEstado.Text = "PENDIENTE";

					PuedeConfirmar = false;
				}
				catch
				{
					TxtVenta.ForeColor = Color.Orange;
					TxtVenta.Text = "No asignado";
					TxtTotal.ForeColor = Color.Orange;
					TxtTotal.Text = "No asignado";
					TxtFecha.ForeColor = Color.Orange;
					TxtFecha.Text = "No asignado";

					LblEstado.ForeColor = Color.Orange;
					LblEstado.Text = "PENDIENTE";

					PuedeConfirmar = false;
				}
			}
			cadenaConcexion.Close();
		}

		private void DGLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void BtnConfirm_Click(object sender, EventArgs e)
		{
			if (PuedeConfirmar && !string.IsNullOrEmpty(TxtBox0.Text) && DineroSuficiente)
			{
				cadenaConcexion.Open();
				string consulta = "select * from VW_DETALLESDEVENTA where IDVenta= '" + CMBPedidos.SelectedItem.ToString() + "'";
				SqlCommand comando = new SqlCommand(consulta, cadenaConcexion);

				SqlDataAdapter adapter = new SqlDataAdapter(comando);
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);

				DGFact.DataSource = dataTable;
				cadenaConcexion.Close();
				PuedeImprimir = true;
				TxtBox0.ReadOnly = true;
				DGFact.Columns[0].Width = 80;
				DGFact.Columns[1].Width = 80;
				DGFact.Columns[2].Width = (int)(DGFact.Width * 0.40);
			}
			else
			{
				MessageBox.Show("Los Datos no han sido rellenados correctamente.");
			}
		}

		private void Imprimir(object sender, PrintPageEventArgs e)
		{
			System.Drawing.Font font = new System.Drawing.Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
			int width = 410;//410
			int height = 20;//820
			int x = 80;
			int y = 20;
			int contador = 0;
			int dgx = 120;
			int contadory = 0;
			string Titulos = "";

			e.Graphics.DrawString("########################################", font, Brushes.Black, new RectangleF(x, y, width, height));
			e.Graphics.DrawString("Numero de Pedido #" + LblEstado.Text, font, Brushes.Black, new RectangleF(x + 110, y + 20, width, height));
			e.Graphics.DrawString("########################################", font, Brushes.Black, new RectangleF(x, y + 40, width, height));
			e.Graphics.DrawString("ID de Venta: " + TxtVenta.Text, font, Brushes.Black, new RectangleF(x + 130, y + 60, width, height));
			e.Graphics.DrawString("########################################", font, Brushes.Black, new RectangleF(x, y + 80, width, height));
			foreach (DataGridViewColumn column in DGFact.Columns)
			{
				switch (contador)
				{
					case 0:
						dgx = 40;//80
						Titulos = "ID";
						break;
					case 1:
						dgx = 40;//80
						Titulos = "N◦";
						break;
					case 2:
						dgx = 45;//115
						Titulos = "PRODUCTO";
						break;
					case 3:
						dgx = 80;//130
						Titulos = "CNT";
						break;
					case 4:
						dgx = 70;//150
						Titulos = "PRECIO";
						break;
					case 5:
						dgx = 70;//100
						Titulos = "TOTAL";
						break;
				}
				e.Graphics.DrawString(Titulos + "\t", font, Brushes.Black, new RectangleF(70 + (dgx * contador), y + 100, width, height));
				contador++;
			}
			contador = 0;

			for (int rowIndex = 0; rowIndex < DGFact.Rows.Count; rowIndex++)
			{
				DataGridViewRow row = DGFact.Rows[rowIndex];
				contador = 0;
				for (int colIndex = 0; colIndex < DGFact.Columns.Count; colIndex++)
				{
					switch (contador)
					{
						case 0:
							dgx = 40;//80
							break;
						case 1:
							dgx = 40;//80
							break;
						case 2:
							dgx = 45;//115
							break;
						case 3:
							dgx = 80;//130
							break;
						case 4:
							dgx = 70;//150
							break;
						case 5:
							dgx = 70;//100
							break;
					}
					DataGridViewCell cell = row.Cells[colIndex];
					string cellValue = cell.Value != null ? cell.Value.ToString() : "";
					if (cellValue.Length > 12)
					{
						cellValue = cellValue.Substring(0, 12);
					}
					e.Graphics.DrawString(cellValue, font, Brushes.Black, new RectangleF(70 + (dgx * contador), y + 120 + (20 * contadory), width, height));
					contador++;
				}
				contadory++;
			}

			e.Graphics.DrawString("########################################", font, Brushes.Black, new RectangleF(x, y + 140 + (20 * contadory), width, height));
			e.Graphics.DrawString("Total a Pagar: $" + TxtTotal.Text, font, Brushes.Black, new RectangleF(x + 110, y + 160 + (20 * contadory), width, height));
			e.Graphics.DrawString("Efectivo: $" + TxtBox0.Text, font, Brushes.Black, new RectangleF(x + 110, y + 180 + (20 * contadory), width, height));
			e.Graphics.DrawString("Cambio: $" + TxtCambio.Text, font, Brushes.Black, new RectangleF(x + 110, y + 200 + (20 * contadory), width, height));
			e.Graphics.DrawString("Fecha de Compra:" + TxtFecha.Text, font, Brushes.Black, new RectangleF(x, y + 240 + (20 * contadory), width, height));
			e.Graphics.DrawString("Gracias por preferirnos.", font, Brushes.Black, new RectangleF(x + 110, y + 280 + (20 * contadory), width, height));
		}

		private void BtnPrint_Click(object sender, EventArgs e)
		{
			if (PuedeImprimir)
			{
				try
				{
					//printDocument1 = new PrintDocument();
					//PrinterSettings ps = new PrinterSettings();
					//printDocument1.PrinterSettings = ps;
					//printDocument1.PrintPage += Imprimir;
					//printDocument1.Print();
					//MessageBox.Show("La impresion se a realizado exitosamente.");
					guaradar_Documento();
					MessageBox.Show("Factura guardada en Documentos","Informacion");
				}
				catch
				{
					MessageBox.Show("Parece que hubo un error");
					PuedeImprimir = false;
				}
			}
			else
			{
				MessageBox.Show("Aun no puede");
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

			try
			{
				decimal Total = Convert.ToDecimal(TxtTotal.Text);

				decimal Efectivo = Convert.ToDecimal(TxtBox0.Text);

				decimal Cambio = Efectivo - Total;

				if (Cambio >= 0)
				{
					TxtCambio.ForeColor = Color.Green;
					TxtCambio.Text = Cambio.ToString("0.00");
					DineroSuficiente = true;
				}
				else
				{
					TxtCambio.ForeColor = Color.Orange;
					TxtCambio.Text = "Insuficiente";
					DineroSuficiente = false;

				}
			}
			catch
			{
				TxtCambio.ForeColor = Color.Red;
				TxtCambio.Text = "0.00";
				DineroSuficiente = false;
			}


		}
		public void guaradar_Documento()
		{
			Document pdfDoc = new Document();
			try
			{
					PdfWriter.GetInstance(pdfDoc, new FileStream($"C:\\Users\\Luis Portillo\\Documents\\Facturas\\Venta_{TxtVenta.Text}.pdf", FileMode.Create));
					iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
					iTextSharp.text.Font cellFont = FontFactory.GetFont(FontFactory.HELVETICA, 8);

					pdfDoc.Open();
					pdfDoc.Add(new Paragraph("##############################################################################"));
					pdfDoc.Add(new Paragraph($"NUMERO DE VENTA: {TxtVenta.Text}                              VENDEDOR: {FormPrincipal.usuario}"));
					pdfDoc.Add(new Paragraph($"NUMERO DE PEDIDO: {LblEstado.Text}                            Fecha de Compra: {TxtFecha.Text}"));
					pdfDoc.Add(new Paragraph("##############################################################################"));
					pdfDoc.Add(new Paragraph("\nDetalles de venta"));

					DataTable dt = (DataTable)DGFact.DataSource;

					var tabla = new PdfPTable(4);
					tabla.SetWidths(new float[4] { 430f, 80f, 100f, 80f });
					tabla.AddCell(new Phrase("Producto", headerFont));
					tabla.AddCell(new Phrase("Cantidad", headerFont));
					tabla.AddCell(new Phrase("Precio Unitario", headerFont));
					tabla.AddCell(new Phrase("Total", headerFont));

					foreach (DataRow row in dt.Rows)
					{
						tabla.AddCell(new Phrase(row[2].ToString(), cellFont));
						tabla.AddCell(new Phrase(Element.ALIGN_CENTER, row[3].ToString(), cellFont));
						tabla.AddCell(new Phrase(Element.ALIGN_CENTER, "$" + row[4].ToString(), cellFont));
						tabla.AddCell(new Phrase(Element.ALIGN_CENTER, "$" + row[5].ToString(), cellFont));

					}
					tabla.AddCell(new Phrase("-", cellFont));
					tabla.AddCell(new Phrase("-", cellFont));
					tabla.AddCell(new Phrase("Total a pagar: ", cellFont));
					tabla.AddCell(new Phrase(TxtTotal.Text, cellFont));
					pdfDoc.Add(new Chunk(Chunk.NEWLINE));
					pdfDoc.Add(tabla);
					pdfDoc.Add(new Paragraph("\n\n##############################################################################"));
					pdfDoc.Add(new Paragraph("Efectivo:   $" + TxtBox0.Text));
					pdfDoc.Add(new Paragraph("Cambio:     $" + TxtCambio.Text));
					pdfDoc.Add(new Paragraph("Gracias por preferirnos."));
				
			}
			catch (DocumentException de)
			{
				Console.Error.WriteLine(de.Message);
			}
			catch (IOException ioe)
			{
				Console.Error.WriteLine(ioe.Message);
			}
			finally
			{

				pdfDoc.Close();
			}
		}
	}
}

