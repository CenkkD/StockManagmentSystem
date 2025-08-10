using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagmentSystem
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void LoginAccount_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void DashBoardButton_Click(object sender, EventArgs e)
		{
			Dashboard dashboardForm = new Dashboard();
			dashboardForm.TopLevel = false;
			dashboardForm.AutoScroll = true;
			MainPanel.Controls.Clear();
			MainPanel.Controls.Add(dashboardForm);
			MainPanel.Controls[0].Show();
		}

		private void close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		

		private void DashboardPanel_Paint(object sender, PaintEventArgs e)
		{
			Dashboard dashboardForm = new Dashboard();
			dashboardForm.TopLevel = false;
			dashboardForm.AutoScroll=true;
			MainPanel.Controls.Add(dashboardForm);
			MainPanel.Controls[0].Dock = DockStyle.Fill;
			MainPanel.Controls[0].Show();

		}

		private void button9_Click(object sender, EventArgs e)
		{

		}

		private void delete_user_button_Click(object sender, EventArgs e)
		{
			DeleteAccount deleteForm = new DeleteAccount();
			deleteForm.TopLevel = false;
			deleteForm.AutoScroll = true;
			MainPanel.Controls.Clear();
			MainPanel.Controls.Add(deleteForm);
			MainPanel.Controls[0].Dock = DockStyle.Fill;
			MainPanel.Controls[0].Show();
		}
	}
}
