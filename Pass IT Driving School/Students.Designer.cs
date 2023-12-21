namespace Pass_IT_Driving_School
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            addStudent = new Label();
            label1 = new Label();
            firstName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            address = new TextBox();
            lastName = new TextBox();
            email = new TextBox();
            phoneNo = new TextBox();
            label6 = new Label();
            gender = new ComboBox();
            addBtn = new Button();
            label7 = new Label();
            listView1 = new ListView();
            label8 = new Label();
            course = new ComboBox();
            deleteBtn = new Button();
            studentId = new TextBox();
            label9 = new Label();
            label10 = new Label();
            Instructor = new ComboBox();
            label11 = new Label();
            date = new DateTimePicker();
            hours = new Label();
            hoursComboBox = new ComboBox();
            label12 = new Label();
            testType = new ComboBox();
            updateStdnt = new Button();
            SuspendLayout();
            // 
            // addStudent
            // 
            addStudent.AutoSize = true;
            addStudent.Font = new Font("Stencil", 18F);
            addStudent.Location = new Point(163, 9);
            addStudent.Name = "addStudent";
            addStudent.Size = new Size(240, 29);
            addStudent.TabIndex = 0;
            addStudent.Text = "Add Student Form";
            addStudent.Click += addStudent_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(52, 139);
            label1.Name = "label1";
            label1.Size = new Size(83, 17);
            label1.TabIndex = 1;
            label1.Text = "First Name: ";
            label1.Click += label1_Click;
            // 
            // firstName
            // 
            firstName.Location = new Point(55, 167);
            firstName.Multiline = true;
            firstName.Name = "firstName";
            firstName.Size = new Size(240, 27);
            firstName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(52, 208);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 3;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(52, 279);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 5;
            label3.Text = "Email:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(52, 356);
            label4.Name = "label4";
            label4.Size = new Size(106, 17);
            label4.TabIndex = 7;
            label4.Text = "Phone Number:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(52, 430);
            label5.Name = "label5";
            label5.Size = new Size(61, 17);
            label5.TabIndex = 9;
            label5.Text = "Address:";
            // 
            // address
            // 
            address.BorderStyle = BorderStyle.FixedSingle;
            address.Location = new Point(52, 464);
            address.Multiline = true;
            address.Name = "address";
            address.Size = new Size(240, 37);
            address.TabIndex = 6;
            // 
            // lastName
            // 
            lastName.Location = new Point(52, 239);
            lastName.Multiline = true;
            lastName.Name = "lastName";
            lastName.Size = new Size(240, 27);
            lastName.TabIndex = 3;
            // 
            // email
            // 
            email.Location = new Point(52, 317);
            email.Multiline = true;
            email.Name = "email";
            email.Size = new Size(240, 27);
            email.TabIndex = 4;
            // 
            // phoneNo
            // 
            phoneNo.Location = new Point(52, 390);
            phoneNo.Multiline = true;
            phoneNo.Name = "phoneNo";
            phoneNo.Size = new Size(240, 27);
            phoneNo.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(318, 68);
            label6.Name = "label6";
            label6.Size = new Size(57, 17);
            label6.TabIndex = 14;
            label6.Text = "Gender:";
            // 
            // gender
            // 
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Male", "Female" });
            gender.Location = new Point(318, 100);
            gender.Name = "gender";
            gender.Size = new Size(238, 23);
            gender.TabIndex = 7;
            gender.Text = "Male";
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(72, 106, 157);
            addBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            addBtn.ForeColor = SystemColors.ButtonHighlight;
            addBtn.Location = new Point(181, 544);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(238, 44);
            addBtn.TabIndex = 13;
            addBtn.Text = "Add Student";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Stencil", 18F);
            label7.Location = new Point(776, 24);
            label7.Name = "label7";
            label7.Size = new Size(217, 29);
            label7.TabIndex = 18;
            label7.Text = "Student Details";
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(598, 78);
            listView1.Name = "listView1";
            listView1.Size = new Size(635, 441);
            listView1.TabIndex = 19;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged_1;
            listView1.Click += listView1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.Location = new Point(318, 138);
            label8.Name = "label8";
            label8.Size = new Size(54, 17);
            label8.TabIndex = 20;
            label8.Text = "Course:";
            // 
            // course
            // 
            course.FormattingEnabled = true;
            course.Items.AddRange(new object[] { "Introductory", "Standard", "Pass Plus", "Driving Test" });
            course.Location = new Point(318, 176);
            course.Name = "course";
            course.Size = new Size(238, 23);
            course.TabIndex = 8;
            course.Text = "Select Course";
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.LightCoral;
            deleteBtn.Location = new Point(937, 544);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(161, 32);
            deleteBtn.TabIndex = 22;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += delete_Click;
            // 
            // studentId
            // 
            studentId.Location = new Point(55, 100);
            studentId.Multiline = true;
            studentId.Name = "studentId";
            studentId.Size = new Size(240, 27);
            studentId.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label9.Location = new Point(52, 68);
            label9.Name = "label9";
            label9.Size = new Size(78, 17);
            label9.TabIndex = 25;
            label9.Text = "Student ID:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label10.Location = new Point(318, 222);
            label10.Name = "label10";
            label10.Size = new Size(73, 17);
            label10.TabIndex = 26;
            label10.Text = "Instructor:";
            // 
            // Instructor
            // 
            Instructor.FormattingEnabled = true;
            Instructor.Items.AddRange(new object[] { "Waseem", "Robert", "Joe", "Ibrahim" });
            Instructor.Location = new Point(318, 258);
            Instructor.Name = "Instructor";
            Instructor.Size = new Size(238, 23);
            Instructor.TabIndex = 9;
            Instructor.Text = "Select Instructor";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label11.Location = new Point(318, 440);
            label11.Name = "label11";
            label11.Size = new Size(41, 17);
            label11.TabIndex = 28;
            label11.Text = "Date:";
            // 
            // date
            // 
            date.Location = new Point(321, 471);
            date.Name = "date";
            date.Size = new Size(237, 23);
            date.TabIndex = 12;
            // 
            // hours
            // 
            hours.AutoSize = true;
            hours.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            hours.Location = new Point(321, 299);
            hours.Name = "hours";
            hours.Size = new Size(49, 17);
            hours.TabIndex = 30;
            hours.Text = "Hours:";
            // 
            // hoursComboBox
            // 
            hoursComboBox.FormattingEnabled = true;
            hoursComboBox.Items.AddRange(new object[] { "1", "2" });
            hoursComboBox.Location = new Point(321, 329);
            hoursComboBox.Name = "hoursComboBox";
            hoursComboBox.Size = new Size(238, 23);
            hoursComboBox.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label12.Location = new Point(321, 371);
            label12.Name = "label12";
            label12.Size = new Size(70, 17);
            label12.TabIndex = 32;
            label12.Text = "Test Type:";
            // 
            // testType
            // 
            testType.FormattingEnabled = true;
            testType.Items.AddRange(new object[] { "Theory", "Practical" });
            testType.Location = new Point(321, 402);
            testType.Name = "testType";
            testType.Size = new Size(238, 23);
            testType.TabIndex = 11;
            // 
            // updateStdnt
            // 
            updateStdnt.BackColor = Color.Teal;
            updateStdnt.Location = new Point(710, 544);
            updateStdnt.Name = "updateStdnt";
            updateStdnt.Size = new Size(173, 32);
            updateStdnt.TabIndex = 34;
            updateStdnt.Text = "Update";
            updateStdnt.UseVisualStyleBackColor = false;
            updateStdnt.Click += updateStdnt_Click;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 609);
            Controls.Add(updateStdnt);
            Controls.Add(testType);
            Controls.Add(label12);
            Controls.Add(hoursComboBox);
            Controls.Add(hours);
            Controls.Add(date);
            Controls.Add(label11);
            Controls.Add(Instructor);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(studentId);
            Controls.Add(deleteBtn);
            Controls.Add(course);
            Controls.Add(label8);
            Controls.Add(listView1);
            Controls.Add(label7);
            Controls.Add(addBtn);
            Controls.Add(gender);
            Controls.Add(label6);
            Controls.Add(phoneNo);
            Controls.Add(email);
            Controls.Add(lastName);
            Controls.Add(address);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(firstName);
            Controls.Add(label1);
            Controls.Add(addStudent);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Students";
            Text = "Students";
            Load += Students_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addStudent;
        private Label label1;
        private TextBox firstName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox address;
        private TextBox lastName;
        private TextBox email;
        private TextBox phoneNo;
        private Label label6;
        private ComboBox gender;
        private Button addBtn;
        private Label label7;
        private ListView listView1;
        private Label label8;
        private ComboBox course;
        private Button deleteBtn;
        private TextBox studentId;
        private Label label9;
        private Label label10;
        private ComboBox Instructor;
        private Label label11;
        private DateTimePicker date;
        private Label hours;
        private ComboBox hoursComboBox;
        private Label label12;
        private ComboBox testType;
        private Button updateStdnt;
    }
}