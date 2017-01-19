using System;
namespace BooleanVariable
{
    class Boolean
    {
        static void Main(string[] args)
        {
            bool boolRecord;
            string stringRecord = Console.ReadLine();
            boolRecord = Convert.ToBoolean(stringRecord);
            Console.WriteLine(boolRecord ? "Yes":"No");
        }
    }
}
