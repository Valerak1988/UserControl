using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public float Price { get; set; }
        public string Pdesc { get; set; }
        public string PicName { get; set; }

        public static List<Product> GetAll()
        {
            return ProductDAL.GetAll();
        }
    }
}