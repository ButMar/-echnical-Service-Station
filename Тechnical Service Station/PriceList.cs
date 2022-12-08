using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТechnicalServiceStation
{
    public class PriceList
    {
        private int bodyRepairPrice = 10;

        private int wheelRepairPrice = 20;

        private int engineRepairPrice = 30;

        private int chassisRepairPrice = 50;

        private int bodyRepairTime = 100;

        private int wheelRepairTime = 200;

        private int engineRepairTime = 300;

        private int chassisRepairTime = 500;

        public PriceList()
        { }

        public PriceList(int bodyRepairPrice, int wheelRepairPrice, int engineRepairPrice,  int chassisRepairPrice,
                         int bodyRepairTime, int wheelRepairTime, int engineRepairTime, int chassisRepairTime)

        {
            this.bodyRepairPrice = bodyRepairPrice;
            this.wheelRepairPrice = wheelRepairPrice;
            this.engineRepairPrice = engineRepairPrice;
            this.chassisRepairPrice = chassisRepairPrice;
            this.bodyRepairTime = bodyRepairTime;
            this.wheelRepairTime = wheelRepairTime;
            this.engineRepairTime = engineRepairTime;
            this.chassisRepairTime = chassisRepairTime;
         }


        public int BodyRepairPrice 
        {
            get { return bodyRepairPrice; }
            set { bodyRepairPrice = value;}
        }
    
        public int WheelRepairPrice
        {
            get { return wheelRepairPrice; }
            set { wheelRepairPrice = value; }
        }
        
        public int EngineRepairPrice
        {
            get { return engineRepairPrice; }
            set { engineRepairPrice = value; }
        }


        public int ChassisRepairPrice
        {
            get { return chassisRepairPrice; }
            set { chassisRepairPrice = value; }
        }



        public int BodyRepairTime
        {
            get { return bodyRepairTime; }
            set { bodyRepairTime = value; }
        }


        public int WheelRepairTime
        {
            get { return wheelRepairTime; }
            set { wheelRepairTime = value; }
        }


        public int EngineRepairTime
        {
            get { return engineRepairTime; }
            set { engineRepairTime = value; }
        }


        public int ChassisRepairTime
        {
            get { return chassisRepairTime; }
            set { chassisRepairTime = value; }
        }

    }
}
