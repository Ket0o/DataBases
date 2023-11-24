using System.Data.SqlClient;

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
