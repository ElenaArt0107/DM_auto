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
using System.Windows.Shapes;
using DMAutoserviceModel;
using PropertyChanged;

namespace DMAutoservice.Views
{
    [AddINotifyPropertyChangedInterface]
    /// <summary>
    /// Interaction logic for BookAppointment.xaml
    /// </summary>
    public partial class BookAppointment : Window
    {
        private readonly IDataService _dataService;

        public ObservableCollection<Person> Customers { get; set; } = new ObservableCollection<Person>();
        public Person Customer { get; set; } = new Person();
        public Person SelectedPerson { get; set; }
        public BookAppointment(IDataService dataService)
        {
            _dataService = dataService;
            InitializeComponent();
            DataContext = this;
        }

        private void BtnAddAppointment_Click(object sender, RoutedEventArgs e)
        {
            if (!IsFilledIn())
            {
                MessageBox.Show("Please fill the information in");
            }

            else
            {
                Person p = new Person
                {
                    Email = Customer.Email,
                    Name = Customer.Name,
                    Surame = Customer.Surame,
                    PhoneNumber = Customer.PhoneNumber,
                };

                Customers.Add(p);
                ClearBlank();
            }
        }

        private void ClearBlank()
        {
            Customer.Email = "";
            Customer.Name = "";
            Customer.Surame = "";
            Customer.PhoneNumber = 0;
        }

        private bool IsFilledIn()
        {
            if (Customer.Email == null || Customer.Name == null || Customer.Surame == null || Customer.PhoneNumber == 0) // || Customer.PhoneNumber == null
            {
                return false;
            }
            return true;
        }

        private void BtnDeleteAnAppointment_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedPerson != null)
            {
                Customers.Remove(SelectedPerson);
            }
        }
    }
}
