namespace BetterGAMUT
{
    partial class Lessons
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
            home_2 = new Button();
            SuspendLayout();
            // 
            // home_2
            // 
            home_2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            home_2.Location = new Point(12, 12);
            home_2.Name = "home_2";
            home_2.Size = new Size(70, 30);
            home_2.TabIndex = 0;
            home_2.Text = "Home";
            home_2.UseVisualStyleBackColor = true;
            home_2.Click += button1_Click;
            // 
            // Lessons
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 249);
            ControlBox = false;
            Controls.Add(home_2);
            Name = "Lessons";
            Text = "Lessons";
            ResumeLayout(false);

        }

        #endregion

        private Button home_2;
    }
}