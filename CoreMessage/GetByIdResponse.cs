using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Message
{
    public class GetByIdResponse<T>
    {
        public T Entity { get; set; }
    }
}
