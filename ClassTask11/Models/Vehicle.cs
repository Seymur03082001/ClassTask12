using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11
{
    internal abstract class Vehicle
    {
        public int _drivePath;
        public int _driveTime;
        
        
        public int DrivePath
        {
            get => _drivePath;
            set 
            { 
            if(value > 0)
                {
                    _drivePath = value;
                }
            }
        }

        public int DriveTime
        {
            get => _driveTime;
            set 
            { 
            if(value > 0)
                {
                    _driveTime = value;
                }
            }
        }
       
        internal abstract void AverageSpeed()
        {
            Console.WriteLine(DrivePath / DriveTime);
        };


    }
}
