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

        public int RowCount()
        {
            return db.MstStates.Count();
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
    }
}
