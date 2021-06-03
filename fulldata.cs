using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace custordempdetassign.Models
{
    public class fulldata
    {

        public String CustomerID { get; set; }
        public String CompanyName { get; set; }
        public String City { get; set; }
        public Double Discount { get; set; }

        public int OrderID { get; set; }
        public String OrderDate { get; set; }
        public int EmployeeID { get; set; }
        public int ProductID { get; set; }
        public String ProductName { get; set; }
        public String QuantityPerUnit { get; set; }
        public Double UnitPrice { get; set; }

        public int Amt { get; set; }
        public int Total { get; set; }

    }
}