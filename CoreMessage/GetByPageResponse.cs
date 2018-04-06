using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Message
{
    public class GetByPageResponse<TItem> : QueryResponse<TItem>
    {
        public long TotalRecord { get; set; }
    }
}
