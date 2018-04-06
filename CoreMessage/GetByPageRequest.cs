﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Message
{
    public class GetByPageRequest : RequestMessage
    {
        public int PageIndex { get; set; } = 1;
        [Range(1, 1000)]
        public int PageSize { get; set; } = 10;
    }
}
