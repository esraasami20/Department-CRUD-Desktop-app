using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Model1 Ent = new Model1();
            foreach (var item in Ent.Departments)
            {
                deptID.Items.Add(item.Dept_ID);
            }

        }

        private void deptID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model1 Ent = new Model1();
            EmpList.Items.Clear();
            deptName.Text = deptID.SelectedItem.ToString();
            int dept_id = int.Parse(deptID.Text);
            Department dept = (from d in Ent.Departments
                               where d.Dept_ID == dept_id
                               select d).First();
            deptName.Text = dept.Dept_Name;
            EmpID.Text = empFName.Text = EmpLname.Text = deptID.Text = empSalary.Text = title.Text = string.Empty;
            foreach (var v in dept.Emps)
            {
                EmpList.Items.Add(v.Fname + " " + v.Lname + " | " +v.Salary+" | "+v.Title);
                empFName.Text = v.Fname;
                EmpLname.Text = v.Lname;
                EmpID.Text = v.ID.ToString();
                empSalary.Text = v.Salary.ToString();
                title.Text = v.Title;
            }

        }

        private void New_Click(object sender, EventArgs e)
        {
            try
            {
                if (deptName.Text==null||deptName.Text=="") { MessageBox.Show("Enter Valid Data"); }
                else {
                    Department dept = new Department();
                    dept.Dept_ID = int.Parse(deptID.Text);
                    dept.Dept_Name = deptName.Text;
                    Model1 Ent = new Model1();
                    Ent.Departments.Add(dept);
                    Ent.SaveChanges();
                    deptID.Text = deptName.Text = string.Empty;
                    MessageBox.Show("New Department added");
                }
            }
            catch
            {
                MessageBox.Show("Enter Valid Data");
                deptID.Text = deptName.Text = string.Empty;
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (deptID.Text==null||deptID.Text==""||deptName.Text==null||deptName.Text=="") { MessageBox.Show("Enter Valid Data"); }
                else
                {
                    int dept_id = int.Parse(deptID.Text);
                    Model1 ent = new Model1();
                    Department dept = ent.Departments.Find(dept_id);
                    dept.Dept_Name = deptName.Text;
                    ent.SaveChanges();
                    deptID.Text = deptName.Text = string.Empty;
                }
            }
            catch
            {
                MessageBox.Show("Enter Valid Data");
                deptID.Text = deptName.Text = string.Empty;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int dept_id = int.Parse(deptID.Text);
                Model1 ent = new Model1();
                Department dept = ent.Departments.Find(dept_id);
                if (dept_id != null)
                {
                    int empNum = (from em in ent.Emps
                                  where em.Dept_id == dept_id
                                  select em).Count();
                    if (empNum != 0)
                    {
                        var emp = from em in ent.Emps
                                  where em.Dept_id == dept_id
                                  select em;
                        foreach (var v in emp)
                        {
                            ent.Emps.Remove(v);
                        }
                        ent.SaveChanges();
                    }

                }
                ent.Departments.Remove(dept);
                ent.SaveChanges();
                deptID.Text = deptName.Text = string.Empty;
            }
            catch
            {
                MessageBox.Show("Enter Valid Data");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (empFName.Text == null || EmpLname.Text == null || deptID.Text == null || empSalary.Text == null || title.Text == null || empFName.Text == null || EmpLname.Text == null || deptID.Text == null || empSalary.Text == null || title.Text== null) { MessageBox.Show("Enter Valid Data"); }
                else {
                    Emp emp = new Emp();
                    emp.ID = int.Parse(EmpID.Text);
                    emp.Fname = empFName.Text.ToString();
                    emp.Lname = EmpLname.Text.ToString();
                    emp.Title = title.Text.ToString();
                    emp.Salary = int.Parse(empSalary.Text);
                    emp.Dept_id = int.Parse(deptID.Text);
                    Model1 m = new Model1();
                    m.Emps.Add(emp);
                    m.SaveChanges();
                    MessageBox.Show("added");
                    EmpID.Text = empFName.Text = EmpLname.Text = deptID.Text = empSalary.Text = title.Text = string.Empty;

                }
            }
            catch
            {
                MessageBox.Show("Enter Valid Data");
                EmpID.Text = empFName.Text = EmpLname.Text = deptID.Text = empSalary.Text = title.Text = string.Empty;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (empFName.Text == null || EmpLname.Text == null || deptID.Text == null || empSalary.Text == null || title.Text == null || empFName.Text == null || EmpLname.Text == null || deptID.Text == null || empSalary.Text == null || title.Text == null) { MessageBox.Show("Enter Valid Data"); }
                else
                {
                    int e_id = int.Parse(EmpID.Text);
                    Model1 m = new Model1();
                    Emp Em = m.Emps.Find(e_id);
                    Em.Fname = empFName.Text.ToString();
                    Em.Salary = int.Parse(empSalary.Text);
                    Em.Lname = EmpLname.Text.ToString();
                    Em.Title = title.Text.ToString();
                    Em.Salary = int.Parse(empSalary.Text);
                    Em.Dept_id = int.Parse(deptID.Text);
                    m.SaveChanges();
                    MessageBox.Show("Updated");
                    EmpID.Text = empFName.Text = EmpLname.Text = deptID.Text = empSalary.Text = title.Text = string.Empty;
                }
            }
            catch
            {
                MessageBox.Show("Enter Valid Data");
                EmpID.Text = empFName.Text = EmpLname.Text = deptID.Text = empSalary.Text = title.Text = string.Empty;

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (empFName.Text == null || EmpLname.Text == null || deptID.Text == null || empSalary.Text == null || title.Text == null || empFName.Text == null || EmpLname.Text == null || deptID.Text == null || empSalary.Text == null || title.Text == null) { MessageBox.Show("Enter Valid Data"); }
                else
                { 
                    int e_id = int.Parse(EmpID.Text);
                    Model1 m = new Model1();
                    Emp emp = m.Emps.Where(em => em.ID == e_id).Select(em => em).First();
                    m.Emps.Remove(emp);
                    m.SaveChanges();
                    EmpID.Text = empFName.Text = EmpLname.Text = deptID.Text = empSalary.Text = title.Text = string.Empty;
                    MessageBox.Show("Deleted");
                }
            }
            catch
            {
                MessageBox.Show("Enter Valid Data");
                EmpID.Text = empFName.Text = EmpLname.Text = deptID.Text = empSalary.Text = title.Text = string.Empty;

            }
        }
    }
}
