using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace asvslabs.ViewModels
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MessageViewModel
    {
        public List<MessageViewModel> MessageList { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
        public string SendFrom { get; set; }
        public string SendTo { get; set; }
        public string Message { get; set; }
        public string ImagePath { get; set; }
    }
}
