using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    [Serializable]
    public class OutcomeEntity
    {
        string outcomeName;
        double outcomeCash;
        DateTime dateTime;
        public string OutcomeName { get => outcomeName; set => outcomeName = value; }
        public double OutcomeCash { get => outcomeCash; set => outcomeCash = value; }
        public DateTime DataTime { get => dateTime; set => dateTime = value; }
        public OutcomeEntity(string outcomeName, double outcomeCash, DateTime dateTime)
        {
            this.dateTime = dateTime;
            this.outcomeCash = outcomeCash;
            this.outcomeName = outcomeName;
        }

    }
}
