using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RT.BL
{
    public class CustomerOutstandingReportData
    {
        public List<SupplierCOReport> SupplierData { get; set; }
        public List<ReturnDraftCOReport> ReturnDraftData { get; set; }
    }

    public class SupplierCOReport
    {
        public string SupplierName { get; set; }
        public string BranchName { get; set; }
        public DateTime? Date { get; set; }
        public string RefNo { get; set; }

        private double? billAmt;
        public double? BillAmt
        {
            get
            {
                return billAmt;
            }
            set
            {
                if (value == null)
                    billAmt = 0;
                else
                    billAmt = value;
            }
        }

        private decimal? collection;
        public decimal? Collection
        {
            get
            {
                return collection;
            }
            set
            {
                if (value == null)
                    collection = 0;
                else
                    collection = value;
            }
        }

        private decimal? discount;
        public decimal? Discount
        {
            get
            {
                return discount;
            }
            set
            {
                if (value == null)
                    discount = 0;
                else
                    discount = value;
            }
        }

        private decimal? gr;
        public decimal? GR
        {
            get
            {
                return gr;
            }
            set
            {
                if (value == null)
                    gr = 0;
                else
                    gr = value;
            }
        }

        public decimal? Balance 
        { 
            get
            {
                return Convert.ToDecimal(BillAmt) - (Collection + Discount + GR);
            }
        }
        public int? ODD { get; set; }
    }

    public class ReturnDraftCOReport
    {        
        public string CustomerName { get; set; }
        public string BranchName { get; set; }
        public string SupplierName { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string DrawnOn { get; set; }
        public DateTime? DraftDate { get; set; }
        public string DraftNumber { get; set; }
        public decimal? Amount { get; set; }
    }
}
