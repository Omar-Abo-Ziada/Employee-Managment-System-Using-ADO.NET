using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal static class DataAccessLayer
    {
        private static SqlConnection sqlConnection;
        private static SqlCommand sqlCommand;
        private static SqlDataAdapter sqlAdapter;

        static DataAccessLayer()
        {
            sqlConnection = new SqlConnection("Data Source=DESKTOP-2U2SE1A;Initial Catalog=Company_SD;Integrated Security=True;");
            sqlCommand = new SqlCommand();
            sqlAdapter = new SqlDataAdapter(sqlCommand);
            sqlCommand.Connection = sqlConnection;
        }

        internal static DataTable GetDepartments()
        {
            sqlCommand.CommandText = "Select * from Departments";

            DataTable dataTable = new DataTable();

            sqlAdapter.Fill(dataTable);

            return dataTable;
        }

        internal static DataTable GetDepartment(int _dno)
        {
            sqlCommand.CommandText = $"Select * from Departments where dno = {_dno}";

            DataTable dataTable = new DataTable();

            sqlAdapter.Fill(dataTable);

            return dataTable;
        }

        internal static DataTable GetDepartmentEmployees(int _dno)
        {
            sqlCommand.CommandText = $"Select * from Employee where Dno = {_dno}";

            DataTable dataTable = new DataTable();

            sqlAdapter.Fill(dataTable);

            return dataTable;
        }

        internal static void AddEmployee(Employee emp)
        {
            sqlCommand.CommandText = $"INSERT INTO Employee (SSN, fname, Lname, Salary, Address, Dno, Bdate) " +
                           $"VALUES ({emp.SSN}, '{emp.FName}', '{emp.LName}', {emp.Salary}, '{emp.Address}', {emp.Department.ID}, '{emp.BirthDate:yyyy-MM-dd HH:mm:ss}')";

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        internal static void DeleteEmployee(int _SSN)
        {
            sqlCommand.CommandText = $"DELETE from Employee where SSN = {_SSN} ";

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        internal static void UpdateEmployee(int _SSN, Employee updatedEmp)
        {
            sqlCommand.CommandText = $"UPDATE Employee " +
                $"SET SSN = {_SSN}, Fname = '{updatedEmp.FName}', Lname = '{updatedEmp.LName}', Bdate = '{updatedEmp.BirthDate}', Address = '{updatedEmp.Address}', Salary = {updatedEmp.Salary}, Dno = {updatedEmp.Department.ID} " +
                $"WHERE SSN = {_SSN}";

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
