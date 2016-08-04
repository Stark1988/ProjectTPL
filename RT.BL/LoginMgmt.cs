using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RT.DL;

namespace RT.BL
{
    public class LoginMgmt
    {
        TPLDBEntities db = new TPLDBEntities();
        public UserData FetchUserData(string Username, string Password)
        {
            return (from u in db.MstUsers
                    where u.UserName == Username && u.Password == Password
                    select new UserData
                    {
                        UserId = u.UserId,
                        UserName = u.UserName,
                        UserType = u.fkUserTypeId.Value,
                    }).FirstOrDefault();
        }
    }

    public class UserData
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int UserType { get; set; }
    }
}
