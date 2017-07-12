using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MedexWebApps.Models;
namespace MedexWebApps.Models
{
    public class ITSchedBusinessLayer
    {
        
        public List<IT_Weekly_Shift> GetActiveSched()
        {
            var autoDB = new Automation();
            return autoDB.IT_Weekly_Shift.Where(x => x.Week.Active == true).ToList();
        }
        public DateTime GetStartDateCurrSched()
        {
            var autoDB = new Automation();
            return Convert.ToDateTime(autoDB.Weeks.SingleOrDefault(x => x.Active == true).Start_Date);
        }

        public List<IT_Weekly_Shift> GetSpecificSched(int WeekAdd)
        {
            var autoDB = new Automation();
            var currWeek = GetActiveSched().First().Week_ID;
            return autoDB.IT_Weekly_Shift.Where(x => x.Week_ID == (currWeek + WeekAdd) % 10).ToList();
        }
    }
}