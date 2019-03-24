using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using asvs_labs.Models;
using Microsoft.AspNetCore.Authorization;
using asvslabs.Models;
using Authentication.API.Models;
using asvslabs.ViewModels;

namespace asvs_labs.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        private IdentityContext IdentityContext;
        public HomeController(IdentityContext db) { IdentityContext = db; }

        public IActionResult Index()
        {
            var jobList = IdentityContext.Jobs;
            JobViewModel model = new JobViewModel();
            model.JobList = new List<JobViewModel>(); 

            if (jobList != null)
            {
                foreach (JobModel x in jobList)
                {
                    model.JobList.Add(new JobViewModel 
                    { 
                        Title = x.Title,
                        Description = x.Description,
                        Webiste = x.Category,
                        Employment = x.Employment,
                        Skills = x.Skills,
                        Price = x.Price 
                    });
                }
            }
            return View(model);
        }

        public IActionResult PostJob(JobViewModel model)
        {
            JobModel addJob = new JobModel { 
                Title = model.Title,
                Category = model.Webiste,
                Description = model.Description,
                Skills = model.Skills,
                Employment = model.Employment,
                Price = model.Price,
            };

            IdentityContext.Jobs.Add(addJob);
            IdentityContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult GetJobs()
        {
            return View();
        }

        public IActionResult DeleteJob()
        {
            return View();
        }
    }
}
