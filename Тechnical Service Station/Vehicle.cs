using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ТechnicalServiceStation
{
    public class Vehicle
    {
        protected string brand;
        protected string model;
        protected string color;
        protected int stateBody;
        protected int stateWheel;
        protected int stateEngine;
        protected int stateChassis;
        

        public Vehicle(string brand, string model, string color, int stateBody,
                       int stateWheel,int stateEngine, int stateChassis)
        {
          this.brand = brand;
          this.model = model;
          this.color = color;
          this.stateBody = stateBody;
          this.stateWheel = stateWheel;
          this.stateEngine = stateEngine;
          this.stateChassis = stateChassis;
        }

        public virtual float СonditionOFvehicle()
        {
            float СonditionResult = (stateBody + stateWheel + stateEngine + stateChassis) / 4;

            if (СonditionResult > 0)
            {
                Console.WriteLine("Сondition of vehicle = " + СonditionResult + " Сontact the service department");
            }
            else
            {
                Console.WriteLine("Сondition of vehicle is good ");
            }


            return СonditionResult;

        }



    }
}
 

   
