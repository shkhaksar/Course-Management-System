using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Management
{
    public partial class FromMain : Form
    {
        public FromMain()
        {
            InitializeComponent();
        }

        private void btn_management_Click(object sender, EventArgs e)
        {
            FromManagement frmFromManagement = new FromManagement();
            frmFromManagement.ShowDialog();
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            FormStudents formStudent = new FormStudents();
            formStudent.ShowDialog();
        }

        private void btn_teacher_Click(object sender, EventArgs e)
        {
            FormTeachers formTeachers = new FormTeachers();
            formTeachers.ShowDialog();
        }
    }
}