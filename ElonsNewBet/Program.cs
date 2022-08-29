using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ElonsNewBet
{
    class Program
    {
        static void Main(string[] args)
        {
            bool on = true;

            Car car1 = new Car();

            Car car2 = new Car();

            // Add color to the cars
            car1.Color = "blå";
            car2.Color = "rød";

            // I create a do/while loop so I can keep driving the car and recharge the car.
            // While the On bool is true.
            do
            {
                // If the Battery value is 0, I call the ChargeCar method, else I call the Drive method.
                if (car1.Battery == 0)
                {
                    car1.ChargeCar(); //ChargeCar method
                }
                else
                {
                    Console.WriteLine("Hvor mange gange skal " + car1.Color + " bil køre");
                    car1.DriveTimes = Convert.ToInt32(Console.ReadLine());

                    car1.Drive(); //Drive method
                }

                // If the Battery value is 0, I call the ChargeCar() method, else I call the Drive() method.
                if (car2.Battery == 0)
                {
                    car2.ChargeCar(); //ChargeCar method
                }
                else
                {
                    Console.WriteLine("Hvor mange gange skal " + car2.Color + " bil køre");
                    car2.DriveTimes = Convert.ToInt32(Console.ReadLine());

                    car2.Drive(); //Drive method
                }

                Console.WriteLine();

            } while (on == true);
        }
    }
}
