using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Gljivar.Service;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace Gljivar.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserService _userService;

        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            // Check if user is logged in
            if (User.Identity.IsAuthenticated)
                // Redirect user to home page
                return RedirectToAction("Index", "Objava");

            ViewBag.LogErr = false;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string name, string password)
        {
            //ako ne postoji vrati ga na postojeci view s upozorenjem
            if (!_userService.checkUser(name, password))
            {
                ViewBag.LogErr = true;
                return View();
            }

            // funkcija koja radi novi identitet za korisnika i sprema taj identitet
            await ClaimsIdentity(name);

            // Redirect user to home page
            return RedirectToAction("Index", "Objava");
        }

        public async Task<IActionResult> Logout()
        {
            // Logout user from application
            await HttpContext.SignOutAsync();

            ViewBag.userName = null;

            return RedirectToAction("Index", "Objava");
        }

        #region Private methods      
        /// <summary>
        /// Calling this function when we want to save authentication
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        private async Task ClaimsIdentity(string username)
        {
            // Create identity for logged user
            var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);

            // Add username for name in identity
            identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, username));
            identity.AddClaim(new Claim(ClaimTypes.Name, username));

            // Create principal
            var principal = new ClaimsPrincipal(identity);

            // Save authentication 
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties { IsPersistent = true });
        }
        #endregion
    }
}