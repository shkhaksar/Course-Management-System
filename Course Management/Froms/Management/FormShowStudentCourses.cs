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
    public partial class FormShowStudentCourses : Form
    {
        private Student student;
        public FormShowStudentCourses(Student student)
        {
            this.student = student;
            InitializeComponent();
        }

        private void FormShowStudentCourses_Load(object sender, EventArgs e)
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
        }
    }
}
