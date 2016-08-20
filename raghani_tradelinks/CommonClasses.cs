using RT.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace raghani_tradelinks
{
    class Branch
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }

    class DealingType
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    class GRHabbit
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    class VisistFrequency
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    class SupplierJsonParse
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class User
    {
        public static int UserId { get; set; }
        public static string UserName { get; set; }
        public static int UserType { get; set; }
    }

    public class CommonMethods
    {
        public static void HandleException(Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        public static List<Supplier> GetSupplierData()
        {
            using (TPLDBEntities db = new TPLDBEntities())
            {
                return (from s in db.Suppliers
                        where s.IsDeleted == false
                        select s).ToList();
            };

        }

        public static List<Customer> GetCustomerata()
        {
            using (TPLDBEntities db = new TPLDBEntities())
            {
                return (from c in db.Customers
                        where c.IsDeleted == false
                        select c).ToList();
            };
        }
    }
}
