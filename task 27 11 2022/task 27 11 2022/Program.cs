using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_27_11_2022
{
    class info
    {
        private int age;
        private string gender;
        private string name;
        private string Email;
        private string phone;
        private string ID;
        public info(int age, string gender, string name, string email, string phone, string ID)
        {


            if (age > 18 && age < 60)
            {
                this.age = age;
            }
            else
            {
                Console.WriteLine("please your age is not valid\n\n");


            }
            this.gender = gender;
            this.name = name;
            Email = email;
            if (phone.Substring(0, 3) == "077" || phone.Substring(0, 3) == "078" || phone.Substring(0, 3) == "079")
            {
                this.phone = phone;
            }
            else
            {
                this.phone=("   please enter the valid number");
            }



            this.ID = ID;



        }
    
    



     
            static void Main(string[] args)
            {

            Console.WriteLine("the name");
            string name = Console.ReadLine();

            Console.WriteLine("the age");
            

            int age =Convert.ToInt32( Console.ReadLine());


            if(age < 18 && age > 60)
            {
                
            }

            Console.WriteLine("the gender");
            string gender = Console.ReadLine();


            Console.WriteLine("the email");
            string Email = Console.ReadLine();

            Console.WriteLine("the phone");
            string phone = Console.ReadLine();

            Console.WriteLine("the ID");
            string ID = Console.ReadLine();

            info detail = new info(age, gender, name, Email, phone, ID);
            
          
            
            Console.WriteLine($" MY NAME IS {detail.name}\n"+" " + $" MY AGE IS {detail.age}\n" + ""+ $" MY gender IS {detail.gender}\n" + " "+ $" MY email IS {detail.Email}\n" + " "+" "+ $" MY phone IS {detail.phone}\n" + " "+ $" MY ID IS {detail.ID}");
          

            }
        }
    }

