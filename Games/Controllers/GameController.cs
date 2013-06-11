using Games.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Games.Controllers
{
    [Authorize]
    public class GameController : Controller
    {
        //
        // GET: /Game/

        public ActionResult Play()
        {
            ViewBag.Game = "hangman";
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PostReply(ChatModel chat)
        {
            return Json(new { message = chat.Message, user = User.Identity.Name });
        }
    }
}
