using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task21_11_22
{
    internal class Program
    {
        static void Main(string[] args)
            
            
        {

            Console.WriteLine("ENTER TWO NUMBERS");

            int x = Convert.ToInt16(Console.ReadLine());
            int y = Convert.ToInt16(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine(x);

            }
            else
            {
                Console.WriteLine(y);

            }


            Console.WriteLine("\n");


            int negative = Convert.ToInt16(Console.ReadLine());

            if(negative <0)
            {

                Console.WriteLine("-");


            }
            else
            {

                Console.WriteLine("+");
            }

            Console.WriteLine("\n");

            int sort = 1;
            int w = 2;
            int q = 8;

            if(sort>w&& w > q)
            {

                Console.WriteLine(sort+"  " +w+" "+q);
            }else if(sort >q && q > w)
            {

                Console.WriteLine(sort + "  " +q+ " " + w);

            }
            else if (w > sort && sort > q)
            {

                Console.WriteLine(w + "  " + sort + " " + q);

            }
            else if (w > q && q > sort)
            {

                Console.WriteLine(w + "  " + q + " " + sort);

            }
            else if (q > w&& w> sort)
            {
                 
                Console.WriteLine(q+ "  " + w + " " + sort);

            }
            else if (q > sort && sort > w)
            {

                Console.WriteLine(w + "  " + q + " " + sort);

            }



            Console.WriteLine("\n");


            int a = 3; int b=4; int c=5; int d = 100 ,r=500;


            if (a > b && a > c && a > d&& a>r)
            {
                Console.WriteLine(a);
            }else if(b> a && b > c && b > d && b > r)
            {

                Console.WriteLine(b);
            }
            else if (c > a && c > b && c> d && c > r)
            {

                Console.WriteLine(c);
            }



              else if (d > a && d > b && d> r&&d>c)
            {

                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine(c);

            }



            Console.WriteLine("\n");

          float kilometers = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(kilometers * 0.62137119);

            Console.WriteLine("\n");

           int hours = Convert.ToInt16(Console.ReadLine());
            int minutes = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(hours*60+minutes + "minutes");


            int totalhours = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(totalhours/60 +"hours"+ ","+ totalhours%60 + "minutes");


            Console.WriteLine("\n");

            string[] equal = { "ahmad", "mohammad", "rami", "khalid" };

            Console.WriteLine(equal[0].Substring(0,2));
            Console.WriteLine(equal[1].Substring(0, 2));
            Console.WriteLine(equal[2].Substring(0, 2));
            Console.WriteLine(equal[3].Substring(0, 2));
        }

    }
}
