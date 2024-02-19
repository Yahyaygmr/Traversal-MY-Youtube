using BusinessLayer.Abstract.AbstractUOW;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCore.Areas.Admin.Models;

namespace TraversalCore.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    [Route("Admin/Account")]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [Route("")]
        [Route("Index")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Index")]
        [HttpPost]
        public IActionResult Index(AccountViewModel model)
        {
            var valuesSender = _accountService.TGetById(model.SenderId);
            var valuesReciever = _accountService.TGetById(model.RecieverId);

            valuesSender.Balance -= model.Amount;
            valuesReciever.Balance += model.Amount;

            List<Account> modifiedAccounts = new List<Account>()
            {
                valuesSender,
                valuesReciever
            };
            _accountService.TMultiUpdate(modifiedAccounts);

            return View();
        }
    }
}
