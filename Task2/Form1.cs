using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BusinessLogicLayer.Intialize();

            comboBoxDepartments.DisplayMember = "Name"; // here have to mention the name of prop not sql name
            comboBoxDepartments.ValueMember = "ID"; // here have to mention the name of prop not sql name
            comboBoxDepartments.DataSource = BusinessLogicLayer.GetDepartments();

            comboBoxDepartmentChoose.DisplayMember = "Name"; // here have to mention the name of prop not sql name
            comboBoxDepartmentChoose.ValueMember = "ID"; // here have to mention the name of prop not sql name
            comboBoxDepartmentChoose.DataSource = BusinessLogicLayer.GetDepartments();

            // Assuming you have a DateTimePicker control named dateTimePicker1
            dateTimePickerBirthDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerBirthDate.CustomFormat = "yyyy-MM-dd"; // Example custom format, you can adjust it as needed

        }

        private void comboBoxDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxDepartmentsEmployees.DisplayMember = "fname";
            listBoxDepartmentsEmployees.ValueMember = "SSN";

            int selectedDeptNum = (int)comboBoxDepartments.SelectedValue;

            listBoxDepartmentsEmployees.DataSource = BusinessLogicLayer.GetDepartmentEmployees(selectedDeptNum);
        }
        private Employee collectEmployeeDate()
        {
            SSNRequiredMesage.Visible = false;
            fNameRequiredMesage.Visible = false;
            LNameRequiredMesage.Visible = false;
            SalaryRequiredMesage.Visible = false;

            bool isValid = true;

            if (textBoxSSN.Text == "")
            {
                isValid = false;
                SSNRequiredMesage.Visible = true;
            }


            if (textBoxFName.Text == "")
            {
                isValid = false;
                fNameRequiredMesage.Visible = true;
            }


            if (textBoxLName.Text == "")
            {
                isValid = false;
                LNameRequiredMesage.Visible = true;
            }


            if (textBoxSalary.Text == "")
            {
                isValid = false;
                SalaryRequiredMesage.Visible = true;
            }


            if (isValid)
            {
                Employee employee = new Employee();

                employee.SSN = int.Parse(textBoxSSN.Text);
                employee.FName = textBoxFName.Text;
                employee.LName = textBoxLName.Text;
                employee.Salary = int.Parse(textBoxSalary.Text);
                employee.Address = textBoxAdress.Text;

                DateTime birthDate = dateTimePickerBirthDate.Value;
                employee.BirthDate = birthDate;

                employee.Department = BusinessLogicLayer.SearchDepartmentByID((int)comboBoxDepartmentChoose.SelectedValue);

                return employee;
            }
            else
            {
                return null;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Employee employee = collectEmployeeDate();

            if (employee != null)
            {
                BusinessLogicLayer.AddEmployee(employee);

                // then updating the list immediately not waiting for comboBoxDepartments_SelectedIndexChange
                listBoxDepartmentsEmployees.DisplayMember = "fname";
                listBoxDepartmentsEmployees.ValueMember = "SSN";

                int selectedDeptNum = (int)comboBoxDepartments.SelectedValue;

                listBoxDepartmentsEmployees.DataSource = BusinessLogicLayer.GetDepartmentEmployees(selectedDeptNum);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int targetEmpSSN = (int)listBoxDepartmentsEmployees.SelectedValue;
            int targetDepID = (int)comboBoxDepartments.SelectedValue;

            BusinessLogicLayer.DeleteEmployee(targetEmpSSN, targetDepID);

            // then updating the list immediately not waiting for comboBoxDepartments_SelectedIndexChange
            listBoxDepartmentsEmployees.DisplayMember = "fname";
            listBoxDepartmentsEmployees.ValueMember = "SSN";

            int selectedDeptNum = (int)comboBoxDepartments.SelectedValue;

            listBoxDepartmentsEmployees.DataSource = BusinessLogicLayer.GetDepartmentEmployees(selectedDeptNum);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int targetEmpSSN = (int)listBoxDepartmentsEmployees.SelectedValue;
            int targetDepID = (int)comboBoxDepartments.SelectedValue;

             Employee updatedEmployee = collectEmployeeDate();

            if (updatedEmployee != null)
            {
                BusinessLogicLayer.UpdateEmployee(targetEmpSSN, targetDepID  , updatedEmployee);

                // then updating the list immediately not waiting for comboBoxDepartments_SelectedIndexChange
                listBoxDepartmentsEmployees.DisplayMember = "fname";
                listBoxDepartmentsEmployees.ValueMember = "SSN";

                int selectedDeptNum = (int)comboBoxDepartments.SelectedValue;

                listBoxDepartmentsEmployees.DataSource = BusinessLogicLayer.GetDepartmentEmployees(selectedDeptNum);
            }
                
            //================================================================

            // another Solution :

            ////delete first: 
            //int targetEmpSSN = (int)listBoxDepartmentsEmployees.SelectedValue;
            //int targetDepID = (int)comboBoxDepartments.SelectedValue;

            //BusinessLogicLayer.DeleteEmployee(targetEmpSSN, targetDepID);

            ////then add new employee with the new values : 
        }
    }
}
