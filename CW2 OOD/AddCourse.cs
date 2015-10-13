using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW2_OOD
{
    public partial class AddCourse : Form
    {
        Course course;
        public AddCourse(Course course)
        {
            this.course = course;
            InitializeComponent();
        }

        private void AddCourseName_Click(object sender, EventArgs e)
        {
			String cname = CourseNameText.Text.Trim();
			if ("".Equals (cname))
			{
				MessageBox.Show("Course Name is blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			course.setName(cname);
            this.Close();
        }
    }
}
