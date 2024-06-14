﻿namespace DesktopApp
{
    partial class Add_Classroom
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
            AddClassBtn = new Button();
            label1 = new Label();
            AddClassName = new TextBox();
            label2 = new Label();
            AddClassDes = new TextBox();
            label3 = new Label();
            AddClassLoc = new TextBox();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            ClassData = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClassData).BeginInit();
            SuspendLayout();
            // 
            // AddClassBtn
            // 
            AddClassBtn.BackColor = Color.MediumSeaGreen;
            AddClassBtn.Location = new Point(300, 58);
            AddClassBtn.Name = "AddClassBtn";
            AddClassBtn.Size = new Size(80, 34);
            AddClassBtn.TabIndex = 0;
            AddClassBtn.Text = "Add";
            AddClassBtn.UseVisualStyleBackColor = false;
            AddClassBtn.Click += AddClassBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 18);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // AddClassName
            // 
            AddClassName.Location = new Point(29, 36);
            AddClassName.Name = "AddClassName";
            AddClassName.Size = new Size(188, 23);
            AddClassName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 77);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Description:";
            // 
            // AddClassDes
            // 
            AddClassDes.Location = new Point(29, 95);
            AddClassDes.Name = "AddClassDes";
            AddClassDes.Size = new Size(188, 23);
            AddClassDes.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 144);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 1;
            label3.Text = "Location:";
            // 
            // AddClassLoc
            // 
            AddClassLoc.Location = new Point(29, 162);
            AddClassLoc.Name = "AddClassLoc";
            AddClassLoc.Size = new Size(188, 23);
            AddClassLoc.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(AddClassBtn);
            panel2.Controls.Add(AddClassLoc);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(AddClassDes);
            panel2.Controls.Add(AddClassName);
            panel2.Location = new Point(87, 326);
            panel2.Name = "panel2";
            panel2.Size = new Size(452, 215);
            panel2.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(357, 127);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 0;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += AddClassBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Location = new Point(253, 127);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 0;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += AddClassBtn_Click;
            // 
            // ClassData
            // 
            ClassData.AllowUserToAddRows = false;
            ClassData.AllowUserToDeleteRows = false;
            ClassData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClassData.Location = new Point(12, 12);
            ClassData.Name = "ClassData";
            ClassData.ReadOnly = true;
            ClassData.RowTemplate.Height = 25;
            ClassData.Size = new Size(616, 296);
            ClassData.TabIndex = 5;
            // 
            // Add_Classroom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(638, 553);
            Controls.Add(ClassData);
            Controls.Add(panel2);
            Name = "Add_Classroom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Classrooms";
            Load += Add_Classroom_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ClassData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AddClassBtn;
        private Label label1;
        private TextBox AddClassName;
        private Label label2;
        private TextBox AddClassDes;
        private Label label3;
        private TextBox AddClassLoc;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private DataGridView ClassData;
    }
}