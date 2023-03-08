using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_OOP
{
    internal class Nakladni : Auto
    {
        public Nakladni(TypPaliva typPaliva, int maxOsob = 1, double maxNaklad = 10000, double velikostNadrze = 1000, int prepravovaneOsoby = 0, double prepravovanyNaklad = 0, double stavNadrze = 0)
        {
            Palivo = typPaliva;
            MaxOsob = maxOsob;
            VelikostNadrze = velikostNadrze;
            MaxNaklad = maxNaklad;
            PrepravovaneOsoby = prepravovaneOsoby;
            PrepravovanyNaklad = prepravovanyNaklad;
            StavNadrze = stavNadrze;
        }
        public override string ToString()
        {
            return string.Format("Nakladni auto {0}, osob {1}, naklad {2} kg, palivo {3} l",Palivo.ToString(), PrepravovaneOsoby, PrepravovanyNaklad, StavNadrze);
        }
    }
}
