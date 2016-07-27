using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Neighbourhood.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;



namespace Neighbourhood.Controllers
{
    public class TaskController : Controller
    {
        [Authorize]
        public ActionResult MainTaskPage()
        {
            using (TskDbcontext db = new TskDbcontext())
            {
                return View(db.tsk.ToList());
            }

        }
        [Authorize]
        public ActionResult CreateTask()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTask(Task Tasks)
        {
            if (ModelState.IsValid)
            {
                using (TskDbcontext db = new TskDbcontext())
                {
                    db.tsk.Add(Tasks);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = "Task added";
            }
            return View();
        }
        [HttpPost]
        public ActionResult UpvotePost(int? id)
        {
            using (TskDbcontext db = new TskDbcontext())
            {
                var Tasks = db.tsk.Find(id);
                Tasks.upvotes++; 
                db.SaveChanges();
                return RedirectToAction("MainTaskPage");
            }
        }


    }

}