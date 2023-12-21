using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass_IT_Driving_School
{
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }

        private void Course_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("ID", 150);
            listView1.Columns.Add("Course Name", 150);
            listView1.Columns.Add("Price", 150);
            listView1.Columns.Add("Instructor", 150);
            listView1.Columns.Add("Date", 150);
            updateCourse.Visible = false;
            deleteCourse.Visible = false;
        }

        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            if (courseId.Text.ToString() == "")
            {
                MessageBox.Show("Course Id  Can Not Be Empty !");
            }

            else if (courseName.Text.ToString() == "")
            {
                MessageBox.Show("Please Select Course Name !");
            }
            else if (coursePrice.Text.ToString() == "")
            {
                MessageBox.Show("Please Select  course Price!");
            }

            else if (Instructor.Text.ToString() == "Choose Role" || Instructor.Text.ToString() == "")
            {
                MessageBox.Show("Please Select Role !");
            }

            else if (date.Text.ToString() == "")
            {
                MessageBox.Show("Please Select Date!");
            }
            else
            {

                ListViewItem newitem = new ListViewItem(courseId.Text.ToString());

                newitem.SubItems.Add(courseName.Text.ToString());
                newitem.SubItems.Add(coursePrice.Text.ToString());
                newitem.SubItems.Add(Instructor.Text.ToString());
                newitem.SubItems.Add(date.Text.ToString());
                listView1.Items.Add(newitem);

                courseId.Text = "";
                courseName.Text = "";
                coursePrice.Text = "";
                Instructor.ResetText();
                date.ResetText();
            }
        }

        private void updateCourse_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].SubItems[0].Text = courseId.Text;
            listView1.SelectedItems[0].SubItems[1].Text = courseName.Text;
            listView1.SelectedItems[0].SubItems[2].Text = coursePrice.Text;
            listView1.SelectedItems[0].SubItems[3].Text = Instructor.Text;

            listView1.SelectedItems[0].SubItems[4].Text = date.Text;
            courseId.Text = "";
            courseName.Text = "";
            coursePrice.Text = "";
            Instructor.ResetText();
            date.ResetText();
            deleteCourse.Visible = false;
            updateCourse.Visible = false;
            addCourseBtn.Enabled = true;

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                courseId.Text = listView1.SelectedItems[0].SubItems[0].Text;
                courseName.Text = listView1.SelectedItems[0].SubItems[1].Text;
                coursePrice.Text = listView1.SelectedItems[0].SubItems[2].Text;
                Instructor.Text = listView1.SelectedItems[0].SubItems[3].Text;

                date.Text = listView1.SelectedItems[0].SubItems[4].Text;
                
                deleteCourse.Visible = true;
                updateCourse.Visible = true;
                addCourseBtn.Enabled = false;

            }
        }

        private void deleteCourse_Click(object sender, EventArgs e)
        {
           
                if (listView1.SelectedItems.Count > 0)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
            courseId.Text = "";
            courseName.Text = "";
            coursePrice.Text = "";
            Instructor.ResetText();
            date.ResetText();
            deleteCourse.Visible = false;
                updateCourse.Visible = false;
            addCourseBtn.Enabled = true;



        }
    }
}
