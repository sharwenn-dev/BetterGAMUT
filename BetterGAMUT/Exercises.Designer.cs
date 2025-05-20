namespace BetterGAMUT
{
    partial class Exercises
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercises));
            this.home_1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // home_1
            // 
            this.home_1.AutoSize = true;
            this.home_1.BackColor = System.Drawing.Color.Transparent;
            this.home_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.home_1.Image = ((System.Drawing.Image)(resources.GetObject("home_1.Image")));
            this.home_1.Location = new System.Drawing.Point(12, 12);
            this.home_1.Name = "home_1";
            this.home_1.Size = new System.Drawing.Size(58, 58);
            this.home_1.TabIndex = 0;
            this.home_1.UseVisualStyleBackColor = true;
            this.home_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Staff Note Identification";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Exercises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(355, 235);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.home_1);
            this.Name = "Exercises";
            this.Text = "Exercises";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button home_1;
        private Button button1;
    }
}