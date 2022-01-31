using System;
using System.Collections.ObjectModel;
using System.Text;

namespace ArtiushenkoOlenaEindwerkKlassendiagram1
{
    public class Brand
    {
        private string _car;

        public string Car
        {
            get { return _car; }
            set { _car = value; }
        }

        private ObservableCollection<Model> _models = new ObservableCollection<Model>();

        public ObservableCollection<Model> Models
        {
            get { return _models; }
            set { _models = value; }

        }
    }
}
