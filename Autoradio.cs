using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_OOP
{
    internal class Autoradio
    {
        public double NaladenyKmitocet { get; private set; }
        public bool Zapnuto { get; set; }
        private Dictionary<int, double> Kanaly = new Dictionary<int, double>();
        public void NastavPredvolbu(int cislo, double kmitocet)
        {
            Kanaly.Add(cislo, kmitocet);
        }
        public void PreladPredvolbu(int cislo)
        {
            NaladenyKmitocet = Kanaly[cislo];
        }
        public override string ToString()
        {
            return string.Format("Kmitocet {0}, Zapnuto: {1}",NaladenyKmitocet,Zapnuto);
        }

    }
}
