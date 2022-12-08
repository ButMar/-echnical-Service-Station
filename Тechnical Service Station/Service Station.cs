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
        private TimerCounter timer = new TimerCounter();
        private PriceList priceList = new PriceList();

        public TimerCounter Timer
        {
            get { return timer; }
        }

        private int RepairePart(int state, int repairPrice, int repairTime)
        {
            int summa = 0;

            while (state <= 100 && state > 0)
            {
                state--;
                summa = summa + repairPrice;
                Thread.Sleep(repairTime);
                Console.WriteLine(" Part under repaire ");
            }             
            return summa;
        }


        public Check[] Repair(Vehicle[] mashinki)
        {
            Check[] TotalCheck = null;  
            for (int i = 0; i < mashinki.Length; i++)
            {
                TotalCheck = new Check[i];
                Console.WriteLine(TotalCheck);        
            }
            

            foreach (Vehicle mashinca in mashinki)
            {
                DateTime startDate = DateTime.Now;

                int sumBody = RepairePart(mashinca.GetStateBody(), priceList.BodyRepairPrice, priceList.BodyRepairTime);
                mashinca.SetStateBody(0);
                Console.WriteLine( mashinca.Brand + "  " + mashinca.Model + "  " + "Body repaired ");

                int sumWheel = RepairePart(mashinca.GetStateWheel(), priceList.WheelRepairPrice, priceList.WheelRepairTime);
                mashinca.SetStateWheel(0);
                Console.WriteLine( mashinca.Brand + "  " + mashinca.Model + "  " + "Wheel repaired ");

                int sumEngine = RepairePart(mashinca.GetStateEngine(), priceList.EngineRepairPrice, priceList.EngineRepairTime);
                mashinca.SetStateEngine(0);
                Console.WriteLine( mashinca.Brand + "  " + mashinca.Model + "  " + "Engine repaired ");

                int sumChassis = RepairePart(mashinca.GetStateChassis(), priceList.ChassisRepairPrice, priceList.ChassisRepairTime);
                mashinca.SetStateChassis(0);
                Console.WriteLine(mashinca.Brand + "  " + mashinca.Model + "  " + "Chassis repaired ");

                int totalSum = sumBody + sumWheel + sumEngine + sumChassis;

                DateTime finishDate = DateTime.Now;

                TimeSpan diff = finishDate - startDate;

                timer.Minutes = (double)diff.Seconds / 60;

                Check checkForWork = new Check();
                checkForWork.TimeSpent = timer.Minutes;
                checkForWork.RepaireCost = totalSum;
            }

            return TotalCheck;
        }


        public static void PrintCondition(Vehicle mashinca)
        {
            float conditionResult = mashinca.СonditionOFvehicle();
            if (conditionResult > 0)
            {
                Console.WriteLine("Сondition of vehicle " + mashinca.Brand + "  " + mashinca.Model + " = " + conditionResult + " Сontact the service department");
            }
            else
            {
                Console.WriteLine("Сondition of vehicle " + mashinca.Brand + "  " + mashinca.Model + " = " + conditionResult + " It is good ");
            }
        }


    }


}
