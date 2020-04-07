using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnniesTeaShop.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{ CategoryId=1, CategoryName="Black teas", Description="Includes Assam, Ceylon, Darjeeling, Keemun and Yunnan teas"},
                new Category{ CategoryId=2, CategoryName="Green teas", Description="Includes Sencha, Matcha, Jasmine, Gunpowder teas"},
                new Category{ CategoryId=3, CategoryName="White teas", Description="Includes Silver Needle, White Peony, Summer Rain teas"},
                new Category{ CategoryId=4, CategoryName="Yellow teas", Description="Includes Hunan, Zhejiang and Sichuan teas"}
            };
        public IEnumerable<Category> AllPieCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Fruit pies", Description="All-fruity pies"},
                new Category{CategoryId=2, CategoryName="Cheese cakes", Description="Cheesy all the way"},
                new Category{CategoryId=3, CategoryName="Seasonal pies", Description="Get in the mood for a seasonal pie"}
            };
    }
}
