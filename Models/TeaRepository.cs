using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnniesTeaShop.Models
{
    public class TeaRepository : ITeaRepository
    {
        private readonly AppDbContext _appDbContext;
        public TeaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Tea> AllTeas
        {
            get
            {
                return _appDbContext.Teas.Include(c => c.Category);

            }
        }

        public IEnumerable<Tea> TeasOfTheWeek
        {
            get
            {
                return _appDbContext.Teas.Include(c => c.Category).Where(t => t.IsTeaOfTheWeek);

            }
        }

        public Tea GetTeabyId(int teaId)
        {
            return _appDbContext.Teas.FirstOrDefault(t => t.TeaId == teaId);
        }
    }
}
