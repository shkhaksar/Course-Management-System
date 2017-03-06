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
using Course_Management.Froms.Students;

namespace Course_Management
{
    public partial class FormStudents : Form
    {
        DatabaseContainer db = new DatabaseContainer();
        private Student student;

        public FormStudents()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txtBox_login.Text.Length > 0)
            {
                long studentCode = long.Parse(txtBox_login.Text);
                student = db.Students.FirstOrDefault(s => s.code == studentCode);
                if (student != null)
                {
                    loginPanel.Hide();
                    txtBox_name_student.Text = student.name;
                    txtBox_code_student.Text = student.code.ToString();
                    LoadCourses();

                }
                else
                {
                    MessageBox.Show("دانشجو پیدا نشد! کد وارد شده را بررسی کنید.");
                }
            }
            else
            {
                MessageBox.Show("کد را وارد کنید!");
            }
        }

        public void LoadCourses()
        {
            string[] days = { "شنبه", "یکشنبه", "دوشنبه", "سه شنبه", "چهارشنبه" };
            string[] hours = { "۸-۱۰", "۱۰-۱۲", "۱۴-۱۶", "۱۶-۱۸" };

            dataGridView1.DataSource = student.Courses.ToArray().Select(c => new
            {
                code = c.code,
                name = c.name,
                capacity = c.capacity,
                teacherId = c.Teacher.name,
                time1 = days[c.time1 / 4] + " " + hours[(c.time1 - 1) % 4],
                time2 = days[c.time2 / 4] + " " + hours[(c.time2 - 1) % 4],
                exam_date = c.exam_date.Date.ToShortDateString(),
                exam_time = c.exam_time.ToShortTimeString()

            }).ToArray();
            txtBox_unit_sum.Text = (student.Courses.ToArray().Count()*3).ToString();
        }

        private void btn_take_course_Click(object sender, EventArgs e)
        {
            FormTakeCourse form = new FormTakeCourse(this,student);
            form.Show();
        }
    }
}
