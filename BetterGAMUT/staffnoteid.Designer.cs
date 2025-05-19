namespace BetterGAMUT
{
    partial class staffnoteid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffnoteid));
            this.home_3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // home_3
            // 
            this.home_3.BackColor = System.Drawing.Color.Transparent;
            this.home_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home_3.BackgroundImage")));
            this.home_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home_3.ForeColor = System.Drawing.Color.Transparent;
            this.home_3.Location = new System.Drawing.Point(12, 12);
            this.home_3.Name = "home_3";
            this.home_3.Size = new System.Drawing.Size(35, 35);
            this.home_3.TabIndex = 0;
            this.home_3.UseVisualStyleBackColor = false;
            this.home_3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(154, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 17);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // staffnoteid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.home_3);
            this.DoubleBuffered = true;
            this.Name = "staffnoteid";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button home_3;
        private Button button1;
    }
}