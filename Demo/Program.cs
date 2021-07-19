using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1, Number2;
            Console.WriteLine("Please Enter Number1");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Number2");
            Number2 = Convert.ToInt32(Console.ReadLine());
            int Add, Substract;
            Add = Number1 + Number2;
            Substract = Number1 - Number2;
            Console.WriteLine("sum of two numbers;") + add.ToString());
            Console.WriteLine("diff of two numbers;") + sub.ToString());
        }
    }
}
