using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceModels
{
    public  class InterfaceCategory
    {
        string categoryName;
        InterfaceOutcome[] outcomes;
        InterfaceIncome[] incomes;


        public string CategoryName { get => categoryName; set => categoryName = value; }

        public InterfaceIncome[] Incomes { get => incomes; set => incomes = value; }
        public InterfaceOutcome[] Outcomes { get => outcomes; set => outcomes = value; }
        public InterfaceCategory(string categoryName, InterfaceIncome[] incomes, InterfaceOutcome[] outcomes)
        {
            this.incomes = incomes;
            this.outcomes = outcomes;
            this.categoryName = categoryName;
        }
        public InterfaceCategory(string categoryName)
        {
            this.categoryName = categoryName;
        }
        public InterfaceCategory() { }
    }
}
