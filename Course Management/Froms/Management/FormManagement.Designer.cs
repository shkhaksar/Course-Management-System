using System;
using System.Linq;
using System.Windows.Forms;
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_course = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_delete_course = new System.Windows.Forms.Button();
            this.btn_new_course = new System.Windows.Forms.Button();
            this.dataGridView_courses = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseDataSet = new Course_Management.CourseDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBox_code_course = new System.Windows.Forms.TextBox();
            this.time_picker_exam_course = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_time_2_course = new System.Windows.Forms.ComboBox();
            this.cmb_day_2_course = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_time_1_course = new System.Windows.Forms.ComboBox();
            this.cmb_day_1_course = new System.Windows.Forms.ComboBox();
            this.date_picker_exam_course = new System.Windows.Forms.DateTimePicker();
            this.cmb_teacher_course = new System.Windows.Forms.ComboBox();
            this.teachersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.course_managementDataSet1 = new Course_Management.course_managementDataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_capacity_course = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_name_course = new System.Windows.Forms.TextBox();
            this.btn_submit_edit_course = new System.Windows.Forms.Button();
            this.tab_student = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_show_courses_student = new System.Windows.Forms.Button();
            this.btn_take_course = new System.Windows.Forms.Button();
            this.btn_delete_student = new System.Windows.Forms.Button();
            this.btn_new_student = new System.Windows.Forms.Button();
            this.dataGridView_students = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.course_managementDataSet = new Course_Management.course_managementDataSet();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBox_code_student = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBox_name_student = new System.Windows.Forms.TextBox();
            this.btn_submit_edit_student = new System.Windows.Forms.Button();
            this.tab_teacher = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btn_delete_teacher = new System.Windows.Forms.Button();
            this.btn_new_teacher = new System.Windows.Forms.Button();
            this.dataGridView_teachers = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBox_code_teacher = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBox_name_teacher = new System.Windows.Forms.TextBox();
            this.btn_submit_edit_teacher = new System.Windows.Forms.Button();
            this.coursesTableAdapter = new Course_Management.CourseDataSetTableAdapters.CoursesTableAdapter();
            this.coursesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coursesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new Course_Management.course_managementDataSetTableAdapters.StudentsTableAdapter();
            this.teachersTableAdapter = new Course_Management.course_managementDataSetTableAdapters.TeachersTableAdapter();
            this.fKTeacherCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter1 = new Course_Management.course_managementDataSetTableAdapters.CoursesTableAdapter();
            this.teachersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter1 = new Course_Management.course_managementDataSet1TableAdapters.TeachersTableAdapter();
            this.tabControl.SuspendLayout();
            this.tab_course.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_courses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_managementDataSet1)).BeginInit();
            this.tab_student.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_managementDataSet)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tab_teacher.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_teachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTeacherCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_course);
            this.tabControl.Controls.Add(this.tab_student);
            this.tabControl.Controls.Add(this.tab_teacher);
            this.tabControl.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl.RightToLeftLayout = true;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(943, 488);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tab_course
            // 
            this.tab_course.Controls.Add(this.groupBox4);
            this.tab_course.Controls.Add(this.groupBox1);
            this.tab_course.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_course.Location = new System.Drawing.Point(4, 33);
            this.tab_course.Name = "tab_course";
            this.tab_course.Padding = new System.Windows.Forms.Padding(3);
            this.tab_course.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tab_course.Size = new System.Drawing.Size(935, 451);
            this.tab_course.TabIndex = 0;
            this.tab_course.Text = "مدیریت درس ها";
            this.tab_course.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_delete_course);
            this.groupBox4.Controls.Add(this.btn_new_course);
            this.groupBox4.Controls.Add(this.dataGridView_courses);
            this.groupBox4.Location = new System.Drawing.Point(14, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(913, 201);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "درس های موجود";
            // 
            // btn_delete_course
            // 
            this.btn_delete_course.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_delete_course.Location = new System.Drawing.Point(829, 66);
            this.btn_delete_course.Name = "btn_delete_course";
            this.btn_delete_course.Size = new System.Drawing.Size(75, 31);
            this.btn_delete_course.TabIndex = 2;
            this.btn_delete_course.Text = "حذف";
            this.btn_delete_course.UseVisualStyleBackColor = true;
            this.btn_delete_course.Click += new System.EventHandler(this.btn_delete_course_Click);
            // 
            // btn_new_course
            // 
            this.btn_new_course.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_new_course.Location = new System.Drawing.Point(829, 29);
            this.btn_new_course.Name = "btn_new_course";
            this.btn_new_course.Size = new System.Drawing.Size(75, 31);
            this.btn_new_course.TabIndex = 1;
            this.btn_new_course.Text = "ایجاد";
            this.btn_new_course.UseVisualStyleBackColor = true;
            this.btn_new_course.Click += new System.EventHandler(this.btn_new_course_Click);
            // 
            // dataGridView_courses
            // 
            this.dataGridView_courses.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.dataGridView_courses.AllowUserToAddRows = false;
            this.dataGridView_courses.AllowUserToDeleteRows = false;
            this.dataGridView_courses.AllowUserToOrderColumns = true;
            this.dataGridView_courses.AllowUserToResizeRows = false;
            this.dataGridView_courses.AutoGenerateColumns = false;
            this.dataGridView_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_courses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.teacherIdDataGridViewTextBoxColumn,
            this.time1DataGridViewTextBoxColumn,
            this.time2DataGridViewTextBoxColumn,
            this.examdateDataGridViewTextBoxColumn,
            this.examtimeDataGridViewTextBoxColumn});
            this.dataGridView_courses.DataSource = this.coursesBindingSource;
            this.dataGridView_courses.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView_courses.Location = new System.Drawing.Point(3, 29);
            this.dataGridView_courses.MultiSelect = false;
            this.dataGridView_courses.Name = "dataGridView_courses";
            this.dataGridView_courses.ReadOnly = true;
            this.dataGridView_courses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_courses.Size = new System.Drawing.Size(820, 163);
            this.dataGridView_courses.TabIndex = 0;
            this.dataGridView_courses.SelectionChanged += new System.EventHandler(this.dataGridView_courses_SelectionChanged);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "کد درس";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام درس";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "ظرفیت";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teacherIdDataGridViewTextBoxColumn
            // 
            this.teacherIdDataGridViewTextBoxColumn.DataPropertyName = "TeacherId";
            this.teacherIdDataGridViewTextBoxColumn.HeaderText = "استاد";
            this.teacherIdDataGridViewTextBoxColumn.Name = "teacherIdDataGridViewTextBoxColumn";
            this.teacherIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // time1DataGridViewTextBoxColumn
            // 
            this.time1DataGridViewTextBoxColumn.DataPropertyName = "time1";
            this.time1DataGridViewTextBoxColumn.HeaderText = "جلسه اول";
            this.time1DataGridViewTextBoxColumn.Name = "time1DataGridViewTextBoxColumn";
            this.time1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // time2DataGridViewTextBoxColumn
            // 
            this.time2DataGridViewTextBoxColumn.DataPropertyName = "time2";
            this.time2DataGridViewTextBoxColumn.HeaderText = "جلسه دوم";
            this.time2DataGridViewTextBoxColumn.Name = "time2DataGridViewTextBoxColumn";
            this.time2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // examdateDataGridViewTextBoxColumn
            // 
            this.examdateDataGridViewTextBoxColumn.DataPropertyName = "exam_date";
            this.examdateDataGridViewTextBoxColumn.HeaderText = "تاریخ امتحان";
            this.examdateDataGridViewTextBoxColumn.Name = "examdateDataGridViewTextBoxColumn";
            this.examdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // examtimeDataGridViewTextBoxColumn
            // 
            this.examtimeDataGridViewTextBoxColumn.DataPropertyName = "exam_time";
            this.examtimeDataGridViewTextBoxColumn.HeaderText = "ساعت امتحان";
            this.examtimeDataGridViewTextBoxColumn.Name = "examtimeDataGridViewTextBoxColumn";
            this.examtimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.courseDataSet;
            // 
            // courseDataSet
            // 
            this.courseDataSet.DataSetName = "CourseDataSet";
            this.courseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtBox_code_course);
            this.groupBox1.Controls.Add(this.time_picker_exam_course);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.date_picker_exam_course);
            this.groupBox1.Controls.Add(this.cmb_teacher_course);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBox_capacity_course);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBox_name_course);
            this.groupBox1.Controls.Add(this.btn_submit_edit_course);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(914, 238);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ویرایش";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(680, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 24);
            this.label13.TabIndex = 19;
            this.label13.Text = "کد درس";
            // 
            // txtBox_code_course
            // 
            this.txtBox_code_course.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_code_course.Font = new System.Drawing.Font("IRAN Sans", 8.25F);
            this.txtBox_code_course.Location = new System.Drawing.Point(574, 26);
            this.txtBox_code_course.Name = "txtBox_code_course";
            this.txtBox_code_course.Size = new System.Drawing.Size(100, 29);
            this.txtBox_code_course.TabIndex = 18;
            this.txtBox_code_course.Tag = "";
            // 
            // time_picker_exam_course
            // 
            this.time_picker_exam_course.CustomFormat = "HH:mm";
            this.time_picker_exam_course.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_picker_exam_course.Location = new System.Drawing.Point(625, 196);
            this.time_picker_exam_course.Name = "time_picker_exam_course";
            this.time_picker_exam_course.RightToLeftLayout = true;
            this.time_picker_exam_course.ShowUpDown = true;
            this.time_picker_exam_course.Size = new System.Drawing.Size(200, 30);
            this.time_picker_exam_course.TabIndex = 17;
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
            this.groupBox3.Controls.Add(this.cmb_time_2_course);
            this.groupBox3.Controls.Add(this.cmb_day_2_course);
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
            // cmb_time_2_course
            // 
            this.cmb_time_2_course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_time_2_course.FormattingEnabled = true;
            this.cmb_time_2_course.Items.AddRange(new object[] {
            "۸-۱۰",
            "۱۰-۱۲",
            "۱۴-۱۶",
            "۱۶-۱۸"});
            this.cmb_time_2_course.Location = new System.Drawing.Point(7, 53);
            this.cmb_time_2_course.Name = "cmb_time_2_course";
            this.cmb_time_2_course.Size = new System.Drawing.Size(121, 32);
            this.cmb_time_2_course.TabIndex = 14;
            // 
            // cmb_day_2_course
            // 
            this.cmb_day_2_course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_day_2_course.FormattingEnabled = true;
            this.cmb_day_2_course.Items.AddRange(new object[] {
            "شنبه",
            "یکشنبه",
            "دوشنبه",
            "سه شنبه",
            "چهارشنبه"});
            this.cmb_day_2_course.Location = new System.Drawing.Point(134, 54);
            this.cmb_day_2_course.Name = "cmb_day_2_course";
            this.cmb_day_2_course.Size = new System.Drawing.Size(121, 32);
            this.cmb_day_2_course.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmb_time_1_course);
            this.groupBox2.Controls.Add(this.cmb_day_1_course);
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
            // cmb_time_1_course
            // 
            this.cmb_time_1_course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_time_1_course.FormattingEnabled = true;
            this.cmb_time_1_course.Items.AddRange(new object[] {
            "۸-۱۰",
            "۱۰-۱۲",
            "۱۴-۱۶",
            "۱۶-۱۸"});
            this.cmb_time_1_course.Location = new System.Drawing.Point(7, 54);
            this.cmb_time_1_course.Name = "cmb_time_1_course";
            this.cmb_time_1_course.Size = new System.Drawing.Size(121, 32);
            this.cmb_time_1_course.TabIndex = 14;
            // 
            // cmb_day_1_course
            // 
            this.cmb_day_1_course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_day_1_course.FormattingEnabled = true;
            this.cmb_day_1_course.Items.AddRange(new object[] {
            "شنبه",
            "یکشنبه",
            "دوشنبه",
            "سه شنبه",
            "چهارشنبه"});
            this.cmb_day_1_course.Location = new System.Drawing.Point(134, 54);
            this.cmb_day_1_course.Name = "cmb_day_1_course";
            this.cmb_day_1_course.Size = new System.Drawing.Size(121, 32);
            this.cmb_day_1_course.TabIndex = 15;
            // 
            // date_picker_exam_course
            // 
            this.date_picker_exam_course.CustomFormat = "";
            this.date_picker_exam_course.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_picker_exam_course.Location = new System.Drawing.Point(625, 157);
            this.date_picker_exam_course.MaxDate = new System.DateTime(2101, 3, 20, 0, 0, 0, 0);
            this.date_picker_exam_course.MinDate = new System.DateTime(1991, 3, 21, 0, 0, 0, 0);
            this.date_picker_exam_course.Name = "date_picker_exam_course";
            this.date_picker_exam_course.RightToLeftLayout = true;
            this.date_picker_exam_course.Size = new System.Drawing.Size(200, 30);
            this.date_picker_exam_course.TabIndex = 12;
            // 
            // cmb_teacher_course
            // 
            this.cmb_teacher_course.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmb_teacher_course.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_teacher_course.DataSource = this.teachersBindingSource2;
            this.cmb_teacher_course.DisplayMember = "name";
            this.cmb_teacher_course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_teacher_course.FormattingEnabled = true;
            this.cmb_teacher_course.Location = new System.Drawing.Point(728, 98);
            this.cmb_teacher_course.Name = "cmb_teacher_course";
            this.cmb_teacher_course.Size = new System.Drawing.Size(121, 32);
            this.cmb_teacher_course.TabIndex = 11;
            // 
            // teachersBindingSource2
            // 
            this.teachersBindingSource2.DataMember = "Teachers";
            this.teachersBindingSource2.DataSource = this.course_managementDataSet1;
            // 
            // course_managementDataSet1
            // 
            this.course_managementDataSet1.DataSetName = "course_managementDataSet1";
            this.course_managementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // txtBox_capacity_course
            // 
            this.txtBox_capacity_course.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_capacity_course.Font = new System.Drawing.Font("IRAN Sans", 8.25F);
            this.txtBox_capacity_course.Location = new System.Drawing.Point(749, 61);
            this.txtBox_capacity_course.Name = "txtBox_capacity_course";
            this.txtBox_capacity_course.Size = new System.Drawing.Size(100, 29);
            this.txtBox_capacity_course.TabIndex = 7;
            this.txtBox_capacity_course.Tag = "";
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
            // txtBox_name_course
            // 
            this.txtBox_name_course.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_name_course.Font = new System.Drawing.Font("IRAN Sans", 8.25F);
            this.txtBox_name_course.Location = new System.Drawing.Point(749, 24);
            this.txtBox_name_course.Name = "txtBox_name_course";
            this.txtBox_name_course.Size = new System.Drawing.Size(100, 29);
            this.txtBox_name_course.TabIndex = 5;
            this.txtBox_name_course.Tag = "";
            // 
            // btn_submit_edit_course
            // 
            this.btn_submit_edit_course.Location = new System.Drawing.Point(6, 201);
            this.btn_submit_edit_course.Name = "btn_submit_edit_course";
            this.btn_submit_edit_course.Size = new System.Drawing.Size(75, 31);
            this.btn_submit_edit_course.TabIndex = 3;
            this.btn_submit_edit_course.Text = "تایید";
            this.btn_submit_edit_course.UseVisualStyleBackColor = true;
            this.btn_submit_edit_course.Click += new System.EventHandler(this.btn_submit_edit_course_Click);
            // 
            // tab_student
            // 
            this.tab_student.Controls.Add(this.groupBox5);
            this.tab_student.Controls.Add(this.groupBox6);
            this.tab_student.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_student.Location = new System.Drawing.Point(4, 33);
            this.tab_student.Name = "tab_student";
            this.tab_student.Padding = new System.Windows.Forms.Padding(3);
            this.tab_student.Size = new System.Drawing.Size(935, 451);
            this.tab_student.TabIndex = 1;
            this.tab_student.Text = "مدیریت دانشجویان";
            this.tab_student.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_show_courses_student);
            this.groupBox5.Controls.Add(this.btn_take_course);
            this.groupBox5.Controls.Add(this.btn_delete_student);
            this.groupBox5.Controls.Add(this.btn_new_student);
            this.groupBox5.Controls.Add(this.dataGridView_students);
            this.groupBox5.Location = new System.Drawing.Point(14, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(913, 202);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "دانشجوهای موجود";
            // 
            // btn_show_courses_student
            // 
            this.btn_show_courses_student.Font = new System.Drawing.Font("IRAN Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_show_courses_student.Location = new System.Drawing.Point(829, 142);
            this.btn_show_courses_student.Name = "btn_show_courses_student";
            this.btn_show_courses_student.Size = new System.Drawing.Size(75, 33);
            this.btn_show_courses_student.TabIndex = 23;
            this.btn_show_courses_student.Text = "واحد ها";
            this.btn_show_courses_student.UseVisualStyleBackColor = true;
            this.btn_show_courses_student.Click += new System.EventHandler(this.btn_show_courses_student_Click);
            // 
            // btn_take_course
            // 
            this.btn_take_course.Font = new System.Drawing.Font("IRAN Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_take_course.Location = new System.Drawing.Point(829, 103);
            this.btn_take_course.Name = "btn_take_course";
            this.btn_take_course.Size = new System.Drawing.Size(75, 33);
            this.btn_take_course.TabIndex = 22;
            this.btn_take_course.Text = "انتخاب واحد";
            this.btn_take_course.UseVisualStyleBackColor = true;
            this.btn_take_course.Click += new System.EventHandler(this.btn_take_course_Click);
            // 
            // btn_delete_student
            // 
            this.btn_delete_student.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_delete_student.Location = new System.Drawing.Point(829, 66);
            this.btn_delete_student.Name = "btn_delete_student";
            this.btn_delete_student.Size = new System.Drawing.Size(75, 31);
            this.btn_delete_student.TabIndex = 2;
            this.btn_delete_student.Text = "حذف";
            this.btn_delete_student.UseVisualStyleBackColor = true;
            this.btn_delete_student.Click += new System.EventHandler(this.btn_delete_student_Click);
            // 
            // btn_new_student
            // 
            this.btn_new_student.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_new_student.Location = new System.Drawing.Point(829, 29);
            this.btn_new_student.Name = "btn_new_student";
            this.btn_new_student.Size = new System.Drawing.Size(75, 31);
            this.btn_new_student.TabIndex = 1;
            this.btn_new_student.Text = "ایجاد";
            this.btn_new_student.UseVisualStyleBackColor = true;
            this.btn_new_student.Click += new System.EventHandler(this.btn_new_student_Click);
            // 
            // dataGridView_students
            // 
            this.dataGridView_students.AllowUserToAddRows = false;
            this.dataGridView_students.AllowUserToDeleteRows = false;
            this.dataGridView_students.AllowUserToOrderColumns = true;
            this.dataGridView_students.AllowUserToResizeRows = false;
            this.dataGridView_students.AutoGenerateColumns = false;
            this.dataGridView_students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.units});
            this.dataGridView_students.DataSource = this.studentsBindingSource;
            this.dataGridView_students.Location = new System.Drawing.Point(3, 29);
            this.dataGridView_students.MultiSelect = false;
            this.dataGridView_students.Name = "dataGridView_students";
            this.dataGridView_students.ReadOnly = true;
            this.dataGridView_students.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_students.Size = new System.Drawing.Size(820, 163);
            this.dataGridView_students.TabIndex = 0;
            this.dataGridView_students.SelectionChanged += new System.EventHandler(this.dataGridView_students_SelectionChanged);
            // 
            // codeDataGridViewTextBoxColumn1
            // 
            this.codeDataGridViewTextBoxColumn1.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn1.HeaderText = "شماره دانشجویی";
            this.codeDataGridViewTextBoxColumn1.Name = "codeDataGridViewTextBoxColumn1";
            this.codeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn1.Width = 119;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "نام دانشجو";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 89;
            // 
            // units
            // 
            this.units.DataPropertyName = "units";
            this.units.HeaderText = "تعداد واحد ها";
            this.units.Name = "units";
            this.units.ReadOnly = true;
            this.units.Width = 101;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.course_managementDataSet;
            // 
            // course_managementDataSet
            // 
            this.course_managementDataSet.DataSetName = "course_managementDataSet";
            this.course_managementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.txtBox_code_student);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.txtBox_name_student);
            this.groupBox6.Controls.Add(this.btn_submit_edit_student);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox6.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(13, 207);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox6.Size = new System.Drawing.Size(914, 238);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ویرایش";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(844, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 24);
            this.label12.TabIndex = 12;
            this.label12.Text = "کد دانشجو";
            // 
            // txtBox_code_student
            // 
            this.txtBox_code_student.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_code_student.Font = new System.Drawing.Font("IRAN Sans", 8.25F);
            this.txtBox_code_student.Location = new System.Drawing.Point(738, 59);
            this.txtBox_code_student.Name = "txtBox_code_student";
            this.txtBox_code_student.Size = new System.Drawing.Size(100, 29);
            this.txtBox_code_student.TabIndex = 11;
            this.txtBox_code_student.Tag = "";
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
            // btn_submit_edit_student
            // 
            this.btn_submit_edit_student.Location = new System.Drawing.Point(6, 201);
            this.btn_submit_edit_student.Name = "btn_submit_edit_student";
            this.btn_submit_edit_student.Size = new System.Drawing.Size(75, 31);
            this.btn_submit_edit_student.TabIndex = 3;
            this.btn_submit_edit_student.Text = "تایید";
            this.btn_submit_edit_student.UseVisualStyleBackColor = true;
            this.btn_submit_edit_student.Click += new System.EventHandler(this.btn_submit_edit_student_Click);
            // 
            // tab_teacher
            // 
            this.tab_teacher.Controls.Add(this.groupBox7);
            this.tab_teacher.Controls.Add(this.groupBox8);
            this.tab_teacher.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_teacher.Location = new System.Drawing.Point(4, 33);
            this.tab_teacher.Name = "tab_teacher";
            this.tab_teacher.Size = new System.Drawing.Size(935, 451);
            this.tab_teacher.TabIndex = 2;
            this.tab_teacher.Text = "مدیریت استادها";
            this.tab_teacher.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btn_delete_teacher);
            this.groupBox7.Controls.Add(this.btn_new_teacher);
            this.groupBox7.Controls.Add(this.dataGridView_teachers);
            this.groupBox7.Location = new System.Drawing.Point(14, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(913, 202);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "استاد‌ های موجود";
            // 
            // btn_delete_teacher
            // 
            this.btn_delete_teacher.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_delete_teacher.Location = new System.Drawing.Point(829, 66);
            this.btn_delete_teacher.Name = "btn_delete_teacher";
            this.btn_delete_teacher.Size = new System.Drawing.Size(75, 31);
            this.btn_delete_teacher.TabIndex = 2;
            this.btn_delete_teacher.Text = "حذف";
            this.btn_delete_teacher.UseVisualStyleBackColor = true;
            this.btn_delete_teacher.Click += new System.EventHandler(this.btn_delete_teacher_Click);
            // 
            // btn_new_teacher
            // 
            this.btn_new_teacher.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_new_teacher.Location = new System.Drawing.Point(829, 29);
            this.btn_new_teacher.Name = "btn_new_teacher";
            this.btn_new_teacher.Size = new System.Drawing.Size(75, 31);
            this.btn_new_teacher.TabIndex = 1;
            this.btn_new_teacher.Text = "ایجاد";
            this.btn_new_teacher.UseVisualStyleBackColor = true;
            this.btn_new_teacher.Click += new System.EventHandler(this.btn_new_teacher_Click);
            // 
            // dataGridView_teachers
            // 
            this.dataGridView_teachers.AllowUserToAddRows = false;
            this.dataGridView_teachers.AllowUserToDeleteRows = false;
            this.dataGridView_teachers.AllowUserToOrderColumns = true;
            this.dataGridView_teachers.AllowUserToResizeRows = false;
            this.dataGridView_teachers.AutoGenerateColumns = false;
            this.dataGridView_teachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_teachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn2});
            this.dataGridView_teachers.DataSource = this.teachersBindingSource;
            this.dataGridView_teachers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_teachers.Location = new System.Drawing.Point(3, 29);
            this.dataGridView_teachers.MultiSelect = false;
            this.dataGridView_teachers.Name = "dataGridView_teachers";
            this.dataGridView_teachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_teachers.Size = new System.Drawing.Size(820, 163);
            this.dataGridView_teachers.StandardTab = true;
            this.dataGridView_teachers.TabIndex = 0;
            this.dataGridView_teachers.SelectionChanged += new System.EventHandler(this.dataGridView_teachers_SelectionChanged);
            // 
            // codeDataGridViewTextBoxColumn2
            // 
            this.codeDataGridViewTextBoxColumn2.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn2.HeaderText = "کد استاد";
            this.codeDataGridViewTextBoxColumn2.Name = "codeDataGridViewTextBoxColumn2";
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "نام استاد";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.course_managementDataSet;
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.txtBox_code_teacher);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.txtBox_name_teacher);
            this.groupBox8.Controls.Add(this.btn_submit_edit_teacher);
            this.groupBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox8.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(13, 207);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox8.Size = new System.Drawing.Size(914, 238);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "ویرایش";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(844, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 24);
            this.label11.TabIndex = 8;
            this.label11.Text = "کد استاد";
            // 
            // txtBox_code_teacher
            // 
            this.txtBox_code_teacher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_code_teacher.Font = new System.Drawing.Font("IRAN Sans", 8.25F);
            this.txtBox_code_teacher.Location = new System.Drawing.Point(738, 59);
            this.txtBox_code_teacher.Name = "txtBox_code_teacher";
            this.txtBox_code_teacher.Size = new System.Drawing.Size(100, 29);
            this.txtBox_code_teacher.TabIndex = 7;
            this.txtBox_code_teacher.Tag = "";
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
            // btn_submit_edit_teacher
            // 
            this.btn_submit_edit_teacher.Location = new System.Drawing.Point(6, 201);
            this.btn_submit_edit_teacher.Name = "btn_submit_edit_teacher";
            this.btn_submit_edit_teacher.Size = new System.Drawing.Size(75, 31);
            this.btn_submit_edit_teacher.TabIndex = 3;
            this.btn_submit_edit_teacher.Text = "تایید";
            this.btn_submit_edit_teacher.UseVisualStyleBackColor = true;
            this.btn_submit_edit_teacher.Click += new System.EventHandler(this.btn_submit_edit_teacher_Click);
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // coursesBindingSource1
            // 
            this.coursesBindingSource1.DataMember = "Courses";
            this.coursesBindingSource1.DataSource = this.courseDataSet;
            // 
            // coursesBindingSource2
            // 
            this.coursesBindingSource2.DataMember = "Courses";
            this.coursesBindingSource2.DataSource = this.courseDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // fKTeacherCourseBindingSource
            // 
            this.fKTeacherCourseBindingSource.DataMember = "FK_TeacherCourse";
            this.fKTeacherCourseBindingSource.DataSource = this.teachersBindingSource;
            // 
            // coursesTableAdapter1
            // 
            this.coursesTableAdapter1.ClearBeforeFill = true;
            // 
            // teachersBindingSource1
            // 
            this.teachersBindingSource1.DataMember = "Teachers";
            this.teachersBindingSource1.DataSource = this.course_managementDataSet;
            // 
            // teachersTableAdapter1
            // 
            this.teachersTableAdapter1.ClearBeforeFill = true;
            // 
            // FromManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 488);
            this.Controls.Add(this.tabControl);
            this.Name = "FromManagement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "بخش آموزش";
            this.Load += new System.EventHandler(this.FromManagement_Load);
            this.tabControl.ResumeLayout(false);
            this.tab_course.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_courses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_managementDataSet1)).EndInit();
            this.tab_student.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_managementDataSet)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tab_teacher.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_teachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTeacherCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_course;
        private System.Windows.Forms.TabPage tab_student;
        private System.Windows.Forms.TabPage tab_teacher;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_submit_edit_course;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_capacity_course;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_name_course;
        private System.Windows.Forms.DateTimePicker date_picker_exam_course;
        private System.Windows.Forms.ComboBox cmb_teacher_course;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_time_1_course;
        private System.Windows.Forms.ComboBox cmb_day_1_course;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_time_2_course;
        private System.Windows.Forms.ComboBox cmb_day_2_course;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker time_picker_exam_course;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_delete_course;
        private System.Windows.Forms.Button btn_new_course;
        private System.Windows.Forms.DataGridView dataGridView_courses;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_delete_student;
        private System.Windows.Forms.Button btn_new_student;
        private System.Windows.Forms.DataGridView dataGridView_students;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBox_name_student;
        private System.Windows.Forms.Button btn_submit_edit_student;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btn_delete_teacher;
        private System.Windows.Forms.Button btn_new_teacher;
        private System.Windows.Forms.DataGridView dataGridView_teachers;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBox_name_teacher;
        private System.Windows.Forms.Button btn_submit_edit_teacher;
        private Label label11;
        private TextBox txtBox_code_teacher;
        private Label label12;
        private TextBox txtBox_code_student;
        private Label label13;
        private TextBox txtBox_code_course;
        private CourseDataSet courseDataSet;
        private BindingSource coursesBindingSource;
        private CourseDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private BindingSource coursesBindingSource1;
        private BindingSource coursesBindingSource2;
        private course_managementDataSet course_managementDataSet;
        private BindingSource studentsBindingSource;
        private course_managementDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private BindingSource teachersBindingSource;
        private course_managementDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private BindingSource fKTeacherCourseBindingSource;
        private course_managementDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter1;
        private BindingSource teachersBindingSource1;
        private course_managementDataSet1 course_managementDataSet1;
        private BindingSource teachersBindingSource2;
        private course_managementDataSet1TableAdapters.TeachersTableAdapter teachersTableAdapter1;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn teacherIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn time1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn time2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn examdateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn examtimeDataGridViewTextBoxColumn;
        private Button btn_take_course;
        private Button btn_show_courses_student;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn units;
    }
}