using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vives.Services.Model
{
    public class Paging
    {
        public int startIndex { get; set; } = 0;
        public int pageSize { get; set; } = 10;
    }
}
