using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20161027_C_MIDTERM_PolinaVargot
{
    public class SportCar:Car
    {
        //===========================================================================================================================
        //2.	Add a class SportCar that inherits from Car. The SportCar should have an additional field: _zeroToSixty  (in seconds)
        private int _zeroToSixty;
        public SportCar (string make, string model, int milage, int year, decimal price, string engineSize, 
            int averageMpg, int customerID, int zeroToSixty):base(make, model, milage, year, price, engineSize, averageMpg, customerID)
        {
            _zeroToSixty = zeroToSixty;
        }
        public int ZeroToSixty
        { get { return _zeroToSixty; } }
        //=================================================end of ex.2===============================================================
    }
}
