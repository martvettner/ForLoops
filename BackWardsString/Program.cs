using System;
using System.Data;

namespace BackWardsString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name");


            string name = "Larry";
            Console.WriteLine(name[4]);

            for (int i = name.Length - 1; i >= 0; i = --) 
            {
                Console.WriteLine(name[i]);
            }
          

        }
    }
}
