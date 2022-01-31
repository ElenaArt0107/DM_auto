using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppBinding
{
    public class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _surname;

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public string FullName => $"{Name} {Surname}";
    }
}
