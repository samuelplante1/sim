using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class sql
    {
        public SqlDataReader SQL(string commande, string use) {
            SqlConnection sqlcon = connectToDB(use);
            SqlCommand command = sqlcon.CreateCommand();
            command.CommandText = commande;
            return command.ExecuteReader();
        }

        public SqlConnection connectToDB(string use)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source = ed4sql2; Initial Catalog = " + use + "; Integrated Security = True");
            sqlcon.Open();
            return sqlcon;
        }
    }
}
