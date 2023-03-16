using System;

namespace Excersize_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excersize 12 asks for the length and width of carpet and price per square foot
            //make a constant for the constant fo the price per square foot


            const double perSquareFoot = 1.50; 

            Console.WriteLine("What is the Length of your room?");
            double roomLength = double.Parse(Console.ReadLine());

            Console.WriteLine("Enetr the Width of your room?");

            double roomWidth = double.Parse(Console.ReadLine());

            double area = roomLength * roomWidth;
            //how much it will cost to
            double price = area * perSquareFoot;

            Console.WriteLine("The price to carpet this {0} by {1} room is ${2} " ,roomLength ,roomWidth, price);

        }
    }
}
