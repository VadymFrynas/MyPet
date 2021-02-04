using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Entity;

namespace Mapper
{
    public static class CategoryMapper
    {
        public static CategoryEntity ToEntity(this Category category)
        {
            return new CategoryEntity(category.CategoryName, category.Incomes.ToEntities(), category.Outcomes.ToEntities());
        }
        public static CategoryEntity[] ToEntities(this Category[] category)
        {
            CategoryEntity[] categoryEntities;
            if (category == null)
            {
                return categoryEntities = null;
            }
            else
            {
                categoryEntities = new CategoryEntity[category.Length];
                for (int i = 0; i < categoryEntities.Length; i++)
                {
                    categoryEntities[i] = category[i].ToEntity();
                }
                return categoryEntities;
            }
        }
        public static Category[] ToBLLEntities(this CategoryEntity[] category)
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
                    categoryEntities[i] = category[i].ToBLLEntity();
                }
                return categoryEntities;
            }
        }



        public static Category ToBLLEntity(this CategoryEntity category)
        {
            return new Category(category.CategoryName, category.Incomes.ToBLLEntities(), category.Outcome.ToBLLEntities());
        }

    }
}
