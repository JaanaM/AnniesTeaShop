using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnniesTeaShop.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Tea> TeasOfTheWeek { get; set; }
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}
