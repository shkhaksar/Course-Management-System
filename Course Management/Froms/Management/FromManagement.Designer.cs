using System.Linq;
using Course_Management.Database;

namespace Course_Management
{
    partial class FromManagement
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_course_management = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_delete_course = new System.Windows.Forms.Button();
            this.btn_edit_course = new System.Windows.Forms.Button();
            this.dataGridView_courses = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.time_picker_exam = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_time_2 = new System.Windows.Forms.ComboBox();
            this.cmb_day_2 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_time_1 = new System.Windows.Forms.ComboBox();
            this.cmb_day_1 = new System.Windows.Forms.ComboBox();
            this.date_picker_exam = new System.Windows.Forms.DateTimePicker();
            this.cmb_teacher = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_capacity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.btn_submit_course = new System.Windows.Forms.Button();
            this.tab_student_management = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_delete_student = new System.Windows.Forms.Button();
            this.btn_edit_student = new System.Windows.Forms.Button();
            this.dataGridView_students = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBox_name_student = new System.Windows.Forms.TextBox();
            this.btn_submit_student = new System.Windows.Forms.Button();
            this.tab_teacher_managemetn = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btn_delete_teacher = new System.Windows.Forms.Button();
            this.btn_edit_teacher = new System.Windows.Forms.Button();
            this.dataGridView_teachers = new System.Windows.Forms.DataGridView();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBox_name_teacher = new System.Windows.Forms.TextBox();
            this.btn_submit_teacher = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tab_course_management.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_courses)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tab_student_management.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_students)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tab_teacher_managemetn.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_teachers)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_course_management);
            this.tabControl.Controls.Add(this.tab_student_management);
            this.tabControl.Controls.Add(this.tab_teacher_managemetn);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl.RightToLeftLayout = true;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(943, 488);
            this.tabControl.TabIndex = 0;
            // 
            // tab_course_management
            // 
            this.tab_course_management.Controls.Add(this.groupBox4);
            this.tab_course_management.Controls.Add(this.groupBox1);
            this.tab_course_management.Location = new System.Drawing.Point(4, 22);
            this.tab_course_management.Name = "tab_course_management";
            this.tab_course_management.Padding = new System.Windows.Forms.Padding(3);
            this.tab_course_management.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tab_course_management.Size = new System.Drawing.Size(935, 462);
            this.tab_course_management.TabIndex = 0;
            this.tab_course_management.Text = "مدیریت درس ها";
            this.tab_course_management.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_delete_course);
            this.groupBox4.Controls.Add(this.btn_edit_course);
            this.groupBox4.Controls.Add(this.dataGridView_courses);
            this.groupBox4.Location = new System.Drawing.Point(8, 252);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(913, 202);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "درس های موجود";
            // 
            // btn_delete_course
            // 
            this.btn_delete_course.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_delete_course.Location = new System.Drawing.Point(829, 56);
            this.btn_delete_course.Name = "btn_delete_course";
            this.btn_delete_course.Size = new System.Drawing.Size(75, 31);
            this.btn_delete_course.TabIndex = 2;
            this.btn_delete_course.Text = "حذف";
            this.btn_delete_course.UseVisualStyleBackColor = true;
            // 
            // btn_edit_course
            // 
            this.btn_edit_course.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_edit_course.Location = new System.Drawing.Point(829, 19);
            this.btn_edit_course.Name = "btn_edit_course";
            this.btn_edit_course.Size = new System.Drawing.Size(75, 31);
            this.btn_edit_course.TabIndex = 1;
            this.btn_edit_course.Text = "ویرایش";
            this.btn_edit_course.UseVisualStyleBackColor = true;
            // 
            // dataGridView_courses
            // 
            this.dataGridView_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_courses.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_courses.Name = "dataGridView_courses";
            this.dataGridView_courses.Size = new System.Drawing.Size(820, 186);
            this.dataGridView_courses.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.time_picker_exam);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.date_picker_exam);
            this.groupBox1.Controls.Add(this.cmb_teacher);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBox_capacity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBox_name);
            this.groupBox1.Controls.Add(this.btn_submit_course);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(914, 239);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ایجاد درس جدید";
            // 
            // time_picker_exam
            // 
            this.time_picker_exam.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time_picker_exam.Location = new System.Drawing.Point(625, 196);
            this.time_picker_exam.Name = "time_picker_exam";
            this.time_picker_exam.RightToLeftLayout = true;
            this.time_picker_exam.Size = new System.Drawing.Size(200, 30);
            this.time_picker_exam.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(831, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "ساعت امتحان";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(837, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "تاریخ امتحان";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cmb_time_2);
            this.groupBox3.Controls.Add(this.cmb_day_2);
            this.groupBox3.Location = new System.Drawing.Point(6, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 92);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "جلسه دوم";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "ساعت";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "روز";
            // 
            // cmb_time_2
            // 
            this.cmb_time_2.FormattingEnabled = true;
            this.cmb_time_2.Location = new System.Drawing.Point(7, 53);
            this.cmb_time_2.Name = "cmb_time_2";
            this.cmb_time_2.Size = new System.Drawing.Size(121, 32);
            this.cmb_time_2.TabIndex = 14;
            // 
            // cmb_day_2
            // 
            this.cmb_day_2.FormattingEnabled = true;
            this.cmb_day_2.Location = new System.Drawing.Point(134, 54);
            this.cmb_day_2.Name = "cmb_day_2";
            this.cmb_day_2.Size = new System.Drawing.Size(121, 32);
            this.cmb_day_2.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmb_time_1);
            this.groupBox2.Controls.Add(this.cmb_day_1);
            this.groupBox2.Location = new System.Drawing.Point(273, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 92);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جلسه اول";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "ساعت";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "روز";
            // 
            // cmb_time_1
            // 
            this.cmb_time_1.FormattingEnabled = true;
            this.cmb_time_1.Location = new System.Drawing.Point(7, 54);
            this.cmb_time_1.Name = "cmb_time_1";
            this.cmb_time_1.Size = new System.Drawing.Size(121, 32);
            this.cmb_time_1.TabIndex = 14;
            // 
            // cmb_day_1
            // 
            this.cmb_day_1.FormattingEnabled = true;
            this.cmb_day_1.Location = new System.Drawing.Point(134, 54);
            this.cmb_day_1.Name = "cmb_day_1";
            this.cmb_day_1.Size = new System.Drawing.Size(121, 32);
            this.cmb_day_1.TabIndex = 15;
            // 
            // date_picker_exam
            // 
            this.date_picker_exam.Location = new System.Drawing.Point(625, 157);
            this.date_picker_exam.MaxDate = new System.DateTime(2101, 3, 20, 0, 0, 0, 0);
            this.date_picker_exam.MinDate = new System.DateTime(1991, 3, 21, 0, 0, 0, 0);
            this.date_picker_exam.Name = "date_picker_exam";
            this.date_picker_exam.RightToLeftLayout = true;
            this.date_picker_exam.Size = new System.Drawing.Size(200, 30);
            this.date_picker_exam.TabIndex = 12;
            // 
            // cmb_teacher
            // 
            this.cmb_teacher.FormattingEnabled = true;
            this.cmb_teacher.Location = new System.Drawing.Point(728, 98);
            this.cmb_teacher.Name = "cmb_teacher";
            this.cmb_teacher.Size = new System.Drawing.Size(121, 32);
            this.cmb_teacher.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(873, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "استاد";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(863, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "ظرفیت";
            // 
            // txtBox_capacity
            // 
            this.txtBox_capacity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_capacity.Font = new System.Drawing.Font("IRAN Sans", 8.25F);
            this.txtBox_capacity.Location = new System.Drawing.Point(749, 61);
            this.txtBox_capacity.Name = "txtBox_capacity";
            this.txtBox_capacity.Size = new System.Drawing.Size(100, 29);
            this.txtBox_capacity.TabIndex = 7;
            this.txtBox_capacity.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(855, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "نام درس";
            // 
            // txtBox_name
            // 
            this.txtBox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_name.Font = new System.Drawing.Font("IRAN Sans", 8.25F);
            this.txtBox_name.Location = new System.Drawing.Point(749, 24);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(100, 29);
            this.txtBox_name.TabIndex = 5;
            this.txtBox_name.Tag = "";
            // 
            // btn_submit_course
            // 
            this.btn_submit_course.Location = new System.Drawing.Point(6, 201);
            this.btn_submit_course.Name = "btn_submit_course";
            this.btn_submit_course.Size = new System.Drawing.Size(75, 31);
            this.btn_submit_course.TabIndex = 3;
            this.btn_submit_course.Text = "تایید";
            this.btn_submit_course.UseVisualStyleBackColor = true;
            // 
            // tab_student_management
            // 
            this.tab_student_management.Controls.Add(this.groupBox5);
            this.tab_student_management.Controls.Add(this.groupBox6);
            this.tab_student_management.Location = new System.Drawing.Point(4, 22);
            this.tab_student_management.Name = "tab_student_management";
            this.tab_student_management.Padding = new System.Windows.Forms.Padding(3);
            this.tab_student_management.Size = new System.Drawing.Size(935, 462);
            this.tab_student_management.TabIndex = 1;
            this.tab_student_management.Text = "مدیریت دانشجویان";
            this.tab_student_management.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_delete_student);
            this.groupBox5.Controls.Add(this.btn_edit_student);
            this.groupBox5.Controls.Add(this.dataGridView_students);
            this.groupBox5.Location = new System.Drawing.Point(10, 253);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(913, 202);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "دانشجوهای موجود";
            // 
            // btn_delete_student
            // 
            this.btn_delete_student.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_delete_student.Location = new System.Drawing.Point(829, 56);
            this.btn_delete_student.Name = "btn_delete_student";
            this.btn_delete_student.Size = new System.Drawing.Size(75, 31);
            this.btn_delete_student.TabIndex = 2;
            this.btn_delete_student.Text = "حذف";
            this.btn_delete_student.UseVisualStyleBackColor = true;
            // 
            // btn_edit_student
            // 
            this.btn_edit_student.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_edit_student.Location = new System.Drawing.Point(829, 19);
            this.btn_edit_student.Name = "btn_edit_student";
            this.btn_edit_student.Size = new System.Drawing.Size(75, 31);
            this.btn_edit_student.TabIndex = 1;
            this.btn_edit_student.Text = "ویرایش";
            this.btn_edit_student.UseVisualStyleBackColor = true;
            // 
            // dataGridView_students
            // 
            this.dataGridView_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_students.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_students.Name = "dataGridView_students";
            this.dataGridView_students.Size = new System.Drawing.Size(820, 186);
            this.dataGridView_students.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.txtBox_name_student);
            this.groupBox6.Controls.Add(this.btn_submit_student);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox6.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(10, 7);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox6.Size = new System.Drawing.Size(914, 239);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ایجاد دانشجوی جدید";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(844, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 24);
            this.label18.TabIndex = 6;
            this.label18.Text = "نام دانشجو";
            // 
            // txtBox_name_student
            // 
            this.txtBox_name_student.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_name_student.Font = new System.Drawing.Font("IRAN Sans", 8.25F);
            this.txtBox_name_student.Location = new System.Drawing.Point(738, 24);
            this.txtBox_name_student.Name = "txtBox_name_student";
            this.txtBox_name_student.Size = new System.Drawing.Size(100, 29);
            this.txtBox_name_student.TabIndex = 5;
            this.txtBox_name_student.Tag = "";
            // 
            // btn_submit_student
            // 
            this.btn_submit_student.Location = new System.Drawing.Point(6, 201);
            this.btn_submit_student.Name = "btn_submit_student";
            this.btn_submit_student.Size = new System.Drawing.Size(75, 31);
            this.btn_submit_student.TabIndex = 3;
            this.btn_submit_student.Text = "تایید";
            this.btn_submit_student.UseVisualStyleBackColor = true;
            // 
            // tab_teacher_managemetn
            // 
            this.tab_teacher_managemetn.Controls.Add(this.groupBox7);
            this.tab_teacher_managemetn.Controls.Add(this.groupBox8);
            this.tab_teacher_managemetn.Location = new System.Drawing.Point(4, 22);
            this.tab_teacher_managemetn.Name = "tab_teacher_managemetn";
            this.tab_teacher_managemetn.Size = new System.Drawing.Size(935, 462);
            this.tab_teacher_managemetn.TabIndex = 2;
            this.tab_teacher_managemetn.Text = "مدیریت استادها";
            this.tab_teacher_managemetn.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btn_delete_teacher);
            this.groupBox7.Controls.Add(this.btn_edit_teacher);
            this.groupBox7.Controls.Add(this.dataGridView_teachers);
            this.groupBox7.Location = new System.Drawing.Point(10, 253);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(913, 202);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "استاد‌ های موجود";
            // 
            // btn_delete_teacher
            // 
            this.btn_delete_teacher.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_delete_teacher.Location = new System.Drawing.Point(829, 56);
            this.btn_delete_teacher.Name = "btn_delete_teacher";
            this.btn_delete_teacher.Size = new System.Drawing.Size(75, 31);
            this.btn_delete_teacher.TabIndex = 2;
            this.btn_delete_teacher.Text = "حذف";
            this.btn_delete_teacher.UseVisualStyleBackColor = true;
            // 
            // btn_edit_teacher
            // 
            this.btn_edit_teacher.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_edit_teacher.Location = new System.Drawing.Point(829, 19);
            this.btn_edit_teacher.Name = "btn_edit_teacher";
            this.btn_edit_teacher.Size = new System.Drawing.Size(75, 31);
            this.btn_edit_teacher.TabIndex = 1;
            this.btn_edit_teacher.Text = "ویرایش";
            this.btn_edit_teacher.UseVisualStyleBackColor = true;
            // 
            // dataGridView_teachers
            // 
            this.dataGridView_teachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_teachers.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_teachers.Name = "dataGridView_teachers";
            this.dataGridView_teachers.Size = new System.Drawing.Size(820, 186);
            this.dataGridView_teachers.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.txtBox_name_teacher);
            this.groupBox8.Controls.Add(this.btn_submit_teacher);
            this.groupBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox8.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(10, 7);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox8.Size = new System.Drawing.Size(914, 239);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "ایجاد استاد جدید";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(844, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 24);
            this.label10.TabIndex = 6;
            this.label10.Text = "نام استاد";
            // 
            // txtBox_name_teacher
            // 
            this.txtBox_name_teacher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_name_teacher.Font = new System.Drawing.Font("IRAN Sans", 8.25F);
            this.txtBox_name_teacher.Location = new System.Drawing.Point(738, 24);
            this.txtBox_name_teacher.Name = "txtBox_name_teacher";
            this.txtBox_name_teacher.Size = new System.Drawing.Size(100, 29);
            this.txtBox_name_teacher.TabIndex = 5;
            this.txtBox_name_teacher.Tag = "";
            // 
            // btn_submit_teacher
            // 
            this.btn_submit_teacher.Location = new System.Drawing.Point(6, 201);
            this.btn_submit_teacher.Name = "btn_submit_teacher";
            this.btn_submit_teacher.Size = new System.Drawing.Size(75, 31);
            this.btn_submit_teacher.TabIndex = 3;
            this.btn_submit_teacher.Text = "تایید";
            this.btn_submit_teacher.UseVisualStyleBackColor = true;
            // 
            // FromManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 488);
            this.Controls.Add(this.tabControl);
            this.Name = "FromManagement";
            this.Text = "بخش آموزش";
            this.tabControl.ResumeLayout(false);
            this.tab_course_management.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_courses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tab_student_management.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_students)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tab_teacher_managemetn.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_teachers)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_course_management;
        private System.Windows.Forms.TabPage tab_student_management;
        private System.Windows.Forms.TabPage tab_teacher_managemetn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_submit_course;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_capacity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_name;
        private System.Windows.Forms.DateTimePicker date_picker_exam;
        private System.Windows.Forms.ComboBox cmb_teacher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_time_1;
        private System.Windows.Forms.ComboBox cmb_day_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_time_2;
        private System.Windows.Forms.ComboBox cmb_day_2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker time_picker_exam;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_delete_course;
        private System.Windows.Forms.Button btn_edit_course;
        private System.Windows.Forms.DataGridView dataGridView_courses;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_delete_student;
        private System.Windows.Forms.Button btn_edit_student;
        private System.Windows.Forms.DataGridView dataGridView_students;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBox_name_student;
        private System.Windows.Forms.Button btn_submit_student;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btn_delete_teacher;
        private System.Windows.Forms.Button btn_edit_teacher;
        private System.Windows.Forms.DataGridView dataGridView_teachers;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBox_name_teacher;
        private System.Windows.Forms.Button btn_submit_teacher;
    }
}