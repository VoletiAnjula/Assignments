using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignBAL
{
    public class BAL
    {

    }
    public class customer
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }
    }
    public class products:customer
    {
        //public int prodid { get; set; }
        public string ProductName { get; set; }
    }
    public class orders:products
    {
        public int OrderID { get; set; }
       // public string custid { get; set; }
        public int EmployeeID { get; set; }
        public string OrderDate { get; set; }
    }
    public class orderdet:orders
    {
        public int ProductID { get; set; }
        public double UnitPrice { get; set; }
        public double Discount { get; set; }
        public string QuantityPerUnit { get; set; }
        

    }
    
    public class invoice : orderdet
    {
        public double Amt { get; set; }
        public double Total { get; set; }
    }
}
