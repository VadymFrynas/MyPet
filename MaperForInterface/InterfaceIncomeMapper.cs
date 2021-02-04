using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using InterfaceModels;

namespace MapperForInterface
{
    public static class InterfaceIncomeMapper
    {
        public static Income[] ToBllEntities(this InterfaceIncome[] incomes)
        {
            Income[] incomeEntities;
            if (incomes == null)
            {
                return incomeEntities = null;
            }
            else
            {
                incomeEntities = new Income[incomes.Length];
                for (int i = 0; i < incomeEntities.Length; i++)
                {
                    incomeEntities[i] = incomes[i].ToBllEntity();
                }
                return incomeEntities;
            }
        }



        public static Income ToBllEntity(this InterfaceIncome income)
        {
            return new Income(income.IncomeName, income.IncomeCash, income.DataTime);
        }
        public static InterfaceIncome[] ToInterfaceEntities(this Income[] incomes)
        {
            InterfaceIncome[] incomeEntities;
            if (incomes == null)
            {
                return incomeEntities = null;
            }
            else
            {
                incomeEntities = new InterfaceIncome[incomes.Length];
                for (int i = 0; i < incomeEntities.Length; i++)
                {
                    incomeEntities[i] = incomes[i].ToInterfaceEntity();
                }
                return incomeEntities;
            }
        }



        public static InterfaceIncome ToInterfaceEntity(this Income income)
        {
            return new InterfaceIncome(income.IncomeName, income.IncomeCash, income.DataTime);
        }
    }
}
