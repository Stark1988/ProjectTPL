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

        public List<Customer> SelectSisterCompany()
        {
            return (from c in db.Customers
                    //where c.Status != "Rejected"
                    select new
                    {
                        CustomerId = c.CustomerId,
                        CustomerName = c.CustomerName
                    }).ToList()
                    .Select(q => new Customer
                    {
                        CustomerId = q.CustomerId,
                        CustomerName = q.CustomerName
                    }).ToList();
        }

        public int InsertCustomer(string CustomerACNumber, int CreatedByBranch, string CashCredit, string CustomerName, string Alias, string TypeOfFirm,
                                    string Priority, string Status, string TIN, string CSTNumber, string GSTNumber, string LastOAC, int NoLRAddressPrinting,
                                    int fkSubAgentId, string Zone, string Group, string Username, List<clsAuthorization> lstAuthorization,
                                    List<clsCustomerContactInfo> lstCustContactInfo, List<clsCustomerInfo> lstCustInfo, List<clsCustomerProprietor> lstCustProprietors,
                                    List<clsCustomerSalesman> lstCustSalesman, List<clsCustomerSisterConcern> lstCustSisConcern, List<clsCustomerAccountant> lstCustAccts,
                                    List<clsParty> lstParty, List<clsReference> lstReference, int CustomerId = 0)
        {
            Customer customer;
            if (CustomerId == 0)
                customer = new Customer();
            else
                customer = db.Customers.Find(CustomerId);

            customer.CustomerACNumber = CustomerACNumber;
            customer.fkCreatedByBranchId = CreatedByBranch;
            customer.CashOrCredit = CashCredit;
            customer.CustomerName = CustomerName;
            customer.Alias = Alias;
            customer.TypeOfFirm = TypeOfFirm;
            customer.Priority = Priority;
            customer.Status = Status;
            customer.TIN = TIN;
            if (CustomerId == 0)
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

            int i = 0;
            foreach (clsAuthorization auth in lstAuthorization)
            {
                if (CustomerId == 0)
                {
                    Authorization dbAuth = new Authorization();
                    dbAuth.BranchHead = auth.BranchHead;
                    dbAuth.Director1Name = auth.Director1Name;
                    dbAuth.Director2Name = auth.Director2Name;
                    dbAuth.Director3Name = auth.Director3Name;

                    customer.Authorizations.Add(dbAuth);
                }
                else
                {
                    customer.Authorizations.ElementAt(i).BranchHead = auth.BranchHead;
                    customer.Authorizations.ElementAt(i).Director1Name = auth.Director1Name;
                    customer.Authorizations.ElementAt(i).Director2Name = auth.Director2Name;
                    customer.Authorizations.ElementAt(i).Director3Name = auth.Director3Name;
                    i++;
                }
            }

            i = 0;
            foreach (clsCustomerContactInfo custCInfo in lstCustContactInfo)
            {

                if (CustomerId == 0)
                {
                    CustomerContactInfo cInfo = new CustomerContactInfo();
                    cInfo.Address = custCInfo.Address;
                    cInfo.Email = custCInfo.Email;
                    cInfo.Fax = custCInfo.Fax;
                    cInfo.fkCityId = custCInfo.fkCityId;
                    cInfo.fkStateId = custCInfo.fkStateId;
                    cInfo.OfficePhone = custCInfo.OfficePhone;
                    cInfo.RemContactPerson = custCInfo.RemContactPerson;
                    cInfo.RemContactPhone = custCInfo.RemContactPhone;
                    cInfo.RemSMSCell1 = custCInfo.RemSMSCell1;
                    cInfo.RemSMSCell2 = custCInfo.RemSMSCell2;
                    cInfo.SMSCellNumber = custCInfo.SMSCellNumber;
                    cInfo.SMSName = custCInfo.SMSName;
                    cInfo.STDCode = custCInfo.STDCode;
                    cInfo.Pincode = custCInfo.Pincode;

                    customer.CustomerContactInfoes.Add(cInfo);
                }
                else
                {
                    customer.CustomerContactInfoes.ElementAt(i).Address = custCInfo.Address;
                    customer.CustomerContactInfoes.ElementAt(i).Email = custCInfo.Email;
                    customer.CustomerContactInfoes.ElementAt(i).Fax = custCInfo.Fax;
                    customer.CustomerContactInfoes.ElementAt(i).fkCityId = custCInfo.fkCityId;
                    customer.CustomerContactInfoes.ElementAt(i).fkStateId = custCInfo.fkStateId;
                    customer.CustomerContactInfoes.ElementAt(i).OfficePhone = custCInfo.OfficePhone;
                    customer.CustomerContactInfoes.ElementAt(i).RemContactPerson = custCInfo.RemContactPerson;
                    customer.CustomerContactInfoes.ElementAt(i).RemContactPhone = custCInfo.RemContactPhone;
                    customer.CustomerContactInfoes.ElementAt(i).RemSMSCell1 = custCInfo.RemSMSCell1;
                    customer.CustomerContactInfoes.ElementAt(i).RemSMSCell2 = custCInfo.RemSMSCell2;
                    customer.CustomerContactInfoes.ElementAt(i).SMSCellNumber = custCInfo.SMSCellNumber;
                    customer.CustomerContactInfoes.ElementAt(i).SMSName = custCInfo.SMSName;
                    customer.CustomerContactInfoes.ElementAt(i).STDCode = custCInfo.STDCode;
                    customer.CustomerContactInfoes.ElementAt(i).Pincode = custCInfo.Pincode;
                    i++;
                }
            }

            i = 0;
            foreach (clsCustomerInfo cInfo in lstCustInfo)
            {
                if (CustomerId == 0)
                {
                    CustomerInfo info = new CustomerInfo();
                    info.Abuse = cInfo.Abuse;
                    info.AdmitType = cInfo.AdmitType;
                    info.CreditLimit = cInfo.CreditLimit;
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
                else
                {
                    customer.CustomerInfoes.ElementAt(i).Abuse = cInfo.Abuse;
                    customer.CustomerInfoes.ElementAt(i).AdmitType = cInfo.AdmitType;
                    customer.CustomerInfoes.ElementAt(i).CreditLimit = cInfo.CreditLimit;
                    customer.CustomerInfoes.ElementAt(i).DealingType = cInfo.DealingType;
                    customer.CustomerInfoes.ElementAt(i).DirectDealing = cInfo.DirectDealing;
                    customer.CustomerInfoes.ElementAt(i).GRHabbit = cInfo.GRHabbit;
                    customer.CustomerInfoes.ElementAt(i).Hotel = cInfo.Hotel;
                    customer.CustomerInfoes.ElementAt(i).OtherAgent = cInfo.OtherAgent;
                    customer.CustomerInfoes.ElementAt(i).PaymentHabbit = cInfo.PaymentHabbit;
                    customer.CustomerInfoes.ElementAt(i).RapportType = cInfo.RapportType;
                    customer.CustomerInfoes.ElementAt(i).Remarks = cInfo.Remarks;
                    customer.CustomerInfoes.ElementAt(i).Restriction = cInfo.Restriction;
                    customer.CustomerInfoes.ElementAt(i).TransportReference = cInfo.TransportReference;
                    customer.CustomerInfoes.ElementAt(i).VisitFrequency = cInfo.VisitFrequency;
                    customer.CustomerInfoes.ElementAt(i).WorkNature = cInfo.WorkNature;
                    i++;
                }
            }

            i = 0;
            foreach (clsCustomerProprietor propr in lstCustProprietors)
            {
                if (CustomerId == 0)
                {
                    CustomerProprietor cProp = new CustomerProprietor();
                    cProp.ContactNumber = propr.ContactNumber;
                    cProp.ProprietorName = propr.ProprietorName;

                    customer.CustomerProprietors.Add(cProp);
                }
                else
                {
                    customer.CustomerProprietors.ElementAt(i).ContactNumber = propr.ContactNumber;
                    customer.CustomerProprietors.ElementAt(i).ProprietorName = propr.ProprietorName;
                    i++;
                }
            }

            i = 0;
            foreach (clsCustomerSalesman salesman in lstCustSalesman)
            {
                if (CustomerId == 0)
                {
                    CustomerSalesman cSalesman = new CustomerSalesman();
                    cSalesman.ContactNumber = salesman.ContactNumber;
                    cSalesman.SalesmanName = salesman.SalesmanName;

                    customer.CustomerSalesmen.Add(cSalesman);
                }
                else
                {
                    customer.CustomerSalesmen.ElementAt(i).ContactNumber = salesman.ContactNumber;
                    customer.CustomerSalesmen.ElementAt(i).SalesmanName = salesman.SalesmanName;
                    i++;
                }
            }

            i = 0;
            foreach (clsCustomerSisterConcern concern in lstCustSisConcern)
            {
                if (CustomerId == 0)
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
                else
                {
                    customer.CustomerSisterConcerns.ElementAt(i).CreatedBy = Username;
                    customer.CustomerSisterConcerns.ElementAt(i).CreatedDate = DateTime.Now;
                    customer.CustomerSisterConcerns.ElementAt(i).IsDeleted = false;
                    customer.CustomerSisterConcerns.ElementAt(i).SisterConcernId = concern.SisterConcernId;
                    customer.CustomerSisterConcerns.ElementAt(i).UpdatedBy = Username;
                    customer.CustomerSisterConcerns.ElementAt(i).UpdatedDate = DateTime.Now;
                    i++;
                }
            }

            i = 0;
            foreach (clsCustomerAccountant cAccts in lstCustAccts)
            {
                if (CustomerId == 0)
                {
                    CustomerAccountant acct = new CustomerAccountant();
                    acct.AccountantName = cAccts.AccountantName;
                    acct.ContactNumber = cAccts.ContactNumber;

                    customer.CustomerAccountants.Add(acct);
                }
                else
                {
                    customer.CustomerAccountants.ElementAt(i).AccountantName = cAccts.AccountantName;
                    customer.CustomerAccountants.ElementAt(i).ContactNumber = cAccts.ContactNumber;
                    i++;
                }
            }

            i = 0;
            foreach (clsParty cParty in lstParty)
            {
                if (CustomerId == 0)
                {
                    Party party = new Party();
                    party.Nature = cParty.Nature;
                    party.PartyName = cParty.PartyName;
                    party.Remarks = cParty.Remarks;
                    party.SpokenBy = cParty.SpokenBy;
                    party.SpokenDate = cParty.SpokenDate.Value.Year == 0001 ? null : cParty.SpokenDate;
                    party.SpokenTo = cParty.SpokenTo;

                    customer.Parties.Add(party);
                }
                else
                {
                    customer.Parties.ElementAt(i).Nature = cParty.Nature;
                    customer.Parties.ElementAt(i).PartyName = cParty.PartyName;
                    customer.Parties.ElementAt(i).Remarks = cParty.Remarks;
                    customer.Parties.ElementAt(i).SpokenBy = cParty.SpokenBy;
                    customer.Parties.ElementAt(i).SpokenDate = cParty.SpokenDate.Value.Year == 0001 ? null : cParty.SpokenDate;
                    customer.Parties.ElementAt(i).SpokenTo = cParty.SpokenTo;
                    i++;
                }
            }

            i = 0;
            foreach (clsReference cRef in lstReference)
            {
                if (CustomerId == 0)
                {
                    Reference refe = new Reference();
                    refe.ReferenceType = cRef.ReferenceType;
                    refe.TourBy = cRef.TourBy;
                    refe.TourDate = cRef.TourDate;

                    customer.References.Add(refe);
                }
                else
                {
                    customer.References.ElementAt(i).ReferenceType = cRef.ReferenceType;
                    customer.References.ElementAt(i).TourBy = cRef.TourBy;
                    customer.References.ElementAt(i).TourDate = cRef.TourDate;
                    i++;
                }
            }

            if (CustomerId == 0)
                db.Customers.Add(customer);
            return db.SaveChanges();
        }

        public List<Customer> SelectCustomer()
        {
            return db.Customers
                    //.Where(q => q.Status != "Rejected")
                    .Select(q => new { CustomerId = q.CustomerId, CustomerName = q.CustomerName })
                    .ToList()
                    .Select(q => new Customer() { CustomerName = q.CustomerName, CustomerId = q.CustomerId }).ToList();
        }

        public Customer FindCustomer(int CustomerId)
        {
            return db.Customers.Find(CustomerId);
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

        public Nullable<int> fkStateId { get; set; }
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
        public string Pincode { get; set; }
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
