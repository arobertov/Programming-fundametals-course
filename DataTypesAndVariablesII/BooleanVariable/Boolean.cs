using System;
namespace BooleanVariable
{
    class Boolean
    {
        static void Main(string[] args)
        {
            string stringRecord = Console.ReadLine();
            bool boolRecord = Convert.ToBoolean(stringRecord);
            Console.WriteLine(boolRecord ? "Yes":"No");
        }
    }
}
