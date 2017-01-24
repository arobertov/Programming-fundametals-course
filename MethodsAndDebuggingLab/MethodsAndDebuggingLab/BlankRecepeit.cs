using System;
namespace Blank

{
   public class BlankRecepeit
    {
       public static void Main()
        {
            PrintRecepeitHeader();
            PrintRecepeitBody();
            PrintRecepeitFooter();

        }

       static public void PrintRecepeitHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
      static public void  PrintRecepeitBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static public void PrintRecepeitFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }
    }
}
