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
            this.Exercises = new System.Windows.Forms.Button();
            this.Lessons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exercises
            // 
            this.Exercises.Location = new System.Drawing.Point(238, 66);
            this.Exercises.Name = "Exercises";
            this.Exercises.Size = new System.Drawing.Size(75, 23);
            this.Exercises.TabIndex = 0;
            this.Exercises.Text = "Exercises";
            this.Exercises.UseVisualStyleBackColor = true;
            this.Exercises.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lessons
            // 
            this.Lessons.Location = new System.Drawing.Point(238, 95);
            this.Lessons.Name = "Lessons";
            this.Lessons.Size = new System.Drawing.Size(75, 23);
            this.Lessons.TabIndex = 1;
            this.Lessons.Text = "Lessons";
            this.Lessons.UseVisualStyleBackColor = true;
            this.Lessons.Click += new System.EventHandler(this.Lessons_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 239);
            this.Controls.Add(this.Lessons);
            this.Controls.Add(this.Exercises);
            this.Name = "Index";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Exercises;
        private Button Lessons;
    }
}