using Newtonsoft.Json;
using StockManagmentSystem.Data;
using StockManagmentSystem.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagmentSystem
{

	public partial class Form1 : Form
	{
		public Form1()
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




		
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void register_label_Click(object sender, EventArgs e)
		{
			RegisterForm regForm = new RegisterForm();
			regForm.Show();
			this.Hide();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void LoginAccount_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}



		private void login_password_TextChanged(object sender, EventArgs e)
		{

		}

		private void login_username_TextChanged(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private async void login_button_Click(object sender, EventArgs e)
		{

			HttpClient client = new HttpClient();
			var loginDto = new UserForLoginDto()
			{
				Email = login_email.Text,
				Password = login_password.Text,
			};
			var myContent = JsonConvert.SerializeObject(loginDto);
			var buffer = Encoding.UTF8.GetBytes(myContent);
			var byteContent = new ByteArrayContent(buffer);
			byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

			var response = await client.PostAsync("https://localhost:7270/api/account/login", byteContent);
			if (response.IsSuccessStatusCode == true)
			{
				var loginResponse = JsonConvert.DeserializeObject<LoginResponseDto>(await response.Content.ReadAsStringAsync());
				if (loginResponse.IsSuccessfulLogin == true)
				{

					StaticData.USER = new ActiveUserDto()
					{
						Email = loginResponse.Email,
						FirstName = loginResponse.FirstName,
						LastName = loginResponse.LastName,
					};

					MainForm mainForm = new MainForm();
					mainForm.Show();
					this.Hide();

				}

			}



		}
	}
}

