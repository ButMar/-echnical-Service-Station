using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ТechnicalServiceStation
{
    internal class EngineeringCalculator
    {
        private int counterSum;
        private int counterDiff;
        private int counterArea;

        public int CounterSum { get { return counterSum;} }
        public int CounterDiff { get { return counterDiff; } }
        public int CounterArea { get { return counterArea; } }

        public int Sum(int number1,int number2)
        {
            counterSum++;

            int sum = number1 + number2;
            return sum;
        }

        
        public int Diff(int number1, int number2)
        {
            counterDiff++;

            int diff = number1 - number2;
            return diff;
            
        }

        public int AreaRectangle(int number1, int number2, int number3, int number4)
        {
            counterArea++;

            int area = 0;

            if (number1 == number3 && number2 == number4)
            {
                area = number1 * number2;
                Console.WriteLine(" The area of rectangle = " + area);
            }
            else
            {
                Console.WriteLine(" it is not a rectangle ");
                return 0;
            }

            return area;
            
        }


    }
}
