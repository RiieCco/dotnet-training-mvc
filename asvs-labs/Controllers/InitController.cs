using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asvslabs.Models;
using Authentication.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace asvslabs.Controllers
{
  public class InitController : Controller
  {

    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IConfiguration _configuration;
    private IdentityContext IdentityContext;

    public InitController
      (
      UserManager<IdentityUser> userManager,
      SignInManager<IdentityUser> signInManager,
      IConfiguration configuration,
      IdentityContext db
      )
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _configuration = configuration;
      IdentityContext = db;
    }

    // GET: /<controller>/
    public IActionResult Index()
    {
      var user1 = new IdentityUser{UserName = "user1", Email = "user1@user1.com"};
      var user2 = new IdentityUser{UserName = "user2", Email = "user2@user2.com"};
      _userManager.CreateAsync(user2, "Password01!");
      _userManager.CreateAsync(user1, "Password01!");

      JobModel wordpress = new JobModel { Title = "Wordpress Developer", Description = "We are looking for a new wordpress developer that has a lot of good experience writing his own plugins. we need this to customize websites for our customers to give them the post possible results!", Website = "https://wordpress.com", Employment = "40", Skills="PHP, CSS, JS, HMTL", Price= 60};
      JobModel appsec = new JobModel { Title = "Application security specialist", Description = "We are looking for an expert security specialist to help us with doing security testing on our web applications. It is a pre id you know OWASP and ASVS and how to set up security test automation in CI/CD pipelines", Website = "https://owasp.org", Employment = "40", Skills = "Docker, OWASP, Appsec", Price = 150 };
      IdentityContext.Jobs.Add(wordpress);
      IdentityContext.Jobs.Add(appsec);

      IdentityContext.SaveChanges();

      return RedirectToAction("Index", "Home");
    }
  }
}
