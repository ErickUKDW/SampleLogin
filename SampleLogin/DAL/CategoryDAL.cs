using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SampleLogin.Models;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;

namespace SampleLogin.DAL
{
    public class CategoryDAL
    {
        private string GetConnStr()
        {
            return ConfigurationManager
                .ConnectionStrings["SampleConnectionString"]
                .ConnectionString;
        }

        public IEnumerable<Category> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                string strSql = @"select * from Categories 
                                  order by CategoryName";

                return conn.Query<Category>(strSql);
            }
        }
    }
}