using PropertyChanged;
using System;
using System.Collections.ObjectModel;


namespace DMAutoserviceModel
{
    [AddINotifyPropertyChangedInterface]
    public class Person
    {
        private string _name;
        private string _surname;
        private string _email;
        private int _phoneNumber;

        private Login _log;

        public Login Log
        {
            get { return _log; }
            set { _log = value; }
        }

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
        public string PersonalData => $"{Email} {PhoneNumber}";


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
        private ObservableCollection<UserCar> _cars = new ObservableCollection<UserCar>();

        public ObservableCollection<UserCar> Cars
        {
            get { return _cars; }
            set { _cars = value; }

        }

    }
}
