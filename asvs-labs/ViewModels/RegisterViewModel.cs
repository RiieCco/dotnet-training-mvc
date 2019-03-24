using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace asvslabs.ViewModels
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class RegisterViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public string PhoneNumber { get; set; }
    }
}
