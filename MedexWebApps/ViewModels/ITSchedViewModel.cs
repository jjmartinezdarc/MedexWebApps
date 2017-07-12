using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MedexWebApps.Models;
namespace MedexWebApps.ViewModels
{
    public class ITSchedViewModel
    {
        public List<IT_Weekly_Shift> ITWeeklyShift { get; set; }
        public DateTime SchedStartDate { get; set; }
        public DateTime SchedEndDate { get; set; }
    }
}