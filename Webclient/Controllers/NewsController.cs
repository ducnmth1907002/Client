using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Webclient.Data;
using Webclient.Models;

namespace Webclient.Controllers
{
    public class NewsController : Controller
    {
        private WebclientContext db = new WebclientContext();

        // GET: News
        public ActionResult Index()
        {
            return View(db.News.ToList());
        }

        // GET: News/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            News news = db.News.Find(id);
            if (news == null)
            {
                return HttpNotFound();
            }
            return View(news);
        }
    }
}
