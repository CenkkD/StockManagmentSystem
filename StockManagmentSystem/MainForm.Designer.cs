namespace StockManagmentSystem
{
	partial class MainForm
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
			this.LoginAccount = new System.Windows.Forms.Label();
			this.close = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.delete_user_button = new System.Windows.Forms.Button();
			this.StockListButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.AddProductButton = new System.Windows.Forms.Button();
			this.DashBoardButton = new System.Windows.Forms.Button();
			this.MainPanel = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(153)))));
			this.panel1.Controls.Add(this.LoginAccount);
			this.panel1.Controls.Add(this.close);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1217, 61);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			// 
			// LoginAccount
			// 
			this.LoginAccount.AutoSize = true;
			this.LoginAccount.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginAccount.ForeColor = System.Drawing.Color.White;
			this.LoginAccount.Location = new System.Drawing.Point(10, 12);
			this.LoginAccount.Name = "LoginAccount";
			this.LoginAccount.Size = new System.Drawing.Size(366, 33);
			this.LoginAccount.TabIndex = 11;
			this.LoginAccount.Text = "Stock Managment System";
			this.LoginAccount.Click += new System.EventHandler(this.LoginAccount_Click);
			this.LoginAccount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			// 
			// close
			// 
			this.close.BackColor = System.Drawing.Color.Firebrick;
			this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.close.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.close.Location = new System.Drawing.Point(1127, 12);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(67, 27);
			this.close.TabIndex = 10;
			this.close.Text = "X";
			this.close.UseVisualStyleBackColor = false;
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(153)))));
			this.pictureBox1.Image = global::StockManagmentSystem.Properties.Resources._2020080412331577;
			this.pictureBox1.Location = new System.Drawing.Point(0, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(304, 183);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(153)))));
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Controls.Add(this.pictureBox1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Location = new System.Drawing.Point(0, 61);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(307, 613);
			this.panel4.TabIndex = 14;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(153)))));
			this.panel5.Controls.Add(this.delete_user_button);
			this.panel5.Controls.Add(this.StockListButton);
			this.panel5.Controls.Add(this.label2);
			this.panel5.Controls.Add(this.AddProductButton);
			this.panel5.Controls.Add(this.DashBoardButton);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel5.Location = new System.Drawing.Point(0, 212);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(307, 401);
			this.panel5.TabIndex = 14;
			// 
			// delete_user_button
			// 
			this.delete_user_button.Dock = System.Windows.Forms.DockStyle.Top;
			this.delete_user_button.FlatAppearance.BorderSize = 0;
			this.delete_user_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.delete_user_button.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.delete_user_button.ForeColor = System.Drawing.Color.White;
			this.delete_user_button.Location = new System.Drawing.Point(0, 180);
			this.delete_user_button.Name = "delete_user_button";
			this.delete_user_button.Size = new System.Drawing.Size(307, 60);
			this.delete_user_button.TabIndex = 19;
			this.delete_user_button.Text = "User Delete / Role Change";
			this.delete_user_button.UseVisualStyleBackColor = true;
			this.delete_user_button.Click += new System.EventHandler(this.delete_user_button_Click);
			// 
			// StockListButton
			// 
			this.StockListButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.StockListButton.FlatAppearance.BorderSize = 0;
			this.StockListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.StockListButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.StockListButton.ForeColor = System.Drawing.Color.White;
			this.StockListButton.Location = new System.Drawing.Point(0, 120);
			this.StockListButton.Name = "StockListButton";
			this.StockListButton.Size = new System.Drawing.Size(307, 60);
			this.StockListButton.TabIndex = 18;
			this.StockListButton.Text = "Stock List";
			this.StockListButton.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(3, 317);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(214, 33);
			this.label2.TabIndex = 14;
			this.label2.Text = "Welcome, Admin";
			// 
			// AddProductButton
			// 
			this.AddProductButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.AddProductButton.FlatAppearance.BorderSize = 0;
			this.AddProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddProductButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.AddProductButton.ForeColor = System.Drawing.Color.White;
			this.AddProductButton.Location = new System.Drawing.Point(0, 60);
			this.AddProductButton.Name = "AddProductButton";
			this.AddProductButton.Size = new System.Drawing.Size(307, 60);
			this.AddProductButton.TabIndex = 17;
			this.AddProductButton.Text = "Add Products";
			this.AddProductButton.UseVisualStyleBackColor = true;
			// 
			// DashBoardButton
			// 
			this.DashBoardButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.DashBoardButton.FlatAppearance.BorderSize = 0;
			this.DashBoardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DashBoardButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.DashBoardButton.ForeColor = System.Drawing.Color.White;
			this.DashBoardButton.Location = new System.Drawing.Point(0, 0);
			this.DashBoardButton.Name = "DashBoardButton";
			this.DashBoardButton.Size = new System.Drawing.Size(307, 60);
			this.DashBoardButton.TabIndex = 13;
			this.DashBoardButton.Text = "Dashboard";
			this.DashBoardButton.UseVisualStyleBackColor = true;
			this.DashBoardButton.Click += new System.EventHandler(this.DashBoardButton_Click);
			// 
			// MainPanel
			// 
			this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainPanel.Location = new System.Drawing.Point(307, 61);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new System.Drawing.Size(910, 613);
			this.MainPanel.TabIndex = 20;
			this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DashboardPanel_Paint);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1217, 674);
			this.Controls.Add(this.MainPanel);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button close;
		private System.Windows.Forms.Label LoginAccount;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button StockListButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button AddProductButton;
		private System.Windows.Forms.Button DashBoardButton;
		private System.Windows.Forms.Panel MainPanel;
		private System.Windows.Forms.Button delete_user_button;
	}
}