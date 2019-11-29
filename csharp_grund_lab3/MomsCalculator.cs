using System;
using System.Text.RegularExpressions;

namespace csharp_grund_lab3
{
    public class MomsCalculator
    {
        private double moms;

        public double Belopp { get; set; }

        public double Moms
        {
            get { return moms; }
            set { moms = value / 100; }
        }

        public double UtraknadMoms()
        {
            return Belopp * Moms;
        }

        public double UtraknatBelopp()
        {
            return Belopp - UtraknadMoms();
        }
    }
}
