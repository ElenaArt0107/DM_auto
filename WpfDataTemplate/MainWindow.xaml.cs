using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace WpfDataTemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Een data template is een flexibele oplossing om complexere UI voor elke data item te voorzien.
    ///     We kunnen foto’s gebruiken, zelfs wpf controls zoals checkboxes.
    /// </summary>
    public partial class MainWindow : Window
    {
        // in WPF De ItemTemplate laat ons toe om een DataTemplate te maken

        private MainWindowViewModel mainWindowData = new MainWindowViewModel();
        private ObservableCollection<Person> _people;

        public MainWindow()
        {
            _people = new ObservableCollection<Person>()
            {
                new Person()
                {
                    Name = "Elena",
                    Surname = "Art",
                    IsMarried = false
                },
                new Person()
                {
                    Name = "Dimi",
                    Surname = "Nel",
                 IsMarried = false
        },
                new Person()
                {
                    Name = "Innika",
                    Surname = "Art",
                     IsMarried = true
        }
            };
            InitializeComponent();
            mainWindowData.People = _people;
            DataContext = mainWindowData;
        }

        private void btnAddPerson_Click(object sender, RoutedEventArgs e)
        {
            _people.Add(new Person
            {
                Name = "Leo",
                Surname = "Pold",
                IsMarried = true
            });
        }

        private void btnChangePerson_Click(object sender, RoutedEventArgs e)
        {
            if (ListViewPeople.SelectedItem is Person person)
            {
                person.Name = "Random Name";
                person.Surname = "Random Lastname";
                person.IsMarried = false;
            }
        }

        private void btnDeletePerson_Click(object sender, RoutedEventArgs e)
        {
            if (ListViewPeople.SelectedItem is Person p)
            {
                _people.Remove(p);
            }
        }

        //Wanneer we een collectie wijzigen moeten we de interface INotifyCollectionChanged implementeren.

        //Gelukkig heeft WPF al een ingebouwde data structuur dat deze interface implementeert > ObservableCollection
        //Er word nog altijd van ons verwacht dat de Persoon class de  INotifyPreprtyChanged interface implementeert.
        //namespase : using System.Collections.ObjectModel;


        /////////////Adding the textblock in the right with a selected person////////////////////////////
        //        Doordat GeselecteerdePersoon een Persoon is, kunnen we alle eigenschappen van Persoon gebruiken.

        //        Initieel is GeselecteerdePersoon NULL, dit is geen probleem WPF zorgt ervoor dat er geen NullReferenceException gesmeten word.


        // NOT a good practice to use ithe follozing code , it always better to use in WPF SelectedItem="{Binding SelectedPerson}" 
        // instead of SelectionChanged="ListViewPeople_SelectionChanged"
        private void ListViewPeople_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                mainWindowData.SelectedPerson = e.AddedItems[0] as Person;
            }
            catch
            {
            }
        }

        // adding to the listView SelectionChanged = "ListViewPeople_SelectionChanged"
    }
}
