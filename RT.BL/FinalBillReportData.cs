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
        public decimal? TotalBillValue { get; set; }
        public decimal? BillRaisedValue { get; set; }
        public decimal? Amount { get; set; }
    }

    public class BillsRaisedDetail
    {
        public DateTime? BillDate { get; set; }
        public decimal? CommissionAmount { get; set; }
        public decimal? ServiceTax { get; set; }
        public decimal? Swachh { get; set; }
        public decimal? EducationCess { get; set; }        
        public decimal? RoundedOff { get; set; }
        public decimal? Others { get; set; }
        public decimal? Total 
        {
            get
            {
                return CommissionAmount + ServiceTax + Swachh + EducationCess + Others;
            }
        }
    }
}
