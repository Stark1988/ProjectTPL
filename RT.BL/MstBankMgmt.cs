using RT.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RT.BL
{
    public class MstBankMgmt
    {
        TPLDBEntities db = new TPLDBEntities();

        public List<BankData> SelectData()
        {
            return (from b in db.MstBanks
                    where b.IsDeleted == false
                    select new BankData
                    {
                        ID = b.BankId,
                        Name = b.BankName,
                        CreateBy = b.CreatedBy,
                        CreatedDate = b.CreatedDate,
                        UpdatedBy = b.UpdatedBy,
                        UpdatedDate = b.UpdatedDate,
                    }).ToList();
        }

        public int InsertBank(string BankName)
        {
            MstBank bank = new MstBank();
            bank.CreatedBy = "admin";
            bank.CreatedDate = DateTime.Now;
            bank.IsDeleted = false;
            bank.BankName = BankName;
            bank.UpdatedBy = "admin";
            bank.UpdatedDate = DateTime.Now;
            db.MstBanks.Add(bank);

            return db.SaveChanges();
        }

        public int UpdateBank(int Id, string Name)
        {
            MstBank bank = db.MstBanks.Find(Id);
            bank.BankName = Name;
            bank.UpdatedBy = "admin";
            bank.UpdatedDate = DateTime.Now;
            return db.SaveChanges();
        }

        public int DeleteBank(int Id)
        {
            MstBank bank = db.MstBanks.Find(Id);
            bank.IsDeleted = true;
            bank.UpdatedBy = "admin";
            bank.UpdatedDate = DateTime.Now;
            return db.SaveChanges();
        }
    }

    public class BankData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
