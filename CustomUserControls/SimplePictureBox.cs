using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomUserControls
{
    public partial class SimplePictureBox: UserControl
    {
        private Image image;
        private SimplePictureBoxSizeMode sizeMode;

        [Browsable(true), Description("Gets or sets the image that is displayed.")]
        public Image Image 
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                // Invalidate method calls the OnPaint method and redraws the control.
                Invalidate();
            }
        }

        [Browsable(true), Description("Specifies how the image is positioned.")]
        public SimplePictureBoxSizeMode SizeMode
        {
            get
            {
                return sizeMode;
            }
            set
            {
                sizeMode = value;
                Invalidate();
            }
        }
        
        public SimplePictureBox()
        {
            InitializeComponent();
            sizeMode = SimplePictureBoxSizeMode.AutoSize;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (this.DesignMode)
            {
                image = new Bitmap(Properties.Resources.microsoft_logo_2012, 200, 200);
            }
            int spbWidth = this.Width;
            int spbHeight = this.Height;
            int imgWidth = image.Width;
            int imgHeight = image.Height;
            switch(sizeMode)
            {
                case SimplePictureBoxSizeMode.StretchImage:
                    g.DrawImage(image, 0, 0, spbWidth, spbHeight);
                    break;
                case SimplePictureBoxSizeMode.AutoSize:
                    this.Width = imgWidth;
                    this.Height = imgHeight;
                    g.DrawImage(image, 0, 0);
                    break;
                case SimplePictureBoxSizeMode.Normal:
                    Rectangle destRect = new Rectangle(0, 0, spbWidth, spbHeight);
                    Rectangle srcRect = new Rectangle(0, 0, spbWidth, spbHeight);
                    GraphicsUnit units = GraphicsUnit.Pixel;
                    g.DrawImage(image, destRect, srcRect, units);
                    break;
                default:
                    g.DrawImage(image, 0, 0, spbWidth, spbHeight);
                    break;
            }
             
            
            base.OnPaint(e);
        }
    }
}
