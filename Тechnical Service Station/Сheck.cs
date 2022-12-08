using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ТechnicalServiceStation
{
    public class Check
    {
        private double timeSpent;

        private int repaireCost;


        public double TimeSpent
        {
            get { return timeSpent; }
            set
            {
                timeSpent = value;
            }
        }


        public int RepaireCost
        { 
           get { return repaireCost; }
           set
            { 
              repaireCost = value;
            }
        }


    }
}
