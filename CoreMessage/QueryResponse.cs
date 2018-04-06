using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Message
{
    public class QueryResponse<TItem>
    {
        public IEnumerable<TItem> List { get; set; }
    }
}
