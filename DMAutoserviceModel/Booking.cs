using PropertyChanged;
using System;
using System.Collections.ObjectModel;
using System.Text;

namespace DMAutoserviceModel
{
    [AddINotifyPropertyChangedInterface]
    public class Booking
    {
        public Person Person { get; set; }
        public EngineType EngineType { get; set; }

        private int _nextNum;

        public int NextNumbers
        {
            get { return _nextNum; }
            set { _nextNum = value; }
        }
        public Options ExtraOptions { get; set; }

    }
}
