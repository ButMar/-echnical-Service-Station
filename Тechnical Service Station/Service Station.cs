using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ТechnicalServiceStation
{
    public class ServiceStation
    {
        private int costOfrepairPart = 10;
        private TimerCounter timer = new TimerCounter();

        public TimerCounter Timer
        {
            get { return timer; }
        }

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
            //start time
            DateTime startDate = DateTime.Now;

            int stateBody = mashinca.GetStateBody();
            for ( ; stateBody <= 100 && stateBody > 0; stateBody--)
            {
                Thread.Sleep(200);
                Console.WriteLine("Body under repaire ");
            }

            mashinca.SetStateBody(stateBody);
            Console.WriteLine("Body repaired ");
            

            int stateWheel = mashinca.GetStateWheel();
            while (stateWheel <= 100 && stateWheel > 0)
            {
                stateWheel--;
                Thread.Sleep(300);
                Console.WriteLine("Wheel under repaire ");
            }
            
            mashinca.SetStateWheel(stateWheel);
                Console.WriteLine("Wheel repaired ");

           
            
            
            int stateEngine = mashinca.GetStateEngine();
            while (stateEngine <= 100 && stateEngine > 0)
            {
                stateEngine--;
                Thread.Sleep(500);
                Console.WriteLine("Engine under repaire ");
            }

            mashinca.SetStateEngine(stateEngine);
            Console.WriteLine("Engine repaired ");




            int stateChassis = mashinca.GetStateChassis();
            while (stateChassis <= 100 && stateChassis > 0)
            {
                stateChassis--;
                Thread.Sleep(100);
                Console.WriteLine("Chassis under repaire ");
            }

            mashinca.SetStateChassis(stateChassis);
            Console.WriteLine("Chassis repaired ");

            // finish time
            DateTime finishDate = DateTime.Now;

            TimeSpan diff = finishDate - startDate;

            timer.Minutes = (double) diff.Seconds / 60;
            //calculate timeSpent
        }








    }


}
