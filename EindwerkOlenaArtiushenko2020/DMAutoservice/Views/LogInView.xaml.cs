using DMAutoserviceModel;
using PropertyChanged;
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

namespace DMAutoservice.Views
{
    [AddINotifyPropertyChangedInterface]
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class LogInView : Window
    {
        public Login Log { get; set; }
        public ObservableCollection<Login> Logins { get; set; }
        //public string LogName { get; set; }
        //public string Pass { get; set; }

        private readonly IDataService _dataService;
        public LogInView(IDataService dataServise)
        {
            _dataService = dataServise;

            InitializeModel();
            InitializeComponent();


            DataContext = this;
        }
        void InitializeModel()
        {
            Logins = _dataService.GetAllLogins();
        }

        private void LogInAdmin_Click(object sender, RoutedEventArgs e)
        {

            if (_dataService.CheckCredentials(Log.LoginName, Log.Password))
            {
                Log = _dataService.Login(Log.LoginName);
                OpenAdminPageView();
            }
            else
            {
                //ErrorMessage.Visibility = Visibility.Visible;
                MessageBox.Show("Loging or password is incorrect.\nPlease try again.");
                CleanCredentialFields();
            }
            CleanCredentialFields();
        }
        void CleanCredentialFields()
        {
            Log.LoginName = "";
            Log.Password = "";
        }

        private void OpenAdminPageView()
        {
            AdminPage AdminPageView = new AdminPage(_dataService);

            this.Close();
            AdminPageView.Show();
        }
    }
}
