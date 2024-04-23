﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbDepartments.DisplayMember = "Name";
            cmbDepartments.ValueMember = "ID";
            cmbDepartments.DataSource = BLL.GetDepartments();
        }

        private void cmbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
