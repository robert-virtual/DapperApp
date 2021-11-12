using Dapper.Contrib.Extensions;
using DapperApp.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DapperApp.Models
{
    [Table("Products")]
    public class Product:ProductController
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        
        [Write(false)]
        public Category Category { get; set; }
        public int CategoryFk { get; set; }

         
    }
}
