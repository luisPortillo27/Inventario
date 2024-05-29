namespace INTERFACES.Forms
{
    partial class FormPedido
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGrid = new System.Windows.Forms.DataGridView();
			this.lblPedido = new System.Windows.Forms.Label();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.pnlPedido = new System.Windows.Forms.Panel();
			this.BtnAceptarCambio = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblProducto = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.lbl = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
			this.pnlPedido.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid
			// 
			this.dataGrid.AllowUserToAddRows = false;
			this.dataGrid.AllowUserToDeleteRows = false;
			this.dataGrid.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGrid.ColumnHeadersHeight = 40;
			this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGrid.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGrid.EnableHeadersVisualStyles = false;
			this.dataGrid.Location = new System.Drawing.Point(12, 135);
			this.dataGrid.Name = "dataGrid";
			this.dataGrid.ReadOnly = true;
			this.dataGrid.RowHeadersVisible = false;
			this.dataGrid.RowTemplate.Height = 40;
			this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGrid.Size = new System.Drawing.Size(627, 309);
			this.dataGrid.TabIndex = 3;
			// 
			// lblPedido
			// 
			this.lblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPedido.Location = new System.Drawing.Point(130, 27);
			this.lblPedido.Name = "lblPedido";
			this.lblPedido.Size = new System.Drawing.Size(241, 63);
			this.lblPedido.TabIndex = 4;
			this.lblPedido.Text = "PEDIDO #";
			// 
			// btnEditar
			// 
			this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEditar.BackColor = System.Drawing.Color.Lime;
			this.btnEditar.FlatAppearance.BorderSize = 0;
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.Location = new System.Drawing.Point(695, 58);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(91, 32);
			this.btnEditar.TabIndex = 6;
			this.btnEditar.Text = "EDITAR";
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEliminar.BackColor = System.Drawing.Color.Tomato;
			this.btnEliminar.FlatAppearance.BorderSize = 0;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Location = new System.Drawing.Point(792, 58);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(91, 32);
			this.btnEliminar.TabIndex = 7;
			this.btnEliminar.Text = "ELIMINAR";
			this.btnEliminar.UseVisualStyleBackColor = false;
			// 
			// pnlPedido
			// 
			this.pnlPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlPedido.Controls.Add(this.BtnAceptarCambio);
			this.pnlPedido.Controls.Add(this.label1);
			this.pnlPedido.Controls.Add(this.lblProducto);
			this.pnlPedido.Controls.Add(this.panel1);
			this.pnlPedido.Controls.Add(this.lbl);
			this.pnlPedido.Location = new System.Drawing.Point(645, 135);
			this.pnlPedido.Name = "pnlPedido";
			this.pnlPedido.Size = new System.Drawing.Size(239, 309);
			this.pnlPedido.TabIndex = 8;
			// 
			// BtnAceptarCambio
			// 
			this.BtnAceptarCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnAceptarCambio.BackColor = System.Drawing.Color.White;
			this.BtnAceptarCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnAceptarCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnAceptarCambio.Location = new System.Drawing.Point(42, 218);
			this.BtnAceptarCambio.Name = "BtnAceptarCambio";
			this.BtnAceptarCambio.Size = new System.Drawing.Size(158, 32);
			this.BtnAceptarCambio.TabIndex = 7;
			this.BtnAceptarCambio.Text = "ACEPTAR CAMBIO";
			this.BtnAceptarCambio.UseVisualStyleBackColor = false;
			this.BtnAceptarCambio.Click += new System.EventHandler(this.BtnAceptarCambio_Click);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(237, 25);
			this.label1.TabIndex = 5;
			this.label1.Text = "CANTIDAD";
			// 
			// lblProducto
			// 
			this.lblProducto.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProducto.Location = new System.Drawing.Point(0, 25);
			this.lblProducto.Name = "lblProducto";
			this.lblProducto.Size = new System.Drawing.Size(237, 88);
			this.lblProducto.TabIndex = 4;
			this.lblProducto.Text = "-";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txtCantidad);
			this.panel1.Location = new System.Drawing.Point(34, 161);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(170, 27);
			this.panel1.TabIndex = 3;
			// 
			// txtCantidad
			// 
			this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantidad.Location = new System.Drawing.Point(7, 3);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(162, 15);
			this.txtCantidad.TabIndex = 5;
			this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
			this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
			// 
			// lbl
			// 
			this.lbl.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl.Location = new System.Drawing.Point(0, 0);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(237, 25);
			this.lbl.TabIndex = 0;
			this.lbl.Text = "PRODUCTO:";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.BackColor = System.Drawing.Color.Orange;
			this.btnCancelar.FlatAppearance.BorderSize = 0;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Location = new System.Drawing.Point(531, 58);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(158, 32);
			this.btnCancelar.TabIndex = 9;
			this.btnCancelar.Text = "CANCELAR PEDIDO";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAceptar.BackColor = System.Drawing.Color.PaleVioletRed;
			this.btnAceptar.FlatAppearance.BorderSize = 0;
			this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Location = new System.Drawing.Point(434, 58);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(91, 32);
			this.btnAceptar.TabIndex = 10;
			this.btnAceptar.Text = "ACEPTAR";
			this.btnAceptar.UseVisualStyleBackColor = false;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::INTERFACES.Properties.Resources.telefono_inteligente;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(112, 92);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// FormPedido
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(896, 456);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.pnlPedido);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblPedido);
			this.Controls.Add(this.dataGrid);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormPedido";
			this.Text = "FormPedido";
			this.Load += new System.EventHandler(this.FormPedido_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
			this.pnlPedido.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel pnlPedido;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Label lblProducto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnAceptarCambio;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}