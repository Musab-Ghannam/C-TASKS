using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace taskcsharp22_11_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CORRECT THE SYNTAX");

            int[] ARR = { 1, 7, 9, 45 };

            string[] ARR2 = { "str", "alex", "moh" };

            string[] ARR3 = { "the", "fox", "lazy", "dog" };

            Console.WriteLine("\n");


            string[] fruits = { "tomato", "banana", "watermelon" };

            Console.WriteLine("the index of tomato" +"\t "+ Array.IndexOf (fruits, "tomato"));
            Console.WriteLine("the index of banana" + "\t " + Array.IndexOf(fruits, "banana"));

            Console.WriteLine("\n");
            Console.WriteLine("task 3");
            string[] favoritefood = {"mansaf","maqloubeh","al-musakhan","humos","falafel" };
            string[] favoritesport = { "footballmatch", "tennis", "hockey", "boxing", "yoga" };
            string[] favoritemovie = { "matilda", "home-alone", "jumanji", "parenty-trap", "hocus-pocus" };

            foreach(string favourit in favoritefood) {

                Console.WriteLine(favourit);
            }

            Console.WriteLine("\n");

            Console.WriteLine("favoritesport");

            for (int i=0;i<favoritesport.Length;i++)
            {


                Console.WriteLine(favoritesport[i]);
            }


            Console.WriteLine("\n");

            Console.WriteLine("favoritemovie");

            foreach (string favour in favoritemovie )
            {

                Console.WriteLine(favour);
            }


            Console.WriteLine("\n");
            Console.WriteLine("task4");

           string[] SUM =Console.ReadLine().Split(',');


           
            int total = 0;

            for (int i= 0;i< SUM.Length; i++)
            {

                total += Convert.ToInt32(SUM[i]);
              
                

            }
            Console.WriteLine(total);




            Console.WriteLine("\n");
            Console.WriteLine("task 5");
            int odd = 0;

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    odd += i;

                 
                    Console.Write(i+"  ");

                 

                }
              

            }
            Console.WriteLine("\n the sum of odd number is"+odd + "\t");



            Console.WriteLine("\n");
            Console.WriteLine("task6");


            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("\t");

                for(int o = 4; o > i; o--)
                {
                    Console.Write(" ");
                }
                for(int j=0; j<=i; j++)
                {
                  

                    Console.Write("* ");

                }


            }


            Console.WriteLine("\n");
            Console.WriteLine("task7");

            int tot = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("\t");
              

                
                for (int j = 0; j <= i; j++)
                {
                    tot += 1;
                    Console.Write(tot);

                }


            }


            Console.WriteLine("\n");
            Console.WriteLine("task8");
            Console.WriteLine("\n");
          double group = 0;
            double fin = 0;
           string[] avg = Console.ReadLine().Split(',');


            for(int i = 0; i < avg.Length; i++)

            {
              
                       for(int j=0; j<=i; j++)
                {
                    if (avg[j] == avg[i])
                    {

                        continue;
                    }


                   

                }

                group += Convert.ToDouble(avg[i]);








            }
            fin = group / avg.Length;

            Console.WriteLine(fin);
        }


    }
}
