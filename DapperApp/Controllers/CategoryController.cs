using Dapper.Contrib.Extensions;
using DapperApp.DataAccess;
using DapperApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DapperApp.Controllers
{
    public class CategoryController:BasicController<Category>
    {
       
        public List<Category> IncludeProds()
        {
            using (var db = ConnectDB())
            {
                var prods = db.GetAll<Product>().ToList();
                var cats = db.GetAll<Category>().ToList();
                cats.ConvertAll(cat =>
                {
                    cat.Products = prods.FindAll(prod => prod.CategoryFk == cat.CategoryId);
                    return cat;
                });
                return cats;
            }
        }


    }
}
