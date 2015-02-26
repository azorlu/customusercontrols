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
        private string imageLocation;

        [Description("Gets or sets the image that is displayed.")]
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
        
        public SimplePictureBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (this.DesignMode)
            {
                image = new Bitmap(Properties.Resources.microsoft_logo_2012, 200, 200);
            }
            g.DrawImage(image, 0, 0); 
            base.OnPaint(e);
        }
    }
}
