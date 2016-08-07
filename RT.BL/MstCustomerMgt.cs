using RT.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RT.BL
{
    public class MstCustomerMgt
    {
        TPLDBEntities db = new TPLDBEntities();

        public List<BranchData> SelectBranch()
        {
            return (from b in db.MstBranches
                    where b.IsDeleted == false
                    select new BranchData
                    {
                        BranchId = b.BranchId,
                        BranchName = b.BranchName,
                    }).ToList();
        }

        public int InsertCustomer(string CustomerACNumber, int CreatedByBranch, string CashCredit, string CustomerName, string Alias, string TypeOfFirm,
                                    string Priority, string Status, string TIN, string CSTNumber, string GSTNumber, string LastOAC, int NoLRAddressPrinting,
                                    int fkSubAgentId, string Zone, string Group, string Username, List<clsAuthorization> lstAuthorization,
                                    List<clsCustomerContactInfo> lstCustContactInfo, List<clsCustomerInfo> lstCustInfo, List<clsCustomerProprietor> lstCustProprietors,
                                    List<clsCustomerSalesman> lstCustSalesman, List<clsCustomerSisterConcern> lstCustSisConcern, List<clsCustomerAccountant> lstCustAccts,
                                    List<clsParty> lstParty, List<clsReference> lstReference)
        {
            Customer customer = new Customer();

            customer.CustomerACNumber = CustomerACNumber;
            customer.fkCreatedByBranchId = CreatedByBranch;
            customer.CashOrCredit = CashCredit;
            customer.CustomerName = CustomerName;
            customer.Alias = Alias;
            customer.TypeOfFirm = TypeOfFirm;
            customer.Priority = Priority;
            customer.Status = Status;
            customer.TIN = TIN;
            customer.CSTNumber = CSTNumber;
            customer.GSTNumber = GSTNumber;
            customer.LastOAC = LastOAC;
            customer.NoLRAddressPrinting = NoLRAddressPrinting;
            customer.fkSubAgentId = fkSubAgentId;
            customer.Zone = Zone;
            customer.Group = Group;
            customer.CreatedBy = Username;
            customer.CreatedDate = DateTime.Now;
            customer.UpdatedBy = Username;
            customer.UpdatedDate = DateTime.Now;
            customer.IsDeleted = false;

            foreach (clsAuthorization auth in lstAuthorization)
            {
                Authorization dbAuth = new Authorization();
                dbAuth.BranchHead = auth.BranchHead;
                dbAuth.Director1Name = auth.Director1Name;
                dbAuth.Director2Name = auth.Director2Name;
                dbAuth.Director3Name = auth.Director3Name;

                customer.Authorizations.Add(dbAuth);
            }

            foreach (clsCustomerContactInfo custCInfo in lstCustContactInfo)
            {
                CustomerContactInfo cInfo = new CustomerContactInfo();
                cInfo.Address = custCInfo.Address;
                cInfo.Email = custCInfo.Email;
                cInfo.Fax = custCInfo.Fax;
                cInfo.fkCityId = custCInfo.fkCityId;
                cInfo.OfficePhone = custCInfo.OfficePhone;
                cInfo.RemContactPerson = custCInfo.RemContactPerson;
                cInfo.RemContactPhone = custCInfo.RemContactPhone;
                cInfo.RemSMSCell1 = custCInfo.RemSMSCell1;
                cInfo.RemSMSCell2 = custCInfo.RemSMSCell2;
                cInfo.SMSCellNumber = custCInfo.SMSCellNumber;
                cInfo.SMSName = custCInfo.SMSName;
                cInfo.STDCode = custCInfo.STDCode;

                customer.CustomerContactInfoes.Add(cInfo);
            }

            foreach (clsCustomerInfo cInfo in lstCustInfo)
            {
                CustomerInfo info = new CustomerInfo();
                info.Abuse = cInfo.Abuse;
                info.AdmitType = cInfo.AdmitType;
                info.CreditLimit = cInfo.CreditLimit;
                info.CustomerInfoId = cInfo.CustomerInfoId;
                info.DealingType = cInfo.DealingType;
                info.DirectDealing = cInfo.DirectDealing;
                info.GRHabbit = cInfo.GRHabbit;
                info.Hotel = cInfo.Hotel;
                info.OtherAgent = cInfo.OtherAgent;
                info.PaymentHabbit = cInfo.PaymentHabbit;
                info.RapportType = cInfo.RapportType;
                info.Remarks = cInfo.Remarks;
                info.Restriction = cInfo.Restriction;
                info.TransportReference = cInfo.TransportReference;
                info.VisitFrequency = cInfo.VisitFrequency;
                info.WorkNature = cInfo.WorkNature;

                customer.CustomerInfoes.Add(info);
            }

            foreach (clsCustomerProprietor propr in lstCustProprietors)
            {
                CustomerProprietor cProp = new CustomerProprietor();
                cProp.ContactNumber = propr.ContactNumber;
                cProp.ProprietorName = propr.ProprietorName;

                customer.CustomerProprietors.Add(cProp);
            }

            foreach (clsCustomerSalesman salesman in lstCustSalesman)
            {
                CustomerSalesman cSalesman = new CustomerSalesman();
                cSalesman.ContactNumber = salesman.ContactNumber;
                cSalesman.SalesmanName = salesman.SalesmanName;

                customer.CustomerSalesmen.Add(cSalesman);
            }

            foreach (clsCustomerSisterConcern concern in lstCustSisConcern)
            {
                CustomerSisterConcern sisConcrn = new CustomerSisterConcern();
                sisConcrn.CreatedBy = Username;
                sisConcrn.CreatedDate = DateTime.Now;
                sisConcrn.IsDeleted = false;
                sisConcrn.SisterConcernId = concern.SisterConcernId;
                sisConcrn.UpdatedBy = Username;
                sisConcrn.UpdatedDate = DateTime.Now;

                customer.CustomerSisterConcerns.Add(sisConcrn);
            }

            foreach (clsCustomerAccountant cAccts in lstCustAccts)
            {
                CustomerAccountant acct = new CustomerAccountant();
                acct.AccountantName = cAccts.AccountantName;
                acct.ContactNumber = cAccts.ContactNumber;

                customer.CustomerAccountants.Add(acct);
            }

            foreach (clsParty cParty in lstParty)
            {
                Party party = new Party();
                party.Nature = cParty.Nature;
                party.PartyName = cParty.PartyName;
                party.Remarks = cParty.Remarks;
                party.SpokenBy = cParty.SpokenBy;
                party.SpokenDate = cParty.SpokenDate;
                party.SpokenTo = cParty.SpokenTo;

                db.Parties.Add(party);
            }

            foreach (clsReference cRef in lstReference)
            { 
                Reference refe = new Reference();
                refe.ReferenceType = cRef.ReferenceType;
                refe.TourBy = cRef.TourBy;
                refe.TourDate = cRef.TourDate;

                db.References.Add(refe);
            }

            db.Customers.Add(customer);
            return db.SaveChanges();
        }
    }

    public class clsAuthorization
    {
        public int AuthorizationId { get; set; }
        public Nullable<int> fkCustomerId { get; set; }
        public string Director1Name { get; set; }
        public string Director2Name { get; set; }
        public string Director3Name { get; set; }
        public string BranchHead { get; set; }
        public string MBoyBranch { get; set; }
        public string MarketBoy1 { get; set; }
        public string MarketBoy2 { get; set; }
        public string MarketBoy3 { get; set; }
    }
    public class clsCustomerContactInfo
    {
        public int CustomerContactInfoId { get; set; }
        public Nullable<int> fkCustomerId { get; set; }
        public Nullable<int> fkCityId { get; set; }
        public string OfficePhone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string SMSName { get; set; }
        public string SMSCellNumber { get; set; }
        public string RemContactPerson { get; set; }
        public string RemContactPhone { get; set; }
        public string RemSMSCell1 { get; set; }
        public string RemSMSCell2 { get; set; }
        public string Address { get; set; }
        public string STDCode { get; set; }
    }
    public class clsCustomerInfo
    {
        public int CustomerInfoId { get; set; }
        public Nullable<int> fkCustomerId { get; set; }
        public string Abuse { get; set; }
        public string OtherAgent { get; set; }
        public string MBoy1 { get; set; }
        public string MBoy2 { get; set; }
        public string MBoy3 { get; set; }
        public string WorkNature { get; set; }
        public string VisitFrequency { get; set; }
        public string AdmitType { get; set; }
        public string RapportType { get; set; }
        public string DealingType { get; set; }
        public string PaymentHabbit { get; set; }
        public string GRHabbit { get; set; }
        public string TransportReference { get; set; }
        public string Hotel { get; set; }
        public Nullable<decimal> CreditLimit { get; set; }
        public string Restriction { get; set; }
        public string Remarks { get; set; }
        public string DirectDealing { get; set; }
    }
    public class clsCustomerProprietor
    {
        public int ProprietorId { get; set; }
        public Nullable<int> fkCustomerId { get; set; }
        public string ProprietorName { get; set; }
        public string ContactNumber { get; set; }
    }
    public class clsCustomerSalesman
    {
        public int SalesmanId { get; set; }
        public Nullable<int> fkCustomerId { get; set; }
        public string SalesmanName { get; set; }
        public string ContactNumber { get; set; }
    }
    public class clsCustomerSisterConcern
    {
        public int SisterConcernId { get; set; }
        public Nullable<int> fkCustomerId { get; set; }
        public string SisterConcernDescription { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
    public class clsCustomerAccountant
    {
        public int CustomerAccountantId { get; set; }
        public Nullable<int> fkCustomerInfoId { get; set; }
        public string AccountantName { get; set; }
        public string ContactNumber { get; set; }
    }

    public class clsParty
    {
        public int PartyId { get; set; }
        public Nullable<int> fkReferenceId { get; set; }
        public string PartyName { get; set; }
        public string Nature { get; set; }
        public string SpokenTo { get; set; }
        public Nullable<System.DateTime> SpokenDate { get; set; }
        public string SpokenBy { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> CustomerId { get; set; }
    }

    public class clsReference
    {
        public int ReferenceId { get; set; }
        public string ReferenceType { get; set; }
        public string TourBy { get; set; }
        public Nullable<System.DateTime> TourDate { get; set; }
        public Nullable<int> CustomerId { get; set; }
    }
}
