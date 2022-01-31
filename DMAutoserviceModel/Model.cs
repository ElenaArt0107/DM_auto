using PropertyChanged;
using System;
using System.Collections.ObjectModel;
using System.Text;

namespace DMAutoserviceModel
{
    [AddINotifyPropertyChangedInterface]
    public class Model
    {
        private string _modelName;

        public string ModelName
        {
            get { return _modelName; }
            set { _modelName = value; }
        }

        private ObservableCollection<Generation> _generations = new ObservableCollection<Generation>();

        public ObservableCollection<Generation> Generations
        {
            get { return _generations; }
            set { _generations = value; }
        }

        private Brand brand;

        public Brand Brand
        {
            get { return brand; }
            set { brand = value; }
        }


        public override string ToString()
        {
            return Brand.ToString() + $"\nModel:\t\t{ModelName}";
        }
    }
}
