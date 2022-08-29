using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ElonsNewBet
{
    public class Car
    {
        // Variables
        private byte _battery = 100;
        private int _driveTimes;
        private int _meters = 20;
        private int _metersDriven;
        private string _color;

        public string Color { get => _color; set => _color = value; }
        public int DriveTimes { get => _driveTimes; set => _driveTimes = value; }
        public byte Battery { get => _battery; set => _battery = value; }
        private int MetersDriven { get => _metersDriven; set => _metersDriven = value; }
        public int Meters { get => _meters; set => _meters = value; }

        public void Drive()
        {
            // I make a for loop to find out how much battery life their is left.
            for(int i = 0; i < _driveTimes; i++)
            {
                Battery--;
            }

            // Sets the meter driven.
            MetersDriven += Meters * DriveTimes;

            Console.WriteLine("Den " + Color + " bils batteri er på: " + Battery + "%.");
            Console.WriteLine("Den " + Color + " bil har kørt: " + MetersDriven + " meter.");
            Console.WriteLine();
        }

        public void ChargeCar()
        {
            Console.WriteLine("Ladder batteriet op for den " + Color + " bil...");

            // Resets the battery and meter driven.
            Battery = 100;
            MetersDriven = 0;

            Thread.Sleep(3000);

            Console.WriteLine("Batteriet er fuldt opladt.");
            Console.WriteLine();
            Console.WriteLine("Den " + Color + " bils batteri er på: " + Battery + "%.");
            Console.WriteLine("Den " + Color + " bil har kørt: " + MetersDriven + " meter.");
            Console.WriteLine();
        }
    }
}
