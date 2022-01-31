using System;
using System.Collections.Generic;
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
using System.Collections.ObjectModel;

namespace CollectionsBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml ListView & Buttons WITHOUT DATACONTEXT
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Person> people = new ObservableCollection<Person>();
        public MainWindow()
        {
            people = new ObservableCollection<Person>()
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

           ListViewPeople.ItemsSource = people;
            // further in wpf:
            //DisplayMemberPath eigenschap kunnen we kiezen welke eigenschap van de class Persoon er getoond moet worden
            //hier nog geen Data Binding in onze XAML doen.
//Dit komt later.
        }

        private void btnAddPerson_Click(object sender, RoutedEventArgs e)
        {
            people.Add(new Person
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
                people.Remove(p);
            }
        }

        //Wanneer we een collectie wijzigen moeten we de interface INotifyCollectionChanged implementeren.

        //Gelukkig heeft WPF al een ingebouwde data structuur dat deze interface implementeert > ObservableCollection
        //Er word nog altijd van ons verwacht dat de Persoon class de  INotifyPreprtyChanged interface implementeert.
        //namespase : using System.Collections.ObjectModel;

    }
}
