using DevExpress.DataAccess.ObjectBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RT.BL
{
    [HighlightedClass]
    public class FinalBillReportData
    {
        public List<Particular> Particulars { get; set; }
        public List<CurrentBillBreakup> BillBreakup { get; set; }
        public List<BillsRaisedDetail> BillRaisedDetails { get; set; }
    }

    public class Particular
    {
        public int SlNo { get; set; }
        public string Details { get; set; }
        public decimal? Amount { get; set; }
    }

    public class CurrentBillBreakup
    {
        public string Description { get; set; }
        private double? totalBillBreakupValue;
        public double? TotalBillBreakupValue 
        { 
            get
            {
                return totalBillBreakupValue;
            }
            set
            {
                if (value == null)
                    totalBillBreakupValue = 0;
                else
                    totalBillBreakupValue = value;
            }
        }
        private double? billRaisedValue;
        public double? BillRaisedValue
        {
            get
            {
                return billRaisedValue;
            }
            set
            {
                if (value == null)
                    billRaisedValue = 0;
                else
                    billRaisedValue = value;
            }
        }
        public double? Amount 
        { 
            get
            {
                return TotalBillBreakupValue - BillRaisedValue;
            }
        }
    }

    public class BillsRaisedDetail
    {
        public DateTime? BillDate { get; set; }
        public double? CommissionAmount { get; set; }
        public double? ServiceTax { get; set; }
        public double? Swachh { get; set; }
        public double? EducationCess { get; set; }
        public double? RoundedOff { get; set; }
        public double? Others { get; set; }
        public double? Total 
        {
            get
            {
                return CommissionAmount + ServiceTax + Swachh + EducationCess + Others + RoundedOff;
            }
        }
    }
}
