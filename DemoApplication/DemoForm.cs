using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomUserControls;

namespace DemoApplication
{
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            this.cbSizeMode.Items.Add(new ComboBoxItem("AutoSize", SimplePictureBoxSizeMode.AutoSize));
            this.cbSizeMode.Items.Add(new ComboBoxItem("Normal", SimplePictureBoxSizeMode.Normal));
            this.cbSizeMode.Items.Add(new ComboBoxItem("StrechImage", SimplePictureBoxSizeMode.StretchImage));
        }

        private class ComboBoxItem
        {
            public string Name;
            public SimplePictureBoxSizeMode Value;
            public ComboBoxItem(string name, SimplePictureBoxSizeMode value)
            {
                Name = name; 
                Value = value;
            }
            public override string ToString()
            {
                return Name;
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG|All files (*.*)|*.*";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        simplePictureBox.Image = new Bitmap(dlg.FileName);
                    }
                    catch(ArgumentException argex)
                    {
                        MessageBox.Show("Unable to load file: " + argex.Message);
                    }
                }
            }
        }

        private void cbSizeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // reset default simple picture box size
            this.simplePictureBox.Size = new Size(200, 200);
            ComboBoxItem item = (ComboBoxItem) cbSizeMode.SelectedItem;
            this.simplePictureBox.SizeMode = (SimplePictureBoxSizeMode)item.Value;
        }
    }
}
