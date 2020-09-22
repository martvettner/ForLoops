using System;

namespace drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink;
            Console.WriteLine("enter your age");
            int age = Int32.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("you can drink beer");
            }
            else
            {
                Console.WriteLine("you are too young for beer");
            }
            


        }




    }
}
