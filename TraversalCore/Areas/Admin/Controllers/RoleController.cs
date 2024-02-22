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

        public RoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
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
    }
}
