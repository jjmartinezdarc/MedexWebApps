using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MedexWebApps.ViewModels;
using MedexWebApps.Models;

namespace MedexWebApps.Controllers
{
    public class ITSchedController : Controller
    {
        // GET: ITSched
        public ActionResult Index()
        {
            var itSchedVM = new ITSchedViewModel();
            var itSchedBL = new ITSchedBusinessLayer();
            var itScheds = itSchedBL.GetActiveSched();
            itSchedVM.ITWeeklyShift = new List<IT_Weekly_Shift>();
            foreach (IT_Weekly_Shift sched in itScheds)
            {
                itSchedVM.ITWeeklyShift.Add(sched);
            }
            itSchedVM.SchedStartDate = itSchedBL.GetStartDateCurrSched();
            itSchedVM.SchedEndDate = itSchedVM.SchedStartDate.AddDays(4);

            return View("Index", itSchedVM);
        }
    }
}