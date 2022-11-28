using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11.Models
{
    internal class Car : Vehicle
    {
        public byte _doorCount;

        public byte DoorCount
        {
            get => _doorCount;
            set {
            if(value > 0)
                {
                    _doorCount = value;
                }
                else
                {
                    Console.WriteLine("Wrong");
                }
            }
        }

    }
}
