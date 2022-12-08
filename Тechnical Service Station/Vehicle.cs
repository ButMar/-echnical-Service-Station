using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ТechnicalServiceStation
{
    public class Vehicle
    {
        protected string brand;
        protected string model;
        protected string color;
        protected int stateBody;
        protected int stateWheel;
        protected int stateEngine;
        protected int stateChassis;
        

        public Vehicle(string brand, string model, string color, int stateBody,
                       int stateWheel,int stateEngine, int stateChassis)
        {
          this.brand = brand;
          this.model = model;
          this.color = color;
          this.stateBody = stateBody;
          this.stateWheel = stateWheel;
          this.stateEngine = stateEngine;
          this.stateChassis = stateChassis;
        }

     
        public string Brand
        {
            get { return brand; }
            private set { }
        }


        public string Model
        {
            get { return model; }
            private set { }
        }


        public string Color
        {
            get { return color; }
            private set { }
        }


        public virtual float СonditionOFvehicle()
        {
            float conditionResult = (stateBody + stateWheel + stateEngine + stateChassis) / 4;

            return conditionResult;
        }




        public virtual int GetStateBody()
        {
            return stateBody;
        }

        public virtual void SetStateBody(int body)
        {
            stateBody = body;
        }


        public int GetStateWheel()
        {
            return stateWheel;
        }

        public void SetStateWheel(int wheel)
        {
            stateWheel = wheel;
        }

        public int GetStateEngine()
        {
            return stateEngine;
        }


        public void SetStateEngine(int engine)
        {
            stateEngine = engine;
        }


        public virtual int GetStateChassis()
        {
            return stateChassis;
        }

        public virtual void SetStateChassis(int chassis)
        {
            stateChassis = chassis;
        }



    }
}
 

   
