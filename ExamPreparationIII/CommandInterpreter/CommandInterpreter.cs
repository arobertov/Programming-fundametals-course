﻿namespace CommandInterpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CommandInterpreter
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] command = Console.ReadLine().Split(' ');
            int start = 0;
            int count = 0;
            List<string> currList = new List<string>();
            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "reverse":
                        start = int.Parse(command[2]);
                        count = int.Parse(command[4]);
                        if (start < 0 || start >= input.Count || (start + count) > input.Count || count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        currList = input.Skip(start).Take(count).Reverse().ToList();
                        input.RemoveRange(start, count);
                        input.InsertRange(start, currList);
                        break;

                    case "sort":
                        start = int.Parse(command[2]);
                        count = int.Parse(command[4]);

                        if (start < 0 || (start + count) > input.Count || count < 0 || start >= input.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        currList = input.Skip(start).Take(count).OrderBy(str => str).ToList();
                        input.RemoveRange(start, count); 
                        input.InsertRange(start, currList);
                        break;

                    case "rollLeft":
                        count = int.Parse(command[1]);

                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        for (int i = 0; i < count % input.Count; i++)
                        {
                            string element = input[0];
                            input.RemoveAt(0);
                            input.Add(element);
                        }

                        break;

                    case "rollRight":
                        count = int.Parse(command[1]);

                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        for (int i = 0; i < count % input.Count; i++)
                        {
                            string element = input[input.Count - 1];
                            input.RemoveAt(input.Count - 1);
                            input.Insert(0, element);
                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine().Split(' ');
            }
            string output = string.Join((", "), input);
            Console.WriteLine($"[{output}]");
        }
    }
}
