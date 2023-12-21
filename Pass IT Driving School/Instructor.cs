using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Pass_IT_Driving_School
{
    public partial class Instructor : Form
    {
        public Instructor()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Instructor_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("ID", 80);
            listView1.Columns.Add("First Name", 80);
            listView1.Columns.Add("Last Name", 80);
            listView1.Columns.Add("Phone No", 80);
            listView1.Columns.Add("Address", 120);
            listView1.Columns.Add("Role", 60);
            listView1.Columns.Add("Gender", 60);
            listView1.Columns.Add("Course", 60);
            listView1.Columns.Add("Date", 60);
            delete.Visible = false;
            updateBtn.Visible = false;

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (instructorId.Text.ToString() == "")
            {
                MessageBox.Show("Instructor Id  Can Not Be Empty !");
            }
            else if (firstName.Text.ToString() == "")
            {
                MessageBox.Show("First Name Can Not Be Empty !");
            }
            else if (lastName.Text.ToString() == "")
            {
                MessageBox.Show("Last Name Can Not Be Empty !");
            }



            else if (phoneNo.Text.ToString() == "")
            {
                MessageBox.Show("Phone No Can Not Be Empty !");
            }
            else if (address.Text.ToString() == "")
            {
                MessageBox.Show("Address No Can Not Be Empty !");
            }
            else if (gender.Text.ToString() == "" || gender.Text.ToString() == "Choose Gender")
            {
                MessageBox.Show("Gender No Can Not Be Empty !");
            }
            else if (course.Text.ToString() == "Choose Course" || course.Text.ToString() == "")
            {
                MessageBox.Show("Please Select Course !");
            }
            else if (instructorRole.Text.ToString() == "Choose Role" || instructorRole.Text.ToString() == "")
            {
                MessageBox.Show("Please Select Role !");
            }

            else if (date.Text.ToString() == "")
            {
                MessageBox.Show("Please Select Date!");
            }
            else
            {

                ListViewItem newitem = new ListViewItem(instructorId.Text.ToString());
                newitem.SubItems.Add(firstName.Text.ToString());
                newitem.SubItems.Add(lastName.Text.ToString());

                newitem.SubItems.Add(phoneNo.Text.ToString());
                newitem.SubItems.Add(address.Text.ToString());
                newitem.SubItems.Add(instructorRole.Text.ToString());
                newitem.SubItems.Add(gender.Text.ToString());
                newitem.SubItems.Add(course.Text.ToString());

                newitem.SubItems.Add(date.Text.ToString());
                listView1.Items.Add(newitem);

                instructorId.Text = "";
                firstName.Text = "";
                lastName.Text = "";

                phoneNo.Text = "";
                address.Text = "";
                gender.ResetText();
                instructorRole.ResetText();
                course.ResetText();
                date.ResetText();


            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                instructorId.Text = listView1.SelectedItems[0].SubItems[0].Text;
                firstName.Text = listView1.SelectedItems[0].SubItems[1].Text;
                lastName.Text = listView1.SelectedItems[0].SubItems[2].Text;
                phoneNo.Text = listView1.SelectedItems[0].SubItems[3].Text;

                address.Text = listView1.SelectedItems[0].SubItems[4].Text;
                instructorRole.Text = listView1.SelectedItems[0].SubItems[5].Text;
                gender.Text = listView1.SelectedItems[0].SubItems[6].Text;
                course.Text = listView1.SelectedItems[0].SubItems[7].Text;
                date.Text = listView1.SelectedItems[0].SubItems[8].Text;
                addInstructor.Enabled = false;
                delete.Visible = true;
                updateBtn.Visible = true;

            }

        }

        private void listView1_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }

            instructorId.Text = "";
            firstName.Text = "";
            lastName.Text = "";

            phoneNo.Text = "";
            address.Text = "";
            gender.ResetText();
            course.ResetText();
            date.ResetText();
            instructorRole.ResetText();
            addInstructor.Enabled = true;
            delete.Visible = false;
            updateBtn.Visible = false;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].SubItems[0].Text = instructorId.Text;
            listView1.SelectedItems[0].SubItems[1].Text = firstName.Text;
            listView1.SelectedItems[0].SubItems[2].Text = lastName.Text;
            listView1.SelectedItems[0].SubItems[3].Text = phoneNo.Text;

            listView1.SelectedItems[0].SubItems[4].Text = address.Text;
            listView1.SelectedItems[0].SubItems[5].Text = instructorRole.Text;
            listView1.SelectedItems[0].SubItems[6].Text = gender.Text;
            listView1.SelectedItems[0].SubItems[7].Text = course.Text;
            listView1.SelectedItems[0].SubItems[8].Text = date.Text;
            instructorId.Text = "";
            firstName.Text = "";
            lastName.Text = "";

            phoneNo.Text = "";
            address.Text = "";
            gender.ResetText();
            course.ResetText();
            date.ResetText();
            instructorRole.ResetText();
            instructorRole.ResetText();
            delete.Visible = false;
            updateBtn.Visible = false;
            addInstructor.Enabled = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
