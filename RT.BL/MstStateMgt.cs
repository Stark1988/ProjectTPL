using RT.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RT.BL
{
    public class MstStateMgt
    {
        TPLDBEntities db = new TPLDBEntities();

        public List<StateData> SelectData()
        {
            return (from s in db.MstStates
                    where s.IsDeleted == false
                    select new StateData
                    {
                        ID = s.StateId,
                        Name = s.StateName,
                        CreateBy = s.CreatedBy,
                        CreatedDate = s.CreatedDate,
                        UpdatedBy = s.UpdatedBy,
                        UpdatedDate = s.UpdatedDate,
                    }).ToList();
        }

        public int InsertState(string StateName)
        {
            MstState state = new MstState();
            state.CreatedBy = "admin";
            state.CreatedDate = DateTime.Now;
            state.IsDeleted = false;
            state.StateName = StateName;
            state.UpdatedBy = "admin";
            state.UpdatedDate = DateTime.Now;
            db.MstStates.Add(state);

            return db.SaveChanges();
        }

        public int UpdateState(int Id, string Name)
        {
            MstState state = db.MstStates.Find(Id);
            state.StateName = Name;

            return db.SaveChanges();
        }

        public int DeleteState(int Id)
        {
            MstState state = db.MstStates.Find(Id);
            state.IsDeleted = true;

            return db.SaveChanges();
        }
    }

    public class StateData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
