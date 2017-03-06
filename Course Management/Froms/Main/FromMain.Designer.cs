namespace Course_Management
{
    partial class FromMain
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
            this.btn_management = new System.Windows.Forms.Button();
            this.btn_teacher = new System.Windows.Forms.Button();
            this.btn_student = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_management
            // 
            this.btn_management.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_management.AutoSize = true;
            this.btn_management.Font = new System.Drawing.Font("IRAN Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_management.Location = new System.Drawing.Point(111, 82);
            this.btn_management.Name = "btn_management";
            this.btn_management.Size = new System.Drawing.Size(75, 32);
            this.btn_management.TabIndex = 1;
            this.btn_management.Text = "آموزش";
            this.btn_management.UseCompatibleTextRendering = true;
            this.btn_management.UseVisualStyleBackColor = true;
            this.btn_management.Click += new System.EventHandler(this.btn_management_Click);
            // 
            // btn_teacher
            // 
            this.btn_teacher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_teacher.AutoSize = true;
            this.btn_teacher.Font = new System.Drawing.Font("IRAN Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_teacher.Location = new System.Drawing.Point(111, 119);
            this.btn_teacher.Name = "btn_teacher";
            this.btn_teacher.Size = new System.Drawing.Size(75, 32);
            this.btn_teacher.TabIndex = 2;
            this.btn_teacher.Text = "استاد";
            this.btn_teacher.UseCompatibleTextRendering = true;
            this.btn_teacher.UseVisualStyleBackColor = true;
            this.btn_teacher.Click += new System.EventHandler(this.btn_teacher_Click);
            // 
            // btn_student
            // 
            this.btn_student.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_student.AutoSize = true;
            this.btn_student.Font = new System.Drawing.Font("IRAN Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_student.Location = new System.Drawing.Point(111, 156);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(75, 32);
            this.btn_student.TabIndex = 3;
            this.btn_student.Text = "دانشجو";
            this.btn_student.UseCompatibleTextRendering = true;
            this.btn_student.UseVisualStyleBackColor = true;
            this.btn_student.Click += new System.EventHandler(this.btn_student_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_title.Font = new System.Drawing.Font("IRAN Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_title.Location = new System.Drawing.Point(9, 9);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(266, 31);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "سامانه انتخاب واحد";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FromMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_student);
            this.Controls.Add(this.btn_teacher);
            this.Controls.Add(this.btn_management);
            this.Name = "FromMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "سامانه انتخاب واحد";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_management;
        private System.Windows.Forms.Button btn_teacher;
        private System.Windows.Forms.Button btn_student;
        private System.Windows.Forms.Label lbl_title;
    }
}

