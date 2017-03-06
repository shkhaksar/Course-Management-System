namespace Course_Management.Froms.Management
{
    partial class FormNewCourse
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
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.course_managementDataSet = new Course_Management.course_managementDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_capacity_course = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_name_course = new System.Windows.Forms.TextBox();
            this.btn_submit_course = new System.Windows.Forms.Button();
            this.teachersTableAdapter = new Course_Management.course_managementDataSetTableAdapters.TeachersTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_managementDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.btn_submit_course);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(914, 238);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ایجاد درس جدید";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(691, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 24);
            this.label13.TabIndex = 21;
            this.label13.Text = "کد درس";
            // 
            // txtBox_code_course
            // 
            this.txtBox_code_course.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_code_course.Font = new System.Drawing.Font("IRAN Sans", 8.25F);
            this.txtBox_code_course.Location = new System.Drawing.Point(585, 23);
            this.txtBox_code_course.Name = "txtBox_code_course";
            this.txtBox_code_course.Size = new System.Drawing.Size(100, 29);
            this.txtBox_code_course.TabIndex = 20;
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
            this.cmb_teacher_course.DataSource = this.teachersBindingSource;
            this.cmb_teacher_course.DisplayMember = "name";
            this.cmb_teacher_course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_teacher_course.FormattingEnabled = true;
            this.cmb_teacher_course.Location = new System.Drawing.Point(728, 98);
            this.cmb_teacher_course.Name = "cmb_teacher_course";
            this.cmb_teacher_course.Size = new System.Drawing.Size(121, 32);
            this.cmb_teacher_course.TabIndex = 11;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.course_managementDataSet;
            // 
            // course_managementDataSet
            // 
            this.course_managementDataSet.DataSetName = "course_managementDataSet";
            this.course_managementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // btn_submit_course
            // 
            this.btn_submit_course.Location = new System.Drawing.Point(6, 201);
            this.btn_submit_course.Name = "btn_submit_course";
            this.btn_submit_course.Size = new System.Drawing.Size(75, 31);
            this.btn_submit_course.TabIndex = 3;
            this.btn_submit_course.Text = "تایید";
            this.btn_submit_course.UseVisualStyleBackColor = true;
            this.btn_submit_course.Click += new System.EventHandler(this.btn_submit_course_Click);
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // FormNewCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNewCourse";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "درس جدید";
            this.Load += new System.EventHandler(this.FormNewCourse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_managementDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker time_picker_exam_course;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_time_2_course;
        private System.Windows.Forms.ComboBox cmb_day_2_course;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_time_1_course;
        private System.Windows.Forms.ComboBox cmb_day_1_course;
        private System.Windows.Forms.DateTimePicker date_picker_exam_course;
        private System.Windows.Forms.ComboBox cmb_teacher_course;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_capacity_course;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_name_course;
        private System.Windows.Forms.Button btn_submit_course;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBox_code_course;
        private course_managementDataSet course_managementDataSet;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private course_managementDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
    }
}