﻿namespace DemoApplication
{
    partial class DemoForm
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
            this.simplePictureBox = new CustomUserControls.SimplePictureBox();
            this.SuspendLayout();
            // 
            // simplePictureBox
            // 
            this.simplePictureBox.Location = new System.Drawing.Point(13, 13);
            this.simplePictureBox.Name = "simplePictureBox";
            this.simplePictureBox.Size = new System.Drawing.Size(150, 150);
            this.simplePictureBox.TabIndex = 0;
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.simplePictureBox);
            this.Name = "DemoForm";
            this.Text = "Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUserControls.SimplePictureBox simplePictureBox;
    }
}

