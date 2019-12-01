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
    public partial class EditDepartments : Form
    {
        BindingSource bsDepartments;

        public EditDepartments()
        {
            InitializeComponent();

            bsDepartments = new BindingSource();

            bsDepartments.DataSource = Program.data.Departments;

            cbDepartments.DataSource = bsDepartments;

            tbName.DataBindings.Add("Text", bsDepartments, "Name");
            tbPhone.DataBindings.Add("Text", bsDepartments, "PhoneNumber");
            tbAddress.DataBindings.Add("Text", bsDepartments, "Address");

            btOK.Click += btOkClick;

            btAddDepartment.Click += btAddDepartmentClick;
            btRemoveDepartment.Click += btRemoveDepartmentlick;
        }

        private void btRemoveDepartmentlick(object sender, EventArgs e)
        {
            if (bsDepartments.Current != null)
            {
                (bsDepartments.Current as Department).MarkRemoved();
                bsDepartments.RemoveCurrent();
            }
        }

        private void btAddDepartmentClick(object sender, EventArgs e)
        {
            bsDepartments.Add(new Department("new_department", "0000000000", "department_adress"));
            bsDepartments.Position = bsDepartments.Count - 1;
        }

        private void btOkClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
