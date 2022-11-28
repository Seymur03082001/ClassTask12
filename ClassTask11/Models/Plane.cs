using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11.Models
{
    internal class Plane : Vehicle
    {
        public double _wingLength;

        
        public double WingLength
        {
            get => _wingLength;
            set { 
            if(value > 0)
                {
                    _wingLength = value;
                }
            }
        }

    }
}
