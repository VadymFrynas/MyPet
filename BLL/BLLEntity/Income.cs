using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Income
    {
        string IncomeName;
        double IncomeCash;

        public string _IncomeName { get => IncomeName; set => IncomeName = value; }
        public double _IncomeCash { get => IncomeCash; set => IncomeCash = value; }
        public Income(string IncomeName, double IncomeCash)
        {
            this.IncomeCash = IncomeCash;
            this.IncomeName = IncomeName;
        }
        public Income()
        {
            IncomeCash = default;
            IncomeName = default;
        }
        public override string ToString()
        {
            return $"{IncomeName}:\t+{IncomeCash} uan.\n";
        }
    }
}
