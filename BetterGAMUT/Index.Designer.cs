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
            this.Lessons = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Exercises = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lessons
            // 
            this.Lessons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Lessons.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Lessons.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lessons.ForeColor = System.Drawing.Color.White;
            this.Lessons.Location = new System.Drawing.Point(252, 107);
            this.Lessons.Name = "Lessons";
            this.Lessons.Size = new System.Drawing.Size(190, 120);
            this.Lessons.TabIndex = 1;
            this.Lessons.UseVisualStyleBackColor = false;
            this.Lessons.Click += new System.EventHandler(this.Lessons_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(208, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome to BetterGAMUT!";
            // 
            // Exercises
            // 
            this.Exercises.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Exercises.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exercises.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Exercises.ForeColor = System.Drawing.Color.White;
            this.Exercises.Image = ((System.Drawing.Image)(resources.GetObject("Exercises.Image")));
            this.Exercises.Location = new System.Drawing.Point(12, 107);
            this.Exercises.Name = "Exercises";
            this.Exercises.Size = new System.Drawing.Size(190, 120);
            this.Exercises.TabIndex = 0;
            this.Exercises.UseVisualStyleBackColor = false;
            this.Exercises.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 58);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(454, 239);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lessons);
            this.Controls.Add(this.Exercises);
            this.Name = "Index";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Lessons;
        private Label label2;
        private Button Exercises;
        private Button button1;
    }
}