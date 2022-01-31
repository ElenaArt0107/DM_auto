using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BindingCollectionsXAML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Als we de lijst van personen via XAML willen binden, hebben we de DataContext nodig.

    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel mainWindowData = new MainWindowViewModel();
        private ObservableCollection<Person> _people;

        public MainWindow()
        {
            _people = new ObservableCollection<Person>()
            {
                new Person()
                {
                    Name = "Elena",
                    Surname = "Art"
                },
                new Person()
                {
                    Name = "Dimi",
                    Surname = "Nel"
                },
                new Person()
                {
                    Name = "Innika",
                    Surname = "Art"
                }
            };
            InitializeComponent();
            //ListViewPeople.ItemsSource = people;
            //            Een ItemSource moet een Lijst als input krijgen.
            //            De DataContext IS een Lijst van Personen
            // in wpf : DisplayMemberPath="FullName" ItemsSource="{Binding}"
            // We gaan de lijst wrappen in een apparte class.
            // Binding in the wpf changed onto property of the mainWindowVieaModel 
            // DisplayMemberPath="FullName" ItemsSource="{Binding}" ==> DisplayMemberPath="FullName" ItemsSource="{Binding People}"
           // Wanneer een ItemsControl een ItemsSource heeft, zal er doorheen elke entry in de lijst geloopt worden, 
            //De DisplayMemberPath zal gebruikt worden als display.

            mainWindowData.People = _people;
            DataContext = mainWindowData;
            //ComboBoxPeople.ItemsSource = people;  <= not needed anymore; for combobox enough to edit ItemSourse, adding the same list
        }

        private void btnAddPerson_Click(object sender, RoutedEventArgs e)
        {
            _people.Add(new Person
            {
                Name = "Leo",
                Surname = "Pold"
            });
        }

        private void btnChangePerson_Click(object sender, RoutedEventArgs e)
        {
            if (ListViewPeople.SelectedItem is Person person)
            {
                person.Name = "Random Name";
                person.Surname = "Random Lastname";
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

    
    }
}
