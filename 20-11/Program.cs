using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string z = "hello friend";

            z = Console.ReadLine();
            Console.WriteLine(z);

          

            Double A = 2.2;
            String B = "MOSAB";
            char myLetter = 'd';
            bool value = true;
            const int mark = 100;
            Console.WriteLine(A);

            Console.WriteLine(B);

            Console.WriteLine(myLetter);


            Console.WriteLine(value);

            Console.WriteLine(mark);

            string[] cars = { "bmw", "volvo", "honda", "ford" };

            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            Console.WriteLine(cars[3]);

            Console.WriteLine(cars.Length);


            String fname = "sami";
            String lname = "Ali";
            int birthday = 1999;
            Console.WriteLine(fname + " " + lname + " " + birthday);

            int[] Data = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(Data[0] + " " + Data[1] + " " + Data[2] + " " + Data[3] + " " + Data[4] + " " + Data[5] + " " + Data[6] + " " + Data[7] + " " + Data[8] + " " + Data[9]);

            int[] values = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(values[0] + values[1] + values[2] + values[3] + values[4] + values[5] + values[6]);

        }
    }
}
