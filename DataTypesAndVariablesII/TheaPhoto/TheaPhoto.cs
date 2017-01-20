using System;
class Program
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());            //....amaunt of picture.............................//
        uint filterTime = uint.Parse(Console.ReadLine());   //....filter time of every single picture...........//
        uint filterFactor = uint.Parse(Console.ReadLine()); //....percent good picture..........................//
        uint uploadTime = uint.Parse(Console.ReadLine());   /*....the amount of time needed for every ...........
                                                          ....filtered picture to be uploaded to her storage  */

        ulong totalFilterTime=(ulong)filterTime * n;
        ulong filteredPicture = (ulong)Math.Ceiling((double)(n * filterFactor) / 100);
        ulong totalUploadTime = uploadTime * filteredPicture;
        ulong sumTime = totalFilterTime + totalUploadTime;
        ulong day = sumTime / 86400;
        ulong hours = sumTime / 3600;
        hours = hours % 24;
        ulong minutes = sumTime % 3600;
        ulong secounds = minutes % 60;
        minutes /= 60;
        Console.WriteLine("{0:0}:{1:00}:{2:00}:{3:00}",day,hours,minutes,secounds);

    }
}

