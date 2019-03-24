using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asvslabs.Models;
using asvslabs.ViewModels;
using Authentication.API.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace asvslabs.Controllers
{
    public class JobController : Controller
    {
        private IdentityContext IdentityContext;
        public JobController(IdentityContext db) { IdentityContext = db; }
         
        // GET: /<controller>/
        public IActionResult PostJob(JobViewModel model)
        {
            JobModel addJob = new JobModel { Category = model.Category, Description = model.Description  };

            IdentityContext.Jobs.Add(addJob);
            IdentityContext.SaveChanges();
            return View();
        }
    }
}
