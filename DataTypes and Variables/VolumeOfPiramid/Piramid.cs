using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeOfPiramid
{
    class Piramid
    {
        static void Main(string[] args)
        {
            double piramidLength, piramidWidth,piramidHeight, piramidVolume = 0;
            Console.Write("Length: ");
            piramidLength = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            piramidWidth = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            piramidHeight = double.Parse(Console.ReadLine());
            piramidVolume = (piramidLength * piramidWidth * piramidHeight) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", piramidVolume);

        }
    }
}
