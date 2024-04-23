using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal class BLL
    {
        public static List<Department> GetDepartments()
        {
            DataTable dataTable = DAL.GetDepartments();
            List<Department> departments = new List<Department>();

            foreach (DataRow row in dataTable.Rows)
            {
                departments.Add(new Department
                {
                    ID = (int)row["ID"],
                    Name = (string)row["Name"],
                });
            }
            return departments;
        }
    }
}
