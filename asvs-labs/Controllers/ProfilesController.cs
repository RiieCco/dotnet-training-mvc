using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asvslabs.ViewModels;
using Authentication.API.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace asvslabs.Controllers
{
  public class ProfilesController : Controller
  {
    private IdentityContext IdentityContext;
    public ProfilesController(IdentityContext db) { IdentityContext = db; }

    // GET: /<controller>/
    public IActionResult Index()
    {
      var userId = User.Identity.Name;
      var users = IdentityContext.Users.Where(x => x.UserName != userId).ToList();
      ProfileViewModel model = new ProfileViewModel();
      model.UserList = new List<ProfileViewModel>();

      foreach (var profiles in users)
      {
        model.UserList.Add(new ProfileViewModel
        {
          UserName = profiles.UserName,
          userId = profiles.Id
        });
      }
      return View(model);
    }
  }
}
