using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asvslabs.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace asvslabs.ViewModels
{
    public class AccountRegisterViewModel
    {
        public LoginViewModel LoginViewModel { get; set; }
        public RegisterViewModel RegisterViewModel { get; set; }
    }
}
