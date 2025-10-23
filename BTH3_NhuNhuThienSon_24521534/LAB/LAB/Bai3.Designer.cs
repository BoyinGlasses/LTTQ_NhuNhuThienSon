namespace LAB
{
    partial class Bai3
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
            this.Change_color = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Change_color
            // 
            this.Change_color.Location = new System.Drawing.Point(295, 178);
            this.Change_color.Name = "Change_color";
            this.Change_color.Size = new System.Drawing.Size(187, 41);
            this.Change_color.TabIndex = 0;
            this.Change_color.Text = "Change Color";
            this.Change_color.UseVisualStyleBackColor = true;
            this.Change_color.Click += new System.EventHandler(this.Change_color_Click);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Change_color);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.Load += new System.EventHandler(this.Bai3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Change_color;
    }
}