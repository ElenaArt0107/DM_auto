using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfDataTemplate
{
    /// <summary>
    /// Creating a Data template
    /// </summary>
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        // We maken de lijst van personen aan. 
        //We kennen de lijst toe aan mainWindow (mainWindowData).
        //Daarna kennen we mainWindow (mainWindowData) toe aan de DataContext.
        // we need INotifyPropertyChanged as the properties of this class would be changed
        // the check on if there's any listener is obligatory
        // we need additonal property of the class wich is going to be changed with a rise of PropertyChange method in the setter

        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();

        ///////////////////////////////Other posibilities in  MainWindowViewModel////////////////////////////
        //Volgende functionaliteit zullen we voorzien.

        //Wanneer een persoon geselecteerd is in de listview verschijnt de geslecteerde persoon aan de rechterkant van ons scherm
        // need to implement INotifyPropertyChanged
        // add the new 'selected person' object and rise the event handler there


        //        de ListViewPeople_SelectionChanged EventHandler zorgt ervoor dat SelectedPerson toegekend word aan mainWindowData en dus ook de DataContext.

        //Wanneer we een persoon selecteren word onze TextBlock niet opgevuld.

        //Laten we debuggen en kijken wat er in onze DataContext zit.

        public event PropertyChangedEventHandler PropertyChanged;
        private Person _selectedPerson;

        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                _selectedPerson = value;
                RisePropertyChanged();
            }
        }

        public void RisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
