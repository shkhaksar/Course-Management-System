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
using Course_Management.Froms.Management;
using System.Globalization;

namespace Course_Management
{
    public partial class FromManagement : Form
    {
        DatabaseContainer db = new DatabaseContainer();

        public FromManagement()
        {
            InitializeComponent();
        }

        private void FromManagement_Load(object sender, EventArgs e)
        {
            loadCourses();
            loadTeachers();
            loadStudents();
        }

        //Courses Region
        #region Courses

        public void loadCourses()
        {

            cmb_day_1_course.SelectedIndex = 0;
            cmb_day_2_course.SelectedIndex = 0;
            cmb_time_1_course.SelectedIndex = 0;
            cmb_time_2_course.SelectedIndex = 0;
            var teachers = db.Teachers.ToArray();
            cmb_teacher_course.DataSource = teachers;

            string[] days = { "شنبه", "یکشنبه", "دوشنبه", "سه شنبه", "چهارشنبه" };
            string[] hours = { "۸-۱۰", "۱۰-۱۲", "۱۴-۱۶", "۱۶-۱۸" };
            dataGridView_courses.DataSource = db.Courses.ToArray().Select(c => new
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

        private void btn_new_course_Click(object sender, EventArgs e)
        {
            if (db.Teachers.Count() > 0)
            {
                FormNewCourse f = new FormNewCourse(this);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("لطفا استادها را در سیستم وارد کنید!");
            }

        }

        private void btn_delete_course_Click(object sender, EventArgs e)
        {
            if (dataGridView_courses.SelectedRows.Count == 0)
                return;
            DialogResult result = MessageBox.Show("آیا از حذف درس مطمئن هستید؟", "حذف", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;

            int courseCode = int.Parse(dataGridView_courses.SelectedRows[0].Cells[0].Value.ToString());
            Course course = db.Courses.FirstOrDefault(s => s.code == courseCode);
            db.Courses.Remove(course);
            db.SaveChanges();
            loadCourses();
        }

        private void btn_submit_edit_course_Click(object sender, EventArgs e)
        {
            if (dataGridView_courses.SelectedRows.Count == 1)
                if (CourseFormValidator())
                {
                    int courseCode = int.Parse(dataGridView_courses.SelectedRows[0].Cells[0].Value.ToString());
                    Course course = db.Courses.FirstOrDefault(c => c.code == courseCode);
                    course.name = txtBox_name_course.Text;
                    course.code = int.Parse(txtBox_code_course.Text);
                    course.capacity = byte.Parse(txtBox_capacity_course.Text);
                    course.TeacherId = ((Teacher)cmb_teacher_course.SelectedItem).Id;
                    course.time1 = (byte)(Program.TimeToDataBaseCodeConverter(cmb_day_1_course.SelectedIndex, cmb_time_1_course.SelectedIndex));
                    course.time2 = (byte)(Program.TimeToDataBaseCodeConverter(cmb_day_2_course.SelectedIndex, cmb_time_2_course.SelectedIndex));

                    if (course.time1 == course.time2)
                    {
                        MessageBox.Show("ساعت کلاس ها مشابه است");
                        return;
                    }

                    course.exam_time = time_picker_exam_course.Value;
                    course.exam_date = time_picker_exam_course.Value;
                    db.SaveChanges();
                    loadCourses();
                    MessageBox.Show("درس با موفقیت ویرایش شد!");

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

        private void dataGridView_courses_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_courses.SelectedRows.Count == 0)
                return;
            long courseCode = long.Parse(dataGridView_courses.SelectedRows[0].Cells[0].Value.ToString());
            Course course = db.Courses.FirstOrDefault(c => c.code == courseCode);
            txtBox_name_course.Text = course.name;
            txtBox_capacity_course.Text = course.capacity.ToString();
            txtBox_code_course.Text = course.code.ToString();

            cmb_teacher_course.SelectedItem = course.Teacher;
            cmb_day_1_course.SelectedIndex = Program.CodeToDayConvereter(course.time1);
            cmb_time_1_course.SelectedIndex = Program.CodeToHourConverter(course.time1);
            cmb_day_2_course.SelectedIndex = Program.CodeToDayConvereter(course.time2);
            cmb_time_2_course.SelectedIndex = Program.CodeToHourConverter(course.time2);

            date_picker_exam_course.Value = course.exam_date;
            time_picker_exam_course.Value = course.exam_time;
        }

        #endregion

        //Students Region
        #region Studens

        public void loadStudents()
        {
            dataGridView_students.DataSource = db.Students.ToArray().Select(s => new
            {
                code = s.code,
                name = s.name,
                units = s.Courses.Count * 3

            }).ToArray();

        }

        private void btn_new_student_Click(object sender, EventArgs e)
        {
            FormNewStudent f = new FormNewStudent(this);
            f.ShowDialog();
        }

        private void btn_delete_student_Click(object sender, EventArgs e)
        {
            if (dataGridView_students.SelectedRows.Count == 0)
                return;
            DialogResult result = MessageBox.Show("آیا از حذف دانشجو مطمئن هستید؟", "حذف", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;

            int studetnCode = int.Parse(dataGridView_students.SelectedRows[0].Cells[0].Value.ToString());
            Student student = db.Students.FirstOrDefault(s => s.code == studetnCode);
            student.Courses.Clear();
            db.Students.Remove(student);
            db.SaveChanges();
            loadStudents();
        }

        private void btn_submit_edit_student_Click(object sender, EventArgs e)
        {
            if (dataGridView_students.SelectedRows.Count == 1)
                if (txtBox_name_student.Text.Length > 0 && txtBox_code_student.Text.Length > 0)
                {
                    int studemtCode = int.Parse(dataGridView_students.SelectedRows[0].Cells[0].Value.ToString());
                    Student student = db.Students.First(s => s.code == studemtCode);
                    student.name = txtBox_name_student.Text;
                    student.code = long.Parse(txtBox_code_student.Text);
                    db.SaveChanges();
                    loadStudents();
                    MessageBox.Show("دانشجو با موفقیت ویرایش شد!");
                }
                else
                {
                    MessageBox.Show("مشخصات دانشجو را به طور کامل وارد کنید");
                }
        }


        private void dataGridView_students_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_students.SelectedRows.Count == 0)
                return;
            txtBox_name_student.Text = dataGridView_students.SelectedRows[0].Cells[1].Value.ToString();
            txtBox_code_student.Text = dataGridView_students.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btn_take_course_Click(object sender, EventArgs e)
        {
            if (dataGridView_students.SelectedRows.Count == 0)
            {
                MessageBox.Show("هیچ دانشجویی انتخاب نشده است");
                return;
            }

            int studetnCode = int.Parse(dataGridView_students.SelectedRows[0].Cells[0].Value.ToString());
            Student student = db.Students.FirstOrDefault(s => s.code == studetnCode);
            if (student != null)
            {
                FormTakeCourseStudent form = new FormTakeCourseStudent(this, student);
                form.ShowDialog();
            }
        }

        private void btn_show_courses_student_Click(object sender, EventArgs e)
        {
            if (dataGridView_students.SelectedRows.Count == 0)
            {
                MessageBox.Show("هیچ دانشجویی انتخاب نشده است");
                return;
            }

            int studetnCode = int.Parse(dataGridView_students.SelectedRows[0].Cells[0].Value.ToString());
            Student student = db.Students.FirstOrDefault(s => s.code == studetnCode);
            if (student != null)
            {
                if (student.Courses.Count != 0)
                {
                    FormShowStudentCourses form = new FormShowStudentCourses(student);
                    form.ShowDialog();
                }
                else
                    MessageBox.Show("این دانشجو انتخاب واحد نکرده است!");
            }
        }

        #endregion

        //Teachers Region
        #region Teachers
        public void loadTeachers()
        {
            // TODO: This line of code loads data into the 'course_managementDataSet.Teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.course_managementDataSet.Teachers);
        }

        private void btn_new_teacher_Click(object sender, EventArgs e)
        {
            FormNewTeacher f = new FormNewTeacher(this);
            f.ShowDialog();
        }

        private void btn_delete_teacher_Click(object sender, EventArgs e)
        {
            if (dataGridView_teachers.SelectedRows.Count == 0)
                return;
            DialogResult result = MessageBox.Show("آیا از حذف استاد مطمئن هستید؟", "حذف", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;

            int teacherCode = int.Parse(dataGridView_teachers.SelectedRows[0].Cells[0].Value.ToString());
            Teacher teacher = db.Teachers.FirstOrDefault(teacher1 => teacher1.code == teacherCode);
            db.Courses.RemoveRange(teacher.Courses);
            db.Teachers.Remove(teacher);
            db.SaveChanges();
            loadTeachers();
        }

        private void btn_submit_edit_teacher_Click(object sender, EventArgs e)
        {
            if (dataGridView_teachers.SelectedRows.Count == 1)
                if (txtBox_name_teacher.Text.Length > 0 && txtBox_code_teacher.Text.Length > 0)
                {
                    int teacherCode = int.Parse(dataGridView_teachers.SelectedRows[0].Cells[0].Value.ToString());
                    Teacher teacher = db.Teachers.FirstOrDefault(t => t.code == teacherCode);
                    teacher.name = txtBox_name_teacher.Text;
                    teacher.code = long.Parse(txtBox_code_teacher.Text);
                    db.SaveChanges();
                    loadTeachers();
                    MessageBox.Show("استاد با موفقیت ویرایش شد!");
                }
                else
                {
                    MessageBox.Show("مشخصات استاد را به طور کامل وارد کنید");
                }

        }

        private void dataGridView_teachers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_teachers.SelectedRows.Count == 0)
                return;
            txtBox_name_teacher.Text = dataGridView_teachers.SelectedRows[0].Cells[1].Value.ToString();
            txtBox_code_teacher.Text = dataGridView_teachers.SelectedRows[0].Cells[0].Value.ToString();
        }

        #endregion

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((TabControl)sender).SelectedTab == tab_course)
            {
                loadCourses();
            }
            else if (((TabControl)sender).SelectedTab == tab_student)
            {
                loadStudents();
            }
            else if (((TabControl)sender).SelectedTab == tab_teacher)
            {
                loadTeachers();
            }

        }
    }
}
