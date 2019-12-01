namespace SysPro_Lab_05
{
    partial class AddEditEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.numSalary = new System.Windows.Forms.NumericUpDown();
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.btOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBox1
            // 
            this.tbName.Location = new System.Drawing.Point(20, 36);
            this.tbName.Name = "textBox1";
            this.tbName.Size = new System.Drawing.Size(134, 22);
            this.tbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Department";
            // 
            // numericUpDown1
            // 
            this.numAge.Location = new System.Drawing.Point(20, 84);
            this.numAge.Maximum = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.numAge.Name = "numericUpDown1";
            this.numAge.Size = new System.Drawing.Size(134, 22);
            this.numAge.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            this.numSalary.DecimalPlaces = 2;
            this.numSalary.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numSalary.Location = new System.Drawing.Point(20, 133);
            this.numSalary.Maximum = new decimal(new int[] {
            69420,
            0,
            0,
            0});
            this.numSalary.Name = "numericUpDown2";
            this.numSalary.Size = new System.Drawing.Size(134, 22);
            this.numSalary.TabIndex = 9;
            this.numSalary.ThousandsSeparator = true;
            // 
            // comboBox1
            // 
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.Location = new System.Drawing.Point(19, 182);
            this.cbDepartments.Name = "comboBox1";
            this.cbDepartments.Size = new System.Drawing.Size(135, 24);
            this.cbDepartments.TabIndex = 10;
            // 
            // button1
            // 
            this.btOK.Location = new System.Drawing.Point(19, 220);
            this.btOK.Name = "button1";
            this.btOK.Size = new System.Drawing.Size(135, 32);
            this.btOK.TabIndex = 11;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            // 
            // AddEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 264);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.cbDepartments);
            this.Controls.Add(this.numSalary);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(188, 303);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(188, 303);
            this.Name = "AddEditEmployee";
            this.Text = "AddEditEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.NumericUpDown numSalary;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.Button btOK;
    }
}