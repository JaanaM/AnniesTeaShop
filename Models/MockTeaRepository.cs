using AnniesTeaShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnniesTeaShop.Models
{
    public class MockTeaRepository: ITeaRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Tea> AllTeas =>
            new List<Tea>
            {
                new Tea { TeaId = 1, Name="Ceylon tea", Price=5.60M, ShortDescription=" Ceylon tea is brand of black teas", LongDescription="Ceylon tea is a popular type of black tea that is also known as Sri Lankan tea. Served as an iced tea or warm, it is a favorite beverage for many tea drinkers. While Ceylon is known for its bold flavor, it can vary significantly in taste, depending on the type of tea and where it's grown in the country.",Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://images.unsplash.com/photo-1433891248364-3ce993ff0e92?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1350&q=80", InStock=true, IsTeaOfTheWeek=false, ImageThumbnailUrl="https://images.unsplash.com/photo-1433891248364-3ce993ff0e92?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1350&q=80"},
                new Tea{ TeaId=2, Name="Japanese Sencha", Price=6.40M, ShortDescription="Green japanese sencha tea", LongDescription="The most popular tea in Japan, sencha is a green tea with fresh, green color and taste. It is a whole-leaf tea that can be enjoyed hot or cold and makes up over half of Japan's yearly tea harvest.", Category= _categoryRepository.AllCategories.ToList()[1], ImageUrl="https://www.thespruceeats.com/thmb/HXzNCNRLW9jTAsuNtTepOysJDLI=/960x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/AsamushiSencha-56a175f23df78cf7726adaf5.jpg", InStock=true, IsTeaOfTheWeek=true, ImageThumbnailUrl="https://www.thespruceeats.com/thmb/HXzNCNRLW9jTAsuNtTepOysJDLI=/960x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/AsamushiSencha-56a175f23df78cf7726adaf5.jpg"},
                new Tea{ TeaId=3, Name="Japanese Matcha", Price=12.40M, ShortDescription="Green japanese Matcha tea", LongDescription="Matcha is grown in many regions across Japan, and each region and tea makers will produce slightly different flavor profiles and colors in the final ground green tea leaves.", Category= _categoryRepository.AllCategories.ToList()[1], ImageUrl="https://images.unsplash.com/photo-1565117661210-fd54898de423?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=634&q=80", InStock=true, IsTeaOfTheWeek=true, ImageThumbnailUrl="https://images.unsplash.com/photo-1565117661210-fd54898de423?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=634&q=80"},
                new Tea{TeaId=4, Name="White Peony ", Price=10.80M, ShortDescription="Imperial Grade White Peony", LongDescription="white peony. Also known as Pai Mu Tan or Bai Mu Dan, White Peony is a sweet, mild Chinese tea made from unopened tea buds, as well as the two newest leaves to sprout. The freshly harvested leaf is allowed to wither dry in the sun.", Category= _categoryRepository.AllCategories.ToList()[2], ImageUrl="https://www.thespruceeats.com/thmb/cBY_yy7DN2ETA52iil_jRCrwfME=/960x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/GettyImages-463260841-5849af005f9b58dccc00dba9.jpg", InStock=true, IsTeaOfTheWeek=false, ImageThumbnailUrl="https://www.thespruceeats.com/thmb/cBY_yy7DN2ETA52iil_jRCrwfME=/960x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/GettyImages-463260841-5849af005f9b58dccc00dba9.jpg"}
            };

        public IEnumerable<Tea> TeasOfTheWeek { get; }

        public Tea GetTeabyId(int teaId)
        {
            return AllTeas.FirstOrDefault(t => t.TeaId == teaId);
        }
    }
}
