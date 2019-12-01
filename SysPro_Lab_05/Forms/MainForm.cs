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
        AddEditEmployee addEditEmployee;

        BindingSource bs;

        public MainForm()
        {
            InitializeComponent();

            Program.data.Departments.Add(new Department("IT", "0503436617", "Le Street, 69"));
            Program.data.Departments.Add(new Department("Management", "0203436247", "Le Street, 42"));
            Program.data.Departments.Add(new Department("Accounting", "0203423427", "Le Street, 13"));

            Program.data.Employees.Add(new Employee("John", 19, 6500, Program.data.Departments[0]));
            Program.data.Employees.Add(new Employee("Sam", 21, 6400, Program.data.Departments[0]));
            Program.data.Employees.Add(new Employee("Katy", 26, 4500, Program.data.Departments[1]));

            addEditEmployee = new AddEditEmployee();

            bs = new BindingSource();

            bs.DataSource = Program.data.Employees;

            dgvEmpoyees.DataSource = bs;

            btAddEmployee.Click += btAddEmployeeClick;
            btEditEmployee.Click += btEditEmployeeClick;
            btRemoveEmployee.Click += btRemoveEmployeeClick;
        }

        private void btRemoveEmployeeClick(object sender, EventArgs e)
        {
            if(bs.Current != null)
                bs.RemoveCurrent();
        }

        private void btEditEmployeeClick(object sender, EventArgs e)
        {
            if (bs.Current == null)
                return;

            addEditEmployee.SetEdit(bs.Current as Employee);

            if(addEditEmployee.ShowDialog() == DialogResult.OK)
            {
                bs.ResetBindings(false);
            }
        }

        private void btAddEmployeeClick(object sender, EventArgs e)
        {
            addEditEmployee.SetAdd();

            if(addEditEmployee.ShowDialog() == DialogResult.OK)
            {
                bs.Add(addEditEmployee.WorkingEmployee);
            }
        }
    }
}
