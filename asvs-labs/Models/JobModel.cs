using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace asvslabs.Models
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class JobModel
    {
        [Key]
        public int jobID { get; set; }
        public string Title { get; set; } 
        public string Category { get; set; }
        public string Skills { get; set; }
        public int Price { get; set; }
        public string Employment { get; set; }
        public string Description { get; set; }
    }
}
