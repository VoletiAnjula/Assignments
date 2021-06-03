using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using assignDAL;
using AssignBAL;
using custordempdetassign.Models;

namespace custordempdetassign.Controllers
{
    public class ValuesController : ApiController
    {
        
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public List<fulldata> Get(int id)
        {
            DAL ad = new DAL();
            List<invoice> inlist = new List<invoice>();
            List<fulldata> fdlist = new List<fulldata>();
            inlist = ad.getdetails(id);
            foreach (var item in inlist)
            {
                fulldata d = new fulldata();
                //Details d = new Details();
                d.CustomerID = item.CustomerID;
                d.CompanyName = item.CustomerName;
                d.City = item.City;
                d.EmployeeID = item.EmployeeID;
                d.OrderID = item.OrderID;
                d.OrderDate = item.OrderDate;
                d.ProductID = item.ProductID;
                d.ProductName = item.ProductName;
                d.QuantityPerUnit = item.QuantityPerUnit;
                d.UnitPrice = item.UnitPrice;
                d.Discount = item.Discount;
                d.Amt = Convert.ToInt32(item.Amt);
                d.Total = Convert.ToInt32(item.Total);
                fdlist.Add(d);
            }
            return fdlist;
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

