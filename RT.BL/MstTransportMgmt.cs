using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RT.DL;

namespace RT.BL
{
    public class MstTransportMgmt
    {
        TPLDBEntities db = new TPLDBEntities();

        public MstTransportMgmtData SelectData()
        {
            MstTransportMgmtData transportMgmtData = new MstTransportMgmtData();

            transportMgmtData.Transports = (from trans in db.MstTransports
                                            where trans.IsDeleted == false
                                            select new TransportData
                                            {
                                                ID = trans.TransportId,
                                                TransportName = trans.TransportName,
                                                ContactPerson = trans.ContactPerson,
                                                MobileNumber = trans.MobileNumber,
                                                ResPhone = trans.ResPhone,
                                                Address = trans.Address,
                                                CityId = trans.fkCityId,
                                                CityName = trans.MstCity.CityName,
                                                OfficePhone = trans.OfficePhone,
                                                Fax = trans.Fax,
                                                Remarks = trans.Remarks,
                                                CreatedBy = trans.CreatedBy,
                                                CreatedDate = trans.CreatedDate,
                                                UpdatedBy = trans.UpdatedBy,
                                                UpdatedDate = trans.UpdatedDate
                                            }).ToList();

            MstCityMgmt cityMgmt = new MstCityMgmt();
            transportMgmtData.Cities = cityMgmt.SelectData().Cities;

            return transportMgmtData;
        }

        public int InsertTransport(TransportData transportData)
        {
            MstTransport trans = new MstTransport
            {
                TransportName = transportData.TransportName,
                ContactPerson = transportData.ContactPerson,
                Address = transportData.Address,
                fkCityId = transportData.CityId,
                OfficePhone = transportData.OfficePhone,
                Fax = transportData.Fax,
                ResPhone = transportData.ResPhone,
                MobileNumber = transportData.MobileNumber,
                Remarks = transportData.Remarks,
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                UpdatedBy = "admin",
                UpdatedDate = DateTime.Now,
                IsDeleted = false
            };

            db.MstTransports.Add(trans);
            return db.SaveChanges();
        }

        public int UpdateCourier(int Id, TransportData transportData)
        {
            MstTransport trans = db.MstTransports.Find(Id);
            trans.TransportName = transportData.TransportName;
            trans.ContactPerson = transportData.ContactPerson;
            trans.Address = transportData.Address;
            trans.fkCityId = transportData.CityId;
            trans.OfficePhone = transportData.OfficePhone;
            trans.Fax = transportData.Fax;
            trans.ResPhone = transportData.ResPhone;
            trans.MobileNumber = transportData.MobileNumber;
            trans.Remarks = transportData.Remarks;
            trans.UpdatedBy = "admin";
            trans.UpdatedDate = DateTime.Now;

            return db.SaveChanges();
        }

        public int DeleteCourier(int Id)
        {
            MstTransport transport = db.MstTransports.Find(Id);

            transport.IsDeleted = true;
            transport.UpdatedBy = "admin";
            transport.UpdatedDate = DateTime.Now;

            return db.SaveChanges();
        }

    }

    public class MstTransportMgmtData
    {
        public List<CityData> Cities { get; set; }
        public List<TransportData> Transports { get; set; }
    }

    public class TransportData
    {
        public int ID { get; set; }
        public string TransportName { get; set; }
        public string ContactPerson { get; set; }
        public string Address { get; set; }
        public Nullable<int> CityId { get; set; }
        public string CityName { get; set; }
        public string OfficePhone { get; set; }
        public string Fax { get; set; }
        public string ResPhone { get; set; }
        public string MobileNumber { get; set; }
        public string Remarks { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}
