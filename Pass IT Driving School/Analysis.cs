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
    public partial class Analysis : Form
    {
        public Analysis()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Analysis_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("ID", 80);
            listView1.Columns.Add("First Name", 80);
            listView1.Columns.Add("Last Name", 80);
            listView1.Columns.Add("Email", 80);

            ListViewItem newitem = new ListViewItem("1");
            newitem.SubItems.Add("waseem");

            newitem.SubItems.Add("sohail");
            newitem.SubItems.Add("waseem@gmail.com");
            listView1.Items.Add(newitem);


            listView2.Columns.Add("ID", 80);
            listView2.Columns.Add("First Name", 80);
            listView2.Columns.Add("Last Name", 80);
            listView2.Columns.Add("Email", 80);
           

            ListViewItem newitem2 = new ListViewItem("1");
            newitem2.SubItems.Add("Rashid");

            newitem2.SubItems.Add("Umar");
            newitem2.SubItems.Add("rashid@gmail.com");
            listView2.Items.Add(newitem2);


         
            listView3.Columns.Add("ID", 80);
            listView3.Columns.Add("First Name", 80);
            listView3.Columns.Add("Last Name", 80);
            listView3.Columns.Add("Email", 80);
        

            ListViewItem newitem3 = new ListViewItem("1");

            newitem3.SubItems.Add("Raheel");

            newitem3.SubItems.Add("Arshad");
            newitem3.SubItems.Add("Raheelarshid@gmail.com");
            listView3.Items.Add(newitem3);
        }
    }
}
