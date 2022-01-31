using System;
using System.Collections.ObjectModel;
using System.Text;

namespace ArtiushenkoOlenaEindwerkKlassendiagram1
{
    public class Generation : Series
    {
        private string _name;
        public string GenerationName
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _serie;

        public string Serie
        {
            get { return _serie; }
            set { _serie = value; }
        }

        private ObservableCollection<EngineType> _engineTypes = new ObservableCollection<EngineType>();

        public ObservableCollection<EngineType> EngineTypes
        {
            get { return _engineTypes; }
            set { _engineTypes = value; }

        }

        public override string ToString()
        {
            return base.ToString() + $"\n\tGeneration: {GenerationName}";
        }
    }
}
