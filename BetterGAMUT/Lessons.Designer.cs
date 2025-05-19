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
            this.home_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // home_2
            // 
            this.home_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home_2.Location = new System.Drawing.Point(12, 12);
            this.home_2.Name = "home_2";
            this.home_2.Size = new System.Drawing.Size(70, 30);
            this.home_2.TabIndex = 0;
            this.home_2.Text = "Home";
            this.home_2.UseVisualStyleBackColor = true;
            this.home_2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lessons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 249);
            this.ControlBox = false;
            this.Controls.Add(this.home_2);
            this.Name = "Lessons";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private Button home_2;
    }
}