using System;

namespace InterfaceModels
{
    public class InterfaceOutcome
    {
        string outcomeName;
        double outcomeCash;
        DateTime dateTime;
        public string OutcomeName { get => outcomeName; set => outcomeName = value; }
        public double OutcomeCash { get => outcomeCash; set => outcomeCash = value; }
        public DateTime DataTime { get => dateTime; set => dateTime = value; }
        public InterfaceOutcome(string outcomeName, double outcomeCash, DateTime dateTime)
        {
            this.dateTime = dateTime;
            this.outcomeCash = outcomeCash;
            this.outcomeName = outcomeName;
        }
        public InterfaceOutcome() { }
        public override string ToString()
        {
            return $"{outcomeName}:    -{outcomeCash} uan.        {dateTime.ToShortDateString()}\n";
        }
    }
}
