using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20161027_C_MIDTERM_PolinaVargot
{
    public class Car
    {
        //==================================================================================================================================
        //1.	Add a class Car with following fields:
        private string _make;
        private string _model;
        private int _mileage;
        private int _year;
        private decimal _price;
        private string _engineSize; //like 2.4L V4, 3.8L V8
        private int _averageMpg;
        private int _customerID;
        //Add necessary constructor and properties
        //constractor
        public Car (string make, string model, int milage, int year, decimal price, string engineSize, int averageMpg, int customerID)
        {
            _make = make;
            _model = model;
            _mileage = milage;
            _year = year;
            _price = price;
            _engineSize = engineSize;
            _averageMpg = averageMpg;
            _customerID = customerID;
        }
        //properties
        public string Make
        { get { return _make; } }
        
        public string Model
        { get { return _model; } }

        public int Milage
        { get { return _mileage; } }

        public int Year
        { get { return _year; } }

        public decimal Price
        { get { return _price; } }

        public string EngineSize
        { get { return _engineSize; } }

        public int AverageMpg
        { get { return _averageMpg; } }

        public int CustomerID
        { get { return _customerID; } }

        //Add a method ‘LowerPriceBy(decimal percent), where percent is a number in the form of x%, like 2%, 3.5% and so on.      
        //Formula is _price -= percent*price/100;
        public void LowerPriceBy(decimal percent)
        {
            _price -= percent*_price/100;
        }
        //===================================end of ex.1==========================================================
    }
}
