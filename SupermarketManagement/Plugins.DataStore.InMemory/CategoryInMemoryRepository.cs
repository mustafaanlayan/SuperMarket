using System;
using System.Collections.Generic;
using CoreBusines;
using UseCases.DataStorePullingInterface;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository:ICategoryRepository
    {
        private List<Category> categories;

        public CategoryInMemoryRepository(List<Category> categories)
        {
            categories = new List<Category>()
            {
                new Category{CategoryId = 1,Name = "Beverage",Description = "Beverage"},
                new Category{CategoryId = 2,Name = "Bakery",Description = "Bakery"},
                new Category{CategoryId = 3,Name = "Meat",Description = "Meat"}
            };
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }
    }
}
