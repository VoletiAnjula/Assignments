using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using AssignBAL;

namespace assignDAL
{
    public class DAL
    {
        // SqlConnection con = new SqlConnection("server=WINDOWS-TCT2IP9\\SQLEXPRESS;Integrated security=true;database=northwind");
        SqlConnection con = new SqlConnection("server=WINDOWS-TCT2IP9\\sqlexpress;Integrated Security=true;database=northwind");
        public List<invoice> getdetails(int id)
        {
            List<invoice> listinv = new List<invoice>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[fn_invoicegen](" + id + ")", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                while (dr.Read())
                {
                    invoice inv = new invoice();
                    inv.CustomerID = dr["CustomerID"].ToString();
                    inv.CustomerName = dr["CompanyName"].ToString();
                    inv.City = dr["City"].ToString();
                    inv.ProductID = Convert.ToInt32(dr["ProductID"]);
                    inv.ProductName = dr["ProductName"].ToString();
                    inv.UnitPrice = Convert.ToInt32(dr["UnitPrice"]);
                    inv.QuantityPerUnit = dr["Quantity"].ToString();
                    inv.OrderID = Convert.ToInt32(dr["OrderID"]);
                    inv.OrderDate = dr["OrderDate"].ToString();
                    inv.EmployeeID = Convert.ToInt32(dr["EmployeeID"]);
                    inv.Discount = Convert.ToDouble(dr["Discount"]);
                    inv.Amt = Convert.ToDouble(dr["Amt"]);
                    inv.Total = Convert.ToDouble(dr["Total"]);

                    listinv.Add(inv);
                }
                con.Close();
            }
            return listinv;
        }
    }
   
}
