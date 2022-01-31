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
using DMAutoservice.Views;
using PropertyChanged;

namespace DMAutoserviceModel
{
    [AddINotifyPropertyChangedInterface]
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Properties
        public ObservableCollection<Brand> Brands { get; set; }
        public ObservableCollection<Model> Models { get; set; }
        public ObservableCollection<Generation> Generations { get; set; }
        public ObservableCollection<EngineType> EngineTypes { get; set; }
        public TuningSpecification TuningSpec { get; set; }
        public EngineType TypeOfEngine { get; set; }
        public ObservableCollection<Options> ExtraOptions { get; set; }
        public TuningSpecification SpecificationOfTuning { get; set; }

        private Brand _selectedBrand;

        public Brand SelectedBrand
        {
            get { return _selectedBrand; }
            set
            {
                _selectedBrand = value;
                if (SelectedBrand != null)
                {
                    Models = SelectedBrand.Models;
                }
            }
        }
        private Model _selectedModel;

        public Model SelectedModel
        {
            get { return _selectedModel; }
            set 
            {
                _selectedModel = value;
                if (SelectedModel != null && SelectedBrand != null)
                {
                    Generations = SelectedModel.Generations;
                } 
            }
        }


        private Generation _selectedGeneration;

        public Generation SelectedGeneration
        {
            get { return _selectedGeneration; }
            set
            {
                _selectedGeneration = value;
                if (SelectedGeneration != null && SelectedModel != null && SelectedBrand != null)
                {
                    EngineTypes = SelectedGeneration.EngineTypes;
                }
            }
        }


        private EngineType _selectedEngineType;

        public EngineType SelectedEngineType
        {
            get { return _selectedEngineType; }
            set
            {
                _selectedEngineType = value;
                if (SelectedEngineType != null && SelectedGeneration != null && SelectedModel != null && SelectedBrand != null)
                {
                    TuningSpec = SelectedEngineType.SpecificationTuning;
                   // TypeOfEngine = SelectedEngineType;
                }
            }
        }

        public string Info { get; set; }
        #endregion

        private readonly IDataService _dataService;

        public MainWindow()
        {
            _dataService = new DataService();

            InitializeComponent();
            InitializeModel();

            DataContext = this;
        }

        private void InitializeModel()
        {
            Brands = _dataService.GetAllBrands();
            ExtraOptions = _dataService.GetAllOptionsOfEngineTypeTuning();
        }

        public MainWindow(IDataService dataServise)
        {
            _dataService = dataServise;

            InitializeComponent();
            InitializeModel();

            DataContext = this;
        }

        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            if (!CanProvideInfo())
            {
                MessageBox.Show("Choose all specifications please");
                return;
            }

            Info = SelectedEngineType.ToString();
            TypeOfEngine = SelectedEngineType;
            SpecificationOfTuning = SelectedEngineType.SpecificationTuning;
            CleanSelection();
        }

        private bool CanProvideInfo()
        {
            if (SelectedBrand == null || SelectedModel == null || SelectedGeneration == null || SelectedEngineType == null)
            {
                return false;
            }
            return true;
        }

        private void CleanSelection()
        {
            SelectedBrand = null;
            SelectedModel = null;
            SelectedGeneration = null;
            SelectedEngineType = null;
        }

        private void BookTimeButton_Click(object sender, RoutedEventArgs e)
        {
            OpenBookAppointmentView();
        }

        private void OpenBookAppointmentView()
        {
            BookAppointment BookAppointmentView = new BookAppointment(_dataService, TypeOfEngine);

            this.Close();
            BookAppointmentView.Show();
        }

        private void LogInAdmin_Click(object sender, RoutedEventArgs e)
        {
            OpenLogInView();
        }

        private void OpenLogInView()
        {
            LogInView AdminLogInView = new LogInView(_dataService);

            this.Close();
            AdminLogInView.Show();
        }
    }
}
