namespace StockManagmentSystem
{
	partial class Form1
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
			this.close = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.login_button = new System.Windows.Forms.Button();
			this.LoginAccount = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.register_label = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.login_password = new System.Windows.Forms.TextBox();
			this.login_email = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// close
			// 
			this.close.BackColor = System.Drawing.Color.Firebrick;
			this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.close.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.close.Location = new System.Drawing.Point(643, 0);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(82, 30);
			this.close.TabIndex = 9;
			this.close.Text = "X";
			this.close.UseVisualStyleBackColor = false;
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(153)))));
			this.panel1.Controls.Add(this.login_button);
			this.panel1.Controls.Add(this.LoginAccount);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.register_label);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.login_password);
			this.panel1.Controls.Add(this.login_email);
			this.panel1.Location = new System.Drawing.Point(-1, 60);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(372, 423);
			this.panel1.TabIndex = 10;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// login_button
			// 
			this.login_button.Font = new System.Drawing.Font("Tahoma", 14.25F);
			this.login_button.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.login_button.Location = new System.Drawing.Point(75, 236);
			this.login_button.Name = "login_button";
			this.login_button.Size = new System.Drawing.Size(249, 45);
			this.login_button.TabIndex = 11;
			this.login_button.Text = "Login";
			this.login_button.UseVisualStyleBackColor = true;
			this.login_button.Click += new System.EventHandler(this.login_button_Click);
			// 
			// LoginAccount
			// 
			this.LoginAccount.AutoSize = true;
			this.LoginAccount.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginAccount.ForeColor = System.Drawing.SystemColors.Control;
			this.LoginAccount.Location = new System.Drawing.Point(69, 77);
			this.LoginAccount.Name = "LoginAccount";
			this.LoginAccount.Size = new System.Drawing.Size(89, 33);
			this.LoginAccount.TabIndex = 10;
			this.LoginAccount.Text = "Login";
			this.LoginAccount.Click += new System.EventHandler(this.LoginAccount_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(3, 192);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 17);
			this.label4.TabIndex = 9;
			this.label4.Text = "Password";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(3, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "E-Mail";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// register_label
			// 
			this.register_label.AutoSize = true;
			this.register_label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.register_label.ForeColor = System.Drawing.Color.AliceBlue;
			this.register_label.Location = new System.Drawing.Point(206, 312);
			this.register_label.Name = "register_label";
			this.register_label.Size = new System.Drawing.Size(135, 17);
			this.register_label.TabIndex = 7;
			this.register_label.Text = "Click here for register";
			this.register_label.Click += new System.EventHandler(this.register_label_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(50, 312);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "If you have no account?";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// login_password
			// 
			this.login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.login_password.Location = new System.Drawing.Point(75, 186);
			this.login_password.Name = "login_password";
			this.login_password.PasswordChar = '*';
			this.login_password.Size = new System.Drawing.Size(249, 26);
			this.login_password.TabIndex = 4;
			this.login_password.Text = "Admin12345.!!";
			this.login_password.TextChanged += new System.EventHandler(this.login_password_TextChanged);
			this.login_password.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			// 
			// login_email
			// 
			this.login_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.login_email.Location = new System.Drawing.Point(75, 138);
			this.login_email.Name = "login_email";
			this.login_email.Size = new System.Drawing.Size(249, 26);
			this.login_email.TabIndex = 3;
			this.login_email.Text = "admin@gmail.com";
			this.login_email.TextChanged += new System.EventHandler(this.login_username_TextChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::StockManagmentSystem.Properties.Resources._2020080412331577;
			this.pictureBox1.Location = new System.Drawing.Point(377, 132);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(338, 250);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(724, 30);
			this.panel2.TabIndex = 12;
			this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(724, 548);
			this.Controls.Add(this.close);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button close;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label LoginAccount;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label register_label;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox login_password;
		private System.Windows.Forms.TextBox login_email;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button login_button;
		private System.Windows.Forms.Panel panel2;
	}
}

