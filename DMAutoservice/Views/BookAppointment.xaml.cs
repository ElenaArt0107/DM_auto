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
        public EngineType EngineType { get; set; }

        public ObservableCollection<Booking> Bookings { get; set; } = new ObservableCollection<Booking>();
        public Person Customer { get; set; } = new Person();
        public Booking SelectedBooking { get; set; }
        public BookAppointment(IDataService dataService, EngineType engineType)
        {
            _dataService = dataService;
            EngineType = engineType;

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
                    PhoneNumber = Customer.PhoneNumber
                   
                };

                Booking newBooking = _dataService.AddBooking(EngineType, p);
                Bookings.Add(newBooking);

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
            string phoneNumber = Customer.PhoneNumber.ToString();
            if (!int.TryParse(phoneNumber, out int number))
            {
               // MessageBox.Show("The phone number should contain only figures");
            }
            Customer.PhoneNumber = number;
            if (Customer.Email == null || Customer.Name == null || Customer.Surame == null || number == 0)
                {
                    return false;
                }

            return true;
        }

        private void BtnDeleteAnAppointment_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedBooking != null)
            {
                Bookings.Remove(SelectedBooking);
            }
        }

        private void BtnBackToMainView_Click(object sender, RoutedEventArgs e)
        {
            OpenMainView();
            this.Close();
        }

        void OpenMainView()
        {
            MainWindow MainView = new MainWindow(_dataService);
            MainView.Show();
        }
    }
}
