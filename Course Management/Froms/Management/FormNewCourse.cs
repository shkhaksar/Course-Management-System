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
    public partial class FormNewCourse : Form
    {
        FromManagement formManagement;
        public FormNewCourse(FromManagement formManagement)
        {
            InitializeComponent();
            this.formManagement = formManagement;
        }

        private void btn_submit_course_Click(object sender, EventArgs e)
        {
            if (CourseFormValidator())
            {
                Course course = new Course();
                course.name = txtBox_name_course.Text;
                course.code = int.Parse(txtBox_code_course.Text);
                course.capacity = byte.Parse(txtBox_capacity_course.Text);
                course.TeacherId = ((Teacher) cmb_teacher_course.SelectedItem).Id;
                course.time1 = (byte)(Program.TimeToDataBaseCodeConverter(cmb_day_1_course.SelectedIndex, cmb_time_1_course.SelectedIndex));
                course.time2 = (byte)(Program.TimeToDataBaseCodeConverter(cmb_day_2_course.SelectedIndex, cmb_time_2_course.SelectedIndex));

                if (course.time1 == course.time2)
                {
                    MessageBox.Show("ساعت کلاس ها مشابه است");
                    return;
                }

                course.exam_time = time_picker_exam_course.Value;
                course.exam_date = time_picker_exam_course.Value;
                DatabaseContainer db = new DatabaseContainer();
                if (db.Courses.FirstOrDefault(c => c.code == course.code) != null)
                {
                    MessageBox.Show("درسی با این کد وجود دارد!");
                }
                db.Courses.Add(course);
                db.SaveChanges();
                MessageBox.Show("درس مورد نظر اضافه شد");
                formManagement.loadCourses();

            }
            else
            {
                MessageBox.Show("مشخصات درس را به درستی وارد کنید!");
            }
        }

        private bool CourseFormValidator()
        {
            bool is_valid = true;
            if (txtBox_name_course.Text.Length == 0)
            {
                is_valid = false;
            }
            if (txtBox_capacity_course.Text.Length == 0)
            {
                is_valid = false;
            }
            if (txtBox_code_course.Text.Length == 0)
            {
                is_valid = false;
            }

            return true;
        }

        private void FormNewCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'course_managementDataSet.Teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.course_managementDataSet.Teachers);
            cmb_day_1_course.SelectedIndex = 0;
            cmb_day_2_course.SelectedIndex = 0;
            cmb_time_1_course.SelectedIndex = 0;
            cmb_time_2_course.SelectedIndex = 0;
            DatabaseContainer db = new DatabaseContainer();
            var teachers = db.Teachers.ToArray();
            cmb_teacher_course.DataSource = teachers;
        }
    }
}
