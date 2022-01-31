using System.Windows;

namespace WpfAppBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml WITHOUT DATACONTEXT and no Binding property is used
    /// </summary>
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
            InitializeComponent();
            //NameTxt.Text = Pers.Name; // the name of the textbox and property
            //SurnameTxt.Text = Pers.Surname; //for password box mostly

        }

        private void NameSurname_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            FullNameTxt.Text = $"{NameTxt.Text} {SurnameTxt.Text}";
        }

        private string showInitials()
        {
            return $"{Pers.Name[0]}. {Pers.Surname[0]}.";
        }

        //Our goal now is to remove all code behind and replace it with data Binding in XAML. = > watch next project BindingDataInXAML
    }
}
