using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тechnical_Service_Station
{
    public class Bus : Vehicle
    {
        protected int MstateSalon;
        public Bus(string brand, string model, string color, int stateBody, int stateWheel, int stateEngine,
               int stateChassis, int stateSalon) : base(brand, model, color, stateBody, stateWheel, stateEngine, stateChassis)
        {
            MstateSalon = stateSalon;
        }


        public void СonditionOFvehicle()
        {
            int a = MstateBody;
            int b = MstateWheel;
            int c = MstateEngine;
            int d = MstateChassis;
            int e = MstateSalon;

            float СonditionResult = (a + b + c + d + e) / 5;

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
            float h = MstateSalon;

            if (k > 0 && m > 0 && n > 0 && f > 0 && h > 0) ;
            {
                var i = 1;
                k = i;
                m = i;
                n = i;
                f = i;
                h = i;

                float CostResult = (k + m + n + f + h) * costOfRrepairPart;

                Console.WriteLine("Cost of repaire You car = " + CostResult + " hryvnias");
            }
        }


    }
}
