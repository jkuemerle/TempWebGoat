using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OWASP.WebGoat.NET.Controllers
{
    public class DiaryController : Controller
    {
        //
        // GET: /Diary/

        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Tell(OWASP.WebGoat.NET.Models.Diary diary)
        {
            DatabaseUtilities du = new DatabaseUtilities();
            du.AddNewPosting("Secret Entry", "Anonymous", diary.Text);
            return Redirect("~/Default.aspx");
        }

    }
}
