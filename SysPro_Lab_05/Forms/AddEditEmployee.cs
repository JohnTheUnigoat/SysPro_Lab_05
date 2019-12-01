﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPro_Lab_05
{
    public partial class AddEditEmployee : Form
    {
        public Employee WorkingEmployee { get; private set; }

        public AddEditEmployee()
        {
            InitializeComponent();

            cbDepartments.DataSource = Program.data.Departments;

            btOK.Click += btOkClick;
        }

        private void btOkClick(object sender, EventArgs e)
        {
            if(WorkingEmployee == null)
            {
                WorkingEmployee = new Employee(
                    tbName.Text,
                    (int)numAge.Value,
                    numSalary.Value,
                    cbDepartments.SelectedItem as Department
                    );
            }
            else
            {
                WorkingEmployee.Name = tbName.Text;
                WorkingEmployee.Age = (int)numAge.Value;
                WorkingEmployee.Salary = numSalary.Value;
                WorkingEmployee.Department = cbDepartments.SelectedItem as Department;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        public void SetAdd()
        {
            Text = "Add employee";

            tbName.Text = "";
            numAge.Value = 0;
            numSalary.Value = 0;
            cbDepartments.SelectedIndex = 0;

            WorkingEmployee = null;
        }

        public void SetEdit(Employee employee)
        {
            Text = "Edit employee";

            tbName.Text = employee.Name;
            numAge.Value = employee.Age;
            numSalary.Value = employee.Salary;
            cbDepartments.SelectedItem = employee.Department;

            WorkingEmployee = employee;
        }
    }
}
