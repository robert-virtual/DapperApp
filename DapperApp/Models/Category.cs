using Dapper.Contrib.Extensions;
using DapperApp.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DapperApp.Models
{
    [Table("Categories")]
    public class Category:CategoryController
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }

        [Write(false)]
        public List<Product> Products { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
