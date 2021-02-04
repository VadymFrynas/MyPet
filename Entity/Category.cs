using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
   public   class Category
    {
        string categoryName;
        Outcome[] outcomes;
        Income[] incomes;
        
        
        public string CategoryName { get => categoryName; set => categoryName = value; }

        public Income[] Incomes { get => incomes; set => incomes = value; }
        public Outcome[] Outcomes { get => outcomes; set => outcomes = value; }
        public Category(string categoryName,Income[] incomes, Outcome[] outcomes)
        {
            this.incomes = incomes;
            this.outcomes = outcomes;
            this.categoryName = categoryName;
        }
        public Category(string categoryName)
        {
            this.categoryName = categoryName;
        }
        public Category() { }
        public double AllIncomeSum()
        {
            double IncSum = default;
            if (incomes != null)
            {
                for (int i = 0; i < incomes.Length; i++) IncSum += incomes[i].IncomeCash;
                return IncSum;
            }
            else return 0;
        }
        public double AllOutcomeSum()
        {
            double OutSum = default;
            if (outcomes != null)
            {
                for (int i = 0; i < outcomes.Length; i++)
                {
                    OutSum += outcomes[i].OutcomeCash;
                }
                return OutSum;
            }
            else return 0;
        }

        public string AddIncome(Income income)
        {
            if (incomes == null) incomes = new Income[1] { income };
            else
            {
                Income[] buf = new Income[incomes.Length + 1];
                for (int i = 0; i < incomes.Length; i++)
                {
                    buf[i] = incomes[i];
                }
                buf[incomes.Length] = income;
                incomes = new Income[buf.Length];
                for (int i = 0; i < incomes.Length; i++)
                {
                    incomes[i] = buf[i];
                }
            }
            return "Successfully deleted";

        }

        public string AddOutcome(Outcome outcome)
        {
            if (outcomes == null)
            {
                outcomes = new Outcome[1] { outcome };
            }
            else
            {
                Outcome[] buf = new Outcome[outcomes.Length + 1];
                for (int i = 0; i < outcomes.Length; i++)
                {
                    buf[i] = outcomes[i];
                }
                buf[outcomes.Length] = outcome;
                outcomes = new Outcome[buf.Length];
                for (int i = 0; i < outcomes.Length; i++)
                {
                    outcomes[i] = buf[i];
                }
            }
            return "Successfully deleted";

        }
        public override string ToString()
        {
            string str = $"Name of the category: {categoryName}\n";
            if (incomes == null)
            {
                str += "There are no any income in this category\n";
            }
            else
            {
                str += $"Total sum of incomes in this account: {AllIncomeSum()} uan.\n";
                foreach (Income income in incomes)
                {
                    str += income.ToString();
                }

            }
            if (outcomes == null)
            {
                str += "There are no any outcome in this category\n";
            }
            else
            {
                str += $"Total sum of outcomes in this account: {AllOutcomeSum()} uan.\n";
                foreach (Outcome outcome in outcomes)
                {
                    str += outcome.ToString();
                }
            }
            return str;
        }
        public string DeleteIncome(int index)
        {
            if (incomes == null)
            {
                return "There are no any income";
            }
            else
            {
                Income[] buf = new Income[incomes.Length - 1];
                if (index == 1)
                {
                    for (int i = index; i < incomes.Length; i++)
                    {
                        buf[i - 1] = incomes[i];
                    }

                }
                else if (index == incomes.Length)
                {
                    for (int i = 0; i < incomes.Length - 1; i++)
                    {
                        buf[i] = incomes[i];
                    }
                }
                else
                {
                    for (int i = 0; i < index - 1; i++)
                    {
                        buf[i] = incomes[i];
                    }
                    for (int i = index; i < incomes.Length; i++)
                    {
                        buf[i - 1] = incomes[i];
                    }
                }
                incomes = new Income[buf.Length];
                incomes = buf;
                return "Successfully deleted";
            }
        }
        public string DeleteOutcome(int index)
        {
            if (outcomes == null)
            {
                return "There are no any outcome";
            }
            else
            {
                Outcome[] buf = new Outcome[outcomes.Length - 1];
                if (index == 1)
                {
                    for (int i = index; i < outcomes.Length; i++)
                    {
                        buf[i - 1] = outcomes[i];
                    }

                }
                else if (index == outcomes.Length)
                {
                    for (int i = 0; i < outcomes.Length; i++)
                    {
                        buf[i] = outcomes[i];
                    }
                }
                else
                {
                    for (int i = 0; i < index - 1; i++)
                    {
                        buf[i] = outcomes[i];
                    }
                    for (int i = index; i < outcomes.Length; i++)
                    {
                        buf[i - 1] = outcomes[i];
                    }
                }
                outcomes = new Outcome[buf.Length];
                outcomes = buf;
                return "Successfully deleted";
            }
        }
        public string PrintIncomes()
        {
            string str = null;
            if (incomes == null || incomes.Length == 0)
            {
                return "There are no any income on this account\n";
            }
            else
            {
                foreach (Income income in incomes)
                {
                    str += income.ToString();
                }
                return str;
            }

        }
        public string PrintOutcomes()
        {
            string str = null;
            if (outcomes == null || outcomes.Length == 0)
            {
                {
                    return "There are no any outcome on this account\n";
                }
            }
            else
            {
                foreach (Outcome outcome in outcomes)
                {
                    str += outcome.ToString();
                }
                return str;
            }

        }
    }
}
