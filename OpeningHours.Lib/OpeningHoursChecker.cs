using System;
using System.Data.SqlClient;

namespace OpeningHours.Lib
{
    public class OpeningHoursChecker
    {
        public bool IsOpenAt(DateTime aDateTime)
        {
            SqlConnection cn = new SqlConnection("Data Source=.;Database=OpeningHours;Trusted_Connection=Yes");
            cn.Open();
            var cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT dbo.IsOpenAtDateTime(@date)";
            cmd.Parameters.AddWithValue("@date", aDateTime);
            bool result = (bool)cmd.ExecuteScalar();
            cn.Close();
            return result;
        }
    }
}
