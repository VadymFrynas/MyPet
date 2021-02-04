using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
   public   class Category
    {
        string CategoryName;
        Outcome[] Outcomes;
        Income[] Incomes;
        double IncSum = default;
        double OutSum = default;
        public string _CategoryName { get => CategoryName; set => CategoryName = value; }

        public Income[] _Incomes { get => Incomes; }
        public Outcome[] _Outcome { get => Outcomes; }
        public Category(string CategoryName,Income[] Incomes, Outcome[] Outcomes)
        {
            this.Incomes = Incomes;
            this.Outcomes = Outcomes;
            this.CategoryName = CategoryName;
        }
        public double AllIncomeSum()
        {
            if (Incomes != null)
            {
                for (int i = 0; i < Incomes.Length; i++) IncSum += Incomes[i]._IncomeCash;
                return IncSum;
            }
            else return 0;
        }
        public double AllOutcomeSum()
        {
            if (Outcomes != null)
            {
                for (int i = 0; i < Outcomes.Length; i++) OutSum += Outcomes[i]._OutcomeCash;
                return OutSum;
            }
            else return 0;
        }

        public string AddIncome(Income income)
        {
            if (Incomes == null) Incomes = new Income[1] { income };
            else
            {
                Income[] buf = new Income[Incomes.Length + 1];
                for (int i = 0; i < Incomes.Length; i++) buf[i] = Incomes[i];
                buf[Incomes.Length] = income;
                Incomes = new Income[buf.Length];
                for (int i = 0; i < Incomes.Length; i++) Incomes[i] = buf[i];
            }
            return "Successfully deleted";

        }

        public string AddOutcome(Outcome outcome)
        {
            if (Outcomes == null) Outcomes = new Outcome[1] { outcome };
            else
            {
                Outcome[] buf = new Outcome[Outcomes.Length + 1];
                for (int i = 0; i < Outcomes.Length; i++) buf[i] = Outcomes[i];
                buf[Outcomes.Length] = outcome;
                Outcomes = new Outcome[buf.Length];
                for (int i = 0; i < Outcomes.Length; i++) Outcomes[i] = buf[i];
            }
            return "Successfully deleted";

        }
        public string DeleteIncome(int index)
        {
            if (Incomes == null) return "There are no any income";
            else
            {
                Income[] buf = new Income[Incomes.Length - 1];
                if (index == 1)
                {
                    for (int i = 0; i < Incomes.Length; i++)
                    {
                        buf[i - 1] = Incomes[i];
                    }

                }
                else if (index == Incomes.Length)
                {
                    for (int i = 0; i < Incomes.Length; i++) buf[i] = Incomes[i];
                }
                else
                {
                    for (int i = 0; i < index - 1; i++) buf[i] = Incomes[i];
                    for (int i = index; i < Incomes.Length; i++) buf[i - 1] = Incomes[i];
                }
                Incomes = new Income[buf.Length];
                Incomes = buf;
                return "Successfully deleted";
            }
        }
        public string DeleteOutcome(int index)
        {
            if (Outcomes == null) return "There are no any outcome";
            else
            {
                Outcome[] buf = new Outcome[Outcomes.Length - 1];
                if (index == 1)
                {
                    for (int i = 0; i < Outcomes.Length; i++)
                    {
                        buf[i - 1] = Outcomes[i];
                    }

                }
                else if (index == Outcomes.Length)
                {
                    for (int i = 0; i < Outcomes.Length; i++) buf[i] = Outcomes[i];
                }
                else
                {
                    for (int i = 0; i < index - 1; i++) buf[i] = Outcomes[i];
                    for (int i = index; i < Outcomes.Length; i++) buf[i - 1] = Outcomes[i];
                }
                Outcomes = new Outcome[buf.Length];
                Outcomes = buf;
                return "Successfully deleted";
            }
        }
        public string PrintIncomes()
        {
            string str = null;
            if (Incomes == null) return "There are no any income on this account";
            else
            {
                foreach (Income income in Incomes) str += income.ToString();
                return str;
            }

        }
        public string PrintOutcomes()
        {
            string str = null;
            if (Incomes == null) return "There are no any outcome on this account";
            else
            {
                foreach (Outcome outcome in Outcomes) str += outcome.ToString();
                return str;
            }

        }
    }
}
