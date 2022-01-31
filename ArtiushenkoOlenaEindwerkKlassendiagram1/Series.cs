using System;
using System.Collections.ObjectModel;
using System.Text;

namespace ArtiushenkoOlenaEindwerkKlassendiagram1
{
    public class Serie
    {
        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private ObservableCollection<Generation> _generations = new ObservableCollection<Generation>();

        public ObservableCollection<Generation> Generations
        {
            get { return _generations; }
            set { _generations = value; }

        }
    }
}
