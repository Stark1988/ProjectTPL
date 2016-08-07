using RT.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RT.BL
{
    public class MstCourierMgmt
    {
        TPLDBEntities db = new TPLDBEntities();

        public MstCourierMgmtData SelectData()
        {
            MstCourierMgmtData courierMgmtData = new MstCourierMgmtData();

            courierMgmtData.Couriers = (from cour in db.MstCouriers
                                        where cour.IsDeleted == false
                                        select new CourierData
                                        {
                                            ID = cour.CourierMasterId,
                                            Name = cour.CourierName,
                                            ShortName = cour.ShortName,
                                            Rate = cour.Rate,
                                            BranchId = cour.fkBranchId,
                                            BranchName = cour.MstBranch.BranchName,
                                            Address = cour.Address,
                                            CityId = cour.fkCityId,
                                            CityName = cour.MstCity.CityName,
                                            OfficePhone = cour.OfficePhone,
                                            Fax = cour.Fax,
                                            Remarks = cour.Remarks,
                                            Pin = cour.Pin,
                                            ContactPerson = cour.ContactPerson,
                                            CreatedBy = cour.CreatedBy,
                                            CreatedDate = cour.CreatedDate,
                                            UpdatedBy = cour.UpdatedBy,
                                            UpdatedDate = cour.UpdatedDate
                                        }).ToList();

            MstCityMgmt cityMgmt = new MstCityMgmt();
            courierMgmtData.Cities = cityMgmt.SelectData().Cities;

            courierMgmtData.Branches = (from b in db.MstBranches
                                        where b.IsDeleted == false
                                        select new BranchData
                                        {
                                            BranchId = b.BranchId,
                                            BranchName = b.BranchName,
                                            CreatedBy = b.CreatedBy,
                                            CreatedDate = b.CreatedDate,
                                            UpdatedBy = b.UpdatedBy,
                                            UpdatedDate = b.UpdatedDate
                                        }).ToList();

            return courierMgmtData;
        }

        public int InsertCourier(CourierData courierData)
        {
            MstCourier courier = new MstCourier();
            courier.CourierName = courierData.Name;
            courier.Pin = courierData.Pin;
            courier.ContactPerson = courierData.ContactPerson;
            courier.CreatedBy = "admin";
            courier.CreatedDate = DateTime.Now;
            courier.IsDeleted = false;
            courier.UpdatedBy = "admin";
            courier.UpdatedDate = DateTime.Now;
            courier.ShortName = courierData.ShortName;
            courier.Rate = courierData.Rate;
            courier.fkBranchId = courierData.BranchId;
            courier.Address = courierData.Address;
            courier.fkCityId = courierData.CityId;
            courier.OfficePhone = courierData.OfficePhone;
            courier.Fax = courierData.Fax;
            courier.Remarks = courierData.Remarks;

            db.MstCouriers.Add(courier);
            return db.SaveChanges();
        }

        public int UpdateCourier(int Id, CourierData courierData)
        {
            MstCourier courier = db.MstCouriers.Find(Id);
            courier.CourierName = courierData.Name;
            courier.UpdatedBy = "admin";
            courier.UpdatedDate = DateTime.Now;
            courier.ShortName = courierData.ShortName;
            courier.Rate = courierData.Rate;
            courier.fkBranchId = courierData.BranchId;
            courier.Address = courierData.Address;
            courier.fkCityId = courierData.CityId;
            courier.OfficePhone = courierData.OfficePhone;
            courier.Fax = courierData.Fax;
            courier.Remarks = courierData.Remarks;
            courier.Pin = courierData.Pin;
            courier.ContactPerson = courierData.ContactPerson;

            return db.SaveChanges();
        }

        public int DeleteCourier(int Id)
        {
            MstCourier courier = db.MstCouriers.Find(Id);

            courier.IsDeleted = true;
            courier.UpdatedBy = "admin";
            courier.UpdatedDate = DateTime.Now;

            return db.SaveChanges();
        }

    }

    public class MstCourierMgmtData
    {
        public List<CityData> Cities { get; set; }
        public List<BranchData> Branches { get; set; }
        public List<CourierData> Couriers { get; set; }
    }

    public class CourierData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public Nullable<decimal> Rate { get; set; }        
        public Nullable<int> BranchId { get; set; }
        public string BranchName { get; set; }
        public string Address { get; set; }
        public Nullable<int> CityId { get; set; }
        public string CityName { get; set; }
        public string OfficePhone { get; set; }
        public string Fax { get; set; }
        public string Remarks { get; set; }
        public string Pin { get; set; }
        public string ContactPerson { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }

    public class BranchData
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}
