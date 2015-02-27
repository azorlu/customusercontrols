using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomUserControls
{
    public enum SimplePictureBoxSizeMode
    {
        // SimplePictureBox is sized equal to the size of the image that it contains.
        AutoSize,
        // The image is clipped if it is larger than the SimplePictureBox it is contained in.
        Normal,
        // The image within the SimplePictureBox is stretched or shrunk to fit the size of the SimplePictureBox.
        StretchImage
    }
}
