using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Runtime.Serialization;

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

            dgvEmpoyees.ColumnHeaderMouseClick += dgvEmpoyeesHeaderClick;

            btSaveData.Click += btSaveDataClick;
            btLoadData.Click += btLoadDataClick;
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

        private void dgvEmpoyeesHeaderClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SortQueryBy(e.ColumnIndex);
        }

        private void SortQueryBy(int columnIndex)
        {
            switch (columnIndex)
            {
                case 0:
                    query = data.Employees.OrderBy(employee => employee.Name);
                    break;
                case 1:
                    query = data.Employees.OrderBy(employee => employee.Age);
                    break;
                case 2:
                    query = data.Employees.OrderBy(employee => employee.Salary);
                    break;
                case 3:
                    query = data.Employees.OrderBy(employee => employee.Department);
                    break;
                case 4:
                    query = data.Employees.OrderBy(employee => employee.DepartmentPhone);
                    break;
                case 5:
                    query = data.Employees.OrderBy(employee => employee.DepartmentAdress);
                    break;
            }

            bs.DataSource = null;
            bs.DataSource = query;
        }

        private void btSaveDataClick(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "XML files|*.xml";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFile.FileName;

                using (var stream = File.Create(fileName))
                {
                    var serializer = new DataContractSerializer(typeof(Data));
                    serializer.WriteObject(stream, data);
                }
            }
        }

        private void btLoadDataClick(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();
            openFile.Filter = "XML files|*.xml";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFile.FileName;

                using (var stream = File.OpenRead(fileName))
                {
                    var serializer = new DataContractSerializer(typeof(Data));
                    data = serializer.ReadObject(stream) as Data;
                    query = data.Employees;

                    bs.DataSource = query;

                    addEditEmployee.SetBinding(data.Departments);
                    editDepartments.SetBinding(data.Departments);
                }
            }
        }
    }
}
