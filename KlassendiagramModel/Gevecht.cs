using System;
using System.Collections.Generic;
using System.Text;

namespace KlassendiagramModel
{
    public class Gevecht
    {
        private bool _persoonGroep1Gewonnen;

        public bool PersoonGroep1Gewonnen
        {
            get { return _persoonGroep1Gewonnen; }
            set
            {
                _persoonGroep1Gewonnen = value;
            }
        } // default value bool == false

        private bool _persoonGroep2Gewonnen;

        public bool PersoonGroep2Gewonnen
        {
            get { return _persoonGroep2Gewonnen; }
            set
            {
                _persoonGroep2Gewonnen = value;
            }
        }

        private Persoon _persoonGroep1;

        public Persoon PersoonGroep1
        {
            get { return _persoonGroep1; }
            set
            {
                _persoonGroep1 = value;
            }
        }
        private Persoon _persoonGroep2;

        public Persoon PersoonGroep2
        {
            get { return _persoonGroep2; }
            set
            {
                _persoonGroep2 = value;
            }
        }

    }
}
