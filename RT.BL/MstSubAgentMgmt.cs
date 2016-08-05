using RT.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RT.BL
{
    public class MstSubAgentMgmt
    {
        TPLDBEntities db = new TPLDBEntities();

        public MstSubAgentMgmtData SelectData()
        {
            MstSubAgentMgmtData subAgentMgmtData = new MstSubAgentMgmtData();

            subAgentMgmtData.SubAgents = (from agent in db.MstSubAgents
                                          where agent.IsDeleted == false
                                          select new SubAgentData
                                          {
                                              SubAgentId = agent.SubAgentId,
                                              SubAgentName = agent.SubAgentName,
                                              Address = agent.Address,
                                              CityId = agent.fkCityId,
                                              CityName = agent.MstCity.CityName,
                                              OfficePhone = agent.OfficePhone,
                                              Fax = agent.Fax,
                                              Remarks = agent.Remarks,
                                              CreatedBy = agent.CreatedBy,
                                              CreatedDate = agent.CreatedDate,
                                              UpdatedBy = agent.UpdatedBy,
                                              UpdatedDate = agent.UpdatedDate
                                          }).ToList();

            MstCityMgmt cityMgmt = new MstCityMgmt();
            subAgentMgmtData.Cities = cityMgmt.SelectData().Cities;

            return subAgentMgmtData;
        }

        public int InsertSubAgent(SubAgentData subAgentData)
        {
            MstSubAgent subAgent = new MstSubAgent();

            subAgent.SubAgentName = subAgentData.SubAgentName;
            subAgent.Address = subAgentData.Address;
            subAgent.fkCityId = subAgentData.CityId;
            subAgent.OfficePhone = subAgentData.OfficePhone;
            subAgent.Fax = subAgentData.Fax;
            subAgent.ResPhone = subAgentData.ResPhone;
            subAgent.MobileNumber = subAgentData.MobileNumber;
            subAgent.Remarks = subAgentData.Remarks;
            subAgent.CreatedBy = "admin";
            subAgent.CreatedDate = DateTime.Now;
            subAgent.UpdatedBy = "admin";
            subAgent.UpdatedDate = DateTime.Now;

            db.MstSubAgents.Add(subAgent);
            return db.SaveChanges();
        }

        public int UpdateSubAgent(int Id, SubAgentData subAgentData)
        {
            MstSubAgent subAgent = db.MstSubAgents.Find(Id);
            subAgent.SubAgentName = subAgentData.SubAgentName;
            subAgent.Address = subAgentData.Address;
            subAgent.fkCityId = subAgentData.CityId;
            subAgent.OfficePhone = subAgentData.OfficePhone;
            subAgent.Fax = subAgentData.Fax;
            subAgent.ResPhone = subAgentData.ResPhone;
            subAgent.MobileNumber = subAgentData.MobileNumber;
            subAgent.Remarks = subAgentData.Remarks;
            subAgent.UpdatedBy = "admin";
            subAgent.UpdatedDate = DateTime.Now;

            return db.SaveChanges();
        }

        public int DeleteSubAgent(int Id)
        {
            MstSubAgent subAgent = db.MstSubAgents.Find(Id);

            subAgent.IsDeleted = true;
            subAgent.UpdatedBy = "admin";
            subAgent.UpdatedDate = DateTime.Now;

            return db.SaveChanges();
        }
    }

    public class MstSubAgentMgmtData
    {
        public List<SubAgentData> SubAgents { get; set; }
        public List<CityData> Cities { get; set; }
    }

    public class SubAgentData
    {
        public int SubAgentId { get; set; }
        public string SubAgentName { get; set; }
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
