using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movina
{
    internal class Subscribtion
    {
        private int month;
        private double price;

        public int Month
        {
            get;
            private set;
        }
        public double Price
        {
            get;
            private set;
        }

        public Subscribtion(int month, double price)
        {
            Month = month;
            Price = price;
        }
    }
}
