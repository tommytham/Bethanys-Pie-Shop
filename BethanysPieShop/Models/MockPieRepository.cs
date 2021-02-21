using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie {PieId = 1, Name="Chicken Mushroom Pie", Price=15.86M, ShortDescription="Smells good pie", LongDescription="One of my personal favourites when going to fish shop", CategoryId = _categoryRepository.AllCategories.ToList()[2].CategoryId },
                new Pie {PieId = 2, Name="Steak Kidney Pie", Price=14.86M, ShortDescription="Meaty pie", LongDescription="My second choice when it comes to pies", CategoryId = _categoryRepository.AllCategories.ToList()[2].CategoryId},
                new Pie {PieId = 3, Name="Blue Berry Pie", Price=5.86M, ShortDescription="A blueberry dessert pie", LongDescription="If you fancy something sweet", CategoryId = _categoryRepository.AllCategories.ToList()[1].CategoryId},
                new Pie {PieId = 4, Name="Home Style Pie", Price=18.86M, ShortDescription="Classic style pie", LongDescription="The absolute best when you want a feeling of homecoming", CategoryId = _categoryRepository.AllCategories.ToList()[0].CategoryId}
            };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
