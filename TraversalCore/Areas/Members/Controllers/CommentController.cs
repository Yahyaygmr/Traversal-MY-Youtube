﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Members.Controllers
{
    [AllowAnonymous]
    [Area("Members")]
    [Route("Members/[controller]/[Action]")]
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
