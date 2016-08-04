using RT.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RT.BL
{
    public class MstCityMgmt
    {
        TPLDBEntities db = new TPLDBEntities();

        public MstCityMgmtData SelectData()
        {
            MstCityMgmtData cityMgmtData = new MstCityMgmtData();

            cityMgmtData.Cities = (from c in db.MstCities
                    where c.IsDeleted == false
                    select new CityData
                    {
                        ID = c.CityId,
                        Name = c.CityName,
                        StateId = c.MstState.StateId,
                        StateName = c.MstState.StateName,
                        STDCode = c.STDCode,
                        CreatedBy = c.CreatedBy,
                        CreatedDate = c.CreatedDate,
                        UpdatedBy = c.UpdatedBy,
                        UpdatedDate = c.UpdatedDate
                        
                    }).ToList();
            MstStateMgt stateMgmt = new MstStateMgt();
            cityMgmtData.States = stateMgmt.SelectData();

            return cityMgmtData;
        }

        public int InsertCity(string cityName, int stateId, string stdCode)
        {
            MstCity city = new MstCity();
            city.CreatedBy = "admin";
            city.CreatedDate = DateTime.Now;
            city.IsDeleted = false;
            city.CityName = cityName;
            city.fkStateId = stateId;
            city.STDCode = stdCode;
            city.UpdatedBy = "admin";
            city.UpdatedDate = DateTime.Now;
            db.MstCities.Add(city);

            return db.SaveChanges();
        }

        public int UpdateCity(int Id, string cityName, int stateId, string stdCode)
        {
            MstCity city = db.MstCities.Find(Id);
            city.CityName = cityName;
            city.fkStateId = stateId;
            city.STDCode = stdCode;
            city.UpdatedBy = "admin";
            city.UpdatedDate = DateTime.Now;

            return db.SaveChanges();
        }

        public int DeleteCity(int Id)
        {
            MstCity city = db.MstCities.Find(Id);
            city.IsDeleted = true;
            city.UpdatedBy = "admin";
            city.UpdatedDate = DateTime.Now;

            return db.SaveChanges();
        }
    }

    public class MstCityMgmtData
    {
        public List<CityData> Cities { get; set; }
        public List<StateData> States { get; set; }
    }

    public class CityData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public string StateName { get; set; }
        public string STDCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
