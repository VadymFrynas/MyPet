using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Income
    {
        string incomeName;
        double incomeCash;
        DateTime dateTime;
        public string IncomeName { get => incomeName;  }
        public double IncomeCash { get => incomeCash; }
        public DateTime DataTime { get => dateTime; }
        public Income(string incomeName, double incomeCash,DateTime dateTime)
        {
            this.dateTime = dateTime;
            this.incomeCash = incomeCash;
            this.incomeName = incomeName;
        }
        public Income() { }
        public override string ToString()
        {
            return $"{incomeName}:    +{incomeCash} uan.        {dateTime.ToShortDateString()}\n";
        }
    }
}
