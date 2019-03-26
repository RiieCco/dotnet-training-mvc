using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using asvslabs.Models;
using asvslabs.ViewModels;
using Authentication.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace asvslabs.Controllers
{
    public class MessagesController : Controller
    {
        private  UserManager<IdentityUser> _userManager;
        private IdentityContext IdentityContext;

        public MessagesController(IdentityContext db, UserManager<IdentityUser> userManager) { IdentityContext = db; _userManager = userManager; }

        // GET: /<controller>/
        public IActionResult Index()
        {
            MessageViewModel model = new MessageViewModel();

            var users = (from u in IdentityContext.Messages
                         group u by u.SendTo into u2
                         join e in IdentityContext.Users
                         on u2.FirstOrDefault().SendTo equals e.Id
                         select new MessageViewModel {
                             UserName = e.UserName,
                             UserId = e.Id
                        }).ToList();
            return View(users);
        }

        // GET: /<controller>/
        public IActionResult StoreMessage(MessageViewModel model)
        {
          var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
          MessagesModel message = new MessagesModel {
                Message = model.Message,
                SendTo = model.SendTo,
                SendFrom = userId
            };

            IdentityContext.Messages.Add(message);
            IdentityContext.SaveChanges();

            return RedirectToAction("ShowChat", new { Id = model.SendTo});
        }

        // GET: /<controller>/
        public IActionResult StoreImage(MessageViewModel message)
        {
            return RedirectToAction("ShowChat");
        }

        // GET: /<controller>/
        public IActionResult ShowChat(string id)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var messages = IdentityContext.Messages.Where(x => x.SendTo == id || x.SendFrom == id);
            MessageViewModel model = new MessageViewModel();
            model.MessageList = new List<MessageViewModel>();
            model.SendTo = id;
            
            if (messages != null)
            {
              foreach (MessagesModel x in messages)
              {
                model.MessageList.Add(new MessageViewModel
                  {
                    Message = x.Message,
                    ImagePath = x.ImagePath,
                    SendFrom = x.SendFrom
                  });
                }
            }
            return View(model);
        }

        // GET: /<controller>/
        public IActionResult DownloadChatHistory()
        {
            return View();
        }
    }
}
