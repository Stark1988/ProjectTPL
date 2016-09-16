using DevExpress.DataAccess.ObjectBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RT.BL
{
    [HighlightedClass]
    public class StatementOfCollectionReportData
    {
        public List<StatementOfCollectionReport> StatementOfCollectionData { get; set; }
    }

    public class StatementOfCollectionReport
    {
        public string CustomerName { get; set; }
        public DateTime? DraftReceiveDate { get; set; }

        private decimal? draftAmt;
        public decimal? DraftAmt
        {
            get
            {
                return draftAmt;
            }
            set
            {
                if (value == null)
                    draftAmt = 0;
                else
                    draftAmt = value;
            }
        }
    }
}
