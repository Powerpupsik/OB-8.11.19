using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAR
{
    class Car
    {
        public string mark;
        public string model;
        public string color;
        public string regNumber;
        public int odo = 0;

        public void Drive()
        {
            odo += 100;

        }

        public void ShowOdo()
        {
            Console.WriteLine($"The car {mark} {model} has driven {odo} km.");
        }
       
        


    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.model = "Octavia";
            myCar.mark = "Škoda";
            myCar.regNumber = "123ABC";
            myCar.odo = 400;

            for(int i=0; i<10; i++)
            {
                myCar.Drive();
            }

            myCar.ShowOdo();

            Console.ReadLine();
        }
    }
}
