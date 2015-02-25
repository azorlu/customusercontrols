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
        public SimplePictureBox()
        {
            InitializeComponent();
            // default image to be displayed
            Image = (Image) Properties.Resources.ResourceManager.GetObject("microsoft_logo_2012");
            this.Dock = DockStyle.Fill;
        }

        public Image Image { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int imgWidth = Image.Width;
            int imgHeight = Image.Height;
            g.DrawImage(Image, 0, 0);
            base.OnPaint(e);
        }
    }
}
