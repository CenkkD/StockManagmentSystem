using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagmentSystem.Dtos
{
	public class UserForRegistrationDto
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		[Required(ErrorMessage = "Email is Required")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Password is Required")]
		public string Password { get; set; }
		[Compare("Password", ErrorMessage = "Passsword and Confirmation Password are not match")]
		public string ConfirmPassword { get; set; }
	}
}
