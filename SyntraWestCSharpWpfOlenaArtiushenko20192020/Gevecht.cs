using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SyntraWestCSharpWpfOlenaArtiushenko201920201
{
    public class Gevecht : INotifyPropertyChanged
    {
        private bool _persoonGroep1Gewonnen;

        public bool PersoonGroep1Gewonnen
        {
            get { return _persoonGroep1Gewonnen; }
            set
            {
                _persoonGroep1Gewonnen = value;
                RisePropertyChanged();
            }
        } // default value bool == false

        private bool _persoonGroep2Gewonnen;

        public bool PersoonGroep2Gewonnen
        {
            get { return _persoonGroep2Gewonnen; }
            set
            {
                _persoonGroep2Gewonnen = value;
                RisePropertyChanged();
            }
        }

        private Persoon _persoonGroep1;

        public Persoon PersoonGroep1
        {
            get { return _persoonGroep1; }
            set
            {
                _persoonGroep1 = value;
                RisePropertyChanged();
            }
        }
        private Persoon _persoonGroep2;

        public Persoon PersoonGroep2
        {
            get { return _persoonGroep2; }
            set
            {
                _persoonGroep2 = value;
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
