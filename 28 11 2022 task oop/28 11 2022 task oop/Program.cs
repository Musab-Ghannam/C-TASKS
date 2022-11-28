using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_11_2022_task_oop
{
    class test:car
    {
        public test(string Carsmake, string Year, string Type, string Price, string Model, string PalletNO, string color, string turnon, int liter) : base(Carsmake, Year, Type, Price, Model, PalletNO, color, turnon,liter) { }

        void print()
        {


        }

    }
   class car
    {
        string carrsmake { get; set; }
        string year { get; set; }
        string type { get; set; }
        string price { get; set; }
        string model { get; set; }
        string palletNO { get; set; }
        string COLOR { get; set; }
    string TURNON { get; set; }

        int liter { get; set; }
    public car(string Carsmake, string Year,string Type,string Price,string Model,string PalletNO,string color,string turnon,int liter) {
        


            this.carrsmake= Carsmake;
           this.year= Year;
            this.type = Type;
            this.price= Price;
          this.model= Model;
            this.palletNO = PalletNO;
            this.COLOR = color;
            this.TURNON = turnon;
      this.liter = liter;
        }

        void engine()
        {
            if (TURNON == "START")
            {
                Console.WriteLine("START");

            }else if (TURNON == "END")
            {
                Console.WriteLine("START");
            }
        }


        string fullinfo()
        {
            return $"carrsmakeis: {this.carrsmake}\n the year is:{this.year}\n the type is: {this.type}\n the price is:{this.price}\n" +
                $"the model is: {this.model}\n the palletno is: {this.palletNO} \n the color is: {this.COLOR}\n the state of car is {this.TURNON} ";
              

        }
       void CALCULATE()
        {
            Console.WriteLine($"NUMBER OF KILOMETERS IS :{this.liter*20} KM");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("please enter how much litter you spend");
            int LITTER =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the state of car");
            string engine =Console.ReadLine();

           car car1 = new car("meker", "2005","bmw","6000","2010","48556","blue", engine, LITTER) ;

           Console.WriteLine(car1.fullinfo());
            car1.CALCULATE();
                         

        }
    }
}
