namespace Pass_IT_Driving_School
{
    partial class Analysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analysis));
            label1 = new Label();
            listView1 = new ListView();
            label2 = new Label();
            listView2 = new ListView();
            label3 = new Label();
            listView3 = new ListView();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            label5 = new Label();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 42);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 0;
            label1.Text = "Passed Students";
            label1.Click += label1_Click;
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(21, 87);
            listView1.Name = "listView1";
            listView1.Size = new Size(322, 366);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(471, 42);
            label2.Name = "label2";
            label2.Size = new Size(189, 25);
            label2.TabIndex = 2;
            label2.Text = "Failed Students";
            // 
            // listView2
            // 
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Location = new Point(429, 87);
            listView2.Name = "listView2";
            listView2.Size = new Size(315, 366);
            listView2.TabIndex = 3;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(885, 42);
            label3.Name = "label3";
            label3.Size = new Size(217, 25);
            label3.TabIndex = 4;
            label3.Text = "Certificates Given";
            // 
            // listView3
            // 
            listView3.FullRowSelect = true;
            listView3.GridLines = true;
            listView3.Location = new Point(815, 87);
            listView3.Name = "listView3";
            listView3.Size = new Size(324, 366);
            listView3.TabIndex = 5;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // iconButton1
            // 
            iconButton1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(113, 579);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(121, 73);
            iconButton1.TabIndex = 6;
            iconButton1.Text = "1";
            iconButton1.TextAlign = ContentAlignment.TopCenter;
            iconButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(91, 517);
            label4.Name = "label4";
            label4.Size = new Size(238, 22);
            label4.TabIndex = 9;
            label4.Text = "Total Passed Students";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(470, 517);
            label5.Name = "label5";
            label5.Size = new Size(172, 22);
            label5.TabIndex = 11;
            label5.Text = "Failed Students";
            // 
            // iconButton4
            // 
            iconButton4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.User;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.Location = new Point(495, 570);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(121, 73);
            iconButton4.TabIndex = 10;
            iconButton4.Text = "1";
            iconButton4.TextAlign = ContentAlignment.TopCenter;
            iconButton4.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(846, 517);
            label6.Name = "label6";
            label6.Size = new Size(268, 22);
            label6.TabIndex = 13;
            label6.Text = "Certificated Distributed";
            // 
            // iconButton2
            // 
            iconButton2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Certificate;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(910, 561);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(121, 82);
            iconButton2.TabIndex = 12;
            iconButton2.Text = "1";
            iconButton2.TextAlign = ContentAlignment.TopCenter;
            iconButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Brown;
            label7.Location = new Point(311, 9);
            label7.Name = "label7";
            label7.Size = new Size(224, 15);
            label7.TabIndex = 14;
            label7.Text = "Data is static due to not using Database";
            // 
            // Analysis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 750);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(iconButton2);
            Controls.Add(label5);
            Controls.Add(iconButton4);
            Controls.Add(label4);
            Controls.Add(iconButton1);
            Controls.Add(listView3);
            Controls.Add(label3);
            Controls.Add(listView2);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Analysis";
            Text = "Analysis";
            Load += Analysis_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private Label label2;
        private ListView listView2;
        private Label label3;
        private ListView listView3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label4;
        private Label label5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Label label6;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label7;
    }
}