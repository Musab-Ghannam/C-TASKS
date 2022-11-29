using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_29_11_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLEASE ENTER YOUR NAME");
            string name = Console.ReadLine();

            Console.WriteLine("PLEASE ENTER THE YEAR OF THE BIRTHDAY");
            int birth = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("PLEASE ENTER YOUR ID NUMBER");
            string employeeId = Console.ReadLine();

            
            Employee info = new Employee(name,birth,employeeId);
            info.info();
            info.calcAge();//info for employee age from birthday;

            manager info2 = new manager("mosab", 1996, "996555");
            info2.info();//info manager
            info2.calcAge();//info for employee age from birthday
        }
    }

    class Employee
    {
        public string name { get; set; }
       public int birth { get; set; }
        public string EmplyeeId { get; set; }


        public Employee(string name, int birth, string emplyeeId)
        {
            this.name = name;
            this.birth = birth;
            this.EmplyeeId = emplyeeId;
       
        }

        public virtual void calcAge()
        {
            Console.WriteLine($"the age for you is :{2022 - birth})\n\n\n\n");
        }
        public virtual void info()
        {
            Console.WriteLine($"the name of employee {name}\n " +
               $"birth year of employee {birth}\n" +
               $"the employee ID IS: {this.EmplyeeId} ");

        }
    }
    class manager : Employee
    {
        public manager(string name, int birth, string emplyeeId) : base(name, birth, emplyeeId) {  }

        public override void info()
        {
            Console.WriteLine($"the name of manager {name}\n " +
                $"birth year of manager {birth}\n" +
                $"the employee ID IS: {this.EmplyeeId} ");

        }

        public override void calcAge()
        {
            Console.WriteLine($"the age for manager is :{2022 - 1996})");
        }

    }

}
