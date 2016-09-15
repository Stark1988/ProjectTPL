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
        public string BillNo { get; set; }

        private decimal? billAmt;
        public decimal? BillAmt
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

        private decimal? totalCommission;
        public decimal? TotalCommission
        {
            get
            {
                return totalCommission;
            }
            set
            {
                if (value == null)
                    totalCommission = 0;
                else
                    totalCommission = value;
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

        private decimal? receivedCommission;
        public decimal? ReceivedCommission
        {
            get
            {
                return receivedCommission;
            }
            set
            {
                if (value == null)
                    receivedCommission = 0;
                else
                    receivedCommission = value;
            }
        }

        public decimal? Balance
        {
            get
            {
                return TotalCommission - (ReceivedCommission + Discount);
            }
        }
    }
}
