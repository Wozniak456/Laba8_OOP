using System;
using System.Collections.Generic;
using Laba8Lib;
using SimpleAlgorithmsApp;

namespace Laba8_OOP_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vozniak Sofiia, is-01");
            LinkedList1 linkedList = new LinkedList1();
            linkedList.Add(-0.21F);
            linkedList.Add(32.543F);
            linkedList.Add(1.0001F);
            linkedList.Add(18.1212F);
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            try
            {
                Console.WriteLine("Input a num listEls must be more than");
                float num = float.Parse(Console.ReadLine());
                Console.WriteLine($"There are {linkedList.FindNumOfElsThatMore(num)} nums");
                Console.WriteLine("Input a num that listEls must be less than, to delete them");
                float num2 = float.Parse(Console.ReadLine());
                linkedList.Remove(num2);
                foreach (var item in linkedList)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
        }
    }
}
