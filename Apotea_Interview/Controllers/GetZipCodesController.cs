using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Apotea_Interview.Controllers
{
    public class GetZipCodesController : Controller
    {

        Apotea_Student_InterviewQ2Entities db = new Apotea_Student_InterviewQ2Entities();
        // GET: GetZipCodes
        public ActionResult Index()
        {
            return View(db.Orders.ToList());
        }
        [HttpPost]
        public ActionResult Index(DateTime StartDtae, DateTime Enddate)
        {
            return View(db.Func_GetZipCodes(StartDtae, Enddate));
        }
    }
}