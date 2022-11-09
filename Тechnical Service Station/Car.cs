using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тechnical_Service_Station
{
    public class Car : Vehicle
    {
        public Car(string brand, string model, string color, int stateBody, int stateWheel, int stateEngine,
               int stateChassis) : base(brand, model, color, stateBody, stateWheel, stateEngine, stateChassis)
        {
        }
    }
}
