using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal class DAL
    {
        static SqlConnection sqlConnection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Company;Integrated Security=True;");
        static SqlCommand command = new SqlCommand();
        static DataTable dataTable = new DataTable();
        static SqlDataAdapter adapter = new SqlDataAdapter(command);

        static DAL()
        {
            command.Connection = sqlConnection;
        }

        public static DataTable GetDepartments()
        {
            command.CommandText = "select ID, Name from Department";
            adapter.Fill(dataTable);

            return dataTable;
        }

        public static DataTable GetDepartmentEmployees(int id)
        {
            command.CommandText = $"select * from HR.Employee where DeptID = {id}";
            adapter.Fill(dataTable);

            return dataTable;
        }
    }
}
