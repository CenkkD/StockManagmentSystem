using Newtonsoft.Json;
using StockManagmentSystem.Data;
using StockManagmentSystem.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using StockManagmentSystem.Data;
using StockManagmentSystem.Dtos;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StockManagmentSystem
{
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();
			

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private async void Dashboard_Load(object sender, EventArgs e)
		{
			FirstName.Text = StaticData.USER.FirstName.ToString();
			LastName.Text = StaticData.USER.LastName.ToString();
			Email.Text = StaticData.USER.Email.ToString();
		}

		private void LastName_Click(object sender, EventArgs e)
		{

		}
	}
}
