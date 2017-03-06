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

namespace Course_Management
{
    public partial class FormTeachers : Form
    {
        DatabaseContainer db = new DatabaseContainer();
        public FormTeachers()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txtBox_login.Text.Length > 0)
            {
                long teacherCode = long.Parse(txtBox_login.Text);
                Teacher teacher = db.Teachers.FirstOrDefault(t => t.code == teacherCode);
                if (teacher != null)
                {
                    loginPanel.Hide();
                    txtBox_name_teacher.Text = teacher.name;
                    txtBox_code_teacher.Text = teacher.code.ToString();
                    string[] days = { "شنبه", "یکشنبه", "دوشنبه", "سه شنبه", "چهارشنبه" };
                    string[] hours = { "۸-۱۰", "۱۰-۱۲", "۱۴-۱۶", "۱۶-۱۸" };

                    dataGridView1.DataSource = teacher.Courses.ToArray().Select(c => new
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

                }
                else
                {
                    MessageBox.Show("استاد پیدا نشد! کد وارد شده را بررسی کنید.");
                }
            }
            else
            {
                MessageBox.Show("کد را وارد کنید!");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormTeachers_Load(object sender, EventArgs e)
        {
     

        }
    }
}
