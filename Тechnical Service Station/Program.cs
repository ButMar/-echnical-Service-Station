using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ТechnicalServiceStation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceStation sto = new ServiceStation();

            Truck mashina1 = new Truck("tata", "gazel", "grey", 3, 6, 5, 3, 1);
            Bus bogdan = new Bus("etalon", "bogdan", "yellow", 5, 2, 0, 4, 3);
            Car sutula = new Car("toyota", "yaris", "blue", 5, 7, 3, 6);
            Car marynas = new Car("reno", "megan", "black", 9, 0, 6, 2);
            Vehicle[] cars = new Vehicle[] { mashina1, bogdan, sutula, marynas };


            //Manager olya = new Manager();
            //olya.FillPriceList(1, 2, 3, 4);

            //ServiceStation.PrintCondition(mashina1);
            //sto.Repair(mashina1);
            //ServiceStation.PrintCondition(mashina1);
            //Check checkForMashina1 = sto.Repair(mashina1);
            //Console.WriteLine("Time reaire mashina1 = " + checkForMashina1.TimeSpent + " minutes ");
            //Console.WriteLine("Cost of reaire mashina1 = " + checkForMashina1.RepaireCost + " hryvnas ");

            //Console.WriteLine();


            ////ServiceStation.PrintCondition(bogdan);
            ////sto.Repair(bogdan);
            ////ServiceStation.PrintCondition(bogdan);
            //Check checkForBogdan = sto.Repair(bogdan);
            //Console.WriteLine("Time reaire bogdan = " + checkForBogdan.TimeSpent + " minutes ");
            //Console.WriteLine("Money reaire bogdan = " + checkForBogdan.RepaireCost + " hryvnas ");

            //Console.WriteLine();


            //Check checkForMaryna = sto.Repair(marynas);
            //sto.Repair(marynas);
            //Console.WriteLine("Time reaire Marynas car = " + checkForMaryna.TimeSpent + " minutes ");
            //Console.WriteLine("Money reaire Marynas car = " + checkForMaryna.RepaireCost + " hryvnas ");







            //Car miniCar = new Car("tesla", "S", "red", 0, 0, 0, 0); 

            //Table mytable = new Table();
            //Table table2 = new Table();
            //mytable.OpenShelf();
            //mytable.PutInShelf(miniCar);
            //table2.OpenShelf();
            //mytable.ChangeShelf(mytable, table2);
            //mytable.CloseShelf();
            //table2.CloseShelf();






            //EngineeringCalculator calculator = new EngineeringCalculator();
            //calculator.Sum(1, 1);
            //calculator.Sum(1, 2);
            //calculator.Sum(1, 3);
            //calculator.Sum(1, 4);
            //Console.WriteLine(" Sum was called " + calculator.CounterSum + " times ");


            //PriceList zpWithPriceList = new PriceList();
            //int myZP = zpWithPriceList.EngineRepairPrice;

            //int result = calculator.Sum(myZP, 15);
            //Console.WriteLine("summa = " + result);

            //result = calculator.Sum(5865, 8235);
            //Console.WriteLine("summa = " + result);

            //result = calculator.Sum(25, 1328);
            //Console.WriteLine("summa = " + result);

            //calculator.CollCounter();

            //result = calculator.Diff(myZP, 15);
            //Console.WriteLine("different = " + result);

            //result = calculator.Diff(5865, 8235);
            //Console.WriteLine("different = " + result);

            //result = calculator.Diff(25, 1328);
            //Console.WriteLine("different = " + result);


            //result = calculator.AreaRectangle(myZP, 15, myZP, 15);
            //Console.WriteLine("area = " + result);

            //result = calculator.AreaRectangle(myZP, 15, 25, 15);
            //Console.WriteLine("area = " + result);

            //result = calculator.AreaRectangle(myZP, 25, 23, 54);
            //Console.WriteLine("area = " + result);
        }


        static void СomparisonOfRepairTime(double value1, double value2, string brand1, string brand2)
        {
               if (value1 > value2)
                {
                    Console.WriteLine( brand1 + " repaired longer");
                }
                else
                {
                    Console.WriteLine( brand2 + " repaired longer");
                }
        }

    }
}
