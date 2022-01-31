using System;
using System.Collections.ObjectModel;
using System.Text;

namespace DMAutoserviceModel
{
    public class UserCar
    {
        private ObservableCollection<Person> _people = new ObservableCollection<Person>();

        public ObservableCollection<Person> People
        {
            get { return _people; }
            set { _people = value; }

        }

        private ObservableCollection<Brand> _brands = new ObservableCollection<Brand>();

        public ObservableCollection<Brand> Brands
        {
            get { return _brands; }
            set { _brands = value; }
            
        }

        private int _nextNum;

        public int NextNumber
        {
            get { return _nextNum; }
            set { _nextNum = value; }
        }
        public Options ExtraOptions { get; set; }

    }
}
