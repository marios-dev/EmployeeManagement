using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    public class AccountController : Controller
    {
        // Get: /<controller>/
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
    }
}
