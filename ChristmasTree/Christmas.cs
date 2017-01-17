using System;
 class Program
    {
    
public static void PrintStr(string str,int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(str);
        }
   }
    static void Main()
    {
        var name = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
        var spase = " ";
        int c=n;
        for (int i = 1; i <= n; i++)
        {
            PrintStr(spase, c--);
            PrintStr(name, i);
            Console.WriteLine();
            if (i == n)
            {
                for (int j = 0; j < n; j++)
                {
                    PrintStr(spase,j);
                    PrintStr(name,c--);
                    Console.WriteLine();
                }
                
            }
        }
        
    }
}


