using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DMAutoserviceModel
{
    [AddINotifyPropertyChangedInterface]

    public class EngineType 
    {
        public ObservableCollection<Booking> Bookings { get; set; } = new ObservableCollection<Booking>();

        private Generation _generationType;
        public Generation GenerationType
        {
            get { return _generationType; }
            set { _generationType = value; }
        }

        private string _engineType;

        public string TypeEngine
        {
            get { return _engineType; }
            set { _engineType = value; }
        }
        private int _powerStandard;

        public int PowerStandard
        {
            get { return _powerStandard; }
            set { _powerStandard = value; }
        }
        private int _powerAfterTuning;

        public int PowerAfterTuning
        {
            get { return _powerAfterTuning; }
            set { _powerAfterTuning = value; }
        }

        public int PowerDifference => PowerAfterTuning - PowerStandard;


        private int _torqueStandard;

        public int TorqueStandard
        {
            get { return _torqueStandard; }
            set { _torqueStandard = value; }
        }
        private int _torqueAfterTuning;

        public int TorqueAfterTuning
        {
            get { return _torqueAfterTuning; }
            set { _torqueAfterTuning = value; }
        }

        public int TorqueDifference => TorqueAfterTuning - TorqueStandard;
      

        private string _fuel;

        public string Fuel
        {
            get { return _fuel; }
            set { _fuel = value; }
        }

        private TuningSpecification _tuningSpecifications;

        public TuningSpecification SpecificationTuning
        {
            get { return _tuningSpecifications; }
            set { _tuningSpecifications = value; }
        }

        public override string ToString()
        {
            return GenerationType.ToString() + $"\nType of Engine:\t{TypeEngine}";
        }


    }
}
