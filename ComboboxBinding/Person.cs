using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ComboboxBinding
{
    /// <summary>
    /// edding INotifyPropertyChanged for binding changes in person's properties
    /// </summary>
    public class Person : INotifyPropertyChanged
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {  
                _name = value;
                RisePropertyChangedThirdOption();
                RisePropertyChangedThirdOption("FullName");
            }
        }
        private string _surname;


        public string Surname
        {
            get { return _surname; }
            set 
            { 
                _surname = value;
                RisePropertyChangedThirdOption(); //not best practice to usse the string instead of reference RisePropertyChangedSecondOption("Surname");
                RisePropertyChangedThirdOption("FullName");
            }
        }

        public string FullName => $"{Name} {Surname}";


        public event PropertyChangedEventHandler PropertyChanged;

        // We moeten ALTIJD een check doen als het event bestaat.

        // Als hij bestaat roepen we het event op

        // Wanneer je meteen je wijziging wilt updaten zet je de eigenschap UpdateSourceTrigger van Binding in Windiw op PropertyChanged

        private void RisePropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
        // 2nd opton: ? is checking if it's not null. invoke rises the method
        private void RisePropertyChangedSecondOption(string propName)
        {
           
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        // not best practice to usse the string instead of reference RisePropertyChangedSecondOption("Surname");
        // thus we use third option with [CallerMemberName]
        //[CallerMemberName]     Door dit attribute voor onze parameter te plaatsen zal hij de naam van de Eigenschap meegeven als argument als er niets word meegegeven.
        private void RisePropertyChangedThirdOption([CallerMemberName] string propName = "")
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }

}
