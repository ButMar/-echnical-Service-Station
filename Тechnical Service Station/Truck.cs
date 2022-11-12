using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТechnicalServiceStation
{
    public class Truck : Vehicle
    {
        protected int stateHydraulics;
        public Truck(string brand, string model, string color, int stateBody, int stateWheel, int stateEngine,
               int stateChassis, int stateHydraulics) : base(brand, model, color, stateBody, stateWheel, stateEngine, stateChassis)
        {
          this.stateHydraulics = stateHydraulics;
        }



        public override float СonditionOFvehicle()
        {
            float СonditionResult = (stateBody + stateWheel + stateEngine + stateChassis + stateHydraulics) / 5;

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

        //public override void СonditionOFvehicle()
        //{
        //    base.СonditionOFvehicle() + ;
        //}

    }
}
