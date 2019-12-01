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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpoyees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpoyees
            // 
            this.dgvEmpoyees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpoyees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpoyees.Location = new System.Drawing.Point(13, 13);
            this.dgvEmpoyees.Name = "dgvEmpoyees";
            this.dgvEmpoyees.Size = new System.Drawing.Size(721, 276);
            this.dgvEmpoyees.TabIndex = 0;
            // 
            // btAddEmployee
            // 
            this.btAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddEmployee.Location = new System.Drawing.Point(12, 298);
            this.btAddEmployee.Name = "btAddEmployee";
            this.btAddEmployee.Size = new System.Drawing.Size(303, 26);
            this.btAddEmployee.TabIndex = 1;
            this.btAddEmployee.Text = "Add employee";
            this.btAddEmployee.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.btEditEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditEmployee.Location = new System.Drawing.Point(12, 330);
            this.btEditEmployee.Name = "button2";
            this.btEditEmployee.Size = new System.Drawing.Size(303, 26);
            this.btEditEmployee.TabIndex = 2;
            this.btEditEmployee.Text = "Edit employee";
            this.btEditEmployee.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.btRemoveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoveEmployee.Location = new System.Drawing.Point(12, 362);
            this.btRemoveEmployee.Name = "button3";
            this.btRemoveEmployee.Size = new System.Drawing.Size(303, 26);
            this.btRemoveEmployee.TabIndex = 3;
            this.btRemoveEmployee.Text = "Remove employee";
            this.btRemoveEmployee.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.btEditDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditDepartments.Location = new System.Drawing.Point(321, 298);
            this.btEditDepartments.Name = "button4";
            this.btEditDepartments.Size = new System.Drawing.Size(158, 90);
            this.btEditDepartments.TabIndex = 4;
            this.btEditDepartments.Text = "Edit departments";
            this.btEditDepartments.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.btSaveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaveData.Location = new System.Drawing.Point(486, 299);
            this.btSaveData.Name = "button5";
            this.btSaveData.Size = new System.Drawing.Size(248, 40);
            this.btSaveData.TabIndex = 5;
            this.btSaveData.Text = "Save Data";
            this.btSaveData.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.btLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadData.Location = new System.Drawing.Point(486, 348);
            this.btLoadData.Name = "button6";
            this.btLoadData.Size = new System.Drawing.Size(248, 40);
            this.btLoadData.TabIndex = 6;
            this.btLoadData.Text = "Load Data";
            this.btLoadData.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 400);
            this.Controls.Add(this.btLoadData);
            this.Controls.Add(this.btSaveData);
            this.Controls.Add(this.btEditDepartments);
            this.Controls.Add(this.btRemoveEmployee);
            this.Controls.Add(this.btEditEmployee);
            this.Controls.Add(this.btAddEmployee);
            this.Controls.Add(this.dgvEmpoyees);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(762, 439);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(762, 439);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpoyees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpoyees;
        private System.Windows.Forms.Button btAddEmployee;
        private System.Windows.Forms.Button btEditEmployee;
        private System.Windows.Forms.Button btRemoveEmployee;
        private System.Windows.Forms.Button btEditDepartments;
        private System.Windows.Forms.Button btSaveData;
        private System.Windows.Forms.Button btLoadData;
    }
}

