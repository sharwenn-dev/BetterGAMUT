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
            this.home_3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // home_3
            // 
            this.home_3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home_3.Location = new System.Drawing.Point(12, 12);
            this.home_3.Name = "home_3";
            this.home_3.Size = new System.Drawing.Size(70, 30);
            this.home_3.TabIndex = 0;
            this.home_3.Text = "Home";
            this.home_3.UseVisualStyleBackColor = true;
            this.home_3.Click += new System.EventHandler(this.button1_Click);
            // 
            // staffnoteid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 218);
            this.Controls.Add(this.home_3);
            this.Name = "staffnoteid";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button home_3;
    }
}