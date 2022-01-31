using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using Domain.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentatie.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        // GET: HomeController1
        public ActionResult Login()
        {
            return View();
        }

        
        // POST: HomeController1/Delete/5
        [HttpPost]
        public IActionResult Login(Account account)
        {
            return View();
        }
    }
}
