using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MummyProject.Models.ViewModels
{
    public class BurialListViewModel
    {
        public IEnumerable<Burial> Burials { get; set; }
        public PagingInfo PagingInfo { get; set; }

    }
}
