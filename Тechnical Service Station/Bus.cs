using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТechnicalServiceStation
{
    public class Bus : Vehicle
    {
        protected int stateSalon;
        public Bus(string brand, string model, string color, int stateBody, int stateWheel, int stateEngine,
               int stateChassis, int stateSalon) : base(brand, model, color, stateBody, stateWheel, stateEngine, stateChassis)
        {
            this.stateSalon = stateSalon;
        }


        public override float СonditionOFvehicle()  
        {
            float СonditionResult = (stateBody + stateWheel + stateEngine + stateChassis + stateSalon) / 5;

            if (СonditionResult > 0)
            {
                Console.WriteLine("Сondition of vehicle = " + СonditionResult + " Сontact the service department");
            }
            else
            {
                Console.WriteLine("Сondition of vehicle " + brand + "  " + model + " = " + СonditionResult + " It is good ");
            }

            return СonditionResult;
        }


        public override int GetStateBody()
        {
            return stateBody + stateSalon;
        }

        public override void SetStateBody(int body)
        {
            stateBody = body;
            stateSalon = body;
        }


    }
}
