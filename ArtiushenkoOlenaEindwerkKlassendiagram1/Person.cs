using System;
using System.Collections.ObjectModel;


namespace ArtiushenkoOlenaEindwerkKlassendiagram1
{
    public class Person
    {
        private string _name;
        private string _surname;
        private string _email;
        private int _phoneNumber;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surame
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public string Fullname => $"{Name} {Surame}";
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        private ObservableCollection<Car> _cars = new ObservableCollection<Car>();

        public ObservableCollection<Car> Cars
        {
            get { return _cars; }
            set { _cars = value; }

        }


    }
}
