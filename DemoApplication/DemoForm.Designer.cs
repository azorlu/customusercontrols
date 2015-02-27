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
            this.topPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.simplePictureBox = new CustomUserControls.SimplePictureBox();
            this.cbSizeMode = new System.Windows.Forms.ComboBox();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(12, 12);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(150, 23);
            this.btnImage.TabIndex = 1;
            this.btnImage.Text = "Select Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.cbSizeMode);
            this.topPanel.Controls.Add(this.btnImage);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(484, 47);
            this.topPanel.TabIndex = 2;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.simplePictureBox);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(0, 47);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(484, 215);
            this.bottomPanel.TabIndex = 3;
            // 
            // simplePictureBox
            // 
            this.simplePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("simplePictureBox.Image")));
            this.simplePictureBox.Location = new System.Drawing.Point(0, 0);
            this.simplePictureBox.Name = "simplePictureBox";
            this.simplePictureBox.Size = new System.Drawing.Size(200, 200);
            this.simplePictureBox.SizeMode = CustomUserControls.SimplePictureBoxSizeMode.AutoSize;
            this.simplePictureBox.TabIndex = 0;
            // 
            // cbSizeMode
            // 
            this.cbSizeMode.DropDownWidth = 150;
            this.cbSizeMode.FormattingEnabled = true;
            this.cbSizeMode.Location = new System.Drawing.Point(250, 14);
            this.cbSizeMode.Name = "cbSizeMode";
            this.cbSizeMode.Size = new System.Drawing.Size(121, 20);
            this.cbSizeMode.TabIndex = 2;
            this.cbSizeMode.Text = "Size Mode";
            this.cbSizeMode.SelectedIndexChanged += new System.EventHandler(this.cbSizeMode_SelectedIndexChanged);
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "DemoForm";
            this.Text = "Demo";
            this.topPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private CustomUserControls.SimplePictureBox simplePictureBox;
        private System.Windows.Forms.ComboBox cbSizeMode;
    }
}

