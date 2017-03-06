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

namespace Course_Management.Froms.Students
{
    public partial class FormTakeCourse : Form
    {
        DatabaseContainer db = new DatabaseContainer();
        private FormStudents formStudents;
        private Student student;

        List<Course> tempCourses = new List<Course>();

        public FormTakeCourse(FormStudents formStudents,Student student)
        {
            InitializeComponent();
            this.formStudents = formStudents;
            this.student = student;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtBox_code.Text.Length > 0)
            {
                long courseCode = long.Parse(txtBox_code.Text);
                Course course = db.Courses.FirstOrDefault(c => c.code == courseCode);
                if (course != null)
                {

                    foreach (Course c in tempCourses)
                    {
                        if (c.code == course.code)
                        {
                            MessageBox.Show("در لیست موجود است");
                            return;
                        }

                        if (haveTimeConfilict(c, course))
                        {
                            MessageBox.Show(" با درس " + c.name + " تداخل زمانی دارد ");
                            return;
                        }
                        if (haveExamConfilict(c, course))
                        {
                            MessageBox.Show(" با درس " + c.name + " تداخل امتحانی دارد ");
                            return;
                        }
                    }

                    
                    tempCourses.Add(course);
                    if (tempCourses.Count * 3 > 20)
                    {
                        MessageBox.Show("حداکثر واحد انتخابی ۲۰ عدد میباشد");
                        tempCourses.Remove(course);
                        return;
                    }
                             loadCourses();
                }
                else
                {
                    MessageBox.Show("کد درس نا معتبر است!");
                }
            }
            else
            {
                MessageBox.Show("کد درس را وارد کنید!");
            }
        }

        private void loadCourses()
        {
            txtBox_units_sum.Text = (tempCourses.Count * 3).ToString();
            string[] days = { "شنبه", "یکشنبه", "دوشنبه", "سه شنبه", "چهارشنبه" };
            string[] hours = { "۸-۱۰", "۱۰-۱۲", "۱۴-۱۶", "۱۶-۱۸" };
            dataGridView1.DataSource = tempCourses.ToArray().Select(c => new
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

        private bool haveTimeConfilict(Course c1, Course c2)
        {
            bool haveConfilict = c1.time1 == c2.time1 || c1.time1 == c2.time2 || c1.time2 == c2.time2 || c1.time2 == c2.time1;
            return haveConfilict;
        }

        private bool haveExamConfilict(Course c1, Course c2)
        {
            bool haveConfilict = false;
            if (c1.exam_date.Equals(c1.exam_date) && c1.exam_time.Hour.Equals(c2.exam_time.Hour))
            {
                haveConfilict = true;
            }
            return haveConfilict;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            DialogResult result = MessageBox.Show("آیا از حذف درس مطمئن هستید؟", "حذف", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;

            int courseCode = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            tempCourses.Remove(tempCourses.Find(course => course.code == courseCode));
            loadCourses();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (tempCourses.Count<14)
            {
                MessageBox.Show("حداقل تعداد واحدهای انتخابی ۱۴ عدد میاشد");
                return;
            }

            foreach (Course c in tempCourses)
            {
                student.Courses.Add(c);
            }
            db.SaveChanges();
            formStudents.LoadCourses();
            Close();
        }
    }
}
