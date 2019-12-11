namespace SysPro_Lab_05
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEmpoyees = new System.Windows.Forms.DataGridView();
            this.btAddEmployee = new System.Windows.Forms.Button();
            this.btEditEmployee = new System.Windows.Forms.Button();
            this.btRemoveEmployee = new System.Windows.Forms.Button();
            this.btEditDepartments = new System.Windows.Forms.Button();
            this.btSaveData = new System.Windows.Forms.Button();
            this.btLoadData = new System.Windows.Forms.Button();
            this.cbDepartmentFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btResetSorting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpoyees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpoyees
            // 
            this.dgvEmpoyees.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvEmpoyees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpoyees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpoyees.Location = new System.Drawing.Point(13, 44);
            this.dgvEmpoyees.Name = "dgvEmpoyees";
            this.dgvEmpoyees.Size = new System.Drawing.Size(721, 276);
            this.dgvEmpoyees.TabIndex = 0;
            // 
            // btAddEmployee
            // 
            this.btAddEmployee.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddEmployee.Location = new System.Drawing.Point(12, 329);
            this.btAddEmployee.Name = "btAddEmployee";
            this.btAddEmployee.Size = new System.Drawing.Size(303, 26);
            this.btAddEmployee.TabIndex = 1;
            this.btAddEmployee.Text = "Add employee";
            this.btAddEmployee.UseVisualStyleBackColor = true;
            // 
            // btEditEmployee
            // 
            this.btEditEmployee.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btEditEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditEmployee.Location = new System.Drawing.Point(12, 361);
            this.btEditEmployee.Name = "btEditEmployee";
            this.btEditEmployee.Size = new System.Drawing.Size(303, 26);
            this.btEditEmployee.TabIndex = 2;
            this.btEditEmployee.Text = "Edit employee";
            this.btEditEmployee.UseVisualStyleBackColor = true;
            // 
            // btRemoveEmployee
            // 
            this.btRemoveEmployee.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btRemoveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoveEmployee.Location = new System.Drawing.Point(12, 393);
            this.btRemoveEmployee.Name = "btRemoveEmployee";
            this.btRemoveEmployee.Size = new System.Drawing.Size(303, 26);
            this.btRemoveEmployee.TabIndex = 3;
            this.btRemoveEmployee.Text = "Remove employee";
            this.btRemoveEmployee.UseVisualStyleBackColor = true;
            // 
            // btEditDepartments
            // 
            this.btEditDepartments.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btEditDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditDepartments.Location = new System.Drawing.Point(321, 329);
            this.btEditDepartments.Name = "btEditDepartments";
            this.btEditDepartments.Size = new System.Drawing.Size(158, 90);
            this.btEditDepartments.TabIndex = 4;
            this.btEditDepartments.Text = "Edit departments";
            this.btEditDepartments.UseVisualStyleBackColor = true;
            // 
            // btSaveData
            // 
            this.btSaveData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btSaveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaveData.Location = new System.Drawing.Point(486, 330);
            this.btSaveData.Name = "btSaveData";
            this.btSaveData.Size = new System.Drawing.Size(248, 40);
            this.btSaveData.TabIndex = 5;
            this.btSaveData.Text = "Save Data";
            this.btSaveData.UseVisualStyleBackColor = true;
            // 
            // btLoadData
            // 
            this.btLoadData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadData.Location = new System.Drawing.Point(486, 379);
            this.btLoadData.Name = "btLoadData";
            this.btLoadData.Size = new System.Drawing.Size(248, 40);
            this.btLoadData.TabIndex = 6;
            this.btLoadData.Text = "Load Data";
            this.btLoadData.UseVisualStyleBackColor = true;
            // 
            // cbDepartmentFilter
            // 
            this.cbDepartmentFilter.FormattingEnabled = true;
            this.cbDepartmentFilter.Location = new System.Drawing.Point(102, 12);
            this.cbDepartmentFilter.Name = "cbDepartmentFilter";
            this.cbDepartmentFilter.Size = new System.Drawing.Size(195, 21);
            this.cbDepartmentFilter.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Department filter";
            // 
            // btFilterDepartment
            // 
            this.btResetSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResetSorting.Location = new System.Drawing.Point(600, 12);
            this.btResetSorting.Name = "btFilterDepartment";
            this.btResetSorting.Size = new System.Drawing.Size(134, 26);
            this.btResetSorting.TabIndex = 9;
            this.btResetSorting.Text = "Reset sorting";
            this.btResetSorting.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 431);
            this.Controls.Add(this.btResetSorting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDepartmentFilter);
            this.Controls.Add(this.btLoadData);
            this.Controls.Add(this.btSaveData);
            this.Controls.Add(this.btEditDepartments);
            this.Controls.Add(this.btRemoveEmployee);
            this.Controls.Add(this.btEditEmployee);
            this.Controls.Add(this.btAddEmployee);
            this.Controls.Add(this.dgvEmpoyees);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(762, 470);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(762, 470);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpoyees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpoyees;
        private System.Windows.Forms.Button btAddEmployee;
        private System.Windows.Forms.Button btEditEmployee;
        private System.Windows.Forms.Button btRemoveEmployee;
        private System.Windows.Forms.Button btEditDepartments;
        private System.Windows.Forms.Button btSaveData;
        private System.Windows.Forms.Button btLoadData;
        private System.Windows.Forms.ComboBox cbDepartmentFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btResetSorting;
    }
}

