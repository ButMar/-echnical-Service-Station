using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТechnicalServiceStation
{
    public class TimerCounter
    {
    private double seconds;

        public double Minutes
        {
            get {return seconds / 60; }
            set
            {
                if (value > 0)
                seconds = value * 60;
            }
        }


        public double Hours
        {
            get { return seconds / 3600; }
            set
            {
                if (value > 0 )
                seconds = value * 3600;
            }
        }


        public double Days
        {
            get { return seconds / 86400; }
            set
            {
                if (value > 0)
                    seconds = value * 86400;
            }
        }

    }

}

