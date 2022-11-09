using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Тechnical_Service_Station
{
    public class Vehicle
    {
        protected string Mbrand;
        protected string Mmodel;
        protected string Mcolor;
        protected int MstateBody;
        protected int MstateWheel;
        protected int MstateEngine;
        protected int MstateChassis;
        protected int costOfRrepairPart = 10;

        public Vehicle(string brand, string model, string color, int stateBody,
                       int stateWheel,int stateEngine, int stateChassis)
        {
          Mbrand = brand;
          Mmodel = model;
          Mcolor = color;
          MstateBody = stateBody;
          MstateWheel = stateWheel;
          MstateEngine = stateEngine;
          MstateChassis = stateChassis;
        }

        public void СonditionOFvehicle()
        {
            int a = MstateBody;
            int b = MstateWheel;
            int c = MstateEngine;
            int d = MstateChassis;

            float СonditionResult = (a + b + c + d) / 4;

            if (СonditionResult > 0)
            {
                Console.WriteLine("Сondition of vehicle = " + СonditionResult + " Сontact the service department");
            }
            else
            {
                Console.WriteLine("Сondition of vehicle is good ");
            }

        }


        public void СostOFrepair()
        {
            float k = MstateBody;
            float m = MstateWheel;
            float n = MstateEngine;
            float f = MstateChassis;

            if (k > 0 && m > 0 && n > 0 && f > 0 ) ;

            //float CostResult = (k * 10) + (m * 10) + (n * 10) + (f * 10);
            float CostResult = (k + m + n + f) * costOfRrepairPart;

            Console.WriteLine("Cost of repaire You car = " + CostResult + " hryvnias");
        }
    }
}
 

   
