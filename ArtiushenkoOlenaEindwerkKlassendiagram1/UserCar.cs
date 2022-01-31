using System;
using System.Collections.ObjectModel;
using System.Text;

namespace ArtiushenkoOlenaEindwerkKlassendiagram1
{
    public class Car
    {
        private Person _person;
        public Person Person
        {
            get { return _person; }
            set { _person = value; }
        }

          private ObservableCollection<Brand> _brands = new ObservableCollection<Brand>();

        public ObservableCollection<Brand> Brands
        {
            get { return _brands; }
            set { _brands = value; }
            
        }



    }
}
