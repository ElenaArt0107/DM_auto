using System;
using System.Collections.Generic;
using System.Text;

namespace OnOffInterface
{
    public class Marker : IWriteCapitals, IOnOff1
    {
        public ConsoleColor ColourW { get; set; }
        public bool Status { get; set; }
        public Marker(ConsoleColor colorW)
        {
            this.ColourW = colorW;
        }


        public void TurnOff()
        {
            Status = true;
        }

        public void TurnOn()
        {
            Status = false;
        }

        public void Write(string text)
        {
            Console.ForegroundColor = ColourW;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray; //to return colour into default
        }

        public override string ToString()
        {
            return $"Marker:\n\tColour: {ColourW}\n\tStatus: {Status}"; 
        }

        public void WriteInUpperCase(string text)
        {
            Write(text.ToUpper()); 
            // use the method of interface IWriteCapitals which implements Interface IAbleToWrite
        } 
    }
}
