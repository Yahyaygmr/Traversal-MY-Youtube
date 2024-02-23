using System.ComponentModel.DataAnnotations;

namespace TraversalCore.Models
{
	public class ResetPasswordViewModel
	{
        public string Password { get; set; }
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
