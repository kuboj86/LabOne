
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter the length of the room: ");
            string firstDimension = Console.ReadLine();
            double length = Convert.ToDouble(firstDimension);
            
            Console.Write("Please enter the width of the room:  ");
            string secondDimension = Console.ReadLine();
            double width = Convert.ToDouble(secondDimension);

            Console.Write("Please enter the heigth of the room: ");
            string thirdDimension = Console.ReadLine();
            double height = Convert.ToDouble(thirdDimension);
            // changes
            double area = (length * width);
            Console.WriteLine($"The Area of the room is {area}'. \n");

            double perimeter = (length * 2 + width * 2);
            Console.WriteLine($"The Perimeter of the room is {perimeter}'.\n");

            double volume = (length * width * height);
            Console.WriteLine($"The Volume of the room is {volume}'.\n");
        
        }
    }
}
