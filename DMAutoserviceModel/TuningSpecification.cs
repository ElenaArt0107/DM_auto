using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DMAutoserviceModel
{
    [AddINotifyPropertyChangedInterface]

    public class TuningSpecification
    {
        private string _boreXStroke;

        public string BoreXStroke
        {
            get { return _boreXStroke; }
            set { _boreXStroke = value; }
        }
        private string  _compresionRatio;

        public string CompresionRatio
        {
            get { return _compresionRatio; }
            set { _compresionRatio = value; }
        }
        private string _cylinderCapacity;

        public string CylinderCapacity
        {
            get { return _cylinderCapacity; }
            set { _cylinderCapacity = value; }
        }
        private string _ecuType;

        public string EcuType
        {
            get { return _ecuType; }
            set { _ecuType = value; }
        }
        private string _engineNumber;

        public string EngineNumber
        {
            get { return _engineNumber; }
            set { _engineNumber = value; }
        }
        private EngineType _typeEngin;

        public EngineType TypeEngin
        {
            get { return _typeEngin; }
            set { _typeEngin = value; }
        }


    }
}
