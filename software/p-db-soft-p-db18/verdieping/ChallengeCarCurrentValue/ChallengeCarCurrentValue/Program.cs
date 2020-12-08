using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeCarCurrentValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Car carOne = new Car("DBB-11-B", MotorFuelType.Diesel);
            carOne.Drive(4000);
            carOne.Drive(90000);
            Car carTwo = new Car("D-12-BBB", MotorFuelType.Gasoline);
            carTwo.Drive(60000);
            Car carThree = new Car("0-DB-013", MotorFuelType.LPG);
            carThree.Drive(25000);
            Car carFour = new Car("014-DB-0", MotorFuelType.Electric);
            carFour.Drive(300000);

            Console.WriteLine(carOne);
            Console.WriteLine(carTwo);
            Console.WriteLine(carThree);
            Console.WriteLine(carFour);

            Console.ReadLine();
        }
    }
}
