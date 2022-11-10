using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТechnicalServiceStation
{
    public class ServiceStation
    {
        int costOfRrepairPart = 10;

        public void СostOFrepair()
        {
            if ( СonditionOFvehicle > 0)
            {
                float CostResult = (stateBody + stateWheel + stateEngine + stateChassis + stateHydraulics + stateSalon) * costOfRrepairPart;

                Console.WriteLine("Cost of repaire You car = " + CostResult + " hryvnyas");
            }

        }


    }


}
