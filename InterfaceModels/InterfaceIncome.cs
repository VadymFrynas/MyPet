using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceModels
{
    public class InterfaceIncome
    {
        string incomeName;
        double incomeCash;
        DateTime dateTime;
        public string IncomeName { get => incomeName; set => incomeName = value; }
        public double IncomeCash { get => incomeCash; set => incomeCash = value; }
        public DateTime DataTime { get => dateTime; set => dateTime = value; }
        public InterfaceIncome(string incomeName, double incomeCash, DateTime dateTime)
        {
            this.dateTime = dateTime;
            this.incomeCash = incomeCash;
            this.incomeName = incomeName;
        }
        public InterfaceIncome() { }
        public override string ToString()
        {
            return $"{incomeName}:    +{incomeCash} uan.        {dateTime.ToShortDateString()}\n";
        }
    }
}
