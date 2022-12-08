using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТechnicalServiceStation
{
    internal class Manager
    {
        private PriceList priceListWorKDay;
        private PriceList priceListHollyDay;

       public Manager()
        {
            priceListWorKDay = new PriceList();
            priceListHollyDay = new PriceList();

        }

       public void FillPriceList(int bodyRepaireCost, int wheelRepaireCost, int engineRepaireCost, 
                                 int chassisRepaireCost)
        {
            int coefficient = 2;

            priceListWorKDay.BodyRepairPrice = bodyRepaireCost;
            priceListWorKDay.WheelRepairPrice = wheelRepaireCost;
            priceListWorKDay.EngineRepairPrice = engineRepaireCost;
            priceListWorKDay.ChassisRepairPrice = chassisRepaireCost;

            priceListHollyDay.BodyRepairPrice = bodyRepaireCost * coefficient;
            priceListHollyDay.WheelRepairPrice = wheelRepaireCost * coefficient;
            priceListHollyDay.EngineRepairPrice = engineRepaireCost * coefficient;
            priceListHollyDay.ChassisRepairPrice = chassisRepaireCost * coefficient;
            priceListHollyDay.BodyRepairTime = priceListHollyDay.BodyRepairTime * coefficient;
            priceListHollyDay.WheelRepairTime = priceListHollyDay.WheelRepairTime * coefficient;
            priceListHollyDay.EngineRepairTime = priceListHollyDay.EngineRepairTime * coefficient;
            priceListHollyDay.ChassisRepairTime = priceListHollyDay.ChassisRepairTime * coefficient;

        }
            


    }
}
