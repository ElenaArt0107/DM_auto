using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SyntraWestCSharpWpfOlenaArtiushenko201920201
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Persoon> Scientists;

        public ObservableCollection<Persoon> Artists;

        public ObservableCollection<Gevecht> Fights = new ObservableCollection<Gevecht>();

        private MainWindowViewModel mainWindowData = new MainWindowViewModel();

        public MainWindow()
        {
            InitializeComponent();

            Vs.Text = "VS";

            Scientists = new ObservableCollection<Persoon>{
                new Persoon { Naam = "Sikorskii" },
                new Persoon { Naam = "Paton" },
                new Persoon { Naam = "Korolev" }};

            //Scientist.ItemsSource = Scientists;
            //Scientist.DisplayMemberPath = "Naam";
            //Scientist.SelectedItem = Scientists[0];

            Artists = new ObservableCollection<Persoon>{
                new Persoon { Naam = "Bilokur" },
                new Persoon { Naam = "Aivazovskii" },
                new Persoon { Naam = "Soshenko" }};

            //Artist.ItemsSource = Artists;
            //Artist.DisplayMemberPath = "Naam";

            mainWindowData.Scientists = Scientists;
            mainWindowData.Artists = Artists;
            mainWindowData.Fights = Fights;

            DataContext = mainWindowData;
        }

        private Persoon _selectedScientist;
        private Persoon _selectedArtist;

        private void Scientist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _selectedScientist = (Persoon)e.AddedItems[0];
            Vs.Text = $"{_selectedScientist.Naam} VS {_selectedArtist?.Naam}";
        }

        private void Artist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _selectedArtist = (Persoon)e.AddedItems[0];
            Vs.Text = $"{_selectedScientist?.Naam} VS {_selectedArtist.Naam}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            int rand = r.Next(0, 2);

            Fights.Add(new Gevecht
            {
                PersoonGroep1 = _selectedScientist,
                PersoonGroep2 = _selectedArtist,
            });

            switch (rand)
            {
                case 0:
                    Fights.Last().PersoonGroep1Gewonnen = true;
                    break;
                case 1:
                    Fights.Last().PersoonGroep2Gewonnen = true;
                    break;
            }

        }
    }
}
