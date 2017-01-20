sing System;
namespace VowelorDigit
{
    class Vowel
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            switch (input)
            {
                case 'a':
                case 'o':
                case 'u':
                case 'e':
                case 'i':
                    Console.WriteLine("vowel");
                    break;
                default:

                    if (Char.IsDigit(input))
                    {
                        Console.WriteLine("digit");
                    }
                    else
                    {
                        Console.WriteLine("other");
                    }

                    break;

            }
        }
    }
}