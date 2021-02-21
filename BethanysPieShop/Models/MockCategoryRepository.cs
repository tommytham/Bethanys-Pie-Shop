using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        IEnumerable<Category> ICategoryRepository.AllCategories =>
            new List<Category>
            {
                new Category{CategoryId = 1, CategoryName="Fruit Pies", Description="All-fruit kind of pie" },
                new Category{CategoryId = 2, CategoryName="Cheese Pies", Description="All cheese sort of pies" },
                new Category{CategoryId = 3, CategoryName="Meat Pies", Description="Meat infested pies" }
            };
    }
}
