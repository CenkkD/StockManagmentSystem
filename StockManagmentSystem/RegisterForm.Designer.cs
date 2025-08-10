namespace StockManagmentSystem
{
	partial class RegisterForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.firstNameTextBox = new System.Windows.Forms.TextBox();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.register_cPassword = new System.Windows.Forms.TextBox();
			this.LoginAccount = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.login_label = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.signup_btn = new System.Windows.Forms.Button();
			this.registerPassword = new System.Windows.Forms.TextBox();
			this.eMailTextBox = new System.Windows.Forms.TextBox();
			this.close = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(153)))));
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.firstNameTextBox);
			this.panel1.Controls.Add(this.lastNameTextBox);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.register_cPassword);
			this.panel1.Controls.Add(this.LoginAccount);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.login_label);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.signup_btn);
			this.panel1.Controls.Add(this.registerPassword);
			this.panel1.Controls.Add(this.eMailTextBox);
			this.panel1.Location = new System.Drawing.Point(-1, 60);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(372, 423);
			this.panel1.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.Control;
			this.label6.Location = new System.Drawing.Point(5, 110);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 17);
			this.label6.TabIndex = 16;
			this.label6.Text = "First Name";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.Control;
			this.label5.Location = new System.Drawing.Point(5, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 17);
			this.label5.TabIndex = 15;
			this.label5.Text = "Last Name";
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.firstNameTextBox.Location = new System.Drawing.Point(84, 104);
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(249, 26);
			this.firstNameTextBox.TabIndex = 14;
			this.firstNameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lastNameTextBox.Location = new System.Drawing.Point(84, 146);
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(249, 26);
			this.lastNameTextBox.TabIndex = 13;
			this.lastNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(5, 275);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 17);
			this.label2.TabIndex = 12;
			this.label2.Text = "Password";
			// 
			// register_cPassword
			// 
			this.register_cPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.register_cPassword.Location = new System.Drawing.Point(84, 269);
			this.register_cPassword.Name = "register_cPassword";
			this.register_cPassword.PasswordChar = '*';
			this.register_cPassword.Size = new System.Drawing.Size(249, 26);
			this.register_cPassword.TabIndex = 11;
			this.register_cPassword.TextChanged += new System.EventHandler(this.register_cPassword_TextChanged);
			// 
			// LoginAccount
			// 
			this.LoginAccount.AutoSize = true;
			this.LoginAccount.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginAccount.ForeColor = System.Drawing.SystemColors.Control;
			this.LoginAccount.Location = new System.Drawing.Point(78, 45);
			this.LoginAccount.Name = "LoginAccount";
			this.LoginAccount.Size = new System.Drawing.Size(129, 33);
			this.LoginAccount.TabIndex = 10;
			this.LoginAccount.Text = "Register";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(3, 192);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 17);
			this.label4.TabIndex = 9;
			this.label4.Text = "Password";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(5, 233);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "E-Mail";
			// 
			// login_label
			// 
			this.login_label.AutoSize = true;
			this.login_label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_label.ForeColor = System.Drawing.Color.AliceBlue;
			this.login_label.Location = new System.Drawing.Point(214, 382);
			this.login_label.Name = "login_label";
			this.login_label.Size = new System.Drawing.Size(119, 17);
			this.login_label.TabIndex = 7;
			this.login_label.Text = "Click here for login";
			this.login_label.Click += new System.EventHandler(this.login_label_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(28, 382);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Already have an account?";
			// 
			// signup_btn
			// 
			this.signup_btn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.signup_btn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.signup_btn.Location = new System.Drawing.Point(84, 321);
			this.signup_btn.Name = "signup_btn";
			this.signup_btn.Size = new System.Drawing.Size(249, 45);
			this.signup_btn.TabIndex = 6;
			this.signup_btn.Text = "SignUp";
			this.signup_btn.UseVisualStyleBackColor = true;
			this.signup_btn.Click += new System.EventHandler(this.login_btn_Click);
			// 
			// registerPassword
			// 
			this.registerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.registerPassword.Location = new System.Drawing.Point(84, 227);
			this.registerPassword.Name = "registerPassword";
			this.registerPassword.PasswordChar = '*';
			this.registerPassword.Size = new System.Drawing.Size(249, 26);
			this.registerPassword.TabIndex = 4;
			this.registerPassword.TextChanged += new System.EventHandler(this.register_password_TextChanged);
			// 
			// eMailTextBox
			// 
			this.eMailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.eMailTextBox.Location = new System.Drawing.Point(84, 186);
			this.eMailTextBox.Name = "eMailTextBox";
			this.eMailTextBox.Size = new System.Drawing.Size(249, 26);
			this.eMailTextBox.TabIndex = 3;
			this.eMailTextBox.TextChanged += new System.EventHandler(this.register_username_TextChanged);
			// 
			// close
			// 
			this.close.BackColor = System.Drawing.Color.Firebrick;
			this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.close.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.close.Location = new System.Drawing.Point(643, 0);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(82, 30);
			this.close.TabIndex = 12;
			this.close.Text = "X";
			this.close.UseVisualStyleBackColor = false;
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::StockManagmentSystem.Properties.Resources._2020080412331577;
			this.pictureBox1.Location = new System.Drawing.Point(377, 132);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(338, 250);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(724, 30);
			this.panel2.TabIndex = 15;
			this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(724, 548);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.close);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "RegisterForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RegisterForm";
			this.Load += new System.EventHandler(this.RegisterForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label LoginAccount;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label login_label;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button signup_btn;
		private System.Windows.Forms.TextBox registerPassword;
		private System.Windows.Forms.TextBox eMailTextBox;
		private System.Windows.Forms.Button close;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox register_cPassword;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel2;
	}
}