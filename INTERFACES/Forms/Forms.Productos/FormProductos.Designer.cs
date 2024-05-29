namespace INTERFACES.Forms
{
    partial class FormProductos
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pnlBusqueda = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnBasura = new System.Windows.Forms.Button();
			this.btnNuevoP = new System.Windows.Forms.Button();
			this.lblFiltro = new System.Windows.Forms.Label();
			this.cboxFiltro = new System.Windows.Forms.ComboBox();
			this.pnlTxt = new System.Windows.Forms.Panel();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.pnlDataGrid = new System.Windows.Forms.Panel();
			this.dataGrid = new System.Windows.Forms.DataGridView();
			this.pnlBusqueda.SuspendLayout();
			this.pnlTxt.SuspendLayout();
			this.pnlDataGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlBusqueda
			// 
			this.pnlBusqueda.BackColor = System.Drawing.Color.Teal;
			this.pnlBusqueda.Controls.Add(this.button1);
			this.pnlBusqueda.Controls.Add(this.btnEditar);
			this.pnlBusqueda.Controls.Add(this.btnBasura);
			this.pnlBusqueda.Controls.Add(this.btnNuevoP);
			this.pnlBusqueda.Controls.Add(this.lblFiltro);
			this.pnlBusqueda.Controls.Add(this.cboxFiltro);
			this.pnlBusqueda.Controls.Add(this.pnlTxt);
			this.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlBusqueda.Location = new System.Drawing.Point(0, 0);
			this.pnlBusqueda.Name = "pnlBusqueda";
			this.pnlBusqueda.Size = new System.Drawing.Size(896, 58);
			this.pnlBusqueda.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.Transparent;
			this.button1.Image = global::INTERFACES.Properties.Resources.mas;
			this.button1.Location = new System.Drawing.Point(712, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(52, 47);
			this.button1.TabIndex = 9;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
			this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
			// 
			// btnEditar
			// 
			this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEditar.BackColor = System.Drawing.Color.Transparent;
			this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditar.FlatAppearance.BorderSize = 0;
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.ForeColor = System.Drawing.Color.Transparent;
			this.btnEditar.Image = global::INTERFACES.Properties.Resources.editar;
			this.btnEditar.Location = new System.Drawing.Point(770, 8);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(50, 48);
			this.btnEditar.TabIndex = 8;
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			this.btnEditar.MouseEnter += new System.EventHandler(this.btnEditar_MouseEnter);
			this.btnEditar.MouseLeave += new System.EventHandler(this.ButtonLeave);
			// 
			// btnBasura
			// 
			this.btnBasura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBasura.BackColor = System.Drawing.Color.Transparent;
			this.btnBasura.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBasura.FlatAppearance.BorderSize = 0;
			this.btnBasura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBasura.Image = global::INTERFACES.Properties.Resources.basura;
			this.btnBasura.Location = new System.Drawing.Point(656, 7);
			this.btnBasura.Name = "btnBasura";
			this.btnBasura.Size = new System.Drawing.Size(50, 48);
			this.btnBasura.TabIndex = 7;
			this.btnBasura.UseVisualStyleBackColor = false;
			this.btnBasura.Click += new System.EventHandler(this.btnBasura_Click);
			this.btnBasura.MouseEnter += new System.EventHandler(this.btnBasura_MouseEnter);
			this.btnBasura.MouseLeave += new System.EventHandler(this.ButtonLeave);
			// 
			// btnNuevoP
			// 
			this.btnNuevoP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNuevoP.BackColor = System.Drawing.Color.Transparent;
			this.btnNuevoP.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNuevoP.FlatAppearance.BorderSize = 0;
			this.btnNuevoP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNuevoP.Image = global::INTERFACES.Properties.Resources.archivo_nuevo;
			this.btnNuevoP.Location = new System.Drawing.Point(826, 8);
			this.btnNuevoP.Name = "btnNuevoP";
			this.btnNuevoP.Size = new System.Drawing.Size(50, 48);
			this.btnNuevoP.TabIndex = 6;
			this.btnNuevoP.UseVisualStyleBackColor = false;
			this.btnNuevoP.Click += new System.EventHandler(this.btnNuevoP_Click);
			this.btnNuevoP.MouseEnter += new System.EventHandler(this.btnNuevoP_MouseEnter);
			this.btnNuevoP.MouseLeave += new System.EventHandler(this.ButtonLeave);
			// 
			// lblFiltro
			// 
			this.lblFiltro.AutoSize = true;
			this.lblFiltro.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFiltro.Location = new System.Drawing.Point(3, 19);
			this.lblFiltro.Name = "lblFiltro";
			this.lblFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblFiltro.Size = new System.Drawing.Size(106, 16);
			this.lblFiltro.TabIndex = 2;
			this.lblFiltro.Text = "FILTRAR POR";
			// 
			// cboxFiltro
			// 
			this.cboxFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cboxFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboxFiltro.FormattingEnabled = true;
			this.cboxFiltro.Items.AddRange(new object[] {
            "ID",
            "PRODUCTO",
            "UNIDADES",
            "PRECIO",
            "MARCA",
            "CATEGORIA"});
			this.cboxFiltro.Location = new System.Drawing.Point(135, 16);
			this.cboxFiltro.Name = "cboxFiltro";
			this.cboxFiltro.Size = new System.Drawing.Size(121, 28);
			this.cboxFiltro.TabIndex = 1;
			// 
			// pnlTxt
			// 
			this.pnlTxt.BackColor = System.Drawing.Color.White;
			this.pnlTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pnlTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlTxt.Controls.Add(this.txtBusqueda);
			this.pnlTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.pnlTxt.Location = new System.Drawing.Point(283, 16);
			this.pnlTxt.Name = "pnlTxt";
			this.pnlTxt.Size = new System.Drawing.Size(282, 28);
			this.pnlTxt.TabIndex = 0;
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBusqueda.Location = new System.Drawing.Point(3, 4);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(274, 19);
			this.txtBusqueda.TabIndex = 0;
			this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
			this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
			// 
			// pnlDataGrid
			// 
			this.pnlDataGrid.Controls.Add(this.dataGrid);
			this.pnlDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlDataGrid.Location = new System.Drawing.Point(0, 58);
			this.pnlDataGrid.Name = "pnlDataGrid";
			this.pnlDataGrid.Size = new System.Drawing.Size(896, 400);
			this.pnlDataGrid.TabIndex = 3;
			// 
			// dataGrid
			// 
			this.dataGrid.AllowUserToAddRows = false;
			this.dataGrid.AllowUserToDeleteRows = false;
			this.dataGrid.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
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
			this.dataGrid.Location = new System.Drawing.Point(0, 0);
			this.dataGrid.Name = "dataGrid";
			this.dataGrid.ReadOnly = true;
			this.dataGrid.RowHeadersVisible = false;
			this.dataGrid.RowTemplate.Height = 40;
			this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGrid.Size = new System.Drawing.Size(896, 400);
			this.dataGrid.TabIndex = 2;
			// 
			// FormProductos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(896, 458);
			this.Controls.Add(this.pnlDataGrid);
			this.Controls.Add(this.pnlBusqueda);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormProductos";
			this.Text = "FormProductos";
			this.Load += new System.EventHandler(this.FormProductos_Load);
			this.pnlBusqueda.ResumeLayout(false);
			this.pnlBusqueda.PerformLayout();
			this.pnlTxt.ResumeLayout(false);
			this.pnlTxt.PerformLayout();
			this.pnlDataGrid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Panel pnlTxt;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cboxFiltro;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBasura;
        private System.Windows.Forms.Button btnNuevoP;
        private System.Windows.Forms.Button button1;
    }
}