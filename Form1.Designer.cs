
namespace Lab3
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
            this.empSalary = new System.Windows.Forms.TextBox();
            this.EmpLname = new System.Windows.Forms.TextBox();
            this.empFName = new System.Windows.Forms.TextBox();
            this.EmpID = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpList = new System.Windows.Forms.ListBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.deptName = new System.Windows.Forms.TextBox();
            this.deptID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // empSalary
            // 
            this.empSalary.Location = new System.Drawing.Point(547, 300);
            this.empSalary.Name = "empSalary";
            this.empSalary.Size = new System.Drawing.Size(214, 22);
            this.empSalary.TabIndex = 37;
            // 
            // EmpLname
            // 
            this.EmpLname.Location = new System.Drawing.Point(547, 258);
            this.EmpLname.Name = "EmpLname";
            this.EmpLname.Size = new System.Drawing.Size(214, 22);
            this.EmpLname.TabIndex = 36;
            // 
            // empFName
            // 
            this.empFName.Location = new System.Drawing.Point(547, 204);
            this.empFName.Name = "empFName";
            this.empFName.Size = new System.Drawing.Size(214, 22);
            this.empFName.TabIndex = 35;
            // 
            // EmpID
            // 
            this.EmpID.Location = new System.Drawing.Point(547, 157);
            this.EmpID.Name = "EmpID";
            this.EmpID.Size = new System.Drawing.Size(214, 22);
            this.EmpID.TabIndex = 34;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(553, 448);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 33;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(600, 393);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(486, 393);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 31;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Employe Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Employe L Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Employe F Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Employe ID";
            // 
            // EmpList
            // 
            this.EmpList.FormattingEnabled = true;
            this.EmpList.ItemHeight = 16;
            this.EmpList.Location = new System.Drawing.Point(59, 157);
            this.EmpList.Name = "EmpList";
            this.EmpList.Size = new System.Drawing.Size(310, 292);
            this.EmpList.TabIndex = 26;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(547, 84);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 25;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(594, 29);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 24;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(480, 29);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(75, 23);
            this.New.TabIndex = 23;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // deptName
            // 
            this.deptName.Location = new System.Drawing.Point(257, 81);
            this.deptName.Name = "deptName";
            this.deptName.Size = new System.Drawing.Size(173, 22);
            this.deptName.TabIndex = 22;
            // 
            // deptID
            // 
            this.deptID.FormattingEnabled = true;
            this.deptID.Location = new System.Drawing.Point(257, 29);
            this.deptID.Name = "deptID";
            this.deptID.Size = new System.Drawing.Size(173, 24);
            this.deptID.TabIndex = 21;
            this.deptID.SelectedIndexChanged += new System.EventHandler(this.deptID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Department Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Department ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Employe Title";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(547, 343);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(214, 22);
            this.title.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 492);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.empSalary);
            this.Controls.Add(this.EmpLname);
            this.Controls.Add(this.empFName);
            this.Controls.Add(this.EmpID);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmpList);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.New);
            this.Controls.Add(this.deptName);
            this.Controls.Add(this.deptID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox empSalary;
        private System.Windows.Forms.TextBox EmpLname;
        private System.Windows.Forms.TextBox empFName;
        private System.Windows.Forms.TextBox EmpID;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox EmpList;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.TextBox deptName;
        private System.Windows.Forms.ComboBox deptID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox title;
    }
}

