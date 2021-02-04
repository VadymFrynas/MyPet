using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
   public  class Outcome
    {
        string outcomeName;
        double outcomeCash;
        DateTime dateTime;
        public string OutcomeName { get => outcomeName;  }
        public double OutcomeCash { get => outcomeCash;  }
        public DateTime DataTime { get => dateTime;  }
        public Outcome(string outcomeName, double outcomeCash, DateTime dateTime)
        {
            this.dateTime = dateTime;
            this.outcomeCash = outcomeCash;
            this.outcomeName = outcomeName;
        }
        public Outcome() { }
        public override string ToString()
        {
            return $"{outcomeName}:    -{outcomeCash} uan.        {dateTime.ToShortDateString()}\n";
        }
    }
}
