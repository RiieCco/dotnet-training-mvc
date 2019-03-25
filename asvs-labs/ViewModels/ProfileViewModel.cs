using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace asvslabs.ViewModels
{
   public class ProfileViewModel
  {
    public List<ProfileViewModel> UserList { get; set; }
    public string UserName { get; set; }
    public string userId { get; set; }
  }
}
