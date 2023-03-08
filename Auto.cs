using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cars_OOP
{
    internal abstract class Auto
    {
        private Autoradio Radio = new Autoradio();
        public Autoradio AutoRadio { get { return Radio; }}
        public enum TypPaliva { Benzin, Nafta };
        //Parameters cant change from outside, are constant for a given vehicle
        //Also both 'MaxOsob' & 'MaxNaklad' are valid parameters for both cars and trucks ?
        public TypPaliva Palivo { get; protected set; }
        public int MaxOsob { get; protected set; }
        public double MaxNaklad { get; protected set; }
        public double VelikostNadrze { get; protected set; }
        //Has to be changed from 'Natankuj', or on construction
        public double StavNadrze { get; protected set; }
        //Methods 'Nastup/Naloz' weren't specified, thus values are set through setters
        private int Osob;
        public int PrepravovaneOsoby
        {
            get
            {
                return Osob;
            }
            set
            {
                if (value > MaxOsob)
                    throw new ArgumentException("You were arrested for transporting refugees!");
                Osob = value;
            }
        }
        private double Naklad;
        public double PrepravovanyNaklad
        {
            get
            {
                return Naklad;
            }
            set
            {
                if (value > MaxNaklad)
                    throw new ArgumentException("You were arrested for transporting drugs!");
                Naklad = value;
            }
        }

        public void Natankuj(TypPaliva typPaliva, double mnozstvi = 0)
        {
            if (typPaliva != Palivo)
                throw new Exception("You've just ruined motor in your vehicle!");
            double total = StavNadrze + mnozstvi;
            if (total > VelikostNadrze)
                throw new Exception("Your gas tank had overflown and your vehicle caught on fire!");
            StavNadrze = total;
        }
        public override string ToString()
        {
            return "This is only base abstract class !";
        }
    }
}
