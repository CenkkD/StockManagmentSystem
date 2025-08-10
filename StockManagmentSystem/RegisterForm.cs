using Newtonsoft.Json;
using StockManagmentSystem.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace StockManagmentSystem
{
	public partial class RegisterForm : Form
	{
		public RegisterForm()
		{
			InitializeComponent();
		}

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		private void RegisterForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private async void login_btn_Click(object sender, EventArgs e)
		{
			HttpClient client = new HttpClient();
			var registrationDto = new UserForRegistrationDto()
			{
				FirstName = firstNameTextBox.Text,
				LastName = lastNameTextBox.Text,
				Email = eMailTextBox.Text,
				Password = registerPassword.Text,
				ConfirmPassword = register_cPassword.Text,

			};
			var myContent = JsonConvert.SerializeObject(registrationDto);
			var buffer = Encoding.UTF8.GetBytes(myContent);
			var byteContent = new ByteArrayContent(buffer);
			byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

			var response = await client.PostAsync("https://localhost:7270/api/account/register", byteContent);

			if (response.IsSuccessStatusCode == true)
			{
				var registrationResponse = JsonConvert.DeserializeObject<RegistrationResponseDto>(await response.Content.ReadAsStringAsync());
				if (registrationResponse.IsSuccessfulRegistration==true)
				{


					if (MessageBox.Show("Succesfully Registered", "Continue to login", MessageBoxButtons.OK) == DialogResult.OK) ;
					{
						Form1 loginForm = new Form1();
						loginForm.Show();
						this.Hide();
					}
				}
			}
			else
			{
				MessageBox.Show("Email or Password is not valid");
			}		
		}
		private void close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void login_label_Click(object sender, EventArgs e)
		{
			Form1 loginForm = new Form1();
			loginForm.Show();
			this.Hide();
		}

		private void RegisterForm_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void register_cPassword_TextChanged(object sender, EventArgs e)
		{

		}

		private void register_password_TextChanged(object sender, EventArgs e)
		{

		}

		private void register_username_TextChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}
