using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Models
{
	public class LoginViewModel
	{
		[Required(ErrorMessage ="Kullanıcı adı boş olamaz")]
		public string Username { get; set; }
		[Required(ErrorMessage = "Şifre boş olamaz")]
		public string Password { get; set; }
	}
}
