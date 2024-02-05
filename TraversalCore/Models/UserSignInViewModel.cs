using System.ComponentModel.DataAnnotations;

namespace TraversalCore.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Girin !")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Girin !")]
        public string Password { get; set; }
    }
}
