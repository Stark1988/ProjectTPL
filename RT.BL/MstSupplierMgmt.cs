using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RT.DL;

namespace RT.BL
{
    public class MstSupplierMgmt
    {
        TPLDBEntities db = new TPLDBEntities();

        public List<Supplier> SelectSupplier()
        {
            return db.Suppliers
                        .Select(q => new { SupplierId = q.SupplierId, SupplierName = q.SupplierName })
                        .ToList()
                        .Select(q => new Supplier() { SupplierId = q.SupplierId, SupplierName = q.SupplierName }).ToList();
        }

        public Supplier FindSupplier(int SupplierId)
        {
            return db.Suppliers.Find(SupplierId);
        }

        public int InsertCustomer(string SupplierName, string SupplierACNumber, string Alias, string SupplierGroup, string SupplierZone, int ODDays, string BillTerms,
                                    string Priority, string Variety, int FrequencyPerMonth, string TanName, string TanNumber, string Remarks, string GlobalCode,
                                    string Password, string Pin, string ServiceTaxOn, decimal Commission, string PriorityMember, bool IsStartDailyBilling, bool IsBK,
                                    string Username, List<SupplierBillingDetail> lstBills, List<SupplierContactInfo> lstContactInfo, List<SupplierProprietor> lstPropr,
                                    List<SupplierSisterConcern> lstSisConcrn, int SupplierId = 0)
        {
            Supplier supplier;

            if (SupplierId == 0)
                supplier = new Supplier();
            else
                supplier = db.Suppliers.Find(SupplierId);

            if (SupplierId == 0)
                supplier.SupplierName = SupplierName;
            supplier.SupplierACNumber = SupplierACNumber;
            supplier.Alias = Alias;
            supplier.SupplierGroup = SupplierGroup;
            supplier.SupplierZone = SupplierZone;
            supplier.ODDays = ODDays;
            supplier.BillTerms = BillTerms;
            supplier.Priority = Priority;
            supplier.Variety = Variety;
            supplier.FrequencyPerMonth = FrequencyPerMonth;
            supplier.TanName = TanName;
            supplier.TanNumber = TanNumber;
            supplier.Remarks = Remarks;
            supplier.GlobalCode = GlobalCode;
            supplier.Password = Password;
            supplier.Pin = Pin;
            supplier.ServiceTaxOn = ServiceTaxOn;
            supplier.Commission = Commission;
            supplier.PriorityMember = PriorityMember;
            supplier.IsStartDailyBilling = IsStartDailyBilling;
            supplier.IsBK = IsBK;
            if (SupplierId == 0)
            {
                supplier.CreatedBy = Username;
                supplier.CreatedDate = DateTime.Now;
            }
            supplier.UpdatedBy = Username;
            supplier.UpdatedDate = DateTime.Now;
            supplier.IsDeleted = false;

            foreach (SupplierBillingDetail bill in lstBills)
            {
                if (SupplierId == 0)
                    supplier.SupplierBillingDetails.Add(bill);
                else
                {
                    supplier.SupplierBillingDetails.ElementAt(0).BillFrequency = bill.BillFrequency;
                    supplier.SupplierBillingDetails.ElementAt(0).IsStopMonthlyBilling = bill.IsStopMonthlyBilling;
                    supplier.SupplierBillingDetails.ElementAt(0).ITPanNumber = bill.ITPanNumber;
                    supplier.SupplierBillingDetails.ElementAt(0).SupplierCompany = bill.SupplierCompany;
                }
            }

            foreach (SupplierContactInfo info in lstContactInfo)
            {
                if (SupplierId == 0)
                    supplier.SupplierContactInfoes.Add(info);
                else
                {
                    supplier.SupplierContactInfoes.ElementAt(0).Address = info.Address;
                    supplier.SupplierContactInfoes.ElementAt(0).City = info.City;
                    supplier.SupplierContactInfoes.ElementAt(0).State = info.State;
                    supplier.SupplierContactInfoes.ElementAt(0).Email = info.Email;
                    supplier.SupplierContactInfoes.ElementAt(0).Fax = info.Fax;
                    supplier.SupplierContactInfoes.ElementAt(0).OfficePhone = info.OfficePhone;
                    supplier.SupplierContactInfoes.ElementAt(0).Pin = info.Pin;
                    supplier.SupplierContactInfoes.ElementAt(0).Residence = info.Residence;
                    supplier.SupplierContactInfoes.ElementAt(0).ResidenceCity = info.ResidenceCity;
                    supplier.SupplierContactInfoes.ElementAt(0).ResidenceState = info.ResidenceState;
                    supplier.SupplierContactInfoes.ElementAt(0).ResidencePin = info.ResidencePin;
                    supplier.SupplierContactInfoes.ElementAt(0).ResPhone = info.ResPhone;
                    supplier.SupplierContactInfoes.ElementAt(0).SMSCellNumber = info.SMSCellNumber;
                    supplier.SupplierContactInfoes.ElementAt(0).SMSName = info.SMSName;
                }
            }

            int i = 0;
            foreach (SupplierProprietor propr in lstPropr)
            {
                if (SupplierId == 0)
                    supplier.SupplierProprietors.Add(propr);
                else
                {
                    supplier.SupplierProprietors.ElementAt(i).ContactNumber = propr.ContactNumber;
                    supplier.SupplierProprietors.ElementAt(i).ProprietorName = propr.ProprietorName;
                    i++;
                }
            }

            i++;
            foreach (SupplierSisterConcern sisC in lstSisConcrn)
            {
                if (SupplierId == 0)
                    supplier.SupplierSisterConcerns.Add(sisC);
                else
                {

                    i++;
                }
            }

            if (SupplierId == 0)
                db.Suppliers.Add(supplier);

            return db.SaveChanges();
        }
    }
}
