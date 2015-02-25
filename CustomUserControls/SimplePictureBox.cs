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
            Image = new Bitmap(@"E:\Ahmet\dev\projects\CustomUserControls\DemoApplication\Assets\microsoft_logo_2012.jpeg");
            this.Dock = DockStyle.Fill;
        }

        public Image Image { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Image, 0, 0, 360, 360);
            base.OnPaint(e);
        }
    }
}
