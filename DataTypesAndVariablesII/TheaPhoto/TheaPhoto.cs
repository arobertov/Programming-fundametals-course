using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());//amaunt of picture
        int filterTime = int.Parse(Console.ReadLine());//filter time of every single picture
        int filterFactor = int.Parse(Console.ReadLine());//percent good picture
        int uploadTime = int.Parse(Console.ReadLine());//the amount of time needed for every 
                                                       //filtered picture to be uploaded to her storage

        filterTime *= n;
        int filteredPicture = (int)Math.Ceiling((double)(n * filterFactor) / 100);
        uploadTime *= filteredPicture;
        int sumTime = filterTime + uploadTime;
        
        int hours = sumTime / 3600;
        int minutes = sumTime % 3600;
        int secounds = minutes % 60;
        minutes /= 60;
        Console.WriteLine("{0:00}:{1:00}:{2:00}",hours,minutes,secounds);

    }
}

