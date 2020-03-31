using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProgram
{
    public partial class Form1 : Form
    {
        preProcessor pp = new preProcessor();  //create an object from preprocessor class
        OpenFileDialog of = new OpenFileDialog();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            of.Title = "Select the image";
            of.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" + "ALLFiles(*.*)|*.*";

            if (of.ShowDialog() == DialogResult.OK)
            {
                pp.LoadOriginalImage(of.FileName); //call the load image method
                String path = of.FileName.ToString();

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = path; //display into the original picture box
            }
        }

        private void graybtn_Click(object sender, EventArgs e)
        {
            pp.LoadGrayScaleImage();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.ImageLocation = "2.jpg";
        }

        private void thresholdbtn_Click(object sender, EventArgs e)
        {
            pp.LoadThresholdImage();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.ImageLocation = "3.jpg";
        }

        private void negativebtn_Click(object sender, EventArgs e)
        {
            pp.Neg();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.ImageLocation = "4.jpg";
        }


    }
}
