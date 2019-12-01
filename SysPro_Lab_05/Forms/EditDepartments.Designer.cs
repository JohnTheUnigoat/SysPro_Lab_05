namespace SysPro_Lab_05
{
    partial class EditDepartments
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
            this.btOK = new System.Windows.Forms.Button();
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btAddDepartment = new System.Windows.Forms.Button();
            this.btRemoveDepartment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(14, 210);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(280, 32);
            this.btOK.TabIndex = 20;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            // 
            // cbDepartments
            // 
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.Location = new System.Drawing.Point(15, 12);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(123, 24);
            this.cbDepartments.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Adress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(15, 74);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(279, 22);
            this.tbName.TabIndex = 22;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(15, 124);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(279, 22);
            this.tbPhone.TabIndex = 23;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(15, 173);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(279, 22);
            this.tbAddress.TabIndex = 24;
            // 
            // btAddDepartment
            // 
            this.btAddDepartment.Location = new System.Drawing.Point(144, 12);
            this.btAddDepartment.Name = "btAddDepartment";
            this.btAddDepartment.Size = new System.Drawing.Size(75, 23);
            this.btAddDepartment.TabIndex = 25;
            this.btAddDepartment.Text = "Add";
            this.btAddDepartment.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.btRemoveDepartment.Location = new System.Drawing.Point(225, 12);
            this.btRemoveDepartment.Name = "button1";
            this.btRemoveDepartment.Size = new System.Drawing.Size(69, 23);
            this.btRemoveDepartment.TabIndex = 26;
            this.btRemoveDepartment.Text = "Remove";
            this.btRemoveDepartment.UseVisualStyleBackColor = true;
            // 
            // EditDepartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 256);
            this.Controls.Add(this.btRemoveDepartment);
            this.Controls.Add(this.btAddDepartment);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.cbDepartments);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(322, 295);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(322, 295);
            this.Name = "EditDepartments";
            this.Text = "Edit departments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btAddDepartment;
        private System.Windows.Forms.Button btRemoveDepartment;
    }
}