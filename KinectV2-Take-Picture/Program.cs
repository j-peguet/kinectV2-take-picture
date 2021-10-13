using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;

namespace KinectV2_Take_Picture
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // create new object Kinect
            Kinect kinect = new Kinect();

            // wait 2 seconds for the sensor to initialise
            System.Threading.Thread.Sleep(2000);

            int numbersPictures = 1;

            try
            {
                numbersPictures = Int32.Parse(args[0]);
            }
            catch (FormatException e)
            {
            }

            for (int i = 0; i < numbersPictures; i++)
            {
                // take the picture
                kinect.TakePicture();
                System.Threading.Thread.Sleep(1000);
            }

            // close the connection
            kinect.Close();
        }
    }
}
