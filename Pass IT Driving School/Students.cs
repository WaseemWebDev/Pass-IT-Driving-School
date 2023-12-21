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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Pass_IT_Driving_School
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void addStudent_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Students_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("ID", 80);
            listView1.Columns.Add("First Name", 80);
            listView1.Columns.Add("Last Name", 80);
            listView1.Columns.Add("Email", 80);
            listView1.Columns.Add("Phone No", 80);
            listView1.Columns.Add("Address", 120);
            listView1.Columns.Add("Gender", 60);
            listView1.Columns.Add("Course", 60);
            listView1.Columns.Add("Instructor", 60);
            listView1.Columns.Add("Hours", 60);
            listView1.Columns.Add("Test Type", 60);
            listView1.Columns.Add("Date", 60);
            deleteBtn.Visible = false;
            updateStdnt.Visible = true;
            addBtn.Enabled = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regex rx = new Regex(
           @"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");

            if (studentId.Text.ToString() == "")
            {
                MessageBox.Show("Student Id  Can Not Be Empty !");
            }
            else if (firstName.Text.ToString() == "")
            {
                MessageBox.Show("First Name Can Not Be Empty !");
            }
            else if (lastName.Text.ToString() == "")
            {
                MessageBox.Show("Last Name Can Not Be Empty !");
            }
            else if (email.Text.ToString() == "")
            {
                MessageBox.Show("Email Can Not Be Empty !");
            }
            else if (!rx.IsMatch(email.Text.ToString()))
            {
                MessageBox.Show("Please Enter Valid Email Format");
            }

            else if (phoneNo.Text.ToString() == "")
            {
                MessageBox.Show("Phone No Can Not Be Empty !");
            }
            else if (address.Text.ToString() == "")
            {
                MessageBox.Show("Address No Can Not Be Empty !");
            }
            else if (gender.Text.ToString() == "")
            {
                MessageBox.Show("Gender No Can Not Be Empty !");
            }
            else if (course.Text.ToString() == "Select Course" || course.Text.ToString() == "")
            {
                MessageBox.Show("Please Select Course !");
            }
            else if (Instructor.Text.ToString() == "Select Instructor" || Instructor.Text.ToString() == "")
            {
                MessageBox.Show("Please Select Instructor!");
            }
            else if (hoursComboBox.Text.ToString() == "")
            {
                MessageBox.Show("Please Select Hours!");
            }
            else if (testType.Text.ToString() == "")
            {
                MessageBox.Show("Please Select Test Type!");
            }
            else if (date.Text.ToString() == "")
            {
                MessageBox.Show("Please Select Date!");
            }
            else
            {

                ListViewItem newitem = new ListViewItem(studentId.Text.ToString());
                newitem.SubItems.Add(firstName.Text.ToString());
                newitem.SubItems.Add(lastName.Text.ToString());
                newitem.SubItems.Add(email.Text.ToString());
                newitem.SubItems.Add(phoneNo.Text.ToString());
                newitem.SubItems.Add(address.Text.ToString());
                newitem.SubItems.Add(gender.Text.ToString());
                newitem.SubItems.Add(course.Text.ToString());
                newitem.SubItems.Add(Instructor.Text.ToString());
                newitem.SubItems.Add(hoursComboBox.Text.ToString());
                newitem.SubItems.Add(testType.Text.ToString());
                newitem.SubItems.Add(date.Text.ToString());
                listView1.Items.Add(newitem);


                studentId.Text = "";
                firstName.Text = "";
                lastName.Text = "";
                email.Text = "";
                phoneNo.Text = "";
                address.Text = "";
                gender.Text = "";
                course.ResetText();
                Instructor.ResetText();
                hoursComboBox.ResetText();
                testType.ResetText();
                date.ResetText();
            }


        }

        private void delete_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }

            studentId.Text = "";
            firstName.Text = "";
            lastName.Text = "";
            email.Text = "";
            phoneNo.Text = "";
            address.Text = "";
            gender.Text = "";
            course.ResetText();
            Instructor.ResetText();
            hoursComboBox.ResetText();
            testType.ResetText();
            date.ResetText();
            addBtn.Enabled = true;
            deleteBtn.Visible = false;
            updateStdnt.Visible = false;
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            deleteBtn.Visible = true;
            updateStdnt.Visible = true;
            addBtn.Enabled = false;
            if (listView1.SelectedItems.Count > 0)
            {
                studentId.Text = listView1.SelectedItems[0].SubItems[0].Text;
                firstName.Text = listView1.SelectedItems[0].SubItems[1].Text;
                lastName.Text = listView1.SelectedItems[0].SubItems[2].Text;
                email.Text = listView1.SelectedItems[0].SubItems[3].Text;
                phoneNo.Text = listView1.SelectedItems[0].SubItems[4].Text;
                address.Text = listView1.SelectedItems[0].SubItems[5].Text;
                gender.Text = listView1.SelectedItems[0].SubItems[6].Text;
                course.Text = listView1.SelectedItems[0].SubItems[7].Text;
                Instructor.Text = listView1.SelectedItems[0].SubItems[8].Text;
                hoursComboBox.Text = listView1.SelectedItems[0].SubItems[9].Text;
                testType.Text = listView1.SelectedItems[0].SubItems[10].Text;
                date.Text = listView1.SelectedItems[0].SubItems[11].Text;
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void updateStdnt_Click(object sender, EventArgs e)
        {


            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = studentId.Text;
                  listView1.SelectedItems[0].SubItems[1].Text=  firstName.Text;
                listView1.SelectedItems[0].SubItems[2].Text = lastName.Text;
                listView1.SelectedItems[0].SubItems[3].Text = email.Text;
                listView1.SelectedItems[0].SubItems[4].Text = phoneNo.Text;
                listView1.SelectedItems[0].SubItems[5].Text = address.Text;
                listView1.SelectedItems[0].SubItems[6].Text = gender.Text;
                listView1.SelectedItems[0].SubItems[7].Text = course.Text;
                listView1.SelectedItems[0].SubItems[8].Text = Instructor.Text;
                listView1.SelectedItems[0].SubItems[9].Text = hoursComboBox.Text;
                listView1.SelectedItems[0].SubItems[10].Text = testType.Text;
                listView1.SelectedItems[0].SubItems[11].Text = date.Text;
                studentId.Text = "";
                firstName.Text = "";
                lastName.Text = "";
                email.Text = "";
                phoneNo.Text = "";
                address.Text = "";
                gender.Text = "";
                course.ResetText();
                Instructor.ResetText();
                hoursComboBox.ResetText();
                testType.ResetText();
                date.ResetText();
                deleteBtn.Visible = false;
                updateStdnt.Visible = false;
            }
        }
    }
}
