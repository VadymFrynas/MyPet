using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Entity;
namespace Mapper
{
    public static class IncomeMapper
    {
        public static IncomeEntity[] ToEntities(this Income[] incomes)
        {
            IncomeEntity[] incomeEntities;
            if (incomes == null)
            {
                return incomeEntities = null;
            }
            else
            {
                incomeEntities = new IncomeEntity[incomes.Length];
                for (int i = 0; i < incomeEntities.Length; i++)
                {
                    incomeEntities[i] = incomes[i].ToEntity();
                }
                return incomeEntities;
            }
        }



        public static IncomeEntity ToEntity(this Income income)
        {
            return new IncomeEntity(income.IncomeName, income.IncomeCash,income.DataTime);
        }
        public static Income[] ToBLLEntities(this IncomeEntity[] incomes)
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
                    incomeEntities[i] = incomes[i].ToBLLEntity();
                }
                return incomeEntities;
            }
        }



        public static Income ToBLLEntity(this IncomeEntity income)
        {
            return new Income(income.IncomeName, income.IncomeCash,income.DataTime);
        }

    }
}
