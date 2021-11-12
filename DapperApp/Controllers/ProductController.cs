using Dapper;
using Dapper.Contrib.Extensions;
using DapperApp.DataAccess;
using DapperApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DapperApp.Controllers
{
    public class ProductController:BasicController<Product> 
    {
        public List<Product> IncludeCats()
        {
            using (var db = ConnectDB())
            {
               
                var cats = db.GetAll<Category>().ToList();
                var prods = db.GetAll<Product>().ToList();
                var res = prods.ConvertAll(p => {
                    p.Category = cats.Find(cat => cat.CategoryId == p.CategoryFk);
                    return p;
                });
                
                return res.ToList();
            }
        }
    }
}
