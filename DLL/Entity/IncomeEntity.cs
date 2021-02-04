using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    [Serializable]
    public class IncomeEntity
    {
        string incomeName;
        double incomeCash;
        DateTime dateTime;
        public string IncomeName { get => incomeName; set => incomeName = value; }
        public double IncomeCash { get => incomeCash; set => incomeCash = value; }
        public DateTime DataTime { get => dateTime; set => dateTime = value; }
        public IncomeEntity(string incomeName, double incomeCash, DateTime dateTime) 
        {
            this.dateTime = dateTime;
            this.incomeCash = incomeCash;
            this.incomeName = incomeName;
        }


    }
}
