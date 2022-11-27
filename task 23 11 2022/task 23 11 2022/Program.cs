using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task_23_11_2022
{
    internal class Program
    {
        static void sumandavg(string[] x)
        { double total = 0;
            double avg = 0;

           

            for (int i = 0; i < x.Length; i++)
            {
               
                total += Convert.ToInt32(x[i]);

            }
            avg=(total/(x.Length));

            Console.WriteLine("the avg of these number is\t"+avg);
            Console.WriteLine("the total of these number is\t" + total);
         
           

        }

        static void cube(string[] y)
        {
            int result = 0;
            int CUB = 0;
            for (int j = 0; j < y.Length; j++)
            {

                result= Convert.ToInt32(y[j]);

                CUB = result * result * result;
                Console.WriteLine(CUB);
            }
            
        }

        static void getyears(int[] s)
        {
            for(int o = 0; o < s.Length; o++)
            {
                if (s[o] > 1950) 
                {

                    Console.WriteLine(s[o]);
                }
            }

        }

        static double agedays(double d)
        {
            double days = 0;
            days = d * 365;
            return days;

        }

        static void animals(int numbchick, int numbcows, int numbpigs)
        {
          int chicken = 2;int cows = 4; int pigs = 4;int totlegs = 0;

            totlegs = chicken * numbchick + cows * numbcows + pigs * numbpigs;
            Console.WriteLine(totlegs);
        }

        static void pass(string[] a, string[] b)
        {
            string res = "";
            string[] email = { "moath", "ahmad", "rami" };
            string[] pass = { "123", "456", "789" };

            for (int i = 0; i < a.Length; i++)

                for(int j=0; j < email.Length; j++) { 
            {
                if (a[i] == email[j] && b[i] == pass[j])
                {
                    res = "pass";
                            break;
                }
                else
                {
                     res = "fail";
                    
                }
                    }


                }

            Console.WriteLine(res);
        }


        static void power(int a,double b)
        { double res = 1;

            if (b > 0) {
            for(int i = 0; i<(b); i++)
            {


                res= res * a;
            }
            }else if (b == 0)
            {
                res = 1;
            }else if (b < 0)
            {
                b = -1 * b;
                for (int i = 0; i < (b); i++)
                {


                    res = res * a;
                }
                res =1/res;

            }





            Console.WriteLine(res);
            

        }

        static void leapyear(string[] a)
        {
            int fyear = 1904;
            
            for(int j = 1904; j < 2024; j=j+4) { 
            for (int i = 0; i < a.Length; i++)
                {
                  fyear= Convert.ToInt16(a[i]);
                if (fyear == j){
                        Console.WriteLine($"the {a[i]} is a leap year \t");

            }


            }
            }
        }


        static void primenumber(string[] s)
        { int prime = 1;
            bool prim = true;
            int notaccept = 0;
            int accept = 0;
            for (int i = 0; i< s.Length;i++) { 
                for (int j = 2;j <= 100; j++)
                {
                    prime = Convert.ToInt16(s[i]);
                    if (prime!=j&& prime % j == 0)
                    {
                        prim = false;
                        break;

                       
                    }


                }
                if (prim)
                {

                    Console.WriteLine($"{prime} is prime number \t");
                }
                prim = true;
            }
            

        }


        static void numberword(string[] a)
        {
           
            
                Console.WriteLine(a.Length);

           

        }
        static void Main(string[] args)
        {

            //Console.WriteLine(" TASK 1 \t enter values to see the sum and AVG");

            //string[] r = Console.ReadLine().Split(',');




            //sumandavg(r);


            //Console.WriteLine(" TASK 2 \t enter values to see the CUBE");

            //string[] c = Console.ReadLine().Split(',');

            //cube(c);


            //Console.WriteLine(" TASK 3 \t years greater than 1950");

            //int[] year = { 1950, 1955, 1980, 1920, 1900, 2015 };

            //getyears(year);

            //Console.WriteLine(" TASK 4 \t give me the age in years to show the age in days");

            //double myage = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(agedays(myage));

            //Console.WriteLine(" TASK 5 \thow many legs in your farm");

            //animals(2, 3, 5);
            Console.WriteLine(" TASK 6 \t password and emaill pass or not pass");


            string[] test = Console.ReadLine().Split(',');
            string[] numb = Console.ReadLine().Split(',');

            pass(test, numb);

            Console.WriteLine(" TASK 7 \t power of numbers");

            int bas = 5; int pow = 3;

            power(bas, pow);

            Console.WriteLine(" TASK 8 \t leap year");

            string[] leap = Console.ReadLine().Split(',');

            leapyear(leap);

            Console.WriteLine(" TASK 9 \t prime number");

            string[] pr = Console.ReadLine().Split(' ');

            primenumber(pr);

            Console.WriteLine(" TASK 10\t count the words");


            string[] numbword = Console.ReadLine().Split(' ');

            numberword(numbword);


        }
    }
}
