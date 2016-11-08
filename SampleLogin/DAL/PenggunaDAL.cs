using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SampleLogin.Models;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace SampleLogin.DAL
{
    public class PenggunaDAL
    {
        private string GetConnStr()
        {
            return @"Data Source=.\SQLEXPRESS;
                     Initial Catalog=SampleShopDb;
                     Integrated Security=True";
        }

        public string GetMD5Hash(string password)
        {
            UnicodeEncoding unicode = new UnicodeEncoding();
            var dataHash = unicode.GetBytes(password);
            MD5 md5 = new MD5CryptoServiceProvider();
            var hasil = md5.ComputeHash(dataHash);
            return Convert.ToBase64String(hasil);
        }


    }
}