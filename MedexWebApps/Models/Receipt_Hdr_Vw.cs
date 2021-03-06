//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedexWebApps.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Receipt_Hdr_Vw
    {
        public string Receipt_No { get; set; }
        public short Branch_ID { get; set; }
        public System.DateTime Receipt_Date { get; set; }
        public byte POS_Num { get; set; }
        public int Cust_ID { get; set; }
        public short Fulfill_Chan_ID { get; set; }
        public int Cashier_ID { get; set; }
        public System.DateTime Date_Created { get; set; }
        public decimal Net_Total { get; set; }
        public string Voided_Receipt_No { get; set; }
        public byte Shift_Count { get; set; }
        public short PA_ID { get; set; }
        public short Picker_ID { get; set; }
        public string Cashier { get; set; }
        public string SAP_Code { get; set; }
        public string Charge_To { get; set; }
        public Nullable<decimal> Gross_Total { get; set; }
        public decimal Charges_Total { get; set; }
        public Nullable<double> Discounts_Total { get; set; }
        public Nullable<double> Discounts_Vatable { get; set; }
        public Nullable<decimal> Discounts_VAT_Exempt { get; set; }
        public Nullable<decimal> Discounts_Zero_Rated { get; set; }
        public Nullable<decimal> Vatable { get; set; }
        public Nullable<decimal> Vat_Exempt { get; set; }
        public Nullable<decimal> Zero_Rated { get; set; }
        public Nullable<decimal> Vat { get; set; }
        public decimal Free_Goods_Qty { get; set; }
        public decimal Tender_Amount { get; set; }
        public Nullable<bool> MD_Purchase { get; set; }
        public decimal Cost_Of_Sales { get; set; }
        public decimal Cost_Of_Sales_Current { get; set; }
        public decimal MAV_Of_Sales { get; set; }
        public Nullable<decimal> Vatable_Gross { get; set; }
        public Nullable<decimal> Vat_Exempt_Gross { get; set; }
        public Nullable<decimal> Zero_Rated_Gross { get; set; }
        public Nullable<decimal> Vat_Gross { get; set; }
        public Nullable<decimal> SC_Acq_Cost { get; set; }
        public string Tax_Class { get; set; }
        public string Govt_ID { get; set; }
    }
}
