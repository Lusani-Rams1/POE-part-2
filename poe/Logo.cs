using System.IO;
using System;
using System.Drawing;

namespace poe
{
    public class Logo
    {
        public Logo()
        {
            //get app full path
            string paths = AppDomain.CurrentDomain.BaseDirectory;

            //then replace the bin\\bebug\\
            string new_path = paths.Replace("bin\\Debug\\", "");

            //then combine the logo and the image
            string full_path = Path.Combine(new_path, "Logo.jpg");
            Console.WriteLine(full_path);
            //then start working on the ascii
            Bitmap Logo = new Bitmap(full_path);
            Logo = new Bitmap(Logo, new Size(150, 110));

            //for height
            for (int height = 0; height < Logo.Height; height++)
            {
                //for width
                for (int width = 0; width < Logo.Width; width++)
                {
                    Color pixelColor = Logo.GetPixel(width, height);
                    int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    char asciiChar = gray > 200 ? '.' : gray > 150 ? '*' : gray > 100 ? 'o' : gray > 50 ? '#' : '@';
                    Console.Write(asciiChar);

                }
                Console.WriteLine();

            }
        }
    }

}