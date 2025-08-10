using Newtonsoft.Json;
using StockManagmentSystem.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagmentSystem.Utils
{
	public static class Utils
	{
		public static async void RefreshDataGrid(DataGridView dataGrid)
		{
			//DeleteAccount deleteForm = new DeleteAccount();
			//deleteForm.TopLevel = false;
			//deleteForm.AutoScroll = true;
			//MainPanel.Controls.Clear();
			//MainPanel.Controls.Add(deleteForm);
			//MainPanel.Controls[0].Dock = DockStyle.Fill;
			//MainPanel.Controls[0].Show();
			HttpClient client1 = new HttpClient();

			var responsee = await client1.GetAsync("https://localhost:7270/api/account/Listallusers");

			if (responsee.IsSuccessStatusCode == true)
			{
				var registrationResponse = JsonConvert.DeserializeObject<List<UserDeleteDto>>(await responsee.Content.ReadAsStringAsync());


				dataGrid.DataSource = registrationResponse;

			}
		}


	}
}
