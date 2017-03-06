using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Course_Management.Database;
namespace Course_Management.Froms.Management
{
    public partial class FormNewTeacher : Form
    {

        FromManagement formManagment;

        public FormNewTeacher(FromManagement formManagement)
        {
            this.formManagment = formManagement;
            InitializeComponent();
        }

        private void btn_submit_teacher_Click(object sender, EventArgs e)
        {
            if (txtBox_name_teacher.Text.Length > 0 && txtBox_code_teacher.Text.Length > 0)
            {
                Teacher teacher = new Teacher();
                teacher.name = txtBox_name_teacher.Text;
                teacher.code = long.Parse(txtBox_code_teacher.Text);
                DatabaseContainer db = new DatabaseContainer();
                if (db.Teachers.FirstOrDefault(t => t.code == teacher.code) != null)
                {
                    MessageBox.Show("استادی با این کد وجود دارد!");
                }
                db.Teachers.Add(teacher);
                db.SaveChanges();
                MessageBox.Show("استاد مورد نظر اضافه شد");
                formManagment.loadTeachers();
            }
            else
            {
                MessageBox.Show("مشخصات استاد را به طور کامل وارد کنید");
            }
        }
    }
}
