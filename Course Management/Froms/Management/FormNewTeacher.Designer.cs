namespace Course_Management.Froms.Management
{
    partial class FormNewTeacher
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
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBox_code_teacher = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBox_name_teacher = new System.Windows.Forms.TextBox();
            this.btn_submit_teacher = new System.Windows.Forms.Button();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox8.Controls.Add(this.btn_submit_teacher);
            this.groupBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox8.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(14, 11);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox8.Size = new System.Drawing.Size(914, 238);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "ایجاد استاد جدید";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(844, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "کد استاد";
            // 
            // txtBox_code_teacher
            // 
            this.txtBox_code_teacher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_code_teacher.Font = new System.Drawing.Font("IRAN Sans", 8.25F);
            this.txtBox_code_teacher.Location = new System.Drawing.Point(738, 59);
            this.txtBox_code_teacher.Name = "txtBox_code_teacher";
            this.txtBox_code_teacher.Size = new System.Drawing.Size(100, 29);
            this.txtBox_code_teacher.TabIndex = 9;
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
            // btn_submit_teacher
            // 
            this.btn_submit_teacher.Location = new System.Drawing.Point(6, 201);
            this.btn_submit_teacher.Name = "btn_submit_teacher";
            this.btn_submit_teacher.Size = new System.Drawing.Size(75, 31);
            this.btn_submit_teacher.TabIndex = 3;
            this.btn_submit_teacher.Text = "تایید";
            this.btn_submit_teacher.UseVisualStyleBackColor = true;
            this.btn_submit_teacher.Click += new System.EventHandler(this.btn_submit_teacher_Click);
            // 
            // FormNewTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 261);
            this.Controls.Add(this.groupBox8);
            this.Name = "FormNewTeacher";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "استاد جدید";
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBox_name_teacher;
        private System.Windows.Forms.Button btn_submit_teacher;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBox_code_teacher;
    }
}