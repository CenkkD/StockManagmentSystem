namespace StockManagmentSystem
{
	partial class Dashboard
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
			this.label3 = new System.Windows.Forms.Label();
			this.FirstName = new System.Windows.Forms.Label();
			this.LastName = new System.Windows.Forms.Label();
			this.Email = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.YourDaily = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Left;
			this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "Welcome";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// FirstName
			// 
			this.FirstName.AutoSize = true;
			this.FirstName.Dock = System.Windows.Forms.DockStyle.Left;
			this.FirstName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.FirstName.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.FirstName.Location = new System.Drawing.Point(108, 0);
			this.FirstName.Name = "FirstName";
			this.FirstName.Size = new System.Drawing.Size(120, 25);
			this.FirstName.TabIndex = 4;
			this.FirstName.Text = "FirstName";
			// 
			// LastName
			// 
			this.LastName.AutoSize = true;
			this.LastName.Dock = System.Windows.Forms.DockStyle.Left;
			this.LastName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.LastName.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.LastName.Location = new System.Drawing.Point(228, 0);
			this.LastName.Name = "LastName";
			this.LastName.Size = new System.Drawing.Size(118, 25);
			this.LastName.TabIndex = 5;
			this.LastName.Text = "LastName";
			this.LastName.Click += new System.EventHandler(this.LastName_Click);
			// 
			// Email
			// 
			this.Email.AutoSize = true;
			this.Email.Dock = System.Windows.Forms.DockStyle.Left;
			this.Email.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Email.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.Email.Location = new System.Drawing.Point(346, 0);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(70, 25);
			this.Email.TabIndex = 6;
			this.Email.Text = "Email";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(135, 213);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(596, 329);
			this.listBox1.TabIndex = 7;
			// 
			// YourDaily
			// 
			this.YourDaily.AutoSize = true;
			this.YourDaily.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.YourDaily.Location = new System.Drawing.Point(130, 185);
			this.YourDaily.Name = "YourDaily";
			this.YourDaily.Size = new System.Drawing.Size(67, 25);
			this.YourDaily.TabIndex = 8;
			this.YourDaily.Text = "label3";
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(910, 613);
			this.Controls.Add(this.YourDaily);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.Email);
			this.Controls.Add(this.LastName);
			this.Controls.Add(this.FirstName);
			this.Controls.Add(this.label3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Dashboard";
			this.Text = "Dashboard";
			this.Load += new System.EventHandler(this.Dashboard_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label FirstName;
		private System.Windows.Forms.Label LastName;
		private System.Windows.Forms.Label Email;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label YourDaily;
	}
}