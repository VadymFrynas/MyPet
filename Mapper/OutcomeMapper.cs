using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Entity;
namespace Mapper
{
    public static class OutcomeMapper
    {
        public static OutcomeEntity[] ToEntities(this Outcome[] outcomes)
        {
            OutcomeEntity[] outcomeEntities;
            if (outcomes == null)
            {
                return outcomeEntities = null;
            }
            else
            {
                outcomeEntities = new OutcomeEntity[outcomes.Length];
                for (int i = 0; i < outcomeEntities.Length; i++)
                {
                    outcomeEntities[i] = outcomes[i].ToEntity();
                }
                return outcomeEntities;
            }
        }



        public static OutcomeEntity ToEntity(this Outcome outcome)
        {
            return new OutcomeEntity(outcome.OutcomeName, outcome.OutcomeCash, outcome.DataTime);
        }
        public static Outcome[] ToBLLEntities(this OutcomeEntity[] outcomes)
        {
            Outcome[] outcomeEntities;
            if (outcomes == null)
            {
                return outcomeEntities = null;
            }
            else
            {
                outcomeEntities = new Outcome[outcomes.Length];
                for (int i = 0; i < outcomeEntities.Length; i++)
                {
                    outcomeEntities[i] = outcomes[i].ToBLLEntity();
                }
                return outcomeEntities;
            }
        }



        public static Outcome ToBLLEntity(this OutcomeEntity outcome)
        {
            return new Outcome(outcome.OutcomeName, outcome.OutcomeCash, outcome.DataTime);
        }
    }
}
