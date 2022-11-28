using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11.Models
{
    internal class IEngine_interface
    {
        public int _oilCapacity;
        public int _currentOil;
        public string _fueltype;

        
        public int OilCapacity
        {
            get => _oilCapacity;
            set { _oilCapacity = value; }
        }

        
        public int CurrentOil
        {
            get => _currentOil;
            set { _currentOil = value; }
        }
       
        public string FuelType
        {
            get => _fueltype;
            set { _fueltype = value; }
        }

        internal abstract void RemainOilAmount()
        {
            Console.WriteLine();
        }

    }
}
