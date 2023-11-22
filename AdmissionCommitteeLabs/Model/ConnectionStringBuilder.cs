using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionCommitteeLabs.Model
{
    public static class ConnectionStringBuilder
    {
        public static string GetConnectionString(string Username, string Password)
        {
            SqlConnectionStringBuilder connectionStringBuilder =
                new SqlConnectionStringBuilder(AdmissionCommitteeLabs.Properties.Settings.Default.Selection_committeeConnectionString);
            connectionStringBuilder.ConnectionString = connectionStringBuilder.ConnectionString 
                                                       + $";Database=AdmissionCommittee" 
                                                       + $";User ID={Username}" 
                                                       + $";Password={Password}";
            return connectionStringBuilder.ConnectionString;
        }
    }
}
