using System;
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
    public partial class MainForm : Form
    {
        Data data;

        AddEditEmployee addEditEmployee;
        EditDepartments editDepartments;

        IEnumerable<Employee> query;

        BindingSource bs;

        public MainForm()
        {
            InitializeComponent();

            data = new Data();

            data.Departments.Add(new Department("IT", "0503436617", "Le Street, 69"));
            data.Departments.Add(new Department("Management", "0203436247", "Le Street, 42"));
            data.Departments.Add(new Department("Accounting", "0203423427", "Le Street, 13"));

            data.Employees.Add(new Employee("John", 19, 6500, data.Departments[0]));
            data.Employees.Add(new Employee("Sam", 21, 6400, data.Departments[0]));
            data.Employees.Add(new Employee("Katy", 26, 4500, data.Departments[1]));

            addEditEmployee = new AddEditEmployee(data.Departments);
            editDepartments = new EditDepartments(data.Departments);

            bs = new BindingSource();

            query = data.Employees;

            bs.DataSource = query;

            dgvEmpoyees.DataSource = bs;

            btAddEmployee.Click += btAddEmployeeClick;
            btEditEmployee.Click += btEditEmployeeClick;
            btRemoveEmployee.Click += btRemoveEmployeeClick;

            btEditDepartments.Click += btEditDepartmentsClick;
        }

        private void btAddEmployeeClick(object sender, EventArgs e)
        {
            addEditEmployee.SetAdd();

            if (addEditEmployee.ShowDialog() == DialogResult.OK)
            {
                data.Employees.Add(addEditEmployee.WorkingEmployee);

                // Yeah, I don't like that too
                bs.DataSource = null;
                bs.DataSource = query;
            }
        }

        private void btEditEmployeeClick(object sender, EventArgs e)
        {
            if (bs.Current == null)
                return;

            addEditEmployee.SetEdit(bs.Current as Employee);

            if (addEditEmployee.ShowDialog() == DialogResult.OK)
            {
                bs.ResetBindings(false);
            }
        }

        private void btRemoveEmployeeClick(object sender, EventArgs e)
        {
            if (bs.Current != null)
                bs.RemoveCurrent();
        }

        private void btEditDepartmentsClick(object sender, EventArgs e)
        {
            editDepartments.ShowDialog();
            bs.ResetBindings(false);
        }
    }
}
