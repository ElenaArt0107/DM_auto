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
    /// Interaction logic for AllCarsInfoView.xaml
    /// </summary>
    public partial class AllCarsInfoView : Window
    {
        public ObservableCollection<Brand> Brands { get; set; }
        private readonly IDataService _dataServuce;
        public AllCarsInfoView(IDataService dataService)
        {
            _dataServuce = dataService;
            InitializeComponent();
        }
    }
}
