using System;
using System.Collections.Generic;
using System.Text;

namespace interface1
{
    public interface IOnOff // I is always public  but remember to add modifierm but you can also use protected
    {
        public bool Status { get; set; }
        void TurnOn();
        void TurnOff();
    }
}
