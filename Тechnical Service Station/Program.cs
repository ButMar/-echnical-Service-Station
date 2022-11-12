using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТechnicalServiceStation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle Sutula = new Vehicle("toyota", "yaris", "blue", 35, 7, 3, 9);
            Sutula.СonditionOFvehicle();
            //Vehicle.СostOFrepair();

            Console.WriteLine();

            //Car Marynas = new Car("reno", "megan", "black", 0, 52, 3, 12);
            //Marynas.СonditionOFvehicle();
            

            //Console.WriteLine();

            //Truck Gazel = new Truck("tata", "gazel", "grey", 50, 87, 20, 32, 64);
            //Gazel.СonditionOFvehicle();
            

            //Console.WriteLine();

            //Bus Bogdan = new Bus("etalon", "bogdan", "yellow", 0, 0, 0, 0, 0);
            //Bogdan.СonditionOFvehicle();
           
        }
    }
}
