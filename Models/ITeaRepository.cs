using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnniesTeaShop.Models
{
    public interface ITeaRepository
    {
        IEnumerable<Tea> AllTeas { get; }
        IEnumerable<Tea> TeasOfTheWeek { get; }
        Tea GetTeabyId(int teaId);
    }
}
