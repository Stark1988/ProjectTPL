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
        public decimal? BillAmt { get; set; }
        public decimal? Collection { get; set; }
        public decimal? Discount { get; set; }
        public decimal? GR { get; set; }
        public decimal? Balance { get; set; }
        public int ODD { get; set; }
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
