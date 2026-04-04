using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Model
{
    public class PagedResult<T> : PagedResultBase where T : class 
    {
        public List<T> Result { get; set; }

        public PagedResult() { 
            Result = new List<T>();
        }
    }
}
