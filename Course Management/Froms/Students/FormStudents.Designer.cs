namespace Course_Management
{
    partial class FormStudents
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
            this.label12 = new System.Windows.Forms.Label();
            this.txtBox_code_student = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBox_name_student = new System.Windows.Forms.TextBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txtBox_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.coursesTableAdapter = new Course_Management.CourseDataSetTableAdapters.CoursesTableAdapter();
            this.btn_take_course = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_unit_sum = new System.Windows.Forms.TextBox();
            this.loginPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(833, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 24);
            this.label12.TabIndex = 18;
            this.label12.Text = "کد دانشجو";
            // 
            // txtBox_code_student
            // 
            this.txtBox_code_student.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_code_student.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtBox_code_student.Location = new System.Drawing.Point(727, 47);
            this.txtBox_code_student.Name = "txtBox_code_student";
            this.txtBox_code_student.ReadOnly = true;
            this.txtBox_code_student.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBox_code_student.Size = new System.Drawing.Size(100, 30);
            this.txtBox_code_student.TabIndex = 17;
            this.txtBox_code_student.Tag = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label18.Location = new System.Drawing.Point(833, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 24);
            this.label18.TabIndex = 16;
            this.label18.Text = "نام دانشجو";
            // 
            // txtBox_name_student
            // 
            this.txtBox_name_student.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_name_student.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtBox_name_student.Location = new System.Drawing.Point(727, 12);
            this.txtBox_name_student.Name = "txtBox_name_student";
            this.txtBox_name_student.ReadOnly = true;
            this.txtBox_name_student.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBox_name_student.Size = new System.Drawing.Size(100, 30);
            this.txtBox_name_student.TabIndex = 15;
            this.txtBox_name_student.Tag = "";
            // 
            // loginPanel
            // 
            this.loginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginPanel.Controls.Add(this.btn_cancel);
            this.loginPanel.Controls.Add(this.txtBox_login);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.btn_ok);
            this.loginPanel.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.loginPanel.Location = new System.Drawing.Point(-8, -30);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(926, 431);
            this.loginPanel.TabIndex = 19;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_cancel.Location = new System.Drawing.Point(465, 226);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 31);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "بیخیال";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txtBox_login
            // 
            this.txtBox_login.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtBox_login.Location = new System.Drawing.Point(384, 190);
            this.txtBox_login.Name = "txtBox_login";
            this.txtBox_login.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBox_login.Size = new System.Drawing.Size(156, 30);
            this.txtBox_login.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(379, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "لطفا کد دانشجو را وارد نمایید";
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_ok.Location = new System.Drawing.Point(384, 226);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 31);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "تایید";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(709, 369);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "درس های اخذ شده";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.teacherIdDataGridViewTextBoxColumn,
            this.time1DataGridViewTextBoxColumn,
            this.time2DataGridViewTextBoxColumn,
            this.examdateDataGridViewTextBoxColumn,
            this.examtimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.coursesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 29);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(697, 334);
            this.dataGridView1.TabIndex = 0;
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
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // btn_take_course
            // 
            this.btn_take_course.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_take_course.Location = new System.Drawing.Point(728, 119);
            this.btn_take_course.Name = "btn_take_course";
            this.btn_take_course.Size = new System.Drawing.Size(169, 38);
            this.btn_take_course.TabIndex = 21;
            this.btn_take_course.Text = "انتخاب واحد";
            this.btn_take_course.UseVisualStyleBackColor = true;
            this.btn_take_course.Click += new System.EventHandler(this.btn_take_course_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(834, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "جمع واحد ها";
            // 
            // txtBox_unit_sum
            // 
            this.txtBox_unit_sum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_unit_sum.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtBox_unit_sum.Location = new System.Drawing.Point(727, 83);
            this.txtBox_unit_sum.Name = "txtBox_unit_sum";
            this.txtBox_unit_sum.ReadOnly = true;
            this.txtBox_unit_sum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBox_unit_sum.Size = new System.Drawing.Size(100, 30);
            this.txtBox_unit_sum.TabIndex = 22;
            this.txtBox_unit_sum.Tag = "";
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 393);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_unit_sum);
            this.Controls.Add(this.btn_take_course);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBox_code_student);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtBox_name_student);
            this.Name = "FormStudents";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "بخش دانشجویان";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBox_code_student;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBox_name_student;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txtBox_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CourseDataSet courseDataSet;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private CourseDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn time1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn time2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_take_course;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_unit_sum;
    }
}