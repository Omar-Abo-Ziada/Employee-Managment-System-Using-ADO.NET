using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class BusinessLogicLayer
    {
        public static List<Department> Departments { get; set; }

        static BusinessLogicLayer()
        {
            Departments = new List<Department>();
        }

        public static void Intialize()
        {
            DataTable departmentsTable = DataAccessLayer.GetDepartments();

            foreach (DataRow depRow in departmentsTable.Rows)
            {
                Department department = new Department();

                if (depRow["Dnum"] == DBNull.Value)
                {
                    throw new Exception("Invalid Department ID, can't be NULL !");
                }
                else
                {
                    department.ID = (int)depRow["Dnum"];
                }

                if (depRow["Dname"] == DBNull.Value)
                {
                    throw new Exception("Invalid Department Name, can't be NULL !");
                }
                else
                {
                    department.Name = (string)depRow["DName"];
                }

                Departments.Add(department);

                DataTable EmployeesTable = DataAccessLayer.GetDepartmentEmployees((int)depRow["Dnum"]);

                List<Employee> EmployessList = new List<Employee>();

                DateTime currentDate = DateTime.Now;

                foreach (DataRow empRow in EmployeesTable.Rows)
                {
                    EmployessList.Add(new Employee()
                    {
                        SSN = empRow["SSN"] != DBNull.Value ? (int)empRow["SSN"] : -1,
                        FName = empRow["FName"] != DBNull.Value ? (string)empRow["FName"] : "",
                        LName = empRow["LName"] != DBNull.Value ? (string)empRow["LName"] : "",
                        Salary = empRow["Salary"] != DBNull.Value ? (int)empRow["Salary"] : 0,
                        Address = empRow["Address"] != DBNull.Value ? (string)empRow["Address"] : "",
                        BirthDate = empRow["BDate"] != DBNull.Value ? (DateTime)empRow["BDate"] : currentDate,
                        Department = department
                    });
                }
                department.Employees = EmployessList;
            }
        }

        public static List<Department> GetDepartments()
        {
            DataTable datatable = DataAccessLayer.GetDepartments();

            List<Department> departments = new List<Department>();

            foreach (DataRow dataRow in datatable.Rows)
            {
                departments.Add(new Department()
                {
                    ID = dataRow["DNum"] != DBNull.Value ? (int)dataRow["DNum"] : -1 ,
                    Name = dataRow["DName"] != DBNull.Value ? (string)dataRow["DName"] : "" ,
                });
            }
            return departments;
        }

        public static Department GetDepartmentFromDataBase(int _dno)
        {
            DataTable datatable = DataAccessLayer.GetDepartment(_dno);

            Department department = new Department()
            {
                ID = datatable.Rows[0]["ID"] != DBNull.Value ? (int)datatable.Rows[0]["ID"] : -1 ,
                Name = (string)datatable.Rows[0]["Name"],
            };

            return department;
        }

        public static Department SearchDepartmentByID(int _dno)
        {
            foreach (Department dep in Departments)
            {
                if (dep.ID == _dno)
                    return dep;
            }
            return null;
        }

        public static List<Employee> GetDepartmentEmployees(int _dno)
        {
            DataTable dataTable = DataAccessLayer.GetDepartmentEmployees(_dno);

            List<Employee> employees = new List<Employee>();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                employees.Add(new Employee()
                {
                    SSN = (int)dataRow["SSN"],
                    FName = (string)dataRow["Fname"],
                    LName = (string)dataRow["Lname"],
                    Salary = (int)(dataRow["Salary"]),
                });
            }
            return employees;
        }

        public static void AddEmployee(Employee newEmp)
        {
            Employee employee = new Employee()
            {
                SSN = newEmp.SSN,
                FName = newEmp.FName,
                LName = newEmp.LName,
                Salary = newEmp.Salary,
                BirthDate = newEmp.BirthDate,
                Department = newEmp.Department,
                Address = newEmp.Address,
            };

            employee.Department.Employees.Add(employee);

            DataAccessLayer.AddEmployee(employee);
        }

        public static void DeleteEmployee(int _SSN , int _ID)
        {
            Department department = SearchDepartmentByID(_ID);
            Employee employee = SearchEmployeeBySSN(_SSN);

            DataAccessLayer.DeleteEmployee(_SSN);

            department.Employees.Remove(employee);
        }

        public static void UpdateEmployee(int _SSN, int _ID , Employee updatedEmp)
        {
            Department targetdepartment = SearchDepartmentByID(_ID);
            Employee targetemployee = SearchEmployeeBySSN(_SSN);


            targetemployee.SSN = updatedEmp.SSN;
            targetemployee.FName = updatedEmp.FName;
            targetemployee.LName = updatedEmp.LName;
            targetemployee.Salary = updatedEmp.Salary;
            targetemployee.Department = updatedEmp.Department;
            targetemployee.Address = updatedEmp.Address;
            targetemployee.BirthDate = updatedEmp.BirthDate;

            DataAccessLayer.UpdateEmployee(_SSN , updatedEmp);
        }

        public static Employee SearchEmployeeBySSN(int _SSN)
        {
            foreach (Department department in Departments)
            {
                foreach (Employee emp in department.Employees)
                {
                    if (emp.SSN == _SSN)
                        return emp;
                }
            }
            return null;
        }    
    }
}
