using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace WpfAppLes1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // tp create a reference to the wpf

            // give the name to the box in wpf we want to reference to
            // x:Name = "NameTextBox" = the correct space name

            string defaultName = "write here";
            NameTextBox.Text = defaultName;
            //ShowPopUpWithName();
        }
        // a reference for a button EVENTS
        // give the button a name:  x:Name="PushIt"
        // crete a void function with an e.g. MessageBox.Show() in it
        //public void ShowPopUpWithName()
        //{
        //    MessageBox.Show(NameTextBox.Text);
        //}
        //THE CODE ABOVE CAN NOT BE USED AS AN EVENT HANDLER 
        //WE NEED TO ADD 2 ARGUMENTS: object sender, RoutedEventArgs e
        private void ShowPopUpWithName(object sender, RoutedEventArgs args)
        {
            MessageBox.Show(NameTextBox.Text);
        }
        // the lightnening icon in Properties in wpf 
        //corresponds with the EVENTS
        // e.g. Click for Button 
        // put the code in wpf : Click="ShowPopUpWithName" (with a name of the method)
    }
}
