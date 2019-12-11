using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        //string selectedDepartment;

        bool isOrdered = false;
        int orderIndex;

        BindingSource bsEmployeeQuery;
        BindingSource bsDepartmentOptions;

        public MainForm()
        {
            InitializeComponent();

            data = new Data();

            addEditEmployee = new AddEditEmployee(data.Departments);
            editDepartments = new EditDepartments(data.Departments);

            bsEmployeeQuery = new BindingSource();
            bsDepartmentOptions = new BindingSource();

            query = data.Employees;

            bsEmployeeQuery.DataSource = query;
            bsDepartmentOptions.DataSource = data.DepartmentFilterOptions;

            dgvEmpoyees.DataSource = bsEmployeeQuery;

            cbDepartmentFilter.DataSource = bsDepartmentOptions;
            cbDepartmentFilter.SelectedIndexChanged += cbDepartmentFilterChanged;

            btAddEmployee.Click += btAddEmployeeClick;
            btEditEmployee.Click += btEditEmployeeClick;
            btRemoveEmployee.Click += btRemoveEmployeeClick;

            btEditDepartments.Click += btEditDepartmentsClick;

            btResetSorting.Click += btResetSortingclick;

            dgvEmpoyees.ColumnHeaderMouseClick += dgvEmpoyeesHeaderClick;

            btSaveData.Click += btSaveDataClick;
            btLoadData.Click += btLoadDataClick;
        }

        private void cbDepartmentFilterChanged(object sender, EventArgs e)
        {
            var selectedDepartment = (string)cbDepartmentFilter.SelectedItem;

            if (selectedDepartment == "All departments")
            {
                query = data.Employees;
            }
            else
            {
                query = data.Employees.Where(employee => employee.Department.Name == selectedDepartment);
            }

            if(isOrdered)
                SortQuery();

            bsEmployeeQuery.DataSource = query;
        }

        private void btResetSortingclick(object sender, EventArgs e)
        {
            isOrdered = false;

            query = data.Employees;

            bsEmployeeQuery.DataSource = query;
        }

        private void btAddEmployeeClick(object sender, EventArgs e)
        {
            addEditEmployee.SetAdd();

            if (addEditEmployee.ShowDialog() == DialogResult.OK)
            {
                data.Employees.Add(addEditEmployee.WorkingEmployee);

                // Yeah, I don't like that too
                bsEmployeeQuery.DataSource = null;
                bsEmployeeQuery.DataSource = query;
            }
        }

        private void btEditEmployeeClick(object sender, EventArgs e)
        {
            if (bsEmployeeQuery.Current == null)
                return;

            addEditEmployee.SetEdit(bsEmployeeQuery.Current as Employee);

            if (addEditEmployee.ShowDialog() == DialogResult.OK)
            {
                bsEmployeeQuery.ResetBindings(false);
            }
        }

        private void btRemoveEmployeeClick(object sender, EventArgs e)
        {
            if (bsEmployeeQuery.Current != null)
                bsEmployeeQuery.RemoveCurrent();
        }

        private void btEditDepartmentsClick(object sender, EventArgs e)
        {
            editDepartments.ShowDialog();
            bsEmployeeQuery.ResetBindings(false);
        }

        private void dgvEmpoyeesHeaderClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            orderIndex = e.ColumnIndex;
            isOrdered = true;
            SortQuery();
        }

        private void SortQuery()
        {
            switch (orderIndex)
            {
                case 0:
                    query = query.OrderBy(employee => employee.Name);
                    break;
                case 1:
                    query = query.OrderBy(employee => employee.Age);
                    break;
                case 2:
                    query = query.OrderBy(employee => employee.Salary);
                    break;
                case 3:
                    query = query.OrderBy(employee => employee.Department);
                    break;
                case 4:
                    query = query.OrderBy(employee => employee.DepartmentPhone);
                    break;
                case 5:
                    query = query.OrderBy(employee => employee.DepartmentAdress);
                    break;
            }

            bsEmployeeQuery.DataSource = query;
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

                    bsEmployeeQuery.DataSource = query;
                    bsDepartmentOptions.DataSource = data.DepartmentFilterOptions;

                    addEditEmployee.SetBinding(data.Departments);
                    editDepartments.SetBinding(data.Departments);
                }
            }
        }
    }
}
