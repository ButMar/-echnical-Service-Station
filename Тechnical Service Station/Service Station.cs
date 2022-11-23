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

        public void CostOFrepair (Vehicle mashinca)
        {
            if (mashinca.СonditionOFvehicle() > 0)
            {
                float costResult = СonditionResult * costOfrepairPart;

                Console.WriteLine("Cost of repaire You car = " + CostResult + " hryvnyas");
            }

        }


    }


}
