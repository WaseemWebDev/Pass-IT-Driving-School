namespace Pass_IT_Driving_School
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            pictureBox1 = new PictureBox();
            splitter1 = new Splitter();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            StudentsBtn = new FontAwesome.Sharp.IconButton();
            InstructorBtn = new FontAwesome.Sharp.IconButton();
            CoursesBtn = new FontAwesome.Sharp.IconButton();
            splitContainer1 = new SplitContainer();
            label2 = new Label();
            label1 = new Label();
            Logout = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            label6 = new Label();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            label4 = new Label();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LavenderBlush;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(587, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 552);
            splitter1.TabIndex = 8;
            splitter1.TabStop = false;
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(32, 19);
            iconMenuItem1.Text = "iconMenuItem1";
            // 
            // StudentsBtn
            // 
            StudentsBtn.AllowDrop = true;
            StudentsBtn.BackColor = Color.LavenderBlush;
            StudentsBtn.FlatStyle = FlatStyle.Flat;
            StudentsBtn.Font = new Font("Arial Rounded MT Bold", 9.75F);
            StudentsBtn.IconChar = FontAwesome.Sharp.IconChar.User;
            StudentsBtn.IconColor = Color.FromArgb(32, 32, 72);
            StudentsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            StudentsBtn.IconSize = 28;
            StudentsBtn.ImageAlign = ContentAlignment.TopCenter;
            StudentsBtn.Location = new Point(12, 177);
            StudentsBtn.Name = "StudentsBtn";
            StudentsBtn.RightToLeft = RightToLeft.No;
            StudentsBtn.Size = new Size(268, 42);
            StudentsBtn.TabIndex = 10;
            StudentsBtn.Text = "Students";
            StudentsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            StudentsBtn.UseVisualStyleBackColor = false;
            StudentsBtn.Click += StudentsBtn_Click_1;
            // 
            // InstructorBtn
            // 
            InstructorBtn.AllowDrop = true;
            InstructorBtn.BackColor = Color.LavenderBlush;
            InstructorBtn.FlatStyle = FlatStyle.Flat;
            InstructorBtn.Font = new Font("Arial Rounded MT Bold", 9.75F);
            InstructorBtn.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            InstructorBtn.IconColor = Color.FromArgb(32, 32, 72);
            InstructorBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            InstructorBtn.IconSize = 28;
            InstructorBtn.Location = new Point(12, 252);
            InstructorBtn.Name = "InstructorBtn";
            InstructorBtn.Size = new Size(268, 43);
            InstructorBtn.TabIndex = 11;
            InstructorBtn.Text = "Instructor";
            InstructorBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            InstructorBtn.UseVisualStyleBackColor = false;
            InstructorBtn.Click += InstructorBtn_Click;
            // 
            // CoursesBtn
            // 
            CoursesBtn.AllowDrop = true;
            CoursesBtn.BackColor = Color.LavenderBlush;
            CoursesBtn.FlatStyle = FlatStyle.Popup;
            CoursesBtn.Font = new Font("Arial Rounded MT Bold", 9.75F);
            CoursesBtn.IconChar = FontAwesome.Sharp.IconChar.BookJournalWhills;
            CoursesBtn.IconColor = Color.FromArgb(32, 32, 72);
            CoursesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CoursesBtn.IconSize = 28;
            CoursesBtn.Location = new Point(12, 328);
            CoursesBtn.Name = "CoursesBtn";
            CoursesBtn.Size = new Size(268, 44);
            CoursesBtn.TabIndex = 12;
            CoursesBtn.Text = "Courses";
            CoursesBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            CoursesBtn.UseVisualStyleBackColor = false;
            CoursesBtn.Click += CoursesBtn_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(32, 32, 72);
            splitContainer1.Panel1.Controls.Add(iconButton5);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(Logout);
            splitContainer1.Panel1.Controls.Add(InstructorBtn);
            splitContainer1.Panel1.Controls.Add(StudentsBtn);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(32, 32, 72);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(iconButton4);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(iconButton3);
            splitContainer1.Panel2.Controls.Add(iconButton2);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(iconButton1);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.ImeMode = ImeMode.NoControl;
            splitContainer1.Panel2.RightToLeft = RightToLeft.No;
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint_1;
            splitContainer1.Size = new Size(880, 552);
            splitContainer1.SplitterDistance = 290;
            splitContainer1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 24F);
            label2.ForeColor = Color.LavenderBlush;
            label2.Location = new Point(75, 73);
            label2.Name = "label2";
            label2.Size = new Size(123, 37);
            label2.TabIndex = 12;
            label2.Text = "School";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 27.75F);
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(3, 18);
            label1.Name = "label1";
            label1.Size = new Size(287, 43);
            label1.TabIndex = 4;
            label1.Text = "Pass IT Driving";
            // 
            // Logout
            // 
            Logout.BackColor = Color.FromArgb(172, 57, 57);
            Logout.FlatStyle = FlatStyle.Popup;
            Logout.Font = new Font("Arial Rounded MT Bold", 9.75F);
            Logout.ForeColor = SystemColors.ControlText;
            Logout.IconChar = FontAwesome.Sharp.IconChar.Lock;
            Logout.IconColor = Color.FromArgb(32, 32, 72);
            Logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Logout.IconSize = 28;
            Logout.Location = new Point(12, 486);
            Logout.Name = "Logout";
            Logout.Size = new Size(268, 42);
            Logout.TabIndex = 0;
            Logout.Text = "Log out";
            Logout.TextAlign = ContentAlignment.MiddleLeft;
            Logout.TextImageRelation = TextImageRelation.ImageBeforeText;
            Logout.UseVisualStyleBackColor = false;
            Logout.Click += Logout_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(32, 32, 72);
            label7.Font = new Font("Arial Rounded MT Bold", 21.75F);
            label7.ForeColor = Color.LavenderBlush;
            label7.Location = new Point(210, 140);
            label7.Name = "label7";
            label7.Size = new Size(120, 33);
            label7.TabIndex = 12;
            label7.Text = "Metrics";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LavenderBlush;
            label6.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label6.Location = new Point(379, 445);
            label6.Name = "label6";
            label6.Size = new Size(23, 15);
            label6.TabIndex = 11;
            label6.Text = "95";
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.LavenderBlush;
            iconButton4.Font = new Font("Arial Rounded MT Bold", 9.75F);
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Automobile;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 39;
            iconButton4.Location = new Point(305, 376);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(186, 93);
            iconButton4.TabIndex = 10;
            iconButton4.Text = "Exams Taken";
            iconButton4.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LavenderBlush;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label5.Location = new Point(128, 445);
            label5.Name = "label5";
            label5.Size = new Size(23, 15);
            label5.TabIndex = 9;
            label5.Text = "47";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LavenderBlush;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label4.Location = new Point(379, 304);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 8;
            label4.Text = "20";
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.LavenderBlush;
            iconButton3.Font = new Font("Arial Rounded MT Bold", 9.75F);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Book;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 39;
            iconButton3.Location = new Point(53, 376);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(186, 93);
            iconButton3.TabIndex = 7;
            iconButton3.Text = "Courses";
            iconButton3.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.LavenderBlush;
            iconButton2.Font = new Font("Arial Rounded MT Bold", 9.75F);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.MortarBoard;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 39;
            iconButton2.Location = new Point(305, 235);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(186, 93);
            iconButton2.TabIndex = 6;
            iconButton2.Text = "Instructors";
            iconButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LavenderBlush;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label3.Location = new Point(128, 304);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "100";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.LavenderBlush;
            iconButton1.Font = new Font("Arial Rounded MT Bold", 9.75F);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 39;
            iconButton1.Location = new Point(53, 235);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(186, 93);
            iconButton1.TabIndex = 4;
            iconButton1.Text = "Total Students";
            iconButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(32, 19);
            iconMenuItem2.Text = "iconMenuItem2";
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
            // iconButton5
            // 
            iconButton5.AllowDrop = true;
            iconButton5.BackColor = Color.LavenderBlush;
            iconButton5.FlatStyle = FlatStyle.Popup;
            iconButton5.Font = new Font("Arial Rounded MT Bold", 9.75F);
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.BusinessTime;
            iconButton5.IconColor = Color.FromArgb(32, 32, 72);
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 28;
            iconButton5.Location = new Point(12, 400);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(268, 44);
            iconButton5.TabIndex = 14;
            iconButton5.Text = "Analysis";
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = false;
            iconButton5.Click += iconButton5_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(879, 552);
            Controls.Add(CoursesBtn);
            Controls.Add(splitter1);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Splitter splitter1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconButton InstructorBtn;
        public FontAwesome.Sharp.IconButton StudentsBtn;
        private FontAwesome.Sharp.IconButton CoursesBtn;
        private SplitContainer splitContainer1;
        private FontAwesome.Sharp.IconButton Logout;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Label label5;
        private Label label4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label3;
        private Label label6;
        private Label label7;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private FontAwesome.Sharp.IconButton iconButton5;
    }
}