
using System.Text.RegularExpressions;

namespace Pass_IT_Driving_School

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = Email.Text.ToString();
            string password = Password.Text.ToString();
            Regex rx = new Regex(
            @"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");


            if (email == "" || password == "")
            {
                MessageBox.Show("Email & Password Fields Can Not Be Empty!");

            }
            else if (email == "waseem@gmail.com" && password == "123")
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();

            }
            else if (!rx.IsMatch(email))
            {
                MessageBox.Show("Please Enter Valid Email Format");
            }
            else
            {

                MessageBox.Show("Wrong Credentials!");
            }


        }
    }
}
