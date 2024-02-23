using DocumentFormat.OpenXml.Office2010.Excel;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalCore.Areas.Admin.Models;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Role")]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public RoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var roles = _roleManager.Roles.ToList();
            return View(roles);
        }
        [HttpGet]
        [Route("CreateRole")]
        public IActionResult CreateRole()
        {

            return View();
        }
        [HttpPost]
        [Route("CreateRole")]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            AppRole role = new AppRole()
            {
                Name = model.RoleName
            };
            var result = await _roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [Route("DeleteRole/{id}")]
        public async Task<IActionResult> DeleteRole(int id)
        {
            var role = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            await _roleManager.DeleteAsync(role);
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("UpdateRole/{id}")]
        public IActionResult UpdateRole(int id)
        {
            var role = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            UpdateRoleViewModel model = new UpdateRoleViewModel()
            {
                Id = role.Id,
                RoleName = role.Name
            };
            return View(model);
        }
        [HttpPost]
        [Route("UpdateRole/{id}")]
        public async Task<IActionResult> UpdateRole(UpdateRoleViewModel model)
        {
            var role = _roleManager.Roles.FirstOrDefault(x => x.Id == model.Id);
            role.Name = model.RoleName;
            await _roleManager.UpdateAsync(role);
            return RedirectToAction("Index");
        }
        [Route("UserList")]
        public IActionResult UserList()
        {
            var users = _userManager.Users.ToList();

            return View(users);
        }
        [HttpGet]
        [Route("AssignRole/{id}")]
        public async Task<IActionResult> AssignRole(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            TempData["UserId"] = user.Id;
            var roles = _roleManager.Roles.ToList();
            var userRoles = await _userManager.GetRolesAsync(user);
            List<RoleAssignViewModel> roleAssignViewModel = new List<RoleAssignViewModel>();
            foreach (var role in roles)
            {
                RoleAssignViewModel model = new RoleAssignViewModel()
                {
                    RoleId = role.Id,
                    RoleName = role.Name,
                    RoleExist = userRoles.Contains(role.Name)
                };
                roleAssignViewModel.Add(model);
            }

            return View(roleAssignViewModel);
        }
        [HttpPost]
        [Route("AssignRole/{id}")]
        public async Task<IActionResult> AssignRole(List<RoleAssignViewModel> model)
        {
            var userId = (int)TempData["UserId"];
            var user = _userManager.Users.FirstOrDefault(x => x.Id == userId);
            foreach (var item in model)
            {
                if (item.RoleExist)
                {
                    await _userManager.AddToRoleAsync(user, item.RoleName);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);
                }
            }
            return RedirectToAction("UserList");
        }
    }
}
