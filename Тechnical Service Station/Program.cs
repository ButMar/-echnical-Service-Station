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
            Vehicle sutula = new Vehicle("toyota", "yaris", "blue", 0, 7, 3, 9);
            
            ServiceStation sto = new ServiceStation();
            sto.CostOFrepair(sutula);
            sto.Repair(sutula);

            Console.WriteLine();

            //Car Marynas = new Car("reno", "megan", "black", 0, 52, 3, 12);
            //sto.CostOFrepair(Marynas);

            //Console.WriteLine();

            //Truck Gazel = new Truck("tata", "gazel", "grey", 50, 87, 20, 32, 64);
            //Gazel.СonditionOFvehicle();
            //sto.CostOFrepair(Gazel);


            //Console.WriteLine();

            //Bus Bogdan = new Bus("etalon", "bogdan", "yellow", 0, 0, 0, 0, 0);
            //Bogdan.СonditionOFvehicle();
            //sto.CostOFrepair(Bogdan);

        }
    }
}
