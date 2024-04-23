using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Company;Integrated Security=True;");
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            //command.CommandText = "select ID, Name from Department";
            command.CommandText = "update HR.Employee set Salary = salary + 1000";
            //command.CommandText = "procGetDepartments";
            //command.CommandType = System.Data.CommandType.StoredProcedure;

            #region Connected Mode

            //sqlConnection.Open();

            //SqlDataReader dataReader = command.ExecuteReader();

            //while(await dataReader.ReadAsync())
            //{
            //    int id = (int)dataReader["ID"];
            //    string name = dataReader["Name"].ToString();

            //    Console.WriteLine($"ID = {id} \t Name = {name}");
            //}

            //sqlConnection.Close();

            #endregion

            #region DisConnected Mode

            //DataTable dataTable = new DataTable();
            //SqlDataAdapter adapter = new SqlDataAdapter(command);

            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    int id = (int)row["ID"];
            //    string name = row["Name"].ToString();

            //    Console.WriteLine($"ID = {id} \t Name = {name}");
            //}

            #endregion

            //sqlConnection.Open();
            //command.ExecuteNonQuery();
            //sqlConnection.Close();
        }
    }
}
