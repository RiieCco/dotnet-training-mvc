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
    public class MessagesModel
    {
        [Key]
        public int MessageId { get; set; }
        public string SendFrom { get; set; }
        public string SendTo { get; set; }
        public string Message { get; set; }
        public string ImagePath { get; set; }
    }
}
