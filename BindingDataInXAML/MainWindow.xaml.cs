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

namespace BindingDataInXAML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    //   DataContext is een belangrijk deel bij DataBinding

    //    Elke Scherm/View heeft de eigenschap DataContext.

    //    DataContext is van het type object.

    //     Als default is de DataContext null.

    // THE CLASS WHICH IS GOING TO CHANGE ITS PROPERTY SHOULD IMPLEMENT INotifyPropertyChanged

    public partial class MainWindow : Window
    {
        public Person Pers { get; set; } // the property or a new object?
        public MainWindow()
        {
            Pers = new Person()
            {
                Name = "Elena",
                Surname = "Art"
            };
            DataContext = Pers; // once you provide DataContext the Path in not needed anymore as it's the same

            //The DataContext is unchanged.

            //If we want to change the DataContext from our View, WPF will need to be notified with INotifyPropertyChanged.
            // adding only this the info in ftextBlock Will not change as we need an event handler IN WPF Text="{Binding FullName, UpdateSourceTrigger=PropertyChanged}"
            InitializeComponent();

        }

    }
}
