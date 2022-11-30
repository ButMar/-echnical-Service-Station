using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТechnicalServiceStation
{
    public class ServiceStation
    {
        int costOfrepairPart = 10;

        public void CostOFrepair(Vehicle mashinca)
        {
            float condition = mashinca.СonditionOFvehicle();

            if (condition > 0)
            {
                float costResult = condition * costOfrepairPart;

                Console.WriteLine("Cost of repaire You car = " + costResult + " hryvnyas");
            }
        }



        public void Repair(Vehicle mashinca)
        {
            int stateBody = mashinca.СonditionStateBody();
            if (stateBody <= 100 && stateBody != 0)
            {
                stateBody--;
                Console.WriteLine("Body under repaire ");
            }
            else
            {
                Console.WriteLine("Body repaired ");
            }




            int stateWheel = mashinca.СonditionStateWheel();
            if (stateWheel <= 100 && stateWheel != 0)
            {
                stateWheel--;
                Console.WriteLine("Wheel under repaire ");
            }
            else
            {
                Console.WriteLine("Wheel repaired ");
            }




            int stateEngine = mashinca.СonditionStateEngine();
            if (stateEngine <= 100 && stateEngine != 0)
            {
                stateEngine--;
                Console.WriteLine("Engine under repaire ");
            }
            else
            {
                Console.WriteLine("Engine repaired ");
            }




            int stateChassis = mashinca.СonditionStateChassis();
            if (stateChassis <= 100 && stateChassis != 0 )
            {
                stateChassis--;
                Console.WriteLine("Chassis under repaire ");
            }
            else
            {
                Console.WriteLine("Chassis repaired ");
            }



            //if (stateHydraulics <= 100)
            //{
            //    stateHydraulics--;
            //    Console.WriteLine("Hydraulics under repaire ");
            //}
            //else
            //{
            //    Console.WriteLine("Hydraulics repaired ");
            //}



            //if (stateSalon <= 100)
            //{
            //    stateSalon--;
            //    Console.WriteLine("Salon under repaire ");
            //}
            //else
            //{
            //    Console.WriteLine("Salon repaired ");
            //}

        }


    }


}
