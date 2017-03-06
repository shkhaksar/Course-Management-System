namespace Course_Management.Froms.Management
{
    partial class FormNewStudent
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBox_code_student = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBox_name_student = new System.Windows.Forms.TextBox();
            this.btn_submit_student = new System.Windows.Forms.Button();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox6.Controls.Add(this.btn_submit_student);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox6.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(14, 11);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox6.Size = new System.Drawing.Size(914, 238);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ایجاد دانشجوی جدید";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(844, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 24);
            this.label12.TabIndex = 14;
            this.label12.Text = "کد دانشجو";
            // 
            // txtBox_code_student
            // 
            this.txtBox_code_student.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_code_student.Font = new System.Drawing.Font("IRAN Sans", 8.25F);
            this.txtBox_code_student.Location = new System.Drawing.Point(738, 59);
            this.txtBox_code_student.Name = "txtBox_code_student";
            this.txtBox_code_student.Size = new System.Drawing.Size(100, 29);
            this.txtBox_code_student.TabIndex = 13;
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
            // btn_submit_student
            // 
            this.btn_submit_student.Location = new System.Drawing.Point(6, 201);
            this.btn_submit_student.Name = "btn_submit_student";
            this.btn_submit_student.Size = new System.Drawing.Size(75, 31);
            this.btn_submit_student.TabIndex = 3;
            this.btn_submit_student.Text = "تایید";
            this.btn_submit_student.UseVisualStyleBackColor = true;
            this.btn_submit_student.Click += new System.EventHandler(this.btn_submit_student_Click);
            // 
            // FormNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 261);
            this.Controls.Add(this.groupBox6);
            this.Name = "FormNewStudent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "دانشجوی جدید";
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBox_name_student;
        private System.Windows.Forms.Button btn_submit_student;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBox_code_student;
    }
}