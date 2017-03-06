using Course_Management.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Management.Froms.Management
{
    public partial class FormNewStudent : Form
    {
        FromManagement formManagement;
        public FormNewStudent(FromManagement formManagement)
        {
            InitializeComponent();
            this.formManagement = formManagement;
        }

        private void btn_submit_student_Click(object sender, EventArgs e)
        {
            if (txtBox_name_student.Text.Length > 0 && txtBox_code_student.Text.Length>0)
            {
                Student student = new Student();
                student.name = txtBox_name_student.Text;
                student.code = long.Parse(txtBox_code_student.Text);
                DatabaseContainer db = new DatabaseContainer();
                if (db.Students.FirstOrDefault(s => s.code == student.code) != null)
                {
                    MessageBox.Show("دانشجویی با این کد وجود دارد!");
                }
                db.Students.Add(student);
                db.SaveChanges();
                MessageBox.Show("دانشجوی مورد نظر اضافه شد");
                formManagement.loadStudents();
            }
            else
            {
                MessageBox.Show("مشخصات دانشجو را به طور کامل وارد کنید");
            }
        }
    }
}
