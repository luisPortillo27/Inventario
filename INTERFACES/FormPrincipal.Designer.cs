namespace INTERFACES
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
			this.pnlMenu = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.pnlAdministrar = new System.Windows.Forms.Panel();
			this.btnAdministrar = new System.Windows.Forms.Button();
			this.pnlVentas = new System.Windows.Forms.Panel();
			this.btnVentas = new System.Windows.Forms.Button();
			this.pnlPedido = new System.Windows.Forms.Panel();
			this.btnPedidos = new System.Windows.Forms.Button();
			this.pnlProductos = new System.Windows.Forms.Panel();
			this.btnProductos = new System.Windows.Forms.Button();
			this.pnlSeccion = new System.Windows.Forms.Panel();
			this.lblSeccion = new System.Windows.Forms.Label();
			this.pnlFormHijo = new System.Windows.Forms.Panel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.statusUser = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusId = new System.Windows.Forms.ToolStripStatusLabel();
			this.pnlMenu.SuspendLayout();
			this.pnlAdministrar.SuspendLayout();
			this.pnlVentas.SuspendLayout();
			this.pnlPedido.SuspendLayout();
			this.pnlProductos.SuspendLayout();
			this.pnlSeccion.SuspendLayout();
			this.pnlFormHijo.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlMenu
			// 
			this.pnlMenu.BackColor = System.Drawing.Color.Teal;
			this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlMenu.Controls.Add(this.button1);
			this.pnlMenu.Controls.Add(this.pnlAdministrar);
			this.pnlMenu.Controls.Add(this.pnlVentas);
			this.pnlMenu.Controls.Add(this.pnlPedido);
			this.pnlMenu.Controls.Add(this.pnlProductos);
			this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlMenu.Location = new System.Drawing.Point(0, 0);
			this.pnlMenu.Name = "pnlMenu";
			this.pnlMenu.Size = new System.Drawing.Size(965, 80);
			this.pnlMenu.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(869, -1);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(95, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Cerrar Sesion";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pnlAdministrar
			// 
			this.pnlAdministrar.Controls.Add(this.btnAdministrar);
			this.pnlAdministrar.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlAdministrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnlAdministrar.Location = new System.Drawing.Point(519, 0);
			this.pnlAdministrar.Name = "pnlAdministrar";
			this.pnlAdministrar.Size = new System.Drawing.Size(187, 78);
			this.pnlAdministrar.TabIndex = 3;
			// 
			// btnAdministrar
			// 
			this.btnAdministrar.BackColor = System.Drawing.Color.Transparent;
			this.btnAdministrar.FlatAppearance.BorderSize = 0;
			this.btnAdministrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdministrar.Image = global::INTERFACES.Properties.Resources.administrar;
			this.btnAdministrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdministrar.Location = new System.Drawing.Point(-3, 0);
			this.btnAdministrar.Name = "btnAdministrar";
			this.btnAdministrar.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.btnAdministrar.Size = new System.Drawing.Size(199, 80);
			this.btnAdministrar.TabIndex = 2;
			this.btnAdministrar.Text = "ADMINISTRAR";
			this.btnAdministrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAdministrar.UseVisualStyleBackColor = false;
			this.btnAdministrar.Click += new System.EventHandler(this.btnAdministrar_Click);
			this.btnAdministrar.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
			this.btnAdministrar.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
			// 
			// pnlVentas
			// 
			this.pnlVentas.Controls.Add(this.btnVentas);
			this.pnlVentas.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnlVentas.Location = new System.Drawing.Point(346, 0);
			this.pnlVentas.Name = "pnlVentas";
			this.pnlVentas.Size = new System.Drawing.Size(173, 78);
			this.pnlVentas.TabIndex = 2;
			// 
			// btnVentas
			// 
			this.btnVentas.BackColor = System.Drawing.Color.Transparent;
			this.btnVentas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnVentas.FlatAppearance.BorderSize = 0;
			this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVentas.Image = global::INTERFACES.Properties.Resources.terminal_de_pago;
			this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnVentas.Location = new System.Drawing.Point(0, 0);
			this.btnVentas.Name = "btnVentas";
			this.btnVentas.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.btnVentas.Size = new System.Drawing.Size(173, 78);
			this.btnVentas.TabIndex = 2;
			this.btnVentas.Text = "VENTAS";
			this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnVentas.UseVisualStyleBackColor = false;
			this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
			this.btnVentas.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
			this.btnVentas.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
			// 
			// pnlPedido
			// 
			this.pnlPedido.Controls.Add(this.btnPedidos);
			this.pnlPedido.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnlPedido.Location = new System.Drawing.Point(173, 0);
			this.pnlPedido.Name = "pnlPedido";
			this.pnlPedido.Size = new System.Drawing.Size(173, 78);
			this.pnlPedido.TabIndex = 1;
			// 
			// btnPedidos
			// 
			this.btnPedidos.BackColor = System.Drawing.Color.Transparent;
			this.btnPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnPedidos.FlatAppearance.BorderSize = 0;
			this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPedidos.Image = global::INTERFACES.Properties.Resources.caja_de_entrega;
			this.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPedidos.Location = new System.Drawing.Point(0, 0);
			this.btnPedidos.Name = "btnPedidos";
			this.btnPedidos.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.btnPedidos.Size = new System.Drawing.Size(173, 78);
			this.btnPedidos.TabIndex = 2;
			this.btnPedidos.Text = "PEDIDOS";
			this.btnPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPedidos.UseVisualStyleBackColor = false;
			this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
			this.btnPedidos.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
			this.btnPedidos.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
			// 
			// pnlProductos
			// 
			this.pnlProductos.Controls.Add(this.btnProductos);
			this.pnlProductos.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnlProductos.Location = new System.Drawing.Point(0, 0);
			this.pnlProductos.Name = "pnlProductos";
			this.pnlProductos.Size = new System.Drawing.Size(173, 78);
			this.pnlProductos.TabIndex = 0;
			// 
			// btnProductos
			// 
			this.btnProductos.BackColor = System.Drawing.Color.Transparent;
			this.btnProductos.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnProductos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnProductos.FlatAppearance.BorderSize = 0;
			this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProductos.Image = global::INTERFACES.Properties.Resources.carrito_de_compras;
			this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProductos.Location = new System.Drawing.Point(0, 0);
			this.btnProductos.Name = "btnProductos";
			this.btnProductos.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.btnProductos.Size = new System.Drawing.Size(173, 78);
			this.btnProductos.TabIndex = 1;
			this.btnProductos.Text = "PRODUCTOS";
			this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnProductos.UseVisualStyleBackColor = false;
			this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
			this.btnProductos.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
			this.btnProductos.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
			// 
			// pnlSeccion
			// 
			this.pnlSeccion.BackColor = System.Drawing.Color.Teal;
			this.pnlSeccion.Controls.Add(this.lblSeccion);
			this.pnlSeccion.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlSeccion.Location = new System.Drawing.Point(0, 80);
			this.pnlSeccion.Name = "pnlSeccion";
			this.pnlSeccion.Size = new System.Drawing.Size(69, 456);
			this.pnlSeccion.TabIndex = 1;
			// 
			// lblSeccion
			// 
			this.lblSeccion.BackColor = System.Drawing.Color.Transparent;
			this.lblSeccion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSeccion.Location = new System.Drawing.Point(0, 0);
			this.lblSeccion.Name = "lblSeccion";
			this.lblSeccion.Size = new System.Drawing.Size(69, 456);
			this.lblSeccion.TabIndex = 0;
			this.lblSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlFormHijo
			// 
			this.pnlFormHijo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlFormHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
			this.pnlFormHijo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pnlFormHijo.Controls.Add(this.statusStrip1);
			this.pnlFormHijo.Location = new System.Drawing.Point(69, 80);
			this.pnlFormHijo.Name = "pnlFormHijo";
			this.pnlFormHijo.Size = new System.Drawing.Size(896, 456);
			this.pnlFormHijo.TabIndex = 2;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusUser,
            this.statusId});
			this.statusStrip1.Location = new System.Drawing.Point(0, 432);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(896, 24);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// statusUser
			// 
			this.statusUser.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.statusUser.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
			this.statusUser.Name = "statusUser";
			this.statusUser.Size = new System.Drawing.Size(51, 19);
			this.statusUser.Text = "Usuario";
			// 
			// statusId
			// 
			this.statusId.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.statusId.Name = "statusId";
			this.statusId.Size = new System.Drawing.Size(17, 19);
			this.statusId.Text = "Id";
			// 
			// FormPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(965, 536);
			this.Controls.Add(this.pnlFormHijo);
			this.Controls.Add(this.pnlSeccion);
			this.Controls.Add(this.pnlMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(816, 489);
			this.Name = "FormPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
			this.Load += new System.EventHandler(this.FormPrincipal_Load);
			this.pnlMenu.ResumeLayout(false);
			this.pnlAdministrar.ResumeLayout(false);
			this.pnlVentas.ResumeLayout(false);
			this.pnlPedido.ResumeLayout(false);
			this.pnlProductos.ResumeLayout(false);
			this.pnlSeccion.ResumeLayout(false);
			this.pnlFormHijo.ResumeLayout(false);
			this.pnlFormHijo.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlAdministrar;
        private System.Windows.Forms.Panel pnlVentas;
        private System.Windows.Forms.Panel pnlPedido;
        private System.Windows.Forms.Panel pnlProductos;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnAdministrar;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Panel pnlSeccion;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.Panel pnlFormHijo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusUser;
        private System.Windows.Forms.ToolStripStatusLabel statusId;
		private System.Windows.Forms.Button button1;
	}
}

