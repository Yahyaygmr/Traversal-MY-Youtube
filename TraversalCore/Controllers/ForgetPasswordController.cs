using AutoMapper.Internal;
using DocumentFormat.OpenXml.Spreadsheet;
using EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using TraversalCore.Models;

namespace TraversalCore.Controllers
{
    [AllowAnonymous]
    public class ForgetPasswordController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ForgetPasswordController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<string> Index(ForgetPassworViewModel model)
        {
            var user =await _userManager.FindByEmailAsync(model.Mail);
            string passwordResetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
            var passwordResetTokenLink = Url.Action("ResetPassword", "ForgetPasswors", new
            {
                userId = user.Id,
                token = passwordResetToken
            }, HttpContext.Request.Scheme);
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailBoxAddresFrom = new MailboxAddress("Admin", "yahyaygmr@gmail.com");
            mimeMessage.From.Add(mailBoxAddresFrom);
            MailboxAddress mailBoxAddresTo = new MailboxAddress("User", model.Mail);
            mimeMessage.To.Add(mailBoxAddresTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = passwordResetTokenLink;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = "Şifre sıfırlama talebi";

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false);
            smtpClient.Authenticate("yahyaygmr@gmail.com", "gmail sifresi");
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);

           return "Şifre Değiştirme Linkiniz Mailinize yollanmıştır";
        }
        [HttpGet]
        public IActionResult ResetPassword(string userId, string token)
        {
            TempData["UserId"] = userId;
            TempData["token"] = token;

            return View();

			//return RedirectToAction("SignIn", "Login");
		}
		[HttpPost]
		public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
		{
            var userId = TempData["UserId"];
            var token = TempData["token"];
            if (userId == null || token == null)
            {
                //hata mesajı
            }
            var user = await _userManager.FindByIdAsync(userId.ToString());
			var result = await _userManager.ResetPasswordAsync(user, token.ToString(), model.Password);
            if (result.Succeeded)
            {
				return RedirectToAction("SignIn", "Login");
			}
            return View(model);
		}
			

	}
}
