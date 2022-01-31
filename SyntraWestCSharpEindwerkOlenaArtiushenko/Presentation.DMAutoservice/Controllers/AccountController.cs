using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Presentation.DMAutoservice.Models.AccountModels;
using Presentation.DMAutoservice.Models.SessionModels;
using Presentation.Website;
using Services;

namespace Presentation.DMAutoservice.Controllers
{
    public class AccountController : Controller
    {
        private IAccountService _accountSerivce;

        public AccountController(IAccountService accountSerivce)
        {
            _accountSerivce = accountSerivce;
        }

        public IActionResult Logout()
        {
            RemoveAccountSession();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View(new AccountRegisterViewModel());
        }

        [HttpPost]
        public IActionResult Register(AccountRegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (_accountSerivce.IsRegistered(model.UserName))
            {
                model.ErrorMessage = "Username must be unique";
                return View(model);
            }

            var userId = _accountSerivce.CreateAccount(model.UserName, model.Password1);

            _accountSerivce.AddReadRightsToAccount(userId);
            SetAccountSession(model.UserName);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Login()
        {
            return View(new AccountLoginViewModel());
        }

        [HttpPost]
        public IActionResult Login(AccountLoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (!_accountSerivce.IsRegistered(model.UserName))
            {
                model.ErrorMessage = "User is not registered.";
                return View(model);
            }

            if (!_accountSerivce.IsPasswordCorrect(model.UserName, model.Password))
            {
                model.ErrorMessage = "Password is not correct.";
                return View(model);
            }

            SetAccountSession(model.UserName);

            return RedirectToAction("Index", "Home");
        }

        private void SetAccountSession(string username)
        {
            var account = _accountSerivce.GetAccount(username);

            var accountSession = new AccountSession
            {
                UserName = account.LoginName,
                UserId = account.Id,
                Rights = account.AccountRights
                    .Select(x => x.Right.InternalCode)
                    .ToList()
            };

            var json = JsonConvert.SerializeObject(accountSession);

            HttpContext.Session.SetString(AccountSessionHelper.SessionKey, json);
        }

        private void RemoveAccountSession()
        {
            HttpContext.Session.Remove(AccountSessionHelper.SessionKey);
        }
    }
}
