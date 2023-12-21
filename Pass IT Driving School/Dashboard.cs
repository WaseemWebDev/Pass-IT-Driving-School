using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass_IT_Driving_School
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Students_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }




        private void flowLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void StudentsBtn_Click_1(object sender, EventArgs e)
        {
            Students students = new Students();
            students.ShowDialog();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void InstructorBtn_Click(object sender, EventArgs e)
        {

            Instructor instructor = new Instructor();
            instructor.ShowDialog();

        }

        private void CoursesBtn_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.ShowDialog();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Analysis analysis = new Analysis();
            analysis.ShowDialog();
        }
    }
}
