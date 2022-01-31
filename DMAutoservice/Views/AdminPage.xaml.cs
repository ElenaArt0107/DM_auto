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
    public partial class AdminPage : Window
    {
        public Brand NewBrand { get; set; } = new Brand();
        public Model NewModel { get; set; } = new Model();
        public Generation NewGeneration { get; set; } = new Generation();
        public EngineType NewEngineType { get; set; } = new EngineType();
        public TuningSpecification NewTuningSpecification { get; set; } = new TuningSpecification();


        private readonly IDataService _dataService;
        public AdminPage(IDataService dataServise)
        {
            _dataService = dataServise;

            InitializeComponent();

            DataContext = this;
        }

        // i need a previous list
        // i need to have a new list to put the new in  
        // new IDnumber
        //put info in a tableview to all available cars
        private void AddSpecifications_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(NewBrand.BrandName) || string.IsNullOrWhiteSpace(NewModel.ModelName) || string.IsNullOrWhiteSpace(NewGeneration.GenerationName) ||
                string.IsNullOrWhiteSpace(NewEngineType.TypeEngine) || NewEngineType.PowerStandard == 0 || NewEngineType.TorqueStandard == 0 || NewEngineType.Fuel == null)
            {
                MessageBox.Show("Please fill in all necessary fields"); //  with asterics
                return;
            }
            else
            {
                _dataService.AddBrand(NewBrand, NewModel);
                _dataService.AddModel(NewModel, NewGeneration);
                _dataService.AddGeneration(NewGeneration, NewEngineType);
                _dataService.AddEngineType(NewEngineType, NewGeneration);
                _dataService.AddTuningSpecification(NewTuningSpecification, NewEngineType);

                MessageBox.Show($"New spesification for {NewBrand.BrandName} has been successfully added");
                //OpenAllCarsInfoView();
            }
            OpenMainView();
            this.Close();
        }

        //void OpenAllCarsInfoView()
        //{
        //    AllCarsInfoView AllCarsInfo = new AllCarsInfoView(_dataService);

        //    AllCarsInfo.Show();

        //}

        void OpenMainView()
        {
            MainWindow MainView = new MainWindow(_dataService);

            MainView.Show();
        }
    }
}
