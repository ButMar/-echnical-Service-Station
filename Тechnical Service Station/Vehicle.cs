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
            int СonditionResult = (MstateBody + MstateWheel + MstateEngine + MstateChassis) / 4;

            if (СonditionResult > 0)
            {
                Console.WriteLine("Сondition of vehicle = " + СonditionResult + "Сontact the service department");
            }
            else
            {
                Console.WriteLine("Сondition of vehicle is good ");
            }

        }

        public void СostOFrepair()
        {

        }
}
}
 

   
