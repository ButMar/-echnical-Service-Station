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
            float conditionResult = (stateBody + stateWheel + stateEngine + stateChassis + stateHydraulics) / 5;

            return conditionResult;
        }


        public override int GetStateChassis()
        {
            return stateChassis + stateHydraulics;
        }

        public override void  SetStateChassis(int chassis)
        {
            stateChassis = chassis;
            stateHydraulics = chassis;
        }

    }
}
