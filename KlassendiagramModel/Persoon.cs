using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KlassendiagramModel
{
    public class Persoon : INotifyPropertyChanged
    {
        private string _naam;
        public string Naam
        {
            get { return _naam; }
            set
            {
                _naam = value;
                RisePropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
