using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
   public  class Outcome
    {
        string OutcomeName;
        double OutcomeCash;
        public string _OutcomeName { get => OutcomeName; set => OutcomeName = value; }
        public double _OutcomeCash { get => OutcomeCash; set => OutcomeCash = value; }
        public Outcome(string OutcomeName, double OutcomeCash)
        {
            this.OutcomeCash = OutcomeCash;
            this.OutcomeName = OutcomeName;
        }
        public Outcome()
        {
            OutcomeCash = default;
            OutcomeName = default;

        }
        public override string ToString()
        {
            return $"{OutcomeName}:\t-{OutcomeCash} uan.\n";
        }
    }
}
