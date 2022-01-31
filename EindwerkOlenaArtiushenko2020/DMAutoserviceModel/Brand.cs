using System;
using System.Collections.ObjectModel;
using System.Text;

namespace DMAutoserviceModel
{
    public class Brand
    {
        private string _brandName;

        public string BrandName
        {
            get { return _brandName; }
            set { _brandName = value; }
        }

        private ObservableCollection<Model> _models = new ObservableCollection<Model>();

        public ObservableCollection<Model> Models
        {
            get { return _models; }
            set { _models = value; }

        }

        public override string ToString()
        {
            return $"Brand:\t\t{BrandName}";
        }
    }
}
