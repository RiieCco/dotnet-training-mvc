using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asvslabs.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace asvslabs.Controllers
{
  public class AccountController : Controller
  {

    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IConfiguration _configuration;

    public AccountController
      (
      UserManager<IdentityUser> userManager,
      SignInManager<IdentityUser> signInManager,
      IConfiguration configuration
      )
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _configuration = configuration;
    }

    // GET: /<controller>/
    public IActionResult Index()
    {
      return View(new AccountRegisterViewModel());
    }

    public async Task<IActionResult> Login(AccountRegisterViewModel model)
    {
      var result = await _signInManager.PasswordSignInAsync(model.LoginViewModel.Email, model.LoginViewModel.Password, false, false);

      if (result.Succeeded)
      {
        return RedirectToAction("Index", "Home");
      }
      else
      {
        return RedirectToAction("Index", "Account");
      }
    }

    public async Task<IActionResult> Register(AccountRegisterViewModel model)
    {
      if (ModelState.IsValid)
      {
        var user = new IdentityUser
        {
          UserName = model.RegisterViewModel.Email,
          Email = model.RegisterViewModel.Email
        };
        var result = await _userManager.CreateAsync(user, model.RegisterViewModel.Password);

        if (result.Succeeded)
        {
          await _signInManager.SignInAsync(user, false);
          return RedirectToAction("Index", "Home");
        }
        else
        {
          return RedirectToAction("Index", "Account");
        }
      }
      else
      {
        return RedirectToAction("Index", "Account");
      }
    }

    // GET: /<controller>/
    public IActionResult Logout()
    {
      _signInManager.SignOutAsync();
      return RedirectToAction("Index", "Home");

    }
  }
}
