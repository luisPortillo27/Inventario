namespace INTERFACES
{
	partial class Inicio
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
			this.label4 = new System.Windows.Forms.Label();
			this.mostrar = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ocultar = new System.Windows.Forms.PictureBox();
			this.txtclave = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnclear = new System.Windows.Forms.Button();
			this.btinicio = new System.Windows.Forms.Button();
			this.txtuser = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.error = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.mostrar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ocultar)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.LightGray;
			this.label4.Location = new System.Drawing.Point(389, 53);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(0, 13);
			this.label4.TabIndex = 22;
			// 
			// mostrar
			// 
			this.mostrar.BackColor = System.Drawing.Color.White;
			this.mostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.mostrar.Image = ((System.Drawing.Image)(resources.GetObject("mostrar.Image")));
			this.mostrar.Location = new System.Drawing.Point(483, 158);
			this.mostrar.Margin = new System.Windows.Forms.Padding(2);
			this.mostrar.Name = "mostrar";
			this.mostrar.Size = new System.Drawing.Size(19, 18);
			this.mostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.mostrar.TabIndex = 18;
			this.mostrar.TabStop = false;
			this.mostrar.Click += new System.EventHandler(this.mostrar_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(275, 132);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 23);
			this.label3.TabIndex = 21;
			this.label3.Text = "Password";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(273, 66);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 23);
			this.label2.TabIndex = 20;
			this.label2.Text = "Username";
			// 
			// ocultar
			// 
			this.ocultar.BackColor = System.Drawing.Color.White;
			this.ocultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ocultar.Image = ((System.Drawing.Image)(resources.GetObject("ocultar.Image")));
			this.ocultar.Location = new System.Drawing.Point(483, 158);
			this.ocultar.Margin = new System.Windows.Forms.Padding(2);
			this.ocultar.Name = "ocultar";
			this.ocultar.Size = new System.Drawing.Size(19, 18);
			this.ocultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ocultar.TabIndex = 19;
			this.ocultar.TabStop = false;
			this.ocultar.Click += new System.EventHandler(this.ocultar_Click);
			// 
			// txtclave
			// 
			this.txtclave.BackColor = System.Drawing.Color.White;
			this.txtclave.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtclave.ForeColor = System.Drawing.Color.Black;
			this.txtclave.Location = new System.Drawing.Point(279, 156);
			this.txtclave.Margin = new System.Windows.Forms.Padding(2);
			this.txtclave.Name = "txtclave";
			this.txtclave.PasswordChar = '*';
			this.txtclave.ShortcutsEnabled = false;
			this.txtclave.Size = new System.Drawing.Size(227, 24);
			this.txtclave.TabIndex = 2;
			this.txtclave.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(235, 286);
			this.panel1.TabIndex = 16;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Teal;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(235, 286);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnclear
			// 
			this.btnclear.BackColor = System.Drawing.Color.Teal;
			this.btnclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnclear.FlatAppearance.BorderSize = 0;
			this.btnclear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
			this.btnclear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
			this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnclear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnclear.ForeColor = System.Drawing.Color.Beige;
			this.btnclear.Location = new System.Drawing.Point(279, 211);
			this.btnclear.Margin = new System.Windows.Forms.Padding(2);
			this.btnclear.Name = "btnclear";
			this.btnclear.Size = new System.Drawing.Size(109, 28);
			this.btnclear.TabIndex = 15;
			this.btnclear.Text = "CLEAR";
			this.btnclear.UseVisualStyleBackColor = false;
			this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
			// 
			// btinicio
			// 
			this.btinicio.BackColor = System.Drawing.Color.Teal;
			this.btinicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btinicio.FlatAppearance.BorderSize = 0;
			this.btinicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
			this.btinicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
			this.btinicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btinicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btinicio.ForeColor = System.Drawing.Color.Beige;
			this.btinicio.Location = new System.Drawing.Point(395, 211);
			this.btinicio.Margin = new System.Windows.Forms.Padding(2);
			this.btinicio.Name = "btinicio";
			this.btinicio.Size = new System.Drawing.Size(109, 28);
			this.btinicio.TabIndex = 14;
			this.btinicio.Text = "LOGIN";
			this.btinicio.UseVisualStyleBackColor = false;
			this.btinicio.Click += new System.EventHandler(this.btinicio_Click);
			// 
			// txtuser
			// 
			this.txtuser.BackColor = System.Drawing.Color.White;
			this.txtuser.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtuser.ForeColor = System.Drawing.Color.Black;
			this.txtuser.Location = new System.Drawing.Point(277, 90);
			this.txtuser.Margin = new System.Windows.Forms.Padding(2);
			this.txtuser.Name = "txtuser";
			this.txtuser.ShortcutsEnabled = false;
			this.txtuser.Size = new System.Drawing.Size(227, 24);
			this.txtuser.TabIndex = 1;
			this.txtuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtuser_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Goudy Stout", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(271, 17);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(239, 30);
			this.label1.TabIndex = 12;
			this.label1.Text = "¡WELCOME!";
			// 
			// error
			// 
			this.error.ContainerControl = this;
			// 
			// Inicio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(531, 286);
			this.Controls.Add(this.mostrar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ocultar);
			this.Controls.Add(this.txtclave);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnclear);
			this.Controls.Add(this.btinicio);
			this.Controls.Add(this.txtuser);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(547, 325);
			this.MinimumSize = new System.Drawing.Size(547, 325);
			this.Name = "Inicio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Inicio";
			((System.ComponentModel.ISupportInitialize)(this.mostrar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ocultar)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox mostrar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox ocultar;
		private System.Windows.Forms.TextBox txtclave;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnclear;
		private System.Windows.Forms.Button btinicio;
		private System.Windows.Forms.TextBox txtuser;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider error;
	}
}