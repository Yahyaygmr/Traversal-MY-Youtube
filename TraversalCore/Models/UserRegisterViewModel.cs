using System.ComponentModel.DataAnnotations;

namespace TraversalCore.Models
{
	public class UserRegisterViewModel
	{
        [Required(ErrorMessage ="Lütfen Adınızı Girin !")]
        public string Name { get; set; }

		[Required(ErrorMessage = "Lütfen Soyadınızı Girin !")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Lütfen Email Adresinizi Girin !")]
		public string Email { get; set; }

        public string UserName { get; set; }

		[Required(ErrorMessage = "Lütfen Şifrenizi Girin !")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Lütfen Şifrenizi Tekrar Girin !")]
		[Compare("Password",ErrorMessage ="Şifreler Aynı Değil !")]
		public string ConfirmPassword { get; set; }


    }
}
