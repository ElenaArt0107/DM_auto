using System;
using System.Collections.ObjectModel;
using System.Text;

namespace DMAutoserviceModel
{
    public class Generation
    {
        private string _name;
        public string GenerationName
        {
            get { return _name; }
            set { _name = value; }
        }
        private Model _modelType;

        public Model ModelType
        {
            get { return _modelType; }
            set { _modelType = value; }
        }

        private ObservableCollection<EngineType> _engineTypes = new ObservableCollection<EngineType>();

        public ObservableCollection<EngineType> EngineTypes
        {
            get { return _engineTypes; }
            set { _engineTypes = value; }

        }

        public override string ToString()
        {
            return ModelType.ToString() + $"\nGeneration:\t{GenerationName}";
        }

    }
}
