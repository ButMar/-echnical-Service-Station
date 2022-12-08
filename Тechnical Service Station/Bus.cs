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
            float conditionResult = (stateBody + stateWheel + stateEngine + stateChassis + stateSalon) / 5;

            return conditionResult;
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
