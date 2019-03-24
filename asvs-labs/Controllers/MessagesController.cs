using System;
using System.Collections.Generic;
using System.Linq;
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
        public IActionResult StoreMessage(string id, MessageViewModel message)
        {
            var userid = _userManager.GetUserAsync(HttpContext.User).Result;
            MessagesModel model = new MessagesModel {
                Message = message.Message,
                SendTo = message.SendTo,
                SendFrom = userid.Id
            };

            IdentityContext.Messages.Add(model);

            return RedirectToAction("ShowChat");
        }

        // GET: /<controller>/
        public IActionResult StoreImage(MessageViewModel message)
        {
            return RedirectToAction("ShowChat");
        }

        // GET: /<controller>/
        public IActionResult ShowChat(string id)
        {
            var messages = IdentityContext.Messages.Where(x => x.SendTo == id);
            MessageViewModel model = new MessageViewModel();
            model.MessageList = new List<MessageViewModel>();

            if (messages != null)
            {
                foreach (MessagesModel x in messages)
                {
                    model.MessageList.Add(new MessageViewModel
                    {
                        Message = x.Message,
                        ImagePath = x.ImagePath
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
