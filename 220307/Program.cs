using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello World!");

            //string input = Console.ReadLine();

            //Console.WriteLine("輸入的文字為：" + input);



            double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;

            int total = (int)meal_cost + tip_percent + tax_percent;

            Console.WriteLine("總餐費=" + total);


        }
    }
}
