namespace Course_Management
{
    partial class FormTeachers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseDataSet = new Course_Management.CourseDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBox_code_teacher = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBox_name_teacher = new System.Windows.Forms.TextBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txtBox_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.coursesTableAdapter = new Course_Management.CourseDataSetTableAdapters.CoursesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.time1DataGridViewTextBoxColumn,
            this.time2DataGridViewTextBoxColumn,
            this.examdateDataGridViewTextBoxColumn,
            this.examtimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.coursesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 29);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(576, 267);
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
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(588, 302);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست درس های ارائه شده";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(712, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 24);
            this.label11.TabIndex = 14;
            this.label11.Text = "کد استاد";
            // 
            // txtBox_code_teacher
            // 
            this.txtBox_code_teacher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_code_teacher.Font = new System.Drawing.Font("IRAN Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtBox_code_teacher.Location = new System.Drawing.Point(606, 64);
            this.txtBox_code_teacher.Name = "txtBox_code_teacher";
            this.txtBox_code_teacher.ReadOnly = true;
            this.txtBox_code_teacher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBox_code_teacher.Size = new System.Drawing.Size(100, 29);
            this.txtBox_code_teacher.TabIndex = 13;
            this.txtBox_code_teacher.Tag = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(712, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 24);
            this.label10.TabIndex = 12;
            this.label10.Text = "نام استاد";
            // 
            // txtBox_name_teacher
            // 
            this.txtBox_name_teacher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_name_teacher.Font = new System.Drawing.Font("IRAN Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtBox_name_teacher.Location = new System.Drawing.Point(606, 29);
            this.txtBox_name_teacher.Name = "txtBox_name_teacher";
            this.txtBox_name_teacher.ReadOnly = true;
            this.txtBox_name_teacher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBox_name_teacher.Size = new System.Drawing.Size(100, 29);
            this.txtBox_name_teacher.TabIndex = 11;
            this.txtBox_name_teacher.Tag = "";
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
            this.loginPanel.Location = new System.Drawing.Point(-7, -30);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(784, 354);
            this.loginPanel.TabIndex = 15;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_cancel.Location = new System.Drawing.Point(400, 187);
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
            this.txtBox_login.Location = new System.Drawing.Point(319, 151);
            this.txtBox_login.Name = "txtBox_login";
            this.txtBox_login.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBox_login.Size = new System.Drawing.Size(156, 30);
            this.txtBox_login.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(322, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "لطفا کد استاد را وارد نمایید";
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_ok.Location = new System.Drawing.Point(319, 187);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 31);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "تایید";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // FormTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 316);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBox_code_teacher);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBox_name_teacher);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTeachers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "بخش استادها";
            this.Load += new System.EventHandler(this.FormTeachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBox_code_teacher;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBox_name_teacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txtBox_login;
        private System.Windows.Forms.Panel loginPanel;
        private CourseDataSet courseDataSet;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private CourseDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn time1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn time2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examtimeDataGridViewTextBoxColumn;
    }
}