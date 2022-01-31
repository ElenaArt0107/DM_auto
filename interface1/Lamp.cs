using System;
using System.Collections.Generic;
using System.Text;

namespace interface1
{
    public class Lamp : IOnOff
    {
        public bool Status { get ; set; }

        public void TurnOff()
        {
            Console.WriteLine("Lamp on");

        }

        public void TurnOn()
        {
            Console.WriteLine("Lamp off");

        }

        public override string ToString()
        {
            return $"Lamp:\n\tStatus:{Status}";
        }
    }
}
