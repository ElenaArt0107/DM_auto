using System;
using System.Collections.Generic;
using System.Text;

namespace OnOffInterface
{
    public interface IOnOff1
    {
        public bool Status { get; set; }
        void TurnOn();
        void TurnOff();
    }
}
