﻿namespace DesktopApp.Add_Forms
{
    partial class Add_Student
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
            AddStudentBtn = new Button();
            label9 = new Label();
            AddStudentNat = new TextBox();
            AddStudentEmail = new TextBox();
            AddStudentMat = new TextBox();
            AddStudentDep = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            AddStudentPhone = new TextBox();
            AddDob = new TextBox();
            AddStudentStat = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            AddStudentAddr = new TextBox();
            AddStudentName = new TextBox();
            AddStudentGen = new ComboBox();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            StudData = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudData).BeginInit();
            SuspendLayout();
            // 
            // AddStudentBtn
            // 
            AddStudentBtn.BackColor = Color.MediumSeaGreen;
            AddStudentBtn.Location = new Point(692, 145);
            AddStudentBtn.Name = "AddStudentBtn";
            AddStudentBtn.Size = new Size(89, 34);
            AddStudentBtn.TabIndex = 89;
            AddStudentBtn.Text = "Add";
            AddStudentBtn.UseVisualStyleBackColor = false;
            AddStudentBtn.Click += AddStudentBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(290, 21);
            label9.Name = "label9";
            label9.Size = new Size(73, 15);
            label9.TabIndex = 88;
            label9.Text = "Department:";
            // 
            // AddStudentNat
            // 
            AddStudentNat.Location = new Point(304, 205);
            AddStudentNat.Name = "AddStudentNat";
            AddStudentNat.Size = new Size(225, 23);
            AddStudentNat.TabIndex = 69;
            // 
            // AddStudentEmail
            // 
            AddStudentEmail.Location = new Point(304, 152);
            AddStudentEmail.Name = "AddStudentEmail";
            AddStudentEmail.Size = new Size(225, 23);
            AddStudentEmail.TabIndex = 70;
            // 
            // AddStudentMat
            // 
            AddStudentMat.Location = new Point(303, 95);
            AddStudentMat.Name = "AddStudentMat";
            AddStudentMat.Size = new Size(225, 23);
            AddStudentMat.TabIndex = 71;
            // 
            // AddStudentDep
            // 
            AddStudentDep.Location = new Point(303, 39);
            AddStudentDep.Name = "AddStudentDep";
            AddStudentDep.Size = new Size(225, 23);
            AddStudentDep.TabIndex = 72;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(290, 73);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 87;
            label8.Text = "Matricle:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(291, 134);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 86;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(291, 187);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 85;
            label6.Text = "Nationality:";
            // 
            // AddStudentPhone
            // 
            AddStudentPhone.Location = new Point(591, 95);
            AddStudentPhone.Name = "AddStudentPhone";
            AddStudentPhone.Size = new Size(225, 23);
            AddStudentPhone.TabIndex = 82;
            // 
            // AddDob
            // 
            AddDob.Location = new Point(19, 95);
            AddDob.Name = "AddDob";
            AddDob.Size = new Size(209, 23);
            AddDob.TabIndex = 81;
            // 
            // AddStudentStat
            // 
            AddStudentStat.Location = new Point(20, 205);
            AddStudentStat.Name = "AddStudentStat";
            AddStudentStat.Size = new Size(209, 23);
            AddStudentStat.TabIndex = 80;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 187);
            label11.Name = "label11";
            label11.Size = new Size(42, 15);
            label11.TabIndex = 78;
            label11.Text = "Status:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(578, 77);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 77;
            label10.Text = "Phone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 134);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 76;
            label5.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 73);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 75;
            label4.Text = "Date of Birth:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(584, 21);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 74;
            label3.Text = "Gender:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 73;
            label1.Text = "Name:";
            // 
            // AddStudentAddr
            // 
            AddStudentAddr.Location = new Point(20, 152);
            AddStudentAddr.Name = "AddStudentAddr";
            AddStudentAddr.Size = new Size(209, 23);
            AddStudentAddr.TabIndex = 79;
            // 
            // AddStudentName
            // 
            AddStudentName.Location = new Point(19, 39);
            AddStudentName.Name = "AddStudentName";
            AddStudentName.Size = new Size(209, 23);
            AddStudentName.TabIndex = 84;
            // 
            // AddStudentGen
            // 
            AddStudentGen.FormattingEnabled = true;
            AddStudentGen.Items.AddRange(new object[] { "Male", "Female" });
            AddStudentGen.Location = new Point(591, 39);
            AddStudentGen.Name = "AddStudentGen";
            AddStudentGen.Size = new Size(225, 23);
            AddStudentGen.TabIndex = 91;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(AddStudentMat);
            panel2.Controls.Add(AddStudentName);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(AddStudentBtn);
            panel2.Controls.Add(AddStudentGen);
            panel2.Controls.Add(AddStudentPhone);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(AddStudentNat);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(AddStudentEmail);
            panel2.Controls.Add(AddDob);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(AddStudentDep);
            panel2.Controls.Add(AddStudentStat);
            panel2.Controls.Add(AddStudentAddr);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(43, 362);
            panel2.Name = "panel2";
            panel2.Size = new Size(901, 264);
            panel2.TabIndex = 93;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(790, 205);
            button2.Name = "button2";
            button2.Size = new Size(89, 34);
            button2.TabIndex = 89;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += AddStudentBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Location = new Point(600, 205);
            button1.Name = "button1";
            button1.Size = new Size(89, 34);
            button1.TabIndex = 89;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += AddStudentBtn_Click;
            // 
            // StudData
            // 
            StudData.AllowUserToAddRows = false;
            StudData.AllowUserToDeleteRows = false;
            StudData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudData.Location = new Point(12, 2);
            StudData.Name = "StudData";
            StudData.ReadOnly = true;
            StudData.Size = new Size(984, 345);
            StudData.TabIndex = 94;
            // 
            // Add_Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1008, 636);
            Controls.Add(StudData);
            Controls.Add(panel2);
            Name = "Add_Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student";
            Load += Add_Student_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AddStudentBtn;
        private Label label9;
        private TextBox AddStudentNat;
        private TextBox AddStudentEmail;
        private TextBox AddStudentMat;
        private TextBox AddStudentDep;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox AddStudentPhone;
        private TextBox AddDob;
        private TextBox AddStudentStat;
        private Label label11;
        private Label label10;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox AddStudentAddr;
        private TextBox AddStudentName;
        private ComboBox AddStudentGen;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private DataGridView StudData;
    }
}