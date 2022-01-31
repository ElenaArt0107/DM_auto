using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SyntraWestCSharpWpfOlenaArtiushenko201920201
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Persoon> Scientists { get; set; }
            = new ObservableCollection<Persoon>();
        public ObservableCollection<Persoon> Artists { get; set; }
            = new ObservableCollection<Persoon>();
        public ObservableCollection<Gevecht> Fights { get; set; }
            = new ObservableCollection<Gevecht>();

        private Gevecht _currentFight;

        public Gevecht ChangedFight
        {
            get { return _currentFight; }
            set
            {
                _currentFight = value;
                RisePropertyChanged();
            }
        }

        private void RisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}