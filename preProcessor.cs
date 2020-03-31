using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCvSharp;

namespace FirstProgram
{
    class preProcessor
    {
        IplImage src, grayImage, binaryImage, negativeImage, cvtNegativeImage; //declare variable for store original image
        
        public void LoadOriginalImage(String filename) {
            src = Cv.LoadImage(filename,LoadMode.Color); //original image load to the picture box
            Cv.SaveImage("1.jpg", src); //get a copy of original image
        }

        //convert image to gray
        public void LoadGrayScaleImage() {
            grayImage = Cv.CreateImage(src.Size, BitDepth.U8, 1); //create a new image same as the original image
            Cv.CvtColor(src, grayImage, ColorConversion.RgbaToGray); //RGB to gray convertion
            Cv.SaveImage("2.jpg", grayImage);
        }

        public void LoadThresholdImage()
        {
            LoadGrayScaleImage();
            binaryImage = Cv.CreateImage(src.Size, BitDepth.U8, 1);
            Cv.Threshold(grayImage, binaryImage, 180, 255, ThresholdType.Binary);
            Cv.SaveImage("3.jpg", binaryImage);
        }

        public void negative() {
            LoadGrayScaleImage();
            negativeImage = Cv.CreateImage(src.Size, BitDepth.U8, 1);
        }

        public void Neg() {
            LoadGrayScaleImage();
            IplImage negImage = Cv.CreateImage(grayImage.Size, BitDepth.U8, 1);
            Cv.Not(grayImage, negImage);
            Cv.SaveImage("4.jpg", negImage);
        }
    }
}
