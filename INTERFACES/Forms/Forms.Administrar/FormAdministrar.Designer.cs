namespace INTERFACES.Forms
{
	partial class FormAdministrar
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnedit = new System.Windows.Forms.Button();
			this.btneliminar = new System.Windows.Forms.Button();
			this.btnclear = new System.Windows.Forms.Button();
			this.cbxRol = new System.Windows.Forms.ComboBox();
			this.Rol = new System.Windows.Forms.Label();
			this.txtClave = new System.Windows.Forms.TextBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.btnadd = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.error = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnedit
			// 
			this.btnedit.BackColor = System.Drawing.Color.LightPink;
			this.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnedit.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
			this.btnedit.FlatAppearance.BorderSize = 0;
			this.btnedit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
			this.btnedit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
			this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnedit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnedit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnedit.Location = new System.Drawing.Point(144, 164);
			this.btnedit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnedit.Name = "btnedit";
			this.btnedit.Size = new System.Drawing.Size(104, 47);
			this.btnedit.TabIndex = 2;
			this.btnedit.Text = "EDIT";
			this.btnedit.UseVisualStyleBackColor = false;
			this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
			// 
			// btneliminar
			// 
			this.btneliminar.BackColor = System.Drawing.Color.LightPink;
			this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
			this.btneliminar.FlatAppearance.BorderSize = 0;
			this.btneliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
			this.btneliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
			this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btneliminar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btneliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btneliminar.Location = new System.Drawing.Point(592, 164);
			this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btneliminar.Name = "btneliminar";
			this.btneliminar.Size = new System.Drawing.Size(149, 47);
			this.btneliminar.TabIndex = 4;
			this.btneliminar.Text = "DELETE";
			this.btneliminar.UseVisualStyleBackColor = false;
			this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
			// 
			// btnclear
			// 
			this.btnclear.BackColor = System.Drawing.Color.LightPink;
			this.btnclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnclear.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
			this.btnclear.FlatAppearance.BorderSize = 0;
			this.btnclear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
			this.btnclear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
			this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnclear.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnclear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnclear.Location = new System.Drawing.Point(480, 164);
			this.btnclear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnclear.Name = "btnclear";
			this.btnclear.Size = new System.Drawing.Size(104, 47);
			this.btnclear.TabIndex = 27;
			this.btnclear.Text = "CLEAR";
			this.btnclear.UseVisualStyleBackColor = false;
			this.btnclear.Click += new System.EventHandler(this.button5_Click);
			// 
			// cbxRol
			// 
			this.cbxRol.BackColor = System.Drawing.Color.White;
			this.cbxRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbxRol.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxRol.ForeColor = System.Drawing.Color.Black;
			this.cbxRol.FormattingEnabled = true;
			this.cbxRol.Location = new System.Drawing.Point(0, 2);
			this.cbxRol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.cbxRol.Name = "cbxRol";
			this.cbxRol.Size = new System.Drawing.Size(284, 31);
			this.cbxRol.TabIndex = 26;
			// 
			// Rol
			// 
			this.Rol.AutoSize = true;
			this.Rol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Rol.ForeColor = System.Drawing.Color.Black;
			this.Rol.Location = new System.Drawing.Point(453, 9);
			this.Rol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Rol.Name = "Rol";
			this.Rol.Size = new System.Drawing.Size(47, 28);
			this.Rol.TabIndex = 25;
			this.Rol.Text = "Rol";
			// 
			// txtClave
			// 
			this.txtClave.AcceptsTab = true;
			this.txtClave.BackColor = System.Drawing.Color.White;
			this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtClave.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtClave.ForeColor = System.Drawing.Color.Black;
			this.txtClave.Location = new System.Drawing.Point(4, 3);
			this.txtClave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtClave.Name = "txtClave";
			this.txtClave.Size = new System.Drawing.Size(273, 25);
			this.txtClave.TabIndex = 24;
			// 
			// txtUser
			// 
			this.txtUser.AcceptsTab = true;
			this.txtUser.BackColor = System.Drawing.Color.White;
			this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUser.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUser.ForeColor = System.Drawing.Color.Black;
			this.txtUser.Location = new System.Drawing.Point(2, 3);
			this.txtUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(277, 25);
			this.txtUser.TabIndex = 23;
			this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
			// 
			// btnadd
			// 
			this.btnadd.BackColor = System.Drawing.Color.LightPink;
			this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
			this.btnadd.FlatAppearance.BorderSize = 0;
			this.btnadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
			this.btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
			this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnadd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnadd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnadd.Location = new System.Drawing.Point(256, 164);
			this.btnadd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnadd.Name = "btnadd";
			this.btnadd.Size = new System.Drawing.Size(104, 47);
			this.btnadd.TabIndex = 22;
			this.btnadd.Text = "ADD";
			this.btnadd.UseVisualStyleBackColor = false;
			this.btnadd.Click += new System.EventHandler(this.button6_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(139, 85);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 28);
			this.label2.TabIndex = 21;
			this.label2.Text = "Password";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(140, 9);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(129, 28);
			this.label4.TabIndex = 20;
			this.label4.Text = "Username";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Firebrick;
			this.label1.Location = new System.Drawing.Point(143, 224);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(599, 38);
			this.label1.TabIndex = 28;
			this.label1.Text = "Al eliminar un registro, se realizara de forma permanente.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightPink;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Location = new System.Drawing.Point(368, 164);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 47);
			this.button1.TabIndex = 29;
			this.button1.Text = "UPDATE";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// error
			// 
			this.error.ContainerControl = this;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txtUser);
			this.panel1.Location = new System.Drawing.Point(144, 45);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(285, 28);
			this.panel1.TabIndex = 30;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.txtClave);
			this.panel2.Location = new System.Drawing.Point(143, 119);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(285, 28);
			this.panel2.TabIndex = 31;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.cbxRol);
			this.panel3.Location = new System.Drawing.Point(456, 45);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(285, 28);
			this.panel3.TabIndex = 32;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DodgerBlue;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this.dataGridView1.ColumnHeadersHeight = 40;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.Location = new System.Drawing.Point(142, 276);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 40;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(599, 181);
			this.dataGridView1.TabIndex = 33;
			// 
			// FormAdministrar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(896, 458);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnclear);
			this.Controls.Add(this.Rol);
			this.Controls.Add(this.btnadd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btneliminar);
			this.Controls.Add(this.btnedit);
			this.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.MaximumSize = new System.Drawing.Size(1624, 732);
			this.Name = "FormAdministrar";
			this.Text = "FormAdministrar";
			this.Load += new System.EventHandler(this.FormAdministrar_Load);
			((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnedit;
		private System.Windows.Forms.Button btneliminar;
		private System.Windows.Forms.Button btnclear;
		private System.Windows.Forms.ComboBox cbxRol;
		private System.Windows.Forms.Label Rol;
		private System.Windows.Forms.TextBox txtClave;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.Button btnadd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ErrorProvider error;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}