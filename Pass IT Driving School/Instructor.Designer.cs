namespace Pass_IT_Driving_School
{
    partial class Instructor
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
            label1 = new Label();
            label2 = new Label();
            firstName = new TextBox();
            label3 = new Label();
            lastName = new TextBox();
            label4 = new Label();
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            phoneNo = new TextBox();
            label5 = new Label();
            address = new TextBox();
            label6 = new Label();
            gender = new ComboBox();
            label7 = new Label();
            course = new ComboBox();
            label8 = new Label();
            date = new DateTimePicker();
            addInstructor = new Button();
            listView1 = new ListView();
            label9 = new Label();
            instructorId = new TextBox();
            label10 = new Label();
            delete = new Button();
            updateBtn = new Button();
            instructorRole = new ComboBox();
            role = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F);
            label1.Location = new Point(56, 52);
            label1.Name = "label1";
            label1.Size = new Size(195, 22);
            label1.TabIndex = 0;
            label1.Text = "Add Instructor Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label2.Location = new Point(56, 224);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "First Name:";
            // 
            // firstName
            // 
            firstName.Location = new Point(56, 254);
            firstName.Multiline = true;
            firstName.Name = "firstName";
            firstName.Size = new Size(235, 21);
            firstName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label3.Location = new Point(56, 297);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 3;
            label3.Text = "Last Name:";
            // 
            // lastName
            // 
            lastName.Location = new Point(56, 332);
            lastName.Multiline = true;
            lastName.Name = "lastName";
            lastName.Size = new Size(235, 21);
            lastName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label4.Location = new Point(56, 381);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 5;
            label4.Text = "Phone No:";
            // 
            // iconDropDownButton1
            // 
            iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconDropDownButton1.IconColor = Color.Black;
            iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDropDownButton1.Name = "iconDropDownButton1";
            iconDropDownButton1.Size = new Size(23, 23);
            iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // phoneNo
            // 
            phoneNo.Location = new Point(56, 411);
            phoneNo.Multiline = true;
            phoneNo.Name = "phoneNo";
            phoneNo.Size = new Size(235, 21);
            phoneNo.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label5.Location = new Point(56, 461);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 7;
            label5.Text = "Address:";
            // 
            // address
            // 
            address.Location = new Point(56, 501);
            address.Multiline = true;
            address.Name = "address";
            address.Size = new Size(469, 59);
            address.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label6.Location = new Point(326, 315);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 9;
            label6.Text = "Gender:";
            label6.Click += label6_Click;
            // 
            // gender
            // 
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Male", "Female" });
            gender.Location = new Point(326, 346);
            gender.Name = "gender";
            gender.Size = new Size(198, 23);
            gender.TabIndex = 7;
            gender.Text = "Choose Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label7.Location = new Point(327, 140);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 11;
            label7.Text = "Course:";
            // 
            // course
            // 
            course.FormattingEnabled = true;
            course.Items.AddRange(new object[] { "Introductory", "Standard", "Pass Plus", "Driving Test" });
            course.Location = new Point(327, 170);
            course.Name = "course";
            course.Size = new Size(198, 23);
            course.TabIndex = 5;
            course.Text = "Choose Course";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label8.Location = new Point(326, 381);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 13;
            label8.Text = "Date:";
            // 
            // date
            // 
            date.Location = new Point(326, 409);
            date.Name = "date";
            date.Size = new Size(198, 23);
            date.TabIndex = 8;
            date.ValueChanged += date_ValueChanged;
            // 
            // addInstructor
            // 
            addInstructor.BackColor = Color.FromArgb(72, 106, 157);
            addInstructor.FlatStyle = FlatStyle.Popup;
            addInstructor.Font = new Font("Arial Rounded MT Bold", 9.75F);
            addInstructor.ForeColor = Color.LavenderBlush;
            addInstructor.Location = new Point(153, 609);
            addInstructor.Name = "addInstructor";
            addInstructor.Size = new Size(262, 49);
            addInstructor.TabIndex = 10;
            addInstructor.Text = "Submit";
            addInstructor.UseVisualStyleBackColor = false;
            addInstructor.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.BackgroundImageTiled = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(545, 104);
            listView1.Name = "listView1";
            listView1.Size = new Size(565, 456);
            listView1.TabIndex = 16;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.ClientSizeChanged += listView1_ClientSizeChanged;
            listView1.Click += listView1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 14.25F);
            label9.Location = new Point(644, 52);
            label9.Name = "label9";
            label9.Size = new Size(173, 22);
            label9.TabIndex = 17;
            label9.Text = " Instructor Details";
            // 
            // instructorId
            // 
            instructorId.Location = new Point(56, 170);
            instructorId.Multiline = true;
            instructorId.Name = "instructorId";
            instructorId.Size = new Size(235, 21);
            instructorId.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label10.Location = new Point(56, 140);
            label10.Name = "label10";
            label10.Size = new Size(93, 15);
            label10.TabIndex = 18;
            label10.Text = "Instructor ID:";
            label10.Click += label10_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.LightCoral;
            delete.Location = new Point(879, 612);
            delete.Name = "delete";
            delete.Size = new Size(159, 42);
            delete.TabIndex = 20;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.Teal;
            updateBtn.Location = new Point(585, 612);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(162, 42);
            updateBtn.TabIndex = 21;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // instructorRole
            // 
            instructorRole.FormattingEnabled = true;
            instructorRole.Items.AddRange(new object[] { "Part Time", "Full Time" });
            instructorRole.Location = new Point(327, 259);
            instructorRole.Name = "instructorRole";
            instructorRole.Size = new Size(198, 23);
            instructorRole.TabIndex = 6;
            instructorRole.Text = "Choose Role";
            // 
            // role
            // 
            role.AutoSize = true;
            role.Font = new Font("Arial Rounded MT Bold", 9.75F);
            role.Location = new Point(327, 229);
            role.Name = "role";
            role.Size = new Size(40, 15);
            role.TabIndex = 22;
            role.Text = "Role:";
            // 
            // Instructor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 677);
            Controls.Add(instructorRole);
            Controls.Add(role);
            Controls.Add(updateBtn);
            Controls.Add(delete);
            Controls.Add(instructorId);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(listView1);
            Controls.Add(addInstructor);
            Controls.Add(date);
            Controls.Add(label8);
            Controls.Add(course);
            Controls.Add(label7);
            Controls.Add(gender);
            Controls.Add(label6);
            Controls.Add(address);
            Controls.Add(label5);
            Controls.Add(phoneNo);
            Controls.Add(label4);
            Controls.Add(lastName);
            Controls.Add(label3);
            Controls.Add(firstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Instructor";
            Text = "Instructor";
            Load += Instructor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox firstName;
        private Label label3;
        private TextBox lastName;
        private Label label4;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private TextBox phoneNo;
        private Label label5;
        private TextBox address;
        private Label label6;
        private ComboBox gender;
        private Label label7;
        private ComboBox course;
        private Label label8;
        private DateTimePicker date;
        private Button addInstructor;
        private ListView listView1;
        private Label label9;
        private TextBox instructorId;
        private Label label10;
        private Button delete;
        private Button updateBtn;
        private ComboBox instructorRole;
        private Label role;
    }
}