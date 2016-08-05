using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

    public class User
    {
        public static int UserId { get; set; }
        public static string UserName { get; set; }
        public static int UserType { get; set; }
    }
}
