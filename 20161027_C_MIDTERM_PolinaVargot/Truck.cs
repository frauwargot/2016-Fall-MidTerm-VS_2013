using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20161027_C_MIDTERM_PolinaVargot
{
    public class Truck:Car
    {
        //=============================================================================================================================
        //3.	Add a class Truck that inherits from Car as well. The Truck should have an additional field: maxTowing  (like: 12000 lbs)
        private int _maxTowing;

        public Truck (string make, string model, int milage, int year, decimal price, string engineSize, 
            int averageMpg, int customerID, int maxTowing):base(make, model, milage, year, price, engineSize, averageMpg, customerID)
        {
            _maxTowing = maxTowing;
        }
        public int MaxTowing
        { get { return _maxTowing; } }
        //====================================end of ex.3=================================================================================
    }
}
