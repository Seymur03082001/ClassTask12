using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11.Models
{
    internal class Bicycle :Vehicle
    {
        public string _pedalKind;

        
        public string PedalKind
        {
            get => _pedalKind;
            set { 
                if(value == null)
                {
                    _pedalKind = value;
                }
                else
                {
                    Console.WriteLine("Wrong");
                }
            }
        }

    }
}
