using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagmentSystem.Dtos
{
	internal class UserForLoginDto
	{
		[Required(ErrorMessage = "Email is Required")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Password is Required")]
		public string Password { get; set; }
	}
}
