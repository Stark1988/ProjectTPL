using DevExpress.DataAccess.ObjectBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RT.BL
{
    [HighlightedClass]
    public class SupplierOutstandingReportData
    {
        public List<CustomerSOReport> CustomerData { get; set; }
    }

    public class CustomerSOReport
    {
        public string CustomerName { get; set; }
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
}
