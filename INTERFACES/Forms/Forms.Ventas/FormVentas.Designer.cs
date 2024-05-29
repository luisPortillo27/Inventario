namespace INTERFACES.Forms
{
	partial class FormVentas
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.CMBPedidos = new System.Windows.Forms.ComboBox();
			this.Lbl0 = new System.Windows.Forms.Label();
			this.Lbl1 = new System.Windows.Forms.Label();
			this.Lbl2 = new System.Windows.Forms.Label();
			this.Lbl3 = new System.Windows.Forms.Label();
			this.TxtVenta = new System.Windows.Forms.Label();
			this.TxtTotal = new System.Windows.Forms.Label();
			this.TxtFecha = new System.Windows.Forms.Label();
			this.LblEstado = new System.Windows.Forms.Label();
			this.BtnConfirm = new System.Windows.Forms.Button();
			this.BtnPrint = new System.Windows.Forms.Button();
			this.Lbl4 = new System.Windows.Forms.Label();
			this.TxtBox0 = new System.Windows.Forms.TextBox();
			this.Lbl5 = new System.Windows.Forms.Label();
			this.TxtCambio = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.panel1 = new System.Windows.Forms.Panel();
			this.DGLista = new System.Windows.Forms.DataGridView();
			this.DGFact = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGLista)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DGFact)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// CMBPedidos
			// 
			this.CMBPedidos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.CMBPedidos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.CMBPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CMBPedidos.FormattingEnabled = true;
			this.CMBPedidos.Location = new System.Drawing.Point(35, 90);
			this.CMBPedidos.Margin = new System.Windows.Forms.Padding(2);
			this.CMBPedidos.Name = "CMBPedidos";
			this.CMBPedidos.Size = new System.Drawing.Size(186, 28);
			this.CMBPedidos.TabIndex = 0;
			this.CMBPedidos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// Lbl0
			// 
			this.Lbl0.AutoSize = true;
			this.Lbl0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl0.Location = new System.Drawing.Point(31, 49);
			this.Lbl0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Lbl0.Name = "Lbl0";
			this.Lbl0.Size = new System.Drawing.Size(160, 24);
			this.Lbl0.TabIndex = 2;
			this.Lbl0.Text = "Numero de Venta";
			// 
			// Lbl1
			// 
			this.Lbl1.AutoSize = true;
			this.Lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl1.Location = new System.Drawing.Point(31, 154);
			this.Lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Lbl1.Name = "Lbl1";
			this.Lbl1.Size = new System.Drawing.Size(73, 20);
			this.Lbl1.TabIndex = 3;
			this.Lbl1.Text = "IDVenta:";
			// 
			// Lbl2
			// 
			this.Lbl2.AutoSize = true;
			this.Lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl2.Location = new System.Drawing.Point(31, 197);
			this.Lbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Lbl2.Name = "Lbl2";
			this.Lbl2.Size = new System.Drawing.Size(48, 20);
			this.Lbl2.TabIndex = 5;
			this.Lbl2.Text = "Total:";
			// 
			// Lbl3
			// 
			this.Lbl3.AutoSize = true;
			this.Lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl3.Location = new System.Drawing.Point(31, 311);
			this.Lbl3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Lbl3.Name = "Lbl3";
			this.Lbl3.Size = new System.Drawing.Size(58, 20);
			this.Lbl3.TabIndex = 7;
			this.Lbl3.Text = "Fecha:";
			// 
			// TxtVenta
			// 
			this.TxtVenta.AutoSize = true;
			this.TxtVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtVenta.Location = new System.Drawing.Point(147, 154);
			this.TxtVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.TxtVenta.Name = "TxtVenta";
			this.TxtVenta.Size = new System.Drawing.Size(14, 20);
			this.TxtVenta.TabIndex = 11;
			this.TxtVenta.Text = "-";
			// 
			// TxtTotal
			// 
			this.TxtTotal.AutoSize = true;
			this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtTotal.Location = new System.Drawing.Point(169, 197);
			this.TxtTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.TxtTotal.Name = "TxtTotal";
			this.TxtTotal.Size = new System.Drawing.Size(14, 20);
			this.TxtTotal.TabIndex = 12;
			this.TxtTotal.Text = "-";
			// 
			// TxtFecha
			// 
			this.TxtFecha.AutoSize = true;
			this.TxtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtFecha.Location = new System.Drawing.Point(119, 311);
			this.TxtFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.TxtFecha.Name = "TxtFecha";
			this.TxtFecha.Size = new System.Drawing.Size(14, 20);
			this.TxtFecha.TabIndex = 13;
			this.TxtFecha.Text = "-";
			// 
			// LblEstado
			// 
			this.LblEstado.AutoSize = true;
			this.LblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblEstado.Location = new System.Drawing.Point(212, 52);
			this.LblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblEstado.Name = "LblEstado";
			this.LblEstado.Size = new System.Drawing.Size(14, 20);
			this.LblEstado.TabIndex = 14;
			this.LblEstado.Text = "-";
			// 
			// BtnConfirm
			// 
			this.BtnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnConfirm.Location = new System.Drawing.Point(35, 356);
			this.BtnConfirm.Margin = new System.Windows.Forms.Padding(2);
			this.BtnConfirm.Name = "BtnConfirm";
			this.BtnConfirm.Size = new System.Drawing.Size(99, 43);
			this.BtnConfirm.TabIndex = 15;
			this.BtnConfirm.Text = "Confirmar";
			this.BtnConfirm.UseVisualStyleBackColor = true;
			this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
			// 
			// BtnPrint
			// 
			this.BtnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnPrint.Location = new System.Drawing.Point(151, 356);
			this.BtnPrint.Margin = new System.Windows.Forms.Padding(2);
			this.BtnPrint.Name = "BtnPrint";
			this.BtnPrint.Size = new System.Drawing.Size(99, 43);
			this.BtnPrint.TabIndex = 17;
			this.BtnPrint.Text = "Guardar";
			this.BtnPrint.UseVisualStyleBackColor = true;
			this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
			// 
			// Lbl4
			// 
			this.Lbl4.AutoSize = true;
			this.Lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl4.Location = new System.Drawing.Point(31, 235);
			this.Lbl4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Lbl4.Name = "Lbl4";
			this.Lbl4.Size = new System.Drawing.Size(70, 20);
			this.Lbl4.TabIndex = 18;
			this.Lbl4.Text = "Efectivo:";
			// 
			// TxtBox0
			// 
			this.TxtBox0.BackColor = System.Drawing.Color.White;
			this.TxtBox0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtBox0.Location = new System.Drawing.Point(173, 235);
			this.TxtBox0.Margin = new System.Windows.Forms.Padding(2);
			this.TxtBox0.Name = "TxtBox0";
			this.TxtBox0.Size = new System.Drawing.Size(100, 26);
			this.TxtBox0.TabIndex = 19;
			this.TxtBox0.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// Lbl5
			// 
			this.Lbl5.AutoSize = true;
			this.Lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl5.Location = new System.Drawing.Point(31, 277);
			this.Lbl5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Lbl5.Name = "Lbl5";
			this.Lbl5.Size = new System.Drawing.Size(67, 20);
			this.Lbl5.TabIndex = 20;
			this.Lbl5.Text = "Cambio:";
			// 
			// TxtCambio
			// 
			this.TxtCambio.AutoSize = true;
			this.TxtCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtCambio.Location = new System.Drawing.Point(169, 277);
			this.TxtCambio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.TxtCambio.Name = "TxtCambio";
			this.TxtCambio.Size = new System.Drawing.Size(14, 20);
			this.TxtCambio.TabIndex = 21;
			this.TxtCambio.Text = "-";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(147, 197);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 20);
			this.label1.TabIndex = 22;
			this.label1.Text = "$";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(147, 277);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(18, 20);
			this.label2.TabIndex = 23;
			this.label2.Text = "$";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(147, 239);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(18, 20);
			this.label3.TabIndex = 24;
			this.label3.Text = "$";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(573, 447);
			this.panel1.TabIndex = 25;
			// 
			// DGLista
			// 
			this.DGLista.AllowUserToAddRows = false;
			this.DGLista.AllowUserToDeleteRows = false;
			this.DGLista.AllowUserToResizeRows = false;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			this.DGLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.DGLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DGLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DGLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.DGLista.ColumnHeadersHeight = 40;
			this.DGLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DGLista.DefaultCellStyle = dataGridViewCellStyle6;
			this.DGLista.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DGLista.EnableHeadersVisualStyles = false;
			this.DGLista.Location = new System.Drawing.Point(0, 0);
			this.DGLista.Name = "DGLista";
			this.DGLista.ReadOnly = true;
			this.DGLista.RowHeadersVisible = false;
			this.DGLista.RowTemplate.Height = 40;
			this.DGLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGLista.Size = new System.Drawing.Size(570, 239);
			this.DGLista.TabIndex = 34;
			// 
			// DGFact
			// 
			this.DGFact.AllowUserToAddRows = false;
			this.DGFact.AllowUserToDeleteRows = false;
			this.DGFact.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.DGFact.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.DGFact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DGFact.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DGFact.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.DGFact.ColumnHeadersHeight = 40;
			this.DGFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DGFact.DefaultCellStyle = dataGridViewCellStyle3;
			this.DGFact.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DGFact.EnableHeadersVisualStyles = false;
			this.DGFact.Location = new System.Drawing.Point(0, 0);
			this.DGFact.Name = "DGFact";
			this.DGFact.ReadOnly = true;
			this.DGFact.RowHeadersVisible = false;
			this.DGFact.RowTemplate.Height = 40;
			this.DGFact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGFact.Size = new System.Drawing.Size(573, 199);
			this.DGFact.TabIndex = 35;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.BtnConfirm);
			this.panel2.Controls.Add(this.CMBPedidos);
			this.panel2.Controls.Add(this.BtnPrint);
			this.panel2.Controls.Add(this.Lbl0);
			this.panel2.Controls.Add(this.LblEstado);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.Lbl4);
			this.panel2.Controls.Add(this.Lbl1);
			this.panel2.Controls.Add(this.TxtFecha);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.TxtBox0);
			this.panel2.Controls.Add(this.Lbl2);
			this.panel2.Controls.Add(this.TxtTotal);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.Lbl5);
			this.panel2.Controls.Add(this.Lbl3);
			this.panel2.Controls.Add(this.TxtVenta);
			this.panel2.Controls.Add(this.TxtCambio);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(579, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(313, 447);
			this.panel2.TabIndex = 26;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.Controls.Add(this.DGLista);
			this.panel3.Location = new System.Drawing.Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(570, 239);
			this.panel3.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.Controls.Add(this.DGFact);
			this.panel4.Location = new System.Drawing.Point(3, 248);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(573, 199);
			this.panel4.TabIndex = 1;
			// 
			// FormVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(892, 447);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(1624, 732);
			this.Name = "FormVentas";
			this.Text = "FormVentas";
			this.Load += new System.EventHandler(this.FormVentas_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DGLista)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DGFact)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox CMBPedidos;
		private System.Windows.Forms.Label Lbl0;
		private System.Windows.Forms.Label Lbl1;
		private System.Windows.Forms.Label Lbl2;
		private System.Windows.Forms.Label Lbl3;
		private System.Windows.Forms.Label TxtVenta;
		private System.Windows.Forms.Label TxtTotal;
		private System.Windows.Forms.Label TxtFecha;
		private System.Windows.Forms.Label LblEstado;
		private System.Windows.Forms.Button BtnConfirm;
		private System.Windows.Forms.Button BtnPrint;
		private System.Windows.Forms.Label Lbl4;
		private System.Windows.Forms.TextBox TxtBox0;
		private System.Windows.Forms.Label Lbl5;
		private System.Windows.Forms.Label TxtCambio;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView DGLista;
		private System.Windows.Forms.DataGridView DGFact;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
	}
}