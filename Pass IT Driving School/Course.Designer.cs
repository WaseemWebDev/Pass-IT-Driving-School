namespace Pass_IT_Driving_School
{
    partial class Course
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
            date = new DateTimePicker();
            label11 = new Label();
            Instructor = new ComboBox();
            label10 = new Label();
            addCourseBtn = new Button();
            coursePrice = new TextBox();
            courseName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            addStudent = new Label();
            label7 = new Label();
            listView1 = new ListView();
            label1 = new Label();
            courseId = new TextBox();
            updateCourse = new Button();
            deleteCourse = new Button();
            SuspendLayout();
            // 
            // date
            // 
            date.Location = new Point(66, 447);
            date.Name = "date";
            date.Size = new Size(237, 23);
            date.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label11.Location = new Point(63, 415);
            label11.Name = "label11";
            label11.Size = new Size(41, 17);
            label11.TabIndex = 44;
            label11.Text = "Date:";
            // 
            // Instructor
            // 
            Instructor.FormattingEnabled = true;
            Instructor.Items.AddRange(new object[] { "Waseem", "Robert", "Joe", "Ibrahim" });
            Instructor.Location = new Point(63, 362);
            Instructor.Name = "Instructor";
            Instructor.Size = new Size(238, 23);
            Instructor.TabIndex = 4;
            Instructor.Text = "Select Instructor";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label10.Location = new Point(61, 323);
            label10.Name = "label10";
            label10.Size = new Size(73, 17);
            label10.TabIndex = 42;
            label10.Text = "Instructor:";
            // 
            // addCourseBtn
            // 
            addCourseBtn.BackColor = Color.FromArgb(72, 106, 157);
            addCourseBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            addCourseBtn.FlatStyle = FlatStyle.Flat;
            addCourseBtn.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            addCourseBtn.ForeColor = SystemColors.ButtonHighlight;
            addCourseBtn.Location = new Point(65, 526);
            addCourseBtn.Name = "addCourseBtn";
            addCourseBtn.Size = new Size(238, 44);
            addCourseBtn.TabIndex = 6;
            addCourseBtn.Text = "Add Course";
            addCourseBtn.UseVisualStyleBackColor = false;
            addCourseBtn.Click += addCourseBtn_Click;
            // 
            // coursePrice
            // 
            coursePrice.Location = new Point(61, 282);
            coursePrice.Multiline = true;
            coursePrice.Name = "coursePrice";
            coursePrice.Size = new Size(240, 27);
            coursePrice.TabIndex = 3;
            // 
            // courseName
            // 
            courseName.Location = new Point(63, 204);
            courseName.Multiline = true;
            courseName.Name = "courseName";
            courseName.Size = new Size(240, 27);
            courseName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(61, 245);
            label4.Name = "label4";
            label4.Size = new Size(38, 17);
            label4.TabIndex = 31;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(61, 170);
            label3.Name = "label3";
            label3.Size = new Size(90, 17);
            label3.TabIndex = 30;
            label3.Text = "Course Name";
            // 
            // addStudent
            // 
            addStudent.AutoSize = true;
            addStudent.Font = new Font("Stencil", 18F);
            addStudent.Location = new Point(61, 39);
            addStudent.Name = "addStudent";
            addStudent.Size = new Size(226, 29);
            addStudent.TabIndex = 47;
            addStudent.Text = "Add Course Form";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Stencil", 18F);
            label7.Location = new Point(621, 39);
            label7.Name = "label7";
            label7.Size = new Size(203, 29);
            label7.TabIndex = 48;
            label7.Text = "Course Details";
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(407, 111);
            listView1.Name = "listView1";
            listView1.Size = new Size(695, 404);
            listView1.TabIndex = 49;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.Click += listView1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(61, 89);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 50;
            label1.Text = "Course ID:";
            // 
            // courseId
            // 
            courseId.Location = new Point(65, 127);
            courseId.Multiline = true;
            courseId.Name = "courseId";
            courseId.Size = new Size(240, 27);
            courseId.TabIndex = 1;
            // 
            // updateCourse
            // 
            updateCourse.BackColor = Color.Teal;
            updateCourse.Location = new Point(475, 535);
            updateCourse.Name = "updateCourse";
            updateCourse.Size = new Size(180, 35);
            updateCourse.TabIndex = 52;
            updateCourse.Text = "Update";
            updateCourse.UseVisualStyleBackColor = false;
            updateCourse.Click += updateCourse_Click;
            // 
            // deleteCourse
            // 
            deleteCourse.BackColor = Color.LightCoral;
            deleteCourse.Location = new Point(704, 535);
            deleteCourse.Name = "deleteCourse";
            deleteCourse.Size = new Size(160, 35);
            deleteCourse.TabIndex = 53;
            deleteCourse.Text = "Delete";
            deleteCourse.UseVisualStyleBackColor = false;
            deleteCourse.Click += deleteCourse_Click;
            // 
            // Course
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 622);
            Controls.Add(deleteCourse);
            Controls.Add(updateCourse);
            Controls.Add(courseId);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(label7);
            Controls.Add(addStudent);
            Controls.Add(date);
            Controls.Add(label11);
            Controls.Add(Instructor);
            Controls.Add(label10);
            Controls.Add(addCourseBtn);
            Controls.Add(coursePrice);
            Controls.Add(courseName);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "Course";
            Text = "Course";
            Load += Course_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker date;
        private Label label11;
        private ComboBox Instructor;
        private Label label10;
      
       
        private Button addCourseBtn;
       
        
        private TextBox coursePrice;
        private TextBox courseName;
     
        private Label label4;
        private Label label3;
        private Label addStudent;
        private Label label7;
        private ListView listView1;
        private Label label1;
        private TextBox courseId;
        private Button updateCourse;
        private Button deleteCourse;
    }
}