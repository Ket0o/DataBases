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
        public static string GetConnectionString(string username, string password)
        {
            var connectionStringBuilder =
                new SqlConnectionStringBuilder(Properties.Settings.Default
                    .Selection_committeeConnectionString);
            connectionStringBuilder.ConnectionString = connectionStringBuilder.ConnectionString 
                                                       + ";Database=AdmissionCommittee" 
                                                       + $";User ID={username}" 
                                                       + $";Password={password}";
            return connectionStringBuilder.ConnectionString;
        }
    }
}
