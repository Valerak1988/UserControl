using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using BLL;
using DATA;

namespace DAL
{
    public class ProductDAL
    {
        public static List<Product> GetAll()
        {
            DbContext Db = new DbContext();
            string Sql = "Select * From T_Product";
            DataTable Dt = Db.Execute(Sql);
            List<Product> ProductList = new List<Product>();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                Product Temp = new Product()
                {
                    Pid = int.Parse(Dt.Rows[i]["Pid"] + ""),
                    Pname = Dt.Rows[i]["Pname"] + "",
                    Price = float.Parse(Dt.Rows[i]["Price"] + ""),
                    Pdesc = Dt.Rows[i]["Pdesc"] + "",
                    PicName = Dt.Rows[i]["PicName"] + "",
                };
                ProductList.Add(Temp);
            }
            Db.Close();
            return ProductList;
        }
    }
}