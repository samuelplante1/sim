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
        SqlConnection sqlcon;
        SqlCommand command;
        public sql(string commande, string use)
        {
            sqlcon = new SqlConnection("Data Source=ed4sql2.laboratoire.collegeem.qc.ca; Initial Catalog=" + use + "; User ID=Sim07_User; Pwd=Sim07_=2=3User:2018");
            sqlcon.Open();
            command = sqlcon.CreateCommand();
            command.CommandText = commande;
        }
        public SqlDataReader execute() {
            return command.ExecuteReader();
        }
        public void close() {
            sqlcon.Close();
        }
    }
}
