using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asvslabs.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace asvslabs.ViewModels
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class JobViewModel
    {
        public List<JobViewModel> JobList { get; set; }
        public string Title { get; set; }
        public string Webiste { get; set; }
        public string Skills { get; set; }
        public int Price { get; set; }
        public string Employment { get; set; }
        public string Description { get; set; }
    }
}
