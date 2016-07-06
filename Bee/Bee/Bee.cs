using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bee
{
    public class Bee
    {
        private double weight;
        public Bee(double weight)
        {
            this.weight = weight;
        }

        public virtual int ShiftsLeft
        {
            get { return 0; }
        }
        
        public virtual double GetHoneyConsumption()
        {
            double consumption = (ShiftsLeft == 0) ? 7.5 : 9 + ShiftsLeft;
            if (weight > 150)
                consumption *= 1.35;
            return consumption;
        }
        
    }
}
