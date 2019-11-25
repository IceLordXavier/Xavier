using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DDM
{
    public class DBConector
    {
        private SqlConnection connection;
        private static SqlConnectionStringBuilder builderString;
        private static string GetConnectionString()
        {
            builderString["DataSource"] = @"dbsys.cs.vsb.cz\STUDENT";
            builderString["UserID"] = "hec0051";
            builderString["Password"] = "qcMtesaPCb";
            builderString["InitialCatalog"] = "hec0051";
            return builderString.ConnectionString;
        }
        private static readonly DBConector conector = new DBConector()
        {
            connection = new SqlConnection(GetConnectionString())
                
        };
        private DBConector() { }
        public static DBConector GetConnector()
        {
            return conector; 
        }
        public SqlConnection GetSqlConnection()
        {
            if(connection.State == System.Data.ConnectionState.Broken)
            {
                connection.Close();
            }
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection; 
        }

       
        
    }
}
