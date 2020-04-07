using AnniesTeaShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnniesTeaShop.ViewModels
{
    public class TeaListViewModel
    {
        public IEnumerable<Tea> Teas { get; set; }
        public string CurrentCategory { get; set; }
    }
}
