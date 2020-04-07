 using System.Collections.Generic;

namespace AnniesTeaShop.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
        IEnumerable<Category> AllPieCategories { get; }
    }
}