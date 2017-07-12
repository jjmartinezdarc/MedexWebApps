using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedexWebApps.Models
{
    public class ReceiptHdrBusinessLayer
    {
        public Receipt_Hdr_Vw GetMaxTran()
        {
            POSDataEntities posdata = new POSDataEntities();
            return posdata.Receipt_Hdr_Vw.OrderByDescending(x => x.Receipt_Date).FirstOrDefault(x => x.Receipt_No.StartsWith("SM"));
        }
    }
}