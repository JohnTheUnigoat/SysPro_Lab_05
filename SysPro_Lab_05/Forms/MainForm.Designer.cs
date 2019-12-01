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
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
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
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(486, 299);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(248, 40);
            this.button5.TabIndex = 5;
            this.button5.Text = "Save Data";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(486, 348);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(248, 40);
            this.button6.TabIndex = 6;
            this.button6.Text = "Load Data";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 400);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

