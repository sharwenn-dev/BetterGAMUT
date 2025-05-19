namespace BetterGAMUT
{
    partial class Index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            Lessons = new Button();
            label2 = new Label();
            Exercises = new Button();
            panel1 = new Panel();
            label3 = new Label();
            homebutton1 = new Button();
            label1 = new Label();
            closebutton1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Lessons
            // 
            Lessons.BackColor = Color.FromArgb(40, 40, 40);
            Lessons.BackgroundImage = (Image)resources.GetObject("Lessons.BackgroundImage");
            Lessons.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Lessons.ForeColor = Color.White;
            Lessons.Location = new Point(295, 135);
            Lessons.Name = "Lessons";
            Lessons.Size = new Size(275, 200);
            Lessons.TabIndex = 1;
            Lessons.UseVisualStyleBackColor = false;
            Lessons.Click += Lessons_Click;
            // 
            // label2
            // 
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Myanmar Text", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 91);
            label2.Name = "label2";
            label2.Size = new Size(275, 41);
            label2.TabIndex = 3;
            label2.Text = "Exercises";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // Exercises
            // 
            Exercises.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Exercises.BackColor = Color.FromArgb(40, 40, 40);
            Exercises.BackgroundImage = (Image)resources.GetObject("Exercises.BackgroundImage");
            Exercises.BackgroundImageLayout = ImageLayout.Stretch;
            Exercises.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Exercises.ForeColor = Color.FromArgb(30, 30, 30);
            Exercises.Location = new Point(14, 135);
            Exercises.Name = "Exercises";
            Exercises.Size = new Size(275, 200);
            Exercises.TabIndex = 0;
            Exercises.UseVisualStyleBackColor = false;
            Exercises.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(homebutton1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 57);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Myanmar Text", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(55, 2);
            label3.Name = "label3";
            label3.Size = new Size(276, 41);
            label3.TabIndex = 7;
            label3.Text = "BetterGAMUT";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // homebutton1
            // 
            homebutton1.AutoSize = true;
            homebutton1.BackColor = Color.FromArgb(30, 30, 30);
            homebutton1.FlatStyle = FlatStyle.Flat;
            homebutton1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            homebutton1.ForeColor = Color.FromArgb(30, 30, 30);
            homebutton1.Image = (Image)resources.GetObject("homebutton1.Image");
            homebutton1.Location = new Point(-2, -3);
            homebutton1.Name = "homebutton1";
            homebutton1.Size = new Size(58, 58);
            homebutton1.TabIndex = 4;
            homebutton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Myanmar Text", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(295, 91);
            label1.Name = "label1";
            label1.Size = new Size(275, 41);
            label1.TabIndex = 6;
            label1.Text = "Lessons";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // closebutton1
            // 
            closebutton1.AutoSize = true;
            closebutton1.BackColor = Color.FromArgb(30, 30, 30);
            closebutton1.BackgroundImage = (Image)resources.GetObject("closebutton1.BackgroundImage");
            closebutton1.BackgroundImageLayout = ImageLayout.Stretch;
            closebutton1.FlatStyle = FlatStyle.Flat;
            closebutton1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            closebutton1.ForeColor = Color.FromArgb(30, 30, 30);
            closebutton1.Location = new Point(531, 12);
            closebutton1.Name = "closebutton1";
            closebutton1.Size = new Size(35, 35);
            closebutton1.TabIndex = 8;
            closebutton1.UseVisualStyleBackColor = true;
            closebutton1.Click += button2_Click;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(584, 361);
            ControlBox = false;
            Controls.Add(closebutton1);
            Controls.Add(Lessons);
            Controls.Add(Exercises);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Index";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Button Lessons;
        private Label label2;
        private Button Exercises;
        private Button homebutton1;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Button closebutton1;
    }
}