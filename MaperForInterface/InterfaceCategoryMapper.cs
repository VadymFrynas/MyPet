using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using InterfaceModels;

namespace MapperForInterface
{
    public static class InterfaceCategoryMapper
    {

        public static Category ToBllEntity(this InterfaceCategory category)
        {
            return new Category(category.CategoryName, category.Incomes.ToBllEntities(), category.Outcomes.ToBllEntities());
        }
        public static Category[] ToBllEntities(this InterfaceCategory[] category)
        {
            Category[] categoryEntities;
            if (category == null)
            {
                return categoryEntities = null;
            }
            else
            {
                categoryEntities = new Category[category.Length];
                for (int i = 0; i < categoryEntities.Length; i++)
                {
                    categoryEntities[i] = category[i].ToBllEntity();
                }
                return categoryEntities;
            }
        }
        public static InterfaceCategory[] ToInterfaceEntities(this Category[] category)
        {
            InterfaceCategory[] categoryEntities;
            if (category == null)
            {
                return categoryEntities = null;
            }
            else
            {
                categoryEntities = new InterfaceCategory[category.Length];
                for (int i = 0; i < categoryEntities.Length; i++)
                {
                    categoryEntities[i] = category[i].ToInterfaceEntity();
                }
                return categoryEntities;
            }
        }



        public static InterfaceCategory ToInterfaceEntity(this Category category)
        {
            return new InterfaceCategory(category.CategoryName, category.Incomes.ToInterfaceEntities(), category.Outcomes.ToInterfaceEntities());
        }
    }
}
