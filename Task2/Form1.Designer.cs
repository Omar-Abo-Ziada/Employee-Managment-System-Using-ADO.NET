namespace Task2
{
    partial class Form1
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
            this.comboBoxDepartments = new System.Windows.Forms.ComboBox();
            this.listBoxDepartmentsEmployees = new System.Windows.Forms.ListBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelLName = new System.Windows.Forms.Label();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.fNameRequiredMesage = new System.Windows.Forms.Label();
            this.LNameRequiredMesage = new System.Windows.Forms.Label();
            this.SalaryRequiredMesage = new System.Windows.Forms.Label();
            this.SSNRequiredMesage = new System.Windows.Forms.Label();
            this.labelSSN = new System.Windows.Forms.Label();
            this.textBoxSSN = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDepartmentChoose = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxDepartments
            // 
            this.comboBoxDepartments.FormattingEnabled = true;
            this.comboBoxDepartments.Location = new System.Drawing.Point(17, 68);
            this.comboBoxDepartments.Name = "comboBoxDepartments";
            this.comboBoxDepartments.Size = new System.Drawing.Size(162, 24);
            this.comboBoxDepartments.TabIndex = 0;
            this.comboBoxDepartments.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartments_SelectedIndexChanged);
            // 
            // listBoxDepartmentsEmployees
            // 
            this.listBoxDepartmentsEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDepartmentsEmployees.FormattingEnabled = true;
            this.listBoxDepartmentsEmployees.ItemHeight = 25;
            this.listBoxDepartmentsEmployees.Location = new System.Drawing.Point(17, 174);
            this.listBoxDepartmentsEmployees.Name = "listBoxDepartmentsEmployees";
            this.listBoxDepartmentsEmployees.Size = new System.Drawing.Size(232, 229);
            this.listBoxDepartmentsEmployees.TabIndex = 1;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(604, 108);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(178, 22);
            this.textBoxFName.TabIndex = 2;
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFName.Location = new System.Drawing.Point(449, 108);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(133, 27);
            this.labelFName.TabIndex = 3;
            this.labelFName.Text = "First Name";
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLName.Location = new System.Drawing.Point(451, 180);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(131, 27);
            this.labelLName.TabIndex = 5;
            this.labelLName.Text = "Last Name";
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(604, 185);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(178, 22);
            this.textBoxLName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Department Employees ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Birth Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(486, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adress";
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(606, 250);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(178, 22);
            this.textBoxAdress.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(486, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 27);
            this.label5.TabIndex = 15;
            this.label5.Text = "Salary";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(608, 465);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(178, 22);
            this.textBoxSalary.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(342, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 27);
            this.label6.TabIndex = 13;
            this.label6.Text = "Department Number";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(743, 558);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(132, 62);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.Black;
            this.buttonUpdate.Location = new System.Drawing.Point(535, 558);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(132, 62);
            this.buttonUpdate.TabIndex = 17;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Location = new System.Drawing.Point(317, 558);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(132, 62);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // fNameRequiredMesage
            // 
            this.fNameRequiredMesage.AutoSize = true;
            this.fNameRequiredMesage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameRequiredMesage.ForeColor = System.Drawing.Color.Red;
            this.fNameRequiredMesage.Location = new System.Drawing.Point(826, 108);
            this.fNameRequiredMesage.Name = "fNameRequiredMesage";
            this.fNameRequiredMesage.Size = new System.Drawing.Size(115, 21);
            this.fNameRequiredMesage.TabIndex = 19;
            this.fNameRequiredMesage.Text = "* Required !";
            // 
            // LNameRequiredMesage
            // 
            this.LNameRequiredMesage.AutoSize = true;
            this.LNameRequiredMesage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameRequiredMesage.ForeColor = System.Drawing.Color.Red;
            this.LNameRequiredMesage.Location = new System.Drawing.Point(826, 184);
            this.LNameRequiredMesage.Name = "LNameRequiredMesage";
            this.LNameRequiredMesage.Size = new System.Drawing.Size(115, 21);
            this.LNameRequiredMesage.TabIndex = 20;
            this.LNameRequiredMesage.Text = "* Required !";
            // 
            // SalaryRequiredMesage
            // 
            this.SalaryRequiredMesage.AutoSize = true;
            this.SalaryRequiredMesage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryRequiredMesage.ForeColor = System.Drawing.Color.Red;
            this.SalaryRequiredMesage.Location = new System.Drawing.Point(826, 466);
            this.SalaryRequiredMesage.Name = "SalaryRequiredMesage";
            this.SalaryRequiredMesage.Size = new System.Drawing.Size(115, 21);
            this.SalaryRequiredMesage.TabIndex = 22;
            this.SalaryRequiredMesage.Text = "* Required !";
            // 
            // SSNRequiredMesage
            // 
            this.SSNRequiredMesage.AutoSize = true;
            this.SSNRequiredMesage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSNRequiredMesage.ForeColor = System.Drawing.Color.Red;
            this.SSNRequiredMesage.Location = new System.Drawing.Point(823, 50);
            this.SSNRequiredMesage.Name = "SSNRequiredMesage";
            this.SSNRequiredMesage.Size = new System.Drawing.Size(115, 21);
            this.SSNRequiredMesage.TabIndex = 25;
            this.SSNRequiredMesage.Text = "* Required !";
            // 
            // labelSSN
            // 
            this.labelSSN.AutoSize = true;
            this.labelSSN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSSN.Location = new System.Drawing.Point(510, 50);
            this.labelSSN.Name = "labelSSN";
            this.labelSSN.Size = new System.Drawing.Size(59, 27);
            this.labelSSN.TabIndex = 24;
            this.labelSSN.Text = "SSN";
            // 
            // textBoxSSN
            // 
            this.textBoxSSN.Location = new System.Drawing.Point(601, 50);
            this.textBoxSSN.Name = "textBoxSSN";
            this.textBoxSSN.Size = new System.Drawing.Size(178, 22);
            this.textBoxSSN.TabIndex = 23;
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(608, 327);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBirthDate.TabIndex = 27;
            // 
            // comboBoxDepartmentChoose
            // 
            this.comboBoxDepartmentChoose.FormattingEnabled = true;
            this.comboBoxDepartmentChoose.Location = new System.Drawing.Point(608, 394);
            this.comboBoxDepartmentChoose.Name = "comboBoxDepartmentChoose";
            this.comboBoxDepartmentChoose.Size = new System.Drawing.Size(162, 24);
            this.comboBoxDepartmentChoose.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 698);
            this.Controls.Add(this.comboBoxDepartmentChoose);
            this.Controls.Add(this.dateTimePickerBirthDate);
            this.Controls.Add(this.SSNRequiredMesage);
            this.Controls.Add(this.labelSSN);
            this.Controls.Add(this.textBoxSSN);
            this.Controls.Add(this.SalaryRequiredMesage);
            this.Controls.Add(this.LNameRequiredMesage);
            this.Controls.Add(this.fNameRequiredMesage);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.listBoxDepartmentsEmployees);
            this.Controls.Add(this.comboBoxDepartments);
            this.Name = "Form1";
            this.Text = "Mini App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDepartments;
        private System.Windows.Forms.ListBox listBoxDepartmentsEmployees;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label fNameRequiredMesage;
        private System.Windows.Forms.Label LNameRequiredMesage;
        private System.Windows.Forms.Label SalaryRequiredMesage;
        private System.Windows.Forms.Label SSNRequiredMesage;
        private System.Windows.Forms.Label labelSSN;
        private System.Windows.Forms.TextBox textBoxSSN;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.ComboBox comboBoxDepartmentChoose;
    }
}

