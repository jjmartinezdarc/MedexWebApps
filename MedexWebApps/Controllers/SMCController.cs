using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MedexWebApps.Models;
using MedexWebApps.ViewModels;
namespace MedexWebApps.Controllers
{
    public class SMCController : Controller
    {
        // GET: SMC
        public ActionResult MaxTranDate()
        {
            SMCMaxDateViewModel rcptVM = new SMCMaxDateViewModel();
            ReceiptHdrBusinessLayer rcptBL = new ReceiptHdrBusinessLayer();
            Receipt_Hdr_Vw rcpt = rcptBL.GetMaxTran();
            rcptVM.MaxDate = rcpt.Receipt_Date;

            return View("MaxTranDate",rcptVM);
        }
    }
}