using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BindingCollectionsXAML
{
    public class MainWindowViewModel 
    {
        // We maken de lijst van personen aan. 
        //We kennen de lijst toe aan mainWindow (mainWindowData).
        //Daarna kennen we mainWindow (mainWindowData) toe aan de DataContext.

        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>(); //it's a property so you should add the  { get; set; }


        //        Wanneer we een persoon selecteren wordt deze proper in de GeselecteerdePersoon eigenschap gestopt.

        //          Maar Waarom zien we de naam van de persoon niet verschijnen?

        //Dit komt omdat omdat we INotifyPropertyChanged niet implementeren in MainWindowViewModel
        // we need INotifyPropertyChanged as the properties of this class would be changed
        // the check on if there's any listener is obligatory
        // we need additonal property of the class wich is going to be changed with a rise of PropertyChange method in the setter

    }
}
