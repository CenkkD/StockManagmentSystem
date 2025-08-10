using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagmentSystem.Dtos
{
	internal class UserRoleChangeDto
	{
		[Required(ErrorMessage = "User Id is Required")]
		public string Id { get; set; }

		public string RoleName { get; set; }
	}
}
