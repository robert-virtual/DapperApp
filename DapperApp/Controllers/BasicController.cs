using Dapper.Contrib.Extensions;
using DapperApp.DataAccess;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DapperApp.Controllers
{
    public class BasicController<T>:Connection where T: class
    {
        public List<T> GetAll()
        {
            using (var db = ConnectDB())
            {
                return db.GetAll<T>().ToList();
            }
        }

        public long Save(T entity)
        {
            using (var db = ConnectDB())
            {
                return db.Insert(entity);
            }
        }
    }
}
