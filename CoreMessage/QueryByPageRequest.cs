using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Message
{
    public class QueryByPageRequest : RequestMessage
    {
        [Range(1, 9999999999999)]
        public int PageIndex { get; set; } = 1;
        [Range(1, 9999999999999)]
        public int PageSize { get; set; } = 10;
    }
}
