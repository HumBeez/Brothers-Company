using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BrothersCompany.DomainCore.Helpers
{
    public class ConnectionRetreiver : IConnectionRetreiver
    {
        public IDbConnection GetDbConnection()
        {
            string BcDbConnectionString = ConfigurationManager.ConnectionStrings[""].ToString();
            SqlConnection BcDbconnection = new SqlConnection(BcDbConnectionString);
            return BcDbconnection;
        }
    }
}
