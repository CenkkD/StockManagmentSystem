using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagmentSystem.Dtos
{
	internal class UserDeleteResponseDto
	{
		public bool IsDeleteSuccessfull { get; set; }
		public string ErrorMessage { get; set; }

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }

	}
}
