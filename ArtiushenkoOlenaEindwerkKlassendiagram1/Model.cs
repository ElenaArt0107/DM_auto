using System;
using System.Collections.ObjectModel;
using System.Text;

namespace ArtiushenkoOlenaEindwerkKlassendiagram1
{
    public class Model
    {
        private string _brand;

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        private ObservableCollection<Serie> _series = new ObservableCollection<Serie>();

        public ObservableCollection<Serie> Series
        {
            get { return _series; }
            set { _series = value; }

        }
    }
}
