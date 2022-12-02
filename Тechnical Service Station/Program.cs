using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ТechnicalServiceStation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehicle sutula = new Vehicle("toyota", "yaris", "blue", 5, 7, 3, 6);

            ServiceStation sto = new ServiceStation();
            //sto.CostOFrepair(sutula);
            //sto.Repair(sutula);
            //sutula.СonditionOFvehicle();

            //Console.WriteLine();

            //Car Marynas = new Car("reno", "megan", "black", 0, 2, 3, 4);
            //sto.CostOFrepair(Marynas);
            //sto.Repair(Marynas);
            //Marynas.СonditionOFvehicle();

            //Console.WriteLine("minutes spent : " + sto.Timer.Hours);

            //Console.WriteLine();

            Truck Gazel = new Truck("tata", "gazel", "grey", 3, 6, 5, 3, 1);
            gazel.СonditionOFvehicle();
            sto.CostOFrepair(Gazel);
            sto.Repair(Gazel);
            gazel.СonditionOFvehicle();

            Console.WriteLine();

            Bus bogdan = new Bus("etalon", "bogdan", "yellow", 5, 2, 0, 4, 3);
            Bogdan.СonditionOFvehicle();
            sto.CostOFrepair(Bogdan);
            sto.Repair(Bogdan);
            Bogdan.СonditionOFvehicle();

            Console.WriteLine();
        }
    }
}
