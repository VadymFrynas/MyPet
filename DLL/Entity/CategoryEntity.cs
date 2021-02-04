using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    [Serializable]
    public class CategoryEntity
    {

        string categoryName;
        OutcomeEntity[] outcomes;
        IncomeEntity[] incomes;
        public  string CategoryName{ get => categoryName; set => categoryName = value; }
        
        public IncomeEntity[] Incomes { get => incomes; }
        public OutcomeEntity[] Outcome { get => outcomes; }
        public CategoryEntity(string categoryName,IncomeEntity[] incomes,OutcomeEntity[] outcomes) 
        {
            this.incomes = incomes;
            this.outcomes = outcomes;
            this.categoryName = categoryName;
        }



    }
}
