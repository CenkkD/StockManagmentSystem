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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagmentSystem
{
	public partial class DeleteAccount : Form
	{
		public DeleteAccount()
		{
			InitializeComponent();
		}

		private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private async void DeleteAccount_Load(object sender, EventArgs e)
		{
			HttpClient client = new HttpClient();

			var response = await client.GetAsync("https://localhost:7270/api/account/Listallusers");

			if (response.IsSuccessStatusCode == true)
			{
				var registrationResponse = JsonConvert.DeserializeObject<List<UserDeleteDto>>(await response.Content.ReadAsStringAsync());


				dataGridView1.DataSource = registrationResponse;

			}
		}



		private async void Delete_Button_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				var selectedRow = dataGridView1.SelectedRows[0];
				List<string> selectedRowValues = new List<string>();
				var id = selectedRow.Cells[0].Value?.ToString();
				var firstname = selectedRow.Cells[1].Value?.ToString();
				var lastname = selectedRow.Cells[2].Value?.ToString();

				HttpClient client = new HttpClient();

				var mycontent = JsonConvert.SerializeObject(id);
				var buffer = Encoding.UTF8.GetBytes(mycontent);
				var bytecontent = new ByteArrayContent(buffer);
				bytecontent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

				var response = await client.PostAsync("https://localhost:7270/api/account/delete", bytecontent);
				if (response.IsSuccessStatusCode == true)
				{
					MessageBox.Show($" User  {firstname} {lastname} Deleted:");
					
					
				}



			}
			Utils.Utils.RefreshDataGrid(dataGridView1);
	
		}



		private async void role_changer_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				var selectedRow = dataGridView1.SelectedRows[0];
				List<string> selectedRowValues = new List<string>();
				var id = selectedRow.Cells[0].Value?.ToString();
				var firstname = selectedRow.Cells[1].Value?.ToString();
				var lastname = selectedRow.Cells[2].Value?.ToString();
				var newrolename = comboBox1.SelectedItem.ToString();

				var userRoleChange=new UserRoleChangeDto()
				{ 
					Id = id,
					RoleName=newrolename,

				};




				HttpClient client = new HttpClient();

				var mycontent = JsonConvert.SerializeObject(userRoleChange);

				var buffer = Encoding.UTF8.GetBytes(mycontent);
				var bytecontent = new ByteArrayContent(buffer);
				bytecontent.Headers.ContentType = new MediaTypeHeaderValue("application/json");


				var response = await client.PostAsync("https://localhost:7270/api/account/rolechanger", bytecontent);
				
				if (response.IsSuccessStatusCode == true)
				{
					MessageBox.Show($" User  {firstname} {lastname} Role Changed o {newrolename} :");

					Utils.Utils.RefreshDataGrid(dataGridView1);


				}

				

			}
		}
		

	}
}
