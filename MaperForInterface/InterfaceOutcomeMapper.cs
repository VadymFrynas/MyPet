using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using InterfaceModels;
namespace MapperForInterface
{
    public static class InterfaceOutcomeMapper
    {
        public static Outcome[] ToBllEntities(this InterfaceOutcome[] outcomes)
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
                    outcomeEntities[i] = outcomes[i].ToBllEntity();
                }
                return outcomeEntities;
            }
        }



        public static Outcome ToBllEntity(this InterfaceOutcome outcome)
        {
            return new Outcome(outcome.OutcomeName, outcome.OutcomeCash, outcome.DataTime);
        }
        public static InterfaceOutcome[] ToInterfaceEntities(this Outcome[] outcomes)
        {
            InterfaceOutcome[] outcomeEntities;
            if (outcomes == null)
            {
                return outcomeEntities = null;
            }
            else
            {
                outcomeEntities = new InterfaceOutcome[outcomes.Length];
                for (int i = 0; i < outcomeEntities.Length; i++)
                {
                    outcomeEntities[i] = outcomes[i].ToInterfaceEntity();
                }
                return outcomeEntities;
            }
        }



        public static InterfaceOutcome ToInterfaceEntity(this Outcome outcome)
        {
            return new InterfaceOutcome(outcome.OutcomeName, outcome.OutcomeCash, outcome.DataTime);
        }
    }
}
