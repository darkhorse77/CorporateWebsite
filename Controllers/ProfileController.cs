using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using CorporateWebsite.Models;
using CorporateWebsite.ViewModels;

namespace CorporateWebsite.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<User> _userManager;

        public ProfileController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }
            User currentUser = await _userManager.FindByIdAsync(this.User.FindFirst(ClaimTypes.NameIdentifier).Value);
            if (currentUser == null)
            {
                //todo throw
                return RedirectToAction("Index", "Home");
            }
            return View(new ProfileViewModel { UserName = currentUser.UserName, FirstName = currentUser.FirstName, LastName = currentUser.LastName, Patronymic = currentUser.Patronymic, Roles = _userManager.GetRolesAsync(currentUser).Result.ToList() });
        }     
    }
}