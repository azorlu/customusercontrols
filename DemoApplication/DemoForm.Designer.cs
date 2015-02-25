namespace DemoApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoForm));
            this.btnImage = new System.Windows.Forms.Button();
            this.simplePictureBox = new CustomUserControls.SimplePictureBox();
            this.SuspendLayout();
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(12, 527);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(150, 23);
            this.btnImage.TabIndex = 1;
            this.btnImage.Text = "Select Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // simplePictureBox
            // 
            this.simplePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simplePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("simplePictureBox.Image")));
            this.simplePictureBox.Location = new System.Drawing.Point(0, 0);
            this.simplePictureBox.MaximumSize = new System.Drawing.Size(780, 550);
            this.simplePictureBox.Name = "simplePictureBox";
            this.simplePictureBox.Size = new System.Drawing.Size(780, 550);
            this.simplePictureBox.TabIndex = 0;
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.simplePictureBox);
            this.Name = "DemoForm";
            this.Text = "Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUserControls.SimplePictureBox simplePictureBox;
        private System.Windows.Forms.Button btnImage;
    }
}

